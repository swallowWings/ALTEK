
Imports System.Text

Public Class fGRMToolsGridRainfallCalibration
    Dim mDataListInfoForDRFCalibration() As DataListInfoForDRFCalibration
    Dim mGageRainfallInfo() As GageRainfallInfo

    Dim mintCountGridLayer As Integer
    Dim mintCountRainGage As Integer
    Dim mbAllisNormal As Boolean
    Dim mbUpdateDGV As Boolean

    Dim dtRgd As Data.DataTable
    Dim dtFull As Data.DataTable

    Private mfilePattern As cFile.FilePattern

    Structure DataListInfoForDRFCalibration
        Public Order As Integer
        Public GridFileName As String
        Public GridFilePath As String
    End Structure

    Structure GageRainfallInfo
        Public GageName As String
        Public TMx As String
        Public TMy As String
        Public RainfallTS As ArrayList
    End Structure

    Enum GagePositionInfoSourceType
        TextFile
        PointLayer
    End Enum


    Private Sub frmGRMToolsDistributedRainfallCalibration_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If cMap.mwAppMain Is Nothing Then
            Me.rbLoadGagePosUsingPointLayer.Enabled = False
        Else
            Me.rbLoadGagePosUsingPointLayer.Enabled = True
        End If

        mfilePattern = cFile.FilePattern.TIFFILE
        Me.dgvSelectedDataListForDRFCal.AllowUserToAddRows = False
        Me.dgvSelectedDataListForDRFCal.ReadOnly = True
        dtRgd = New Data.DataTable
    End Sub

    Private Sub btAddAllFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddAllFiles.Click

        Call AddFiles(False)
        For intN As Integer = 0 To Me.dgvSelectedDataListForDRFCal.Columns.Count - 1
            Me.dgvSelectedDataListForDRFCal.Columns(intN).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        Me.dgvSelectedDataListForDRFCal.DataSource = dtRgd
    End Sub

    Private Sub btAddSelectedFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddSelectedFile.Click

        Call AddFiles(True)
        For intN As Integer = 0 To Me.dgvSelectedDataListForDRFCal.Columns.Count - 1
            Me.dgvSelectedDataListForDRFCal.Columns(intN).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        Me.dgvSelectedDataListForDRFCal.DataSource = dtRgd
    End Sub


    Sub AddFiles(ByVal bSelectedFile As Boolean)
        If IO.Directory.Exists(txtFolderPathSource.Text.Trim) Then
            If dtRgd.Columns.Count = 0 Then
                dtRgd.Columns.Add("Order")
                dtRgd.Columns.Add("File name")
                dtRgd.Columns.Add("File path")
            End If
            Dim strFilePath As String = txtFolderPathSource.Text.Trim
            Dim obj As New cFile
            Dim items As String() = obj.GetFilesAndCheckDuplication(lstRFfiles, bSelectedFile, strFilePath, dtRgd, "File name", "File path")
            If obj.DuplicationfileProcessMessage = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            obj.AddToDataTable(items, strFilePath, dtRgd, "Order", "File name", "File path")
        End If
    End Sub



    Private Function CheckDuplicatedFiles(ByVal fileNames As String(), ByVal dirPath As String, ByVal dt As DataTable) As String()
        Dim notDup As New List(Of String)
        For Each fileName As String In fileNames
            Dim fullPath As String = Path.Combine(dirPath, fileName).ToLower
            Dim bFound As Boolean = False
            For Each row As DataRow In dt.Rows
                Dim aPath As String = Path.Combine(row.Item("File Path").ToString, row.Item("File Name").ToString).ToLower
                If fullPath = aPath Then
                    bFound = True
                    Exit For
                End If
            Next
            If Not bFound Then notDup.Add(fileName)
        Next

        Return notDup.ToArray
    End Function


    Private Sub btLoadGagePosTextfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLoadGagePosTextfile.Click
        Dim dlg As New OpenFileDialog
        With dlg
            .Title = "Open text file contains rain gage position inforamtion"
            .FileName = ""
            .Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        End With
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            If dlg.FileName <> "" Then
                Me.txtFNPGagePosTextfile.Text = dlg.FileName
            End If
        End If
    End Sub

    Private Sub btViewGagePositionTextFileExample_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewGagePositionTextFileExample.Click
        Dim ofrmTextBox As New fTextBox
        Dim strOut As String

        strOut = "GageName1,TMx1,TMy1" + vbCrLf
        strOut = strOut + "GageName2,TMx2,TMy2" + vbCrLf
        strOut = strOut + "   .     ,  . , .  " + vbCrLf
        strOut = strOut + "   .     ,  . , .  " + vbCrLf
        strOut = strOut + "   .     ,  . , .  " + vbCrLf + vbCrLf

        strOut = strOut + "Gage name,longitude position(TM),latidude position(TM)." + vbCrLf
        strOut = strOut + "Write one gage in a line." + vbCrLf
        strOut = strOut + "Comma(,) is used to separate each data."


        ofrmTextBox.txtTextBox.Text = strOut

        ofrmTextBox.txtTextBox.ReadOnly = True

        ofrmTextBox.txtTextBox.Font = System.Drawing.SystemFonts.DefaultFont
        ofrmTextBox.txtTextBox.Select(Len(strOut), 0)
        ofrmTextBox.Show()

    End Sub


    Private Sub cmbPointLayer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPointLayer.Click, cmbNameField.Click
        Call UpdateCmbPointLayer(Me.cmbPointLayer)
    End Sub

    Sub UpdateCmbPointLayer(ByVal inputCombox As Windows.Forms.ComboBox)
        inputCombox.Items.Clear()
        For Each lyrLayer As MapWindow.Interfaces.Layer In cMap.mwAppMain.Layers
            Select Case lyrLayer.LayerType
                Case MapWindow.Interfaces.eLayerType.PointShapefile
                    inputCombox.Items.Add(lyrLayer.Name)
                Case Else
            End Select
        Next
    End Sub

    Private Sub cmbPointLayer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPointLayer.SelectedIndexChanged
        Try
            If Me.cmbPointLayer.Text <> "" Then
                Me.cmbNameField.Items.Clear()
                Dim pointLayerName As String = Trim(Me.cmbPointLayer.Text)
                Dim oPoint As New MapWinGIS.Shapefile
                oPoint = cMap.GetMWShapeFileWithLayerName(cMap.mwAppMain, pointLayerName)
                For nf As Integer = 0 To oPoint.NumFields - 1
                    Me.cmbNameField.Items.Add(oPoint.Field(nf).Name)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, , cGRM.BuildInfo.ProductName)
        End Try
    End Sub


    Private Sub btLoadTimeSeriesTextFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLoadTimeSeriesTextFile.Click
        Dim dlg As New OpenFileDialog
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            If dlg.FileName <> "" Then
                Me.txtTimeSeriesFPN.Text = dlg.FileName
            End If
        End If
    End Sub

    Private Sub btViewTSTextFileExample_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewTSTextFileExample.Click

        Dim ofrmTextBox As New fTextBox
        Dim strOut As String

        strOut = "GageName1,GageName2,GageName3,...." + vbCrLf
        strOut = strOut + "Rainfall11,Rainfall2,Rainfall13,..." + vbCrLf
        strOut = strOut + "Rainfall21,Rainfal22,Rainfall23,..." + vbCrLf
        strOut = strOut + "Rainfall31,Rainfal32,Rainfall33,..." + vbCrLf
        strOut = strOut + "    .     ,     .   ,     .    ,..." + vbCrLf
        strOut = strOut + "    .     ,     .   ,     .    ,..." + vbCrLf
        strOut = strOut + "    .     ,     .   ,     .    ,..." + vbCrLf + vbCrLf

        strOut = strOut + "First line contains gage name separated with comma(,)." + vbCrLf
        strOut = strOut + "Write rainfall data for each gage from second line." + vbCrLf
        strOut = strOut + "Rainfall data number for each gage must be equal."

        ofrmTextBox.txtTextBox.Text = strOut

        ofrmTextBox.txtTextBox.ReadOnly = True
        ofrmTextBox.txtTextBox.Font = System.Drawing.SystemFonts.DefaultFont
        ofrmTextBox.txtTextBox.Select(Len(strOut), 0)
        ofrmTextBox.Show()
    End Sub

    Private Sub btOpenDestinationFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOpenDestinationFolder.Click
        Dim fb As New FolderBrowserDialog
        If fb.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtDestinationFolderPath.Text = fb.SelectedPath
        End If
    End Sub

    Private Sub btClearAllList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClearAllList.Click

        If dtRgd IsNot Nothing Then dtRgd.Clear()
        If dtFull IsNot Nothing Then dtFull.Clear()
    End Sub


    Private Sub btApplyGageDataInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btApplyGageDataInfo.Click

        mbAllisNormal = True

        If Me.dgvSelectedDataListForDRFCal.Rows.Count = 0 Then

            mbAllisNormal = False : Exit Sub

        Else
            Call ReadAndSetGridLayerInfo() : If mbAllisNormal = False Then Exit Sub
            Call ReadAndSetGagePosition() : If mbAllisNormal = False Then Exit Sub
            Call ReadAndSetGegeTimeSeries() : If mbAllisNormal = False Then Exit Sub
        End If

        Call UpdateDGVSelectDataList() : If mbAllisNormal = False Then Exit Sub

    End Sub


    Sub UpdateDGVSelectDataList()
        Dim intR As Integer
        Dim intC As Integer

        Dim ofrmPrograssBar As New fProgressBar

        ofrmPrograssBar.GRMToolsPrograssBar.Maximum = mintCountGridLayer
        ofrmPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
        ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Set 0/" & CStr(mintCountGridLayer) & " rainfall data..."
        ofrmPrograssBar.Text = "Setup rainfall data for Conditional Merging"
        ofrmPrograssBar.Show()
        System.Windows.Forms.Application.DoEvents()
        'cGRMToolsMakeRFGridLayers.mStopProgress = False

        If Me.dtRgd.Columns.Count > 0 Then
            dtFull = New DataTable
            dtFull = dtRgd.Clone
            For intC = 0 To mintCountRainGage - 1
                dtFull.Columns.Add(mGageRainfallInfo(intC).GageName)
            Next intC
            For intR = 0 To mintCountGridLayer - 1
                Dim drfull As DataRow = dtFull.NewRow
                drfull.Item("Order") = dtRgd.Rows(intR).Item("Order")
                drfull.Item("File name") = dtRgd.Rows(intR).Item("File name")
                drfull.Item("File path") = dtRgd.Rows(intR).Item("File path")
                For intC = 0 To mintCountRainGage - 1
                    drfull.Item(mGageRainfallInfo(intC).GageName) = mGageRainfallInfo(intC).RainfallTS.Item(intR)
                Next intC
                dtFull.Rows.Add(drfull)
                ofrmPrograssBar.GRMToolsPrograssBar.Value = intR + 1
                ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Set " + CStr(intR + 1) + "/" & CStr(mintCountGridLayer) & " grid file..."
                System.Windows.Forms.Application.DoEvents()
            Next intR

            With Me.dgvSelectedDataListForDRFCal
                .DataSource = dtFull

                .AllowUserToOrderColumns = True
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .RowHeadersVisible = True
                .RowHeadersWidth = 10
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                .SelectionMode = DataGridViewSelectionMode.CellSelect
            End With

            For intN As Integer = 0 To Me.dgvSelectedDataListForDRFCal.Columns.Count - 1
                Me.dgvSelectedDataListForDRFCal.Columns(intN).SortMode = DataGridViewColumnSortMode.NotSortable
            Next


        End If

        ofrmPrograssBar.Close()

        MsgBox("Setting rainfall gauge data is completed!!!   ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)

    End Sub

    Sub ReadAndSetGridLayerInfo()

        Dim intCountGridLayer As Integer
        Dim intN As Integer
        intCountGridLayer = Me.dgvSelectedDataListForDRFCal.RowCount
        ReDim mDataListInfoForDRFCalibration(intCountGridLayer - 1)

        With Me.dgvSelectedDataListForDRFCal
            For intN = 0 To intCountGridLayer - 1

                mDataListInfoForDRFCalibration(intN).Order = CInt(.Rows(intN).Cells(0).Value)
                mDataListInfoForDRFCalibration(intN).GridFileName = CStr(.Rows(intN).Cells(1).Value)
                mDataListInfoForDRFCalibration(intN).GridFilePath = CStr(.Rows(intN).Cells(2).Value)
                'mDataListInfoForDRFCalibration(intN).GageRainfallData = New ArrayList

            Next

        End With

        mintCountGridLayer = intCountGridLayer

    End Sub



    Sub ReadAndSetGagePosition()

        Try


            Dim eGagePositionInfoSourceType As GagePositionInfoSourceType

            If Me.rbLoadGageUsingTextFile.Checked = True Then
                eGagePositionInfoSourceType = GagePositionInfoSourceType.TextFile
            Else
                eGagePositionInfoSourceType = GagePositionInfoSourceType.PointLayer
            End If

            Select Case eGagePositionInfoSourceType
                Case GagePositionInfoSourceType.TextFile

                    Dim strFNPgagePos As String = Trim(Me.txtFNPGagePosTextfile.Text)

                    If strFNPgagePos = "" Then
                        MsgBox("Gage position text file is not selected.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
                        mbAllisNormal = False
                        Exit Sub
                    End If

                    If File.Exists(strFNPgagePos) = False Then
                        MsgBox("Selected gage position file is not existed.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
                        mbAllisNormal = False
                        Exit Sub

                    End If

                    Call ReadAndSetGagePositionTextFile(strFNPgagePos)

                Case GagePositionInfoSourceType.PointLayer

                    Dim strPointLayerName As String = Trim(Me.cmbPointLayer.Text)
                    Dim strNameField As String = Trim(Me.cmbNameField.Text)

                    If strPointLayerName = "" Then
                        MsgBox("Rain gage point layer is not selected.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
                        mbAllisNormal = False
                        Exit Sub
                    End If

                    If strNameField = "" Then
                        mbAllisNormal = False
                        MsgBox("Rain gage point layer name field is not selected.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)

                        Exit Sub
                    End If

                    Call ReadAndSetGagePositionWithPointLayer()

                Case Else

            End Select

        Catch ex As Exception
            mbAllisNormal = False
        End Try

    End Sub

    Sub ReadAndSetGagePositionTextFile(ByVal strInFNPgagePos As String)

        Dim stGageName As String
        Dim strPosTMX As String
        Dim strPosTMY As String

        Try

            Dim strLines() As String = System.IO.File.ReadAllLines(strInFNPgagePos)

            mintCountRainGage = strLines.Length

            ReDim mGageRainfallInfo(mintCountRainGage - 1)

            Dim intL As Integer = 0

            Using oTextReader As New FileIO.TextFieldParser(strInFNPgagePos, Encoding.Default)

                oTextReader.TextFieldType = FileIO.FieldType.Delimited
                oTextReader.SetDelimiters(",")
                oTextReader.TrimWhiteSpace = True

                Dim TextIncurrentRow As String()

                While Not oTextReader.EndOfData

                    TextIncurrentRow = oTextReader.ReadFields

                    Select Case TextIncurrentRow.Length


                        Case 3
                            stGageName = TextIncurrentRow(0).ToString
                            strPosTMX = TextIncurrentRow(1).ToString
                            strPosTMY = TextIncurrentRow(2).ToString

                        Case Else

                            MsgBox("Gage position text file has invalid format.   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                            mbAllisNormal = False
                            Exit Sub

                    End Select

                    mGageRainfallInfo(intL).GageName = stGageName
                    mGageRainfallInfo(intL).TMx = strPosTMX
                    mGageRainfallInfo(intL).TMy = strPosTMY
                    mGageRainfallInfo(intL).RainfallTS = New ArrayList

                    intL += 1

                End While

            End Using

        Catch ex As Exception

        End Try
    End Sub


    Sub ReadAndSetGagePositionWithPointLayer()
        Try
            Dim bPositionIsValid As Boolean
            Dim strPointLayerName As String = Trim(Me.cmbPointLayer.Text)
            Dim strNameField As String = Trim(Me.cmbNameField.Text)
            Dim strFPNanRFGrid As String = mDataListInfoForDRFCalibration(0).GridFilePath + "\" + mDataListInfoForDRFCalibration(0).GridFileName
            '그리드 레이어는 강우영역에서 받는다..
            Dim oPointSF As New MapWinGIS.Shapefile
            oPointSF = cMap.GetMWShapeFileWithLayerName(cMap.mwAppMain, strPointLayerName)
            Dim fieldIdName As Integer = cMap.GetFieldIndexByName(oPointSF, strNameField)
            Dim oGrid As New MapWinGIS.Grid
            oGrid.Open(strFPNanRFGrid, MapWinGIS.GridDataType.UnknownDataType, True, _
                        MapWinGIS.GridFileType.UseExtension)
            Dim oGridExt As New cGrid(oGrid)
            Dim nRow As Integer = 0
            mintCountRainGage = oPointSF.NumShapes
            ReDim mGageRainfallInfo(mintCountRainGage - 1)
            For n As Integer = 0 To mintCountRainGage - 1
                Dim p As New MapWinGIS.Point
                p = CType(oPointSF.Shape(n), MapWinGIS.Point)
                Dim tmY As Single = CSng(p.y)
                Dim tmX As Single = CSng(p.x)
                bPositionIsValid = True
                If tmX < oGridExt.left And tmX > oGridExt.right Then bPositionIsValid = False
                If tmY < oGridExt.bottom And tmY > oGridExt.top Then bPositionIsValid = False
                Dim strPointName As String = CStr(oPointSF.CellValue(fieldIdName, n))

                If bPositionIsValid = False Then
                    MsgBox("Point entity '" + strPointName + "'is not involved in the rainfall grid layer area.    ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                    mbAllisNormal = False
                    Exit Sub
                Else
                    mGageRainfallInfo(nRow).GageName = strPointName
                    mGageRainfallInfo(nRow).TMx = CStr(tmX)
                    mGageRainfallInfo(nRow).TMy = CStr(tmY)
                    mGageRainfallInfo(nRow).RainfallTS = New ArrayList
                    nRow += 1
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
        End Try
    End Sub


    Sub ReadAndSetGegeTimeSeries()

        Try
            Dim strInFNPgageTS As String = Trim(Me.txtTimeSeriesFPN.Text)
            If strInFNPgageTS = "" Then
                MsgBox("Gage time series text file is not selected.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
                mbAllisNormal = False
                Exit Sub
            End If
            If File.Exists(strInFNPgageTS) = False Then
                MsgBox("Selected gage time series file is not existed.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
                mbAllisNormal = False
                Exit Sub
            End If
            Dim intL As Integer = 0
            Dim intCountGage As Integer = 0
            Dim intG1 As Integer
            Dim intG2 As Integer
            Dim strGageName(mintCountRainGage - 1) As String
            Dim bGageNameIS As Boolean
            Using oTextReader As New FileIO.TextFieldParser(strInFNPgageTS, Encoding.Default)

                oTextReader.TextFieldType = FileIO.FieldType.Delimited
                oTextReader.SetDelimiters(",")
                oTextReader.TrimWhiteSpace = True

                Dim TextIncurrentRow As String()

                While Not oTextReader.EndOfData

                    TextIncurrentRow = oTextReader.ReadFields

                    If intL = 0 Then

                        intCountGage = TextIncurrentRow.Length

                        If intCountGage <> mintCountRainGage Then
                            '여기서 gage 개수와 입력된 시계열 개수 검증
                            MsgBox("Time series number is different with gage number.   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                            mbAllisNormal = False
                            Exit Sub
                        End If

                        strGageName = TextIncurrentRow

                    Else

                        For intG1 = 0 To intCountGage - 1

                            bGageNameIS = False

                            For intG2 = 0 To intCountGage - 1

                                If strGageName(intG1).ToString = mGageRainfallInfo(intG2).GageName Then
                                    bGageNameIS = True
                                    mGageRainfallInfo(intG2).RainfallTS.Add(TextIncurrentRow(intG1).ToString)
                                    Exit For

                                End If

                            Next intG2

                            If bGageNameIS = False Then
                                MsgBox("Gage name is different between gage position information and gage rainfall data file.   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                                mbAllisNormal = False
                                Exit Sub

                            End If

                        Next intG1

                    End If

                    intL += 1

                End While

            End Using

            'mintCountRFDataInOneGage = intL - 1

            If mintCountGridLayer <> (intL - 1) Then

                MsgBox("The number of rainfall grid layer is different from the number of rainfall data in a gage.    ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                mbAllisNormal = False
                Exit Sub
            End If

            For intG1 = 0 To intCountGage - 1

                If mintCountGridLayer <> mGageRainfallInfo(intG1).RainfallTS.Count Then
                    MsgBox("The number of rainfall data in " + mGageRainfallInfo(intG1).GageName + " is different from the number of rainfall grid layer.   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                    mbAllisNormal = False
                    Exit Sub
                End If
            Next

        Catch ex As Exception
            mbAllisNormal = False
        End Try

    End Sub

    'Private Sub DrvlRGDFiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim strDrvPath As String
    '    Dim strDriveName As String
    '    strDrvPath = Me.DrvlRGDFiles.Drive
    '    strDriveName = cComTools.GetDriveName(strDrvPath)
    '    Me.DirlRGDFiles.Path = strDriveName + "\"
    '    Me.filelRainfallRGDFiles.Path = Me.DirlRGDFiles.Path
    'End Sub

    'Private Sub DirlRGDFiles_Change(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Me.filelRainfallRGDFiles.Path = Me.DirlRGDFiles.Path
    'End Sub



    Private Sub btStartCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStartCM.Click
        If mbUpdateDGV = True Then
            If Me.dgvSelectedDataListForDRFCal.ColumnCount = 3 Then
                MsgBox("Gage rainfall data is invalid.   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                Exit Sub
            End If
            Dim nr As Integer = Me.dgvSelectedDataListForDRFCal.RowCount
            Dim nc As Integer = Me.dgvSelectedDataListForDRFCal.ColumnCount
            If Trim(CStr(Me.dgvSelectedDataListForDRFCal.Rows(nr - 1).Cells(nc - 1).Value)) = "" Then
                MsgBox("Gage rainfall data is invalid.   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                Exit Sub
            End If
        End If

        Dim ProcessCM As Process
        Dim ofrmPrograssBar As New fProgressBar
        ofrmPrograssBar.GRMToolsPrograssBar.Maximum = mintCountGridLayer
        ofrmPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
        ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Running 0/" & CStr(mintCountGridLayer) & " rainfall layer..."
        ofrmPrograssBar.Text = "Conditional Merging"
        ofrmPrograssBar.Show()
        System.Windows.Forms.Application.DoEvents()
        'cGRMToolsMakeRFGridLayers.mStopProgress = False

        ProcessCM = Nothing
        Try
            Dim strRainfallPrefix As String = Trim(Me.txtResultFilePrefix.Text)

            Dim strRainfallTag As String = Trim(Me.txtResultFileTag.Text)
            Dim strDestinationFolderPath As String = Trim(Me.txtDestinationFolderPath.Text)

            Dim strSourceFPN As String
            Dim strResultGridFPN As String
            Dim strResultFNWithoutExtension As String

            Dim intN As Integer
            Dim strFNPtemplate As String = strDestinationFolderPath + "\CMtemplate.tmp"

            For intN = 0 To mintCountGridLayer - 1
                strSourceFPN = mDataListInfoForDRFCalibration(intN).GridFilePath + "\" + mDataListInfoForDRFCalibration(intN).GridFileName
                strResultFNWithoutExtension = strRainfallPrefix + IO.Path.GetFileNameWithoutExtension(mDataListInfoForDRFCalibration(intN).GridFileName) + strRainfallTag '+ ".RGD"
                strResultGridFPN = strDestinationFolderPath + "\" + strResultFNWithoutExtension + ".RGD"

                'c:>RADARCM.exe C:\RadarRain.RGD C:\TMRain.csv C:\result_20100503.RGD

                Call CreateTemplateCVSTextFile(intN, strFNPtemplate)
                'Dim tt As String

                If ProcessCM Is Nothing Then

                    ProcessCM = New Process
                    ProcessCM.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    ProcessCM.StartInfo.FileName = "C:\Program Files\HyGIS2011\Util\Radar\RadarToRain.exe"
                    ProcessCM.StartInfo.Arguments = "CM " + """" + strSourceFPN + """" + " " + """" + strFNPtemplate + """" + " " + """" & strResultGridFPN + """"
                    ProcessCM.Start()
                Else
                    If ProcessCM.HasExited = True Then
                        ProcessCM.StartInfo.Arguments = "CM " + """" + strSourceFPN + """" + " " + """" + strFNPtemplate + """" + " " + """" & strResultGridFPN + """"
                        ProcessCM.Start()
                    End If
                End If

                System.Windows.Forms.Application.DoEvents()
                ProcessCM.WaitForExit()
                System.Windows.Forms.Application.DoEvents()

                ofrmPrograssBar.GRMToolsPrograssBar.Value = intN + 1
                ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Processing " + CStr(intN + 1) + "/" & CStr(mintCountGridLayer) & " grid file is completed..."
                System.Windows.Forms.Application.DoEvents()
                'Call cComTools.DeleteRGDfriends(strResultGridFPN)

                'If cGRMToolsMakeRFGridLayers.mStopProgress = True Then
                '    MsgBox("Processing stopped!!!     ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
                '    If ProcessCM Is Nothing Then
                '    Else
                '        If ProcessCM.HasExited = False Then ProcessCM.Kill()
                '    End If
                '    ofrmPrograssBar.Close()
                '    Exit For
                'End If
            Next

            If IO.File.Exists(strFNPtemplate) = True Then File.Delete(strFNPtemplate)
            ofrmPrograssBar.Close()
            If ProcessCM Is Nothing Then
            Else
                If ProcessCM.HasExited = False Then ProcessCM.Kill()
            End If
            MsgBox("Distributed rainfall calibration is completed.    ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            If ProcessCM Is Nothing Then
            Else
                If ProcessCM.HasExited = False Then ProcessCM.Kill()
            End If
            ofrmPrograssBar.Close()
        End Try

    End Sub

    Sub CreateTemplateCVSTextFile(ByVal intNowOrder As Integer, ByVal strDestinationFPN As String)
        Dim intFNum As Integer = FreeFile()
        Dim intG As Integer
        Dim strOut As String = ""
        If IO.File.Exists(strDestinationFPN) = True Then File.Delete(strDestinationFPN)
        For intG = 0 To mintCountRainGage - 1
            With mGageRainfallInfo(intG)
                strOut = strOut + .TMx + "," + .TMy + "," + CStr(.RainfallTS.Item(intNowOrder)) + vbCrLf
            End With
        Next intG
        IO.File.AppendAllText(strDestinationFPN, strOut, Encoding.Default)
    End Sub


    Private Sub txtFolderPathSource_TextChanged(sender As Object, e As EventArgs) Handles txtFolderPathSource.TextChanged
        If txtFolderPathSource.Text.Trim <> "" AndAlso IO.Directory.Exists(txtFolderPathSource.Text.Trim) Then
            Me.lstRFfiles.DataSource = cFile.GetFileList(txtFolderPathSource.Text.Trim, mfilePattern)
        Else
            Me.lstRFfiles.DataSource = Nothing
        End If
    End Sub

    Private Sub btOpenRfFolder_Click(sender As Object, e As EventArgs) Handles btOpenRfFolder.Click
        Dim fb As New FolderBrowserDialog
        If IO.Directory.Exists(txtFolderPathSource.Text.Trim) Then
            fb.SelectedPath = txtFolderPathSource.Text.Trim
        Else
            fb.SelectedPath = My.Application.Info.DirectoryPath
        End If

        If fb.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtFolderPathSource.Text = fb.SelectedPath
        End If
    End Sub
End Class