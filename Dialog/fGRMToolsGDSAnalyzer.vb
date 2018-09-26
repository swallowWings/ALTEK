
Imports System.Text
Imports gentle


Public Class fGRMToolsGDSAnalyzer
    Private mdtRFFileInfo As New TimeSeriesDS.RainfallFilesDataTable
    Private mintTotCountWSValue As Integer
    Private mintWSCountToCombine As Integer
    Private mbSetupIsNormal As Boolean
    Private mbCalculationIsNormal As Boolean
    Private mWSGridLayerName As String
    Private mRFinfoSelectedCell() As GridRFSummary
    Private mRFinfoForWSMAP() As GridRFSummary
    Private mRFinfoForWSMAPCombination As GridRFSummary
    Private mlWSIDsToCombine As List(Of Integer)

    Private mrfFilePattern As cFile.FilePattern

    Enum CellPositionInfoSourceType
        TextFile
        PointLayer
    End Enum

    Structure GridRFSummary
        Public Name As String
        Public CellCount As Long
        Public ColX As Integer
        Public RowY As Integer
        Public RFCumulative As Single
        Public RFMax As Single
        Public RFMin As Single
        Public RFAverage As Single
        Public RFTSValue As ArrayList
        Public WSValueCollectionColX As ArrayList
        Public WSValueCollectionRowY As ArrayList
    End Structure


    Private Sub frmGRMToolsDRAnalyzer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If mGMApp.Workspace Is Nothing Then
        If cMap.mwAppMain Is Nothing Then
            Me.rbLoadCellPosUsingPointLayer.Enabled = False
        Else
            'mTargetMap = mGMApp.Workspace.Maps(1)
            Me.rbLoadCellPosUsingPointLayer.Enabled = True
        End If

        'Me.filelRainfallFiles.Pattern = "*.RGD"
        mrfFilePattern = cFile.FilePattern.TIFFILE
        Me.dgvRGDFileListToApply.AllowUserToAddRows = False
        Me.dgvGPSummary.ReadOnly = True
        Me.dgvGPSummary.AllowUserToAddRows = False
        Me.dgvMAPSummary.ReadOnly = True
        Me.dgvMAPSummary.AllowUserToAddRows = False
        Me.dgvRGDFileListToApply.DataSource = mdtRFFileInfo
        SetDataGridViewForm()
    End Sub

    Sub SetDataGridViewForm()
        With Me.dgvRGDFileListToApply

            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AllowUserToDeleteRows = False
            .AllowUserToAddRows = False
            .RowHeadersVisible = False

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter '.MiddleLeft
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .AutoResizeRows()

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect '.CellSelect
            .MultiSelect = True

            .Columns(0).DefaultCellStyle.BackColor = System.Drawing.SystemColors.InactiveBorder
            .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(0).ReadOnly = True

            .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).Width = 160 'dgvRainfallASCiiFileList.Width - .Columns(0).Width - .Columns(1).Width

        End With

        Me.dgvRGDFileListToApply.Refresh()
    End Sub

    Private Sub btAddAllFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddAllFiles.Click
        Call AddFiles(False)
    End Sub


    Sub AddFiles(ByVal bSelectedFile As Boolean)
        If IO.Directory.Exists(txtFolderPathSource.Text.Trim) = True Then
            Dim strFilePath As String = txtFolderPathSource.Text.Trim
            Dim obj As New cFile
            Dim items As String() = obj.GetFilesAndCheckDuplication(
                                     lstRFfiles, bSelectedFile, strFilePath, mdtRFFileInfo, "FileName", "FilePath")
            If obj.DuplicationfileProcessMessage = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            obj.AddToDataTable(items, strFilePath, mdtRFFileInfo, "FileOrder", "FileName", "FilePath")
        End If

    End Sub

    Private Sub btAddSelectedFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddSelectedFile.Click
        Call AddFiles(True)
    End Sub


    Private Sub btRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRemoveAll.Click
        mdtRFFileInfo.Rows.Clear()
    End Sub

    Private Sub btRemoveSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRemoveSelected.Click
        If dgvRGDFileListToApply.SelectedRows.Count <= 0 Then
            MsgBox("Please select rows to remove.     ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If

        Dim rowsToRemove As New List(Of DataRow)

        For Each dgvRow As DataGridViewRow In dgvRGDFileListToApply.SelectedRows
            Dim drv As DataRowView = CType(dgvRow.DataBoundItem, DataRowView)
            rowsToRemove.Add(drv.Row)
        Next

        Dim dt As DataTable = CType(dgvRGDFileListToApply.DataSource, DataTable)
        For Each row As DataRow In rowsToRemove
            dt.Rows.Remove(row)
        Next

        cFile.RefreshOrderInDataTable(dt, "FileOrder")
    End Sub

    Private Sub btLoadCellPosTextfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLoadCellPosTextfile.Click
        Dim dlgO As New OpenFileDialog
        With dlgO
            .Title = "Open text file contains cell position inforamtion"
            .FileName = ""
            .Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        End With
        If dlgO.ShowDialog = Windows.Forms.DialogResult.OK Then
            If dlgO.FileName <> "" Then
                Me.txtFNPCellPosTextfile.Text = dlgO.FileName
            End If
        End If
    End Sub


    Sub LoadCellPositionTextFileAndUpdateDGV(ByVal strInputFNPcellPos As String, ByVal TagetDataGridView As Windows.Forms.DataGridView)

        Dim strCellName As String
        Dim strPosXCol As String
        Dim strPosYRow As String
        Try
            TagetDataGridView.Rows.Clear()
            Using oTextReader As New FileIO.TextFieldParser(strInputFNPcellPos, Encoding.Default)
                oTextReader.TextFieldType = FileIO.FieldType.Delimited
                oTextReader.SetDelimiters(",")
                oTextReader.TrimWhiteSpace = True
                'oTextReader .
                Dim currentRow As String()
                Dim intRow As Integer = 0
                While Not oTextReader.EndOfData
                    currentRow = oTextReader.ReadFields
                    intRow += 1
                    Select Case currentRow.Length
                        Case 2
                            strCellName = ""
                            strPosXCol = currentRow(0).ToString
                            strPosYRow = currentRow(1).ToString
                        Case 3
                            strCellName = currentRow(0).ToString
                            strPosXCol = currentRow(1).ToString
                            strPosYRow = currentRow(2).ToString
                        Case Else
                            MsgBox("Required field is invalid.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
                            Exit Sub
                    End Select
                    TagetDataGridView.Rows.Add()
                    TagetDataGridView.Rows(intRow - 1).Cells(0).Value = strCellName
                    TagetDataGridView.Rows(intRow - 1).Cells(1).Value = strPosXCol
                    TagetDataGridView.Rows(intRow - 1).Cells(2).Value = strPosYRow
                End While
            End Using
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btStartGDExtraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStartGDExtraction.Click
        mbSetupIsNormal = True
        Dim eCellPositionInfoSourceType As CellPositionInfoSourceType
        If Me.rbLoadCellPosUsingTextFile.Checked = True Then
            eCellPositionInfoSourceType = CellPositionInfoSourceType.TextFile
        Else
            eCellPositionInfoSourceType = CellPositionInfoSourceType.PointLayer
        End If
        Select Case eCellPositionInfoSourceType
            Case CellPositionInfoSourceType.TextFile
                Dim strFNPcellPos As String = Trim(Me.txtFNPCellPosTextfile.Text)
                If strFNPcellPos = "" Then
                    MsgBox("Text file is not selected.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
                    Exit Sub
                End If
                If File.Exists(strFNPcellPos) = False Then
                    MsgBox("Selected file is not existed.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
                    Exit Sub
                End If
                Call LoadCellPositionTextFileAndUpdateDGV(strFNPcellPos, Me.dgvGPSummary)
            Case CellPositionInfoSourceType.PointLayer
                Dim strPointLayerName As String = Trim(Me.cmbPointLayer.Text)
                Dim strNameField As String = Trim(Me.cmbNameField.Text)
                If strPointLayerName = "" Then
                    MsgBox("Point layer is not selected.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
                    Exit Sub
                End If
                If strNameField = "" Then
                    MsgBox("Point layer name field is not selected.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
                    Exit Sub
                End If
                Call GetCellPositionWithPointLayerAndUpdateDataGridView(cMap.mwAppMain)
        End Select
        mbCalculationIsNormal = True
        If Me.dgvGPSummary.Rows.Count > 0 Then
            ReDim mRFinfoSelectedCell(dgvGPSummary.Rows.Count - 1)
            Call ReadFilesAndAnalyzeGDStatistics()
        Else
            MsgBox("Cells for grid analysis are not selected.   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            mbSetupIsNormal = False
        End If
        If mbCalculationIsNormal = False Then
            MsgBox("Calculation grid precipitation is terminated abnormally!!!  ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If
        Call UpdateDGVGP()
    End Sub

    Private Sub dgvGPSummary_CellContentDoubleClick(ByVal sender As Object,
                                                    ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
                                                Handles dgvGPSummary.CellContentDoubleClick
        If Me.dgvGPSummary.SelectedCells(0).ColumnIndex = 7 Then
            Dim dlgTextBox As New fTextBox
            Dim intRowIndex As Integer = Me.dgvGPSummary.SelectedCells(0).RowIndex
            dlgTextBox.Text = "Grid precipitation time series(Name:" +
                                mRFinfoSelectedCell(intRowIndex).Name +
                                ", ColX=" + CStr(mRFinfoSelectedCell(intRowIndex).ColX) +
                                ", RowY=" + CStr(mRFinfoSelectedCell(intRowIndex).RowY) + ")"
            Dim strOut As String = ""
            For intFile As Integer = 0 To mdtRFFileInfo.Rows.Count - 1
                strOut = strOut + CStr(mRFinfoSelectedCell(intRowIndex).RFTSValue.Item(intFile)) + vbCrLf
            Next
            dlgTextBox.txtTextBox.Text = strOut
            dlgTextBox.txtTextBox.ReadOnly = True
            dlgTextBox.txtTextBox.Font = System.Drawing.SystemFonts.DefaultFont
            dlgTextBox.txtTextBox.Select(Len(strOut), 0)
            dlgTextBox.Show()
        End If
    End Sub


    Sub UpdateDGVGP()
        For intRow As Integer = 0 To dgvGPSummary.RowCount - 1
            With Me.dgvGPSummary.Rows(intRow)
                .Cells(3).Value = mRFinfoSelectedCell(intRow).RFCumulative
                .Cells(4).Value = mRFinfoSelectedCell(intRow).RFMax
                .Cells(5).Value = mRFinfoSelectedCell(intRow).RFMin
                .Cells(6).Value = mRFinfoSelectedCell(intRow).RFAverage
                .Cells(7).Value = "DoubleClick"
            End With
        Next
        Me.dgvGPSummary.ReadOnly = True
    End Sub


    Sub ReadFilesAndAnalyzeGDStatistics()
        mbCalculationIsNormal = True
        Dim nLayerCount As Integer = mdtRFFileInfo.Rows.Count

        For intRow As Integer = 0 To dgvGPSummary.Rows.Count - 1
            Dim sngCumulative As Single = 0
            Dim sngMax As Single = -100000 '작은 값을 줘서 무조건 큰 값이 검색되게
            Dim sngMin As Single = 100000 '큰 값을 줘서 무조건 작은 값이 검색되게..
            Dim sngRFValueNow As Single = 0
            mRFinfoSelectedCell(intRow).RFTSValue = New ArrayList
            Dim colx As Integer = CInt(dgvGPSummary.Rows(intRow).Cells(1).Value)
            Dim rowy As Integer = CInt(dgvGPSummary.Rows(intRow).Cells(2).Value)
            Dim pointName As String = CStr(dgvGPSummary.Rows(intRow).Cells(0).Value)

            Dim dlgprogress As New fProgressBar
            dlgprogress.GRMToolsPrograssBar.Maximum = nLayerCount
            dlgprogress.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
            dlgprogress.labGRMToolsPrograssBar.Text = "Extracting data..."
            dlgprogress.Text = "Extract cell data"
            dlgprogress.Show()
            System.Windows.Forms.Application.DoEvents()

            For Each r As TimeSeriesDS.RainfallFilesRow In mdtRFFileInfo
                If rbGTiff.Checked Then
                    Dim oGrid As New MapWinGIS.Grid
                    oGrid.Open(Path.Combine(r.FilePath, r.FileName), MapWinGIS.GridDataType.UnknownDataType,
                                   True, MapWinGIS.GridFileType.UseExtension)
                    If colx < 0 OrElse colx > oGrid.Header.NumberCols Then mbCalculationIsNormal = False
                    If rowy < 0 OrElse rowy > oGrid.Header.NumberRows Then mbCalculationIsNormal = False
                    If mbCalculationIsNormal = False Then
                        MsgBox(String.Format("{0}(ColX={1}, RowY={2}) is out of range{3}for data file [{4}].",
                                               mRFinfoSelectedCell(intRow).Name, colx, rowy,
                                                vbCrLf, Path.Combine(r.FilePath, r.FileName)), MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                        Exit Sub
                    End If

                    sngRFValueNow = CSng(oGrid.Value(colx, rowy))
                    oGrid = Nothing
                Else
                    Dim FPNdata As String = Path.Combine(r.FilePath, r.FileName)
                    Dim ascFile As New gentle.cTextFileReaderASC(FPNdata)

                    If colx < 0 OrElse colx > ascFile.Header.numberCols Then mbCalculationIsNormal = False
                    If rowy < 0 OrElse rowy > ascFile.Header.numberRows Then mbCalculationIsNormal = False
                    If mbCalculationIsNormal = False Then
                        MsgBox(String.Format("{0}(ColX={1}, RowY={2}) is out of range{3}for data file [{4}].",
                                               mRFinfoSelectedCell(intRow).Name, colx, rowy,
                                                vbCrLf, Path.Combine(r.FilePath, r.FileName)), MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                        Exit Sub
                    End If
                    sngRFValueNow = ascFile.ValueFromTL(colx, rowy)
                End If

                If sngRFValueNow < 0 Then sngRFValueNow = 0
                mRFinfoSelectedCell(intRow).RFTSValue.Add(sngRFValueNow) '이건 시계열
                sngCumulative = sngCumulative + sngRFValueNow '이건 누가
                If sngRFValueNow > sngMax Then sngMax = sngRFValueNow '이건 최대
                If sngRFValueNow < sngMin Then sngMin = sngRFValueNow '이건 최소
                dlgprogress.GRMToolsPrograssBar.Value = r.FileOrder
                dlgprogress.labGRMToolsPrograssBar.Text = String.Format("Processing rainfall file {0}/{1} for point {2}...", r.FileOrder, nLayerCount, pointName)
                System.Windows.Forms.Application.DoEvents()
            Next

            With mRFinfoSelectedCell(intRow)
                .Name = CStr(dgvGPSummary.Rows(intRow).Cells(0).Value)
                .ColX = CInt(dgvGPSummary.Rows(intRow).Cells(1).Value)
                .RowY = CInt(dgvGPSummary.Rows(intRow).Cells(2).Value)
                .RFCumulative = sngCumulative
                .RFAverage = sngCumulative / mdtRFFileInfo.Rows.Count
                .RFMax = sngMax
                .RFMin = sngMin
            End With
            dlgprogress.Close()
            System.Windows.Forms.Application.DoEvents()
        Next intRow

    End Sub


    Private Sub rbLoadCellPosUsingTextFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLoadCellPosUsingTextFile.CheckedChanged
        If Me.rbLoadCellPosUsingTextFile.Checked = True Then

            Me.btLoadCellPosTextfile.Enabled = True
            Me.cmbPointLayer.Enabled = False
            Me.cmbNameField.Enabled = False

        Else

            Me.btLoadCellPosTextfile.Enabled = False
            Me.cmbPointLayer.Enabled = True
            Me.cmbNameField.Enabled = True

        End If

    End Sub

    Private Sub cmbPointLayer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPointLayer.Click, cmbNameField.Click
        Call UpdateCmbPointLayer(Me.cmbPointLayer)
    End Sub


    Sub UpdateCmbPointLayer(ByVal inputCombox As Windows.Forms.ComboBox)
        inputCombox.Items.Clear()
        For Each lyrLayer As MapWindow.Interfaces.Layer In cMap.mwAppMain.Layers
            Select Case lyrLayer.LayerType
                Case MapWindow.Interfaces.eLayerType.PointShapefile
                    'If lyrLayer.Dataset.GeometryType = gmGeometryType.gmPointType Then
                    inputCombox.Items.Add(lyrLayer.Name)
                    'End If
                Case Else
            End Select
        Next
    End Sub


    Sub GetCellPositionWithPointLayerAndUpdateDataGridView(map As MapWindow.Interfaces.IMapWin)
        Dim pointShp As New MapWinGIS.Shapefile
        Dim idxNameField As Integer
        Dim baseGrid As New MapWinGIS.Grid
        Dim dimColX As Integer
        Dim dimRowY As Integer
        Dim bPositionIsValid As Boolean
        Dim strPointLayerName As String = Trim(Me.cmbPointLayer.Text)
        Dim strNameField As String = Trim(Me.cmbNameField.Text)
        Try
            Dim strFPNanRFGrid As String = mdtRFFileInfo(0).FilePath + "\" + mdtRFFileInfo(0).FileName
            '그리드 레이어는 강우영역에서 받는다..
            baseGrid.Open(strFPNanRFGrid, MapWinGIS.GridDataType.UnknownDataType, True, MapWinGIS.GridFileType.UseExtension)
            Dim gridExt As New cGrid(baseGrid)

            Me.dgvGPSummary.Rows.Clear()
            Dim nDgvR As Integer = 0
            pointShp = cMap.GetMWShapeFileWithLayerName(map, strPointLayerName)
            For ns As Integer = 0 To pointShp.NumShapes - 1
                bPositionIsValid = True
                Dim po As MapWinGIS.Shape = pointShp.Shape(ns)
                Dim tmYtoRow As Single = CSng(po.Point(0).y)
                Dim tmXtoCol As Single = CSng(po.Point(0).x)
                If tmXtoCol >= gridExt.left And tmXtoCol <= gridExt.right Then
                    'map좌표이용하여 col number 가 반환될것
                    dimColX = CInt(cMap.GetDimXFromGrid(tmXtoCol, tmYtoRow, baseGrid))
                Else
                    bPositionIsValid = False
                End If

                If tmYtoRow >= gridExt.bottom And tmYtoRow <= gridExt.top Then
                    'map좌표이용하여 row number 가 반환될것
                    dimRowY = CInt(cMap.GetDimYFromGrid(tmXtoCol, tmYtoRow, baseGrid))
                Else
                    bPositionIsValid = False
                End If
                idxNameField = cShp.GetFieldIndexInShpFile(pointShp, strNameField)
                Dim pointName As String = CStr(pointShp.CellValue(idxNameField, ns))
                If bPositionIsValid = False Then
                    MsgBox("Point entity '" + pointName + "'is not involved in the rainfall grid layer area.    ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                Else
                    Me.dgvGPSummary.Rows.Add()
                    Me.dgvGPSummary.Rows(nDgvR).Cells(0).Value = pointName
                    Me.dgvGPSummary.Rows(nDgvR).Cells(1).Value = dimColX
                    Me.dgvGPSummary.Rows(nDgvR).Cells(2).Value = dimRowY
                    nDgvR += 1
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
        End Try
    End Sub

    Private Sub cmbPointLayer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPointLayer.SelectedIndexChanged
        Try

            If Me.cmbPointLayer.Text <> "" Then
                Me.cmbNameField.Items.Clear()
                Dim strPointLayerName As String = Trim(Me.cmbPointLayer.Text)
                Dim shpPoint As MapWinGIS.Shapefile
                shpPoint = cMap.GetMWShapeFileWithLayerName(cMap.mwAppMain, strPointLayerName)
                For nf As Integer = 0 To shpPoint.NumFields - 1
                    Me.cmbNameField.Items.Add(shpPoint.Field(nf).Name)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, , cGRM.BuildInfo.ProductName)
        End Try
    End Sub



    Private Sub btSelectFloderAndSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSelectFloderAndSaveGP.Click
        Dim strFNP As String = ""
        Dim dlgS As New SaveFileDialog
        With dlgS
            .Title = "Save calculation result"
            .FileName = ""
            .Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        End With
        If dlgS.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFNP = dlgS.FileName
            If File.Exists(strFNP) Then File.Delete(strFNP)
        Else
            Exit Sub
        End If

        Dim strOutPutLine As String
        strOutPutLine = "Name" + vbTab + "ColX" + vbTab + "RowY" + vbTab + "Cumulative" + vbTab + "Maximum" + vbTab + "Minimum" + vbTab + "Average" + vbCrLf
        IO.File.AppendAllText(strFNP, strOutPutLine, Encoding.Default)

        For intCell As Integer = 0 To dgvMAPSummary.RowCount - 1
            With mRFinfoSelectedCell(intCell)
                strOutPutLine = .Name + vbTab + CStr(.ColX) + vbTab + CStr(.RowY) + vbTab + CStr(.RFCumulative) + vbTab + CStr(.RFMax) + vbTab + CStr(.RFMin) + vbTab + CStr(.RFAverage) + vbCrLf
                IO.File.AppendAllText(strFNP, strOutPutLine, Encoding.Default)
            End With
        Next
        IO.File.AppendAllText(strFNP, vbCrLf, Encoding.Default)

        strOutPutLine = ""
        For intCell As Integer = 0 To dgvGPSummary.RowCount - 1
            strOutPutLine = strOutPutLine + mRFinfoSelectedCell(intCell).Name + vbTab
        Next
        strOutPutLine = strOutPutLine + vbCrLf
        IO.File.AppendAllText(strFNP, strOutPutLine, Encoding.Default)

        For intFile As Integer = 0 To mdtRFFileInfo.Rows.Count - 1
            strOutPutLine = ""
            For intCell As Integer = 0 To dgvGPSummary.RowCount - 1
                strOutPutLine = strOutPutLine + CStr(mRFinfoSelectedCell(intCell).RFTSValue.Item(intFile)) + vbTab
            Next
            strOutPutLine = strOutPutLine + vbCrLf
            IO.File.AppendAllText(strFNP, strOutPutLine, Encoding.Default)
        Next
    End Sub



    Private Sub btCalculateAM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCalculateAM.Click


        mWSGridLayerName = Me.cmbWSLayer.Text

        If mWSGridLayerName = "" Then
            MsgBox("Watershed grid layer is not selected.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If

        Call SetWatershedIDAndCellCountAndUpdateDGV()

        Call ReadGridLayerAndAnalyzeAMStatistics()

        Call UpdateDgvMAPSummary()


    End Sub





    Sub UpdateDgvMAPSummary()
        For intRow As Integer = 0 To mintTotCountWSValue - 1
            With Me.dgvMAPSummary.Rows(intRow)
                .Cells(2).Value = mRFinfoForWSMAP(intRow).RFCumulative
                .Cells(3).Value = mRFinfoForWSMAP(intRow).RFMax
                .Cells(4).Value = mRFinfoForWSMAP(intRow).RFMin
                .Cells(5).Value = mRFinfoForWSMAP(intRow).RFAverage
                .Cells(6).Value = "DoubleClick"
            End With
        Next
    End Sub


    Sub SetWatershedIDAndCellCountAndUpdateDGV()

        Dim totCountValue As Integer
        Dim lstWSGridValue As New List(Of Integer)
        Dim wsGrid As New MapWinGIS.Grid

        wsGrid = cMap.GetMWGridWithLayerName(cMap.mwAppMain, mWSGridLayerName)
        lstWSGridValue = cMap.GetValueListIntegerInGridLayer(wsGrid)
        lstWSGridValue.Sort()
        totCountValue = lstWSGridValue.Count

        Dim intCountWSValue As Integer = 0
        mintTotCountWSValue = 0
        '여기서 유효한 셀 값 개수 계산하고
        For n As Integer = 0 To totCountValue - 1
            If CStr(lstWSGridValue.Item(n)) <> "-9999" Then intCountWSValue += 1
        Next

        mintTotCountWSValue = intCountWSValue
        ReDim mRFinfoForWSMAP(mintTotCountWSValue - 1 + 100) '100 개 더 저장할 수 있게..

        Dim nArr As Integer = 0
        For n As Integer = 0 To totCountValue - 1
            If CStr(lstWSGridValue.Item(n)) = "-9999" Then
            Else
                mRFinfoForWSMAP(nArr).Name = CStr(lstWSGridValue.Item(n))
                mRFinfoForWSMAP(nArr).CellCount = 0
                mRFinfoForWSMAP(nArr).WSValueCollectionColX = New ArrayList
                mRFinfoForWSMAP(nArr).WSValueCollectionRowY = New ArrayList
                nArr += 1
            End If
        Next

        Dim gridRowCount As Integer = CInt(wsGrid.Header.NumberRows)
        Dim gridColCount As Integer = CInt(wsGrid.Header.NumberCols)
        Dim wsValueNow As Single
        For r As Integer = 0 To gridRowCount - 1
            For c As Integer = 0 To gridColCount - 1
                wsValueNow = CSng(wsGrid.Value(c, r)) ' 여기 위치 확인
                For n As Integer = 0 To mintTotCountWSValue - 1
                    If mRFinfoForWSMAP(n).Name = CStr(wsValueNow) Then
                        mRFinfoForWSMAP(n).CellCount = mRFinfoForWSMAP(n).CellCount + 1
                        mRFinfoForWSMAP(n).WSValueCollectionColX.Add(c)
                        mRFinfoForWSMAP(n).WSValueCollectionRowY.Add(r)
                    End If
                Next
            Next c
        Next r
        Me.dgvMAPSummary.Rows.Clear()
        For n As Integer = 0 To mintTotCountWSValue - 1
            Me.dgvMAPSummary.Rows.Add()
            Me.dgvMAPSummary.Rows(n).Cells(0).Value = mRFinfoForWSMAP(n).Name
            Me.dgvMAPSummary.Rows(n).Cells(1).Value = mRFinfoForWSMAP(n).CellCount
        Next
    End Sub


    Sub ReadGridLayerAndAnalyzeAMStatistics()
        Dim dlgprogress As New fProgressBar
        Try
            dlgprogress.GRMToolsPrograssBar.Maximum = mintTotCountWSValue * mdtRFFileInfo.Rows.Count
            dlgprogress.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
            dlgprogress.labGRMToolsPrograssBar.Text = "Calculating areal mean..."
            dlgprogress.Text = "Calculate areal mean value"
            dlgprogress.Show()
            System.Windows.Forms.Application.DoEvents()

            Dim RefASCFile As cTextFileReaderASC = Nothing
            Dim oGridBase As New MapWinGIS.Grid
            If rbGTiff.Checked Then
                oGridBase.Open(Path.Combine(mdtRFFileInfo(0).FilePath, mdtRFFileInfo(0).FileName),
                                MapWinGIS.GridDataType.UnknownDataType,
                                 True, MapWinGIS.GridFileType.UseExtension)
            Else
                Dim aRow As TimeSeriesDS.RainfallFilesRow = CType(mdtRFFileInfo.Rows(0), TimeSeriesDS.RainfallFilesRow)
                RefASCFile = New cTextFileReaderASC(Path.Combine(aRow.FilePath, aRow.FileName))
            End If

            For intNWSValue As Integer = 0 To mintTotCountWSValue - 1
                Dim sngCumulative As Single = 0
                Dim sngMax As Single = -100000 '작은 값을 줘서 무조건 큰 값이 검색되게
                Dim sngMin As Single = 100000 '큰 값을 줘서 무조건 작은 값이 검색되게..
                Dim sngRFValueNow As Single = 0
                mRFinfoForWSMAP(intNWSValue).RFTSValue = New ArrayList
                For Each r As TimeSeriesDS.RainfallFilesRow In mdtRFFileInfo
                    Dim fpnRFGridFile As String = Path.Combine(r.FilePath, r.FileName)
                    Dim sngRFSumNowWSinNowFile As Single = 0
                    If rbGTiff.Checked Then
                        Dim oGrid As New MapWinGIS.Grid
                        oGrid.Open(fpnRFGridFile, MapWinGIS.GridDataType.UnknownDataType,
                                    True, MapWinGIS.GridFileType.UseExtension)
                        If cGrid.CheckTwoGridLayerExtent(oGridBase, oGrid) = False Then
                            mbSetupIsNormal = False
                            MsgBox("The extent of rainfall grid layer is not equal to watershed grid layer.    " + vbCrLf +
                                   fpnRFGridFile, MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                            Exit Sub
                        End If
                        For lngArrayIndex As Integer = 0 To mRFinfoForWSMAP(intNWSValue).WSValueCollectionColX.Count - 1
                            Dim colx As Integer = CInt(mRFinfoForWSMAP(intNWSValue).WSValueCollectionColX.Item(lngArrayIndex))
                            Dim rowy As Integer = CInt(mRFinfoForWSMAP(intNWSValue).WSValueCollectionRowY.Item(lngArrayIndex))
                            sngRFValueNow = CSng(oGrid.Value(colx, rowy))
                            If sngRFValueNow < 0 Then sngRFValueNow = 0
                            sngRFSumNowWSinNowFile = sngRFSumNowWSinNowFile + sngRFValueNow
                        Next
                        oGrid = Nothing
                    Else
                        Dim mASCfile As cTextFileReaderASC
                        mASCfile = New cTextFileReaderASC(fpnRFGridFile)
                        If cTextFileReaderASC.CompareFiles(RefASCFile, mASCfile) = False Then
                            MsgBox("Input file is different from first asc file.  ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                            Exit Sub
                        End If
                        For lngArrayIndex As Integer = 0 To mRFinfoForWSMAP(intNWSValue).WSValueCollectionColX.Count - 1
                            Dim colx As Integer = CInt(mRFinfoForWSMAP(intNWSValue).WSValueCollectionColX.Item(lngArrayIndex))
                            Dim rowy As Integer = CInt(mRFinfoForWSMAP(intNWSValue).WSValueCollectionRowY.Item(lngArrayIndex))
                            sngRFValueNow = mASCfile.ValueFromTL(colx, rowy)
                            If sngRFValueNow < 0 Then sngRFValueNow = 0
                            sngRFSumNowWSinNowFile = sngRFSumNowWSinNowFile + sngRFValueNow
                        Next lngArrayIndex
                    End If
                    Dim sngMAPNowFile As Single = sngRFSumNowWSinNowFile / mRFinfoForWSMAP(intNWSValue).CellCount
                    sngCumulative = sngCumulative + sngMAPNowFile
                    mRFinfoForWSMAP(intNWSValue).RFTSValue.Add(sngMAPNowFile) '이건 시계열
                    If sngMAPNowFile > sngMax Then sngMax = sngMAPNowFile '이건 최대
                    If sngMAPNowFile < sngMin Then sngMin = sngMAPNowFile '이건 최소
                    dlgprogress.GRMToolsPrograssBar.Value = (intNWSValue + 1) * r.FileOrder
                    dlgprogress.labGRMToolsPrograssBar.Text = "Processing " & CStr((intNWSValue + 1) * r.FileOrder) &
                                                               "/" & CStr(mintTotCountWSValue * mdtRFFileInfo.Rows.Count) & " ..."
                    System.Windows.Forms.Application.DoEvents()
                Next
                With mRFinfoForWSMAP(intNWSValue)
                    .RFCumulative = sngCumulative
                    .RFAverage = sngCumulative / mdtRFFileInfo.Rows.Count
                    .RFMax = sngMax
                    .RFMin = sngMin
                End With
            Next intNWSValue
            oGridBase = Nothing
            dlgprogress.Close()
            System.Windows.Forms.Application.DoEvents()
        Catch ex As Exception
            If dlgprogress.Visible = True Then
                dlgprogress.Close()
            End If
            Throw
        End Try
    End Sub

    Private Sub cmbWSLayer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbWSLayer.Click
        Call UpdateCmbWSGridLayer(Me.cmbWSLayer)
    End Sub

    Sub UpdateCmbWSGridLayer(ByVal inputCombox As Windows.Forms.ComboBox)
        Dim layer As MapWindow.Interfaces.Layer
        inputCombox.Items.Clear()
        For Each layer In cMap.mwAppMain.Layers
            Select Case layer.LayerType
                Case MapWindow.Interfaces.eLayerType.Grid
                    inputCombox.Items.Add(layer.Name)
                Case Else
            End Select
        Next
    End Sub

    Private Sub dgvMAPSummary_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMAPSummary.CellContentDoubleClick

        If Me.dgvMAPSummary.SelectedCells(0).ColumnIndex = 6 Then
            Dim ofrmTextBox As New fTextBox
            Dim intRowIndex As Integer = Me.dgvMAPSummary.SelectedCells(0).RowIndex
            ofrmTextBox.Text = "Mean areal precipitation time series(WS=" +
                                mRFinfoForWSMAP(intRowIndex).Name + ")"
            Dim strOut As String = ""

            For intFile As Integer = 0 To mdtRFFileInfo.Rows.Count - 1
                strOut = strOut + CStr(mRFinfoForWSMAP(intRowIndex).RFTSValue.Item(intFile)) + vbCrLf
            Next
            ofrmTextBox.txtTextBox.Text = strOut
            ofrmTextBox.txtTextBox.ReadOnly = True
            ofrmTextBox.txtTextBox.Font = System.Drawing.SystemFonts.DefaultFont
            ofrmTextBox.txtTextBox.Select(Len(strOut), 0)
            ofrmTextBox.Show()
        End If
    End Sub

    Private Sub btCombineMAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCombineAM.Click

        If Me.dgvMAPSummary.Rows.Count < 1 Then
            MsgBox("MAP for each watershed is not calculated.    ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        Else

            Call GetWSIDsToCombine()

            Call CalculateWSCombination()

            ' 이상의 과정이 정상적으로 수행될 때 마다 summary 대상이 하나씩 추가
            'main 배열에 추가하는 이유는 시계열 자료 출력을 위해서
            mintTotCountWSValue = mintTotCountWSValue + 1

            Call AddWSCombinationToMainArrayAndDGV()


        End If

    End Sub


    Sub AddWSCombinationToMainArrayAndDGV()

        With mRFinfoForWSMAP(mintTotCountWSValue - 1)

            .Name = mRFinfoForWSMAPCombination.Name
            .CellCount = mRFinfoForWSMAPCombination.CellCount
            .RFCumulative = mRFinfoForWSMAPCombination.RFCumulative
            .RFMax = mRFinfoForWSMAPCombination.RFMax
            .RFMin = mRFinfoForWSMAPCombination.RFMin
            .RFAverage = mRFinfoForWSMAPCombination.RFAverage
            .RFTSValue = New ArrayList
            .RFTSValue = mRFinfoForWSMAPCombination.RFTSValue
        End With




        Me.dgvMAPSummary.Rows.Add()
        Dim intLastRowindex As Integer = Me.dgvMAPSummary.Rows.Count - 1

        With Me.dgvMAPSummary.Rows(intLastRowindex)
            .Cells(0).Value = mRFinfoForWSMAP(mintTotCountWSValue - 1).Name
            .Cells(1).Value = mRFinfoForWSMAP(mintTotCountWSValue - 1).CellCount
            .Cells(2).Value = mRFinfoForWSMAP(mintTotCountWSValue - 1).RFCumulative
            .Cells(3).Value = mRFinfoForWSMAP(mintTotCountWSValue - 1).RFMax
            .Cells(4).Value = mRFinfoForWSMAP(mintTotCountWSValue - 1).RFMin
            .Cells(5).Value = mRFinfoForWSMAP(mintTotCountWSValue - 1).RFAverage
            .Cells(6).Value = "DoubleClick"

        End With

        Me.dgvMAPSummary.Refresh()

    End Sub



    Sub GetWSIDsToCombine()
        Dim strInputWSs As String = Trim(Me.txtWSidsToCombine.Text)
        Dim InitialWSIDsToCombine() As String = strInputWSs.Split(CChar(","))
        mlWSIDsToCombine = New List(Of Integer)
        Dim oField As Object
        For Each oField In InitialWSIDsToCombine
            mlWSIDsToCombine.Add(CInt(Trim(CStr(oField))))
        Next
        mintWSCountToCombine = mlWSIDsToCombine.Count
    End Sub



    Sub CalculateWSCombination()
        Dim alTargetArrayNum As New ArrayList

        '각 유역 id 에 대한 원본 자료의 배열 번호를 받아오고..
        For intN As Integer = 0 To mintWSCountToCombine - 1
            Dim intNArray As Integer = GetArrayNumberForWSMAPinfo(CInt(mlWSIDsToCombine.Item(intN)))
            If intNArray < 0 Then
                MsgBox("There is no information for WSid=" + CStr(mlWSIDsToCombine.Item(intN)), MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                Exit Sub
            Else
                alTargetArrayNum.Add(intNArray)
            End If
        Next

        Dim strWSName As String = ""
        Dim intNowANum As Integer
        Dim lngTotCellCount As Long = 0

        For intN As Integer = 0 To mintWSCountToCombine - 1
            intNowANum = CInt(alTargetArrayNum.Item(intN))
            If intN = 0 Then
                strWSName = CStr(mRFinfoForWSMAP(intNowANum).Name)
            Else
                strWSName = strWSName + "_" + CStr(mRFinfoForWSMAP(intNowANum).Name)
            End If
            lngTotCellCount = lngTotCellCount + mRFinfoForWSMAP(intNowANum).CellCount
        Next

        Dim sngRFNow As Single
        Dim sngCumulative As Single
        Dim sngMax As Single
        Dim sngMin As Single

        mRFinfoForWSMAPCombination.RFTSValue = New ArrayList

        sngCumulative = 0
        sngMax = -100000 '작은 값을 줘서 무조건 큰 값이 검색되게
        sngMin = 100000 '큰 값을 줘서 무조건 작은 값이 검색되게..
        sngRFNow = 0

        For intN As Integer = 0 To mdtRFFileInfo.Rows.Count - 1
            For intN2 As Integer = 0 To mintWSCountToCombine - 1
                intNowANum = CInt(alTargetArrayNum.Item(intN2))
                sngRFNow = sngRFNow + CSng(mRFinfoForWSMAP(intNowANum).RFTSValue.Item(intN)) * mRFinfoForWSMAP(intNowANum).CellCount
            Next
            sngRFNow = sngRFNow / lngTotCellCount
            mRFinfoForWSMAPCombination.RFTSValue.Add(sngRFNow)
            sngCumulative = sngCumulative + sngRFNow
            If sngRFNow > sngMax Then sngMax = sngRFNow '이건 최대
            If sngRFNow < sngMin Then sngMin = sngRFNow '이건 최소
        Next

        With mRFinfoForWSMAPCombination
            .Name = strWSName
            .CellCount = lngTotCellCount
            .RFCumulative = sngCumulative
            .RFAverage = sngCumulative / mdtRFFileInfo.Rows.Count
            .RFMax = sngMax
            .RFMin = sngMin
        End With
    End Sub


    Function GetArrayNumberForWSMAPinfo(ByVal inputWSid As Integer) As Integer
        Dim intArrayNum As Integer
        For intArrayNum = 0 To mintTotCountWSValue - 1
            If inputWSid = CInt(mRFinfoForWSMAP(intArrayNum).Name) Then
                GetArrayNumberForWSMAPinfo = intArrayNum
                Exit Function
            End If
        Next
        GetArrayNumberForWSMAPinfo = -1
    End Function

    Private Sub btSelectFloderAndSaveMAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSelectFloderAndSaveMAP.Click

        Dim strFNP As String = ""
        Dim dlgS As New SaveFileDialog
        With dlgS
            .Title = "Save calculation result"
            .FileName = ""
            .Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        End With
        If dlgS.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFNP = dlgS.FileName
        Else
            Exit Sub
        End If

        Dim intFNum As Integer = FreeFile()
        Dim strOutPutLine As String
        Dim intWS As Integer

        strOutPutLine = "Name" + vbTab + "Cell count" + vbTab + "Cumulative" + vbTab + "Maximum" + vbTab + "Minimum" + vbTab + "Average" + vbCrLf
        IO.File.AppendAllText(strFNP, strOutPutLine, Encoding.Default)
        For intWS = 0 To mintTotCountWSValue - 1
            With mRFinfoForWSMAP(intWS)
                strOutPutLine = .Name + vbTab + CStr(.CellCount) + vbTab + CStr(.RFCumulative) + vbTab + CStr(.RFMax) + vbTab + CStr(.RFMin) + vbTab + CStr(.RFAverage) + vbCrLf
                IO.File.AppendAllText(strFNP, strOutPutLine, Encoding.Default)
            End With
        Next
        IO.File.AppendAllText(strFNP, vbCrLf, Encoding.Default)

        strOutPutLine = ""
        For intWS = 0 To mintTotCountWSValue - 1
            strOutPutLine = strOutPutLine + mRFinfoForWSMAP(intWS).Name + vbTab
        Next
        strOutPutLine = strOutPutLine + vbCrLf
        IO.File.AppendAllText(strFNP, strOutPutLine, Encoding.Default)

        For intFile As Integer = 0 To mdtRFFileInfo.Rows.Count - 1

            strOutPutLine = ""
            For intWS = 0 To mintTotCountWSValue - 1
                strOutPutLine = strOutPutLine + CStr(mRFinfoForWSMAP(intWS).RFTSValue.Item(intFile)) + vbTab
            Next
            strOutPutLine = strOutPutLine + vbCrLf
            IO.File.AppendAllText(strFNP, strOutPutLine, Encoding.Default)
        Next
    End Sub



    Private Sub btCellPosViewSample_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCellPosViewSample.Click

        Dim ofrmTextBox As New fTextBox
        Dim strOut As String

        strOut = "CellName1,CellColumnNumber1,CellRowNubmer1" + vbCrLf
        strOut = strOut + "CellName2,CellColumnNumber2,CellRowNubmer2" + vbCrLf
        strOut = strOut + "   .     ,        .        ,      .       " + vbCrLf
        strOut = strOut + "   .     ,        .        ,      .       " + vbCrLf
        strOut = strOut + "   .     ,        .        ,      .       " + vbCrLf + vbCrLf

        strOut = strOut + "Cell name,column number(x),row number(y)." + vbCrLf
        strOut = strOut + "Each number of column and row starts from 0(zero)." + vbCrLf
        strOut = strOut + "For the cell at low-left corner of a grid layer, column number=0 and row number=0." + vbCrLf
        strOut = strOut + "Write one position in a line." + vbCrLf
        strOut = strOut + "Comma(,) is used to separate each data."

        'ofrmTextBox.Width = 600
        'ofrmTextBox.txtTextBox.Width = 500
        ofrmTextBox.txtTextBox.Text = strOut
        ofrmTextBox.txtTextBox.ReadOnly = True
        ofrmTextBox.txtTextBox.Font = System.Drawing.SystemFonts.DefaultFont
        ofrmTextBox.txtTextBox.Select(Len(strOut), 0)
        ofrmTextBox.Show()

    End Sub

    Private Sub btOpenDestinationFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOpenDestinationFolder.Click
        Dim fb As New FolderBrowserDialog
        If fb.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtDestinationFolderPathAcc.Text = fb.SelectedPath
        End If
    End Sub

    Private Sub btStartAccumulation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStartAccumulation.Click
        If rbGTiff.Checked Then
            If rbAccAllFiles.Checked Then
                Call AccumulateAllGridFilesTiff()
            Else
                Call AggregateGridFilesTiff()
            End If
        Else
            If rbAccAllFiles.Checked Then
                Call AccmulateAllGridFilesASCII()
            Else
                If CheckErrResizeTimeScale() = False Then Exit Sub
                Call AggregateGridFilesASCII()
            End If
        End If

    End Sub

    Private Sub AggregateGridFilesASCII()
        Dim ofrmPrograssBar As New fProgressBar
        ofrmPrograssBar.GRMToolsPrograssBar.Maximum = mdtRFFileInfo.Rows.Count
        ofrmPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
        ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Aggregation..."
        ofrmPrograssBar.Text = "Aggregate grid files"
        ofrmPrograssBar.Show()
        System.Windows.Forms.Application.DoEvents()

        Dim nDivider As Integer = CInt(CInt(txtResultTimeInterval.Text) / CSng(txtSourceTimeInterval.Text))
        Dim aRow As TimeSeriesDS.RainfallFilesRow = CType(mdtRFFileInfo.Rows(0), TimeSeriesDS.RainfallFilesRow)
        Dim RefASCFile As New cTextFileReaderASC(Path.Combine(aRow.FilePath, aRow.FileName))
        Dim REFnCols As Integer = RefASCFile.Header.numberCols
        Dim REFnRows As Integer = RefASCFile.Header.numberRows
        Dim REFcellSize As Single = CSng(RefASCFile.Header.cellsize)
        Dim REFNullValue As Integer = CInt(RefASCFile.Header.nodataValue)
        Dim DataToSum(,) As Single
        ReDim DataToSum(REFnCols - 1, REFnRows - 1)
        DataToSum = InitialzeArray(DataToSum, REFnCols, REFnRows, REFNullValue)
        Dim nResultFile As Integer = 0
        Dim nFile As Integer = 0

        Dim mASCfile As cTextFileReaderASC
        For Each r As TimeSeriesDS.RainfallFilesRow In mdtRFFileInfo
            Dim FPNsource As String
            FPNsource = Path.Combine(r.FilePath, r.FileName)
            mASCfile = New cTextFileReaderASC(FPNsource)
            If cTextFileReaderASC.CompareFiles(RefASCFile, mASCfile) = False Then
                MsgBox("Input file is different from first asc file.  ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                Exit Sub
            End If
            Dim nRow As Integer = 0
            For rowY As Integer = 0 To mASCfile.Header.numberRows - 1
                Dim ValuesInARow As String() = mASCfile.ValuesInOneRowFromTopLeft(nRow)
                For colX As Integer = 0 To mASCfile.Header.numberCols - 1
                    If mASCfile.ValueAtColumeXFormOneRow(colX, ValuesInARow) = -9999 Then
                        If Not DataToSum(colX, rowY) = Nothing AndAlso DataToSum(colX, rowY) <> -9999 Then

                        Else
                            DataToSum(colX, rowY) = -9999
                        End If
                    Else
                        If DataToSum(colX, rowY) = -9999 Then DataToSum(colX, rowY) = 0
                        Dim mmPtenMIN As Single = mASCfile.ValueAtColumeXFormOneRow(colX, ValuesInARow) / 6
                        DataToSum(colX, rowY) = DataToSum(colX, rowY) + mmPtenMIN
                    End If
                Next
                nRow += 1
            Next

            If (nFile Mod nDivider) = 0 Then
                Dim NowTimeToPrint As String = cComTools.GetNowTimeToPrintOut(Me.dtpStartingTime.Text, CInt(Me.txtResultTimeInterval.Text), nResultFile)
                Dim FPNresult As String = Path.Combine(Trim(Me.txtDestinationFolderPathAcc.Text), NowTimeToPrint + ".asc")
                Dim ArrayToPrint(REFnRows - 1) As String
                For nrY As Integer = 0 To REFnRows - 1
                    Dim aLine As String = Format(DataToSum(0, nrY), "#0.##")
                    If REFnCols > 1 Then
                        For ncX As Integer = 1 To REFnCols - 1
                            aLine = aLine + " " + Format(DataToSum(ncX, nrY), "#0.##")
                        Next
                    End If
                    ArrayToPrint(nrY) = aLine
                Next
                Call cTextFile.MakeASCTextFile(FPNresult,
                                                                mASCfile.Header.numberCols, mASCfile.Header.numberRows,
                                                                mASCfile.Header.xllcorner, mASCfile.Header.yllcorner,
                                                               mASCfile.Header.cellsize, CStr(mASCfile.Header.nodataValue),
                                                                ArrayToPrint)
                DataToSum = InitialzeArray(DataToSum, REFnCols, REFnRows, REFNullValue)
                nResultFile += 1
            End If
            nFile += 1
            ofrmPrograssBar.GRMToolsPrograssBar.Value = nFile
            ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Processing " & CStr(nFile) & "/" & CStr(mdtRFFileInfo.Rows.Count) & " ..."
            System.Windows.Forms.Application.DoEvents()
        Next
        ofrmPrograssBar.Close()
        System.Windows.Forms.Application.DoEvents()
    End Sub



    Private Sub AggregateGridFilesTiff()
        Dim ofrmPrograssBar As New fProgressBar
        Try
            Dim rfValue As Single
            Dim nColX As Integer
            Dim nRowY As Integer
            ofrmPrograssBar.GRMToolsPrograssBar.Maximum = mdtRFFileInfo.Rows.Count
            ofrmPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
            ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Accumulate precipitation..."
            ofrmPrograssBar.Text = "Accumulate grid precipitation"
            ofrmPrograssBar.Show()
            System.Windows.Forms.Application.DoEvents()
            Dim oGridBase As New MapWinGIS.Grid
            oGridBase.Open(Path.Combine(mdtRFFileInfo(0).FilePath, mdtRFFileInfo(0).FileName),
                            MapWinGIS.GridDataType.UnknownDataType, True,
                             MapWinGIS.GridFileType.UseExtension)
            Dim GridValueAgg(,) As Single 'x,y 좌표체계로
            ReDim GridValueAgg(oGridBase.Header.NumberCols - 1, oGridBase.Header.NumberRows - 1)
            Dim nFile As Integer = 0
            Dim nDivider As Integer = CInt(CInt(txtResultTimeInterval.Text) / CSng(txtSourceTimeInterval.Text))
            Dim nResultFile As Integer = 0
            For Each r As TimeSeriesDS.RainfallFilesRow In mdtRFFileInfo
                Dim fpnRFGrid As String = Path.Combine(r.FilePath, r.FileName)
                Dim oGridTarget As New MapWinGIS.Grid
                oGridTarget.Open(fpnRFGrid, MapWinGIS.GridDataType.UnknownDataType,
                                    True, MapWinGIS.GridFileType.UseExtension)
                If cGrid.CheckTwoGridLayerExtent(oGridBase, oGridTarget) = False Then
                    MsgBox("The target layer extent is not equal to base layer.    " + vbCrLf +
                                   fpnRFGrid, MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                    Exit Sub
                End If
                For nColX = 0 To oGridTarget.Header.NumberCols - 1
                    For nRowY = 0 To oGridTarget.Header.NumberRows - 1
                        rfValue = CSng(oGridTarget.Value(nColX, nRowY))
                        If GridValueAgg(nColX, nRowY) = -9999 Then
                            '이전에 null이었으면..
                            If rfValue = -9999 Then
                                GridValueAgg(nColX, nRowY) = -9999
                            Else
                                If rfValue < 0 Then rfValue = 0
                                GridValueAgg(nColX, nRowY) = rfValue + GridValueAgg(nColX, nRowY)
                            End If
                        Else
                            '이전에 null이 아니었으면..
                            If rfValue < 0 Then rfValue = 0
                            Dim mmPtenMIN As Single = rfValue / 6
                            GridValueAgg(nColX, nRowY) = GridValueAgg(nColX, nRowY) + mmPtenMIN
                        End If
                    Next nRowY
                Next nColX

                If (nFile Mod nDivider) = 0 Then
                    Dim NowTimeToPrint As String = cComTools.GetNowTimeToPrintOut(Me.dtpStartingTime.Text, CInt(Me.txtResultTimeInterval.Text), nResultFile)
                    Dim FPNresult As String = Path.Combine(Trim(Me.txtDestinationFolderPathAcc.Text), NowTimeToPrint + ".tif")
                    Dim oGridResult As New MapWinGIS.Grid
                    oGridResult = cGrid.CreateNewGrid(oGridBase, FPNresult, MapWinGIS.GridDataType.UnknownDataType, -9999)
                    For nColX = 0 To oGridBase.Header.NumberCols - 1
                        For nRowY = 0 To oGridBase.Header.NumberRows - 1
                            oGridResult.Value(nColX, nRowY) = GridValueAgg(nColX, nRowY)

                        Next nRowY
                    Next nColX
                    'ReDim GridValueAgg(oGridBase.Header.NumberCols - 1, oGridBase.Header.NumberRows - 1)
                    nResultFile += 1
                End If
                nFile += 1
                ofrmPrograssBar.GRMToolsPrograssBar.Value = r.FileOrder
                ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Processing " & CStr(r.FileOrder) & "/" & CStr(mdtRFFileInfo.Rows.Count) & " ..."
                System.Windows.Forms.Application.DoEvents()
            Next r
            ofrmPrograssBar.Close()
            System.Windows.Forms.Application.DoEvents()
        Catch ex As Exception
            If ofrmPrograssBar.Visible = True Then
                ofrmPrograssBar.Close()
            End If
            Throw
        End Try
    End Sub

    Private Function InitialzeArray(ByVal inArray As Single(,), ByVal nColX As Integer, ByVal nRowY As Integer, ByVal nullValue As Integer) As Single(,)
        For r As Integer = 0 To nRowY - 1
            For c As Integer = 0 To nColX - 1
                inArray(c, r) = nullValue
            Next
        Next
        Return inArray
    End Function

    Sub AccumulateAllGridFilesTiff()
        Dim strFPNanRFGrid As String
        Dim sngRFValueNow As Single
        Dim intNowColX As Integer
        Dim intNowRowY As Integer
        Dim ofrmPrograssBar As New fProgressBar
        Dim strResultGridFPN As String = Path.Combine(Me.txtDestinationFolderPathAcc.Text, IO.Path.GetFileNameWithoutExtension(Me.txtResultlGridFileNameAcc.Text) + ".RGD")
        Dim GridValueAcc(,) As Single 'x,y 좌표체계로
        Try

            ofrmPrograssBar.GRMToolsPrograssBar.Maximum = mdtRFFileInfo.Rows.Count
            ofrmPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
            ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Accumulate precipitation..."
            ofrmPrograssBar.Text = "Accumulate grid precipitation"
            ofrmPrograssBar.Show()
            System.Windows.Forms.Application.DoEvents()
            Dim oGridBase As New MapWinGIS.Grid
            oGridBase.Open(Path.Combine(mdtRFFileInfo(0).FilePath, mdtRFFileInfo(0).FileName),
                             MapWinGIS.GridDataType.UnknownDataType, True,
                              MapWinGIS.GridFileType.UseExtension)
            ReDim GridValueAcc(oGridBase.Header.NumberCols - 1, oGridBase.Header.NumberRows - 1)
            For Each r As TimeSeriesDS.RainfallFilesRow In mdtRFFileInfo
                strFPNanRFGrid = r.FilePath + "\" + r.FileName
                Dim oGrid As New MapWinGIS.Grid
                oGrid.Open(strFPNanRFGrid, MapWinGIS.GridDataType.UnknownDataType, True,
                             MapWinGIS.GridFileType.UseExtension)
                If cGrid.CheckTwoGridLayerExtent(oGridBase, oGrid) = False Then Exit Sub
                For intNowColX = 0 To oGrid.Header.NumberCols - 1
                    For intNowRowY = 0 To oGrid.Header.NumberRows - 1
                        sngRFValueNow = CSng(oGrid.Value(intNowColX, intNowRowY))
                        If sngRFValueNow < 0 Then sngRFValueNow = 0
                        GridValueAcc(intNowColX, intNowRowY) = sngRFValueNow + GridValueAcc(intNowColX, intNowRowY)
                    Next intNowRowY
                Next intNowColX
                ofrmPrograssBar.GRMToolsPrograssBar.Value = r.FileOrder
                ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Processing " & CStr(r.FileOrder) & "/" & CStr(mdtRFFileInfo.Rows.Count) & " ..."
                System.Windows.Forms.Application.DoEvents()
            Next r
            Dim oGridResult As New MapWinGIS.Grid
            oGridResult = cGrid.CreateNewGrid(oGridBase, strResultGridFPN, MapWinGIS.GridDataType.UnknownDataType, -9999)
            For intNlayer As Integer = 0 To mdtRFFileInfo.Rows.Count - 1
                For intNowColX = 0 To oGridBase.Header.NumberCols - 1
                    For intNowRowY = 0 To oGridBase.Header.NumberRows - 1
                        oGridResult.Value(intNowColX, intNowRowY) = GridValueAcc(intNowColX, intNowRowY)
                    Next intNowRowY
                Next intNowColX
                ofrmPrograssBar.GRMToolsPrograssBar.Value = intNlayer + 1
                ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Processing " & CStr(intNlayer + 1) & "/" & CStr(mdtRFFileInfo.Rows.Count) & " ..."
                System.Windows.Forms.Application.DoEvents()

            Next intNlayer
            ofrmPrograssBar.Close()
            System.Windows.Forms.Application.DoEvents()
        Catch ex As Exception
            If ofrmPrograssBar.Visible = True Then
                ofrmPrograssBar.Close()
            End If
            Throw
        End Try
    End Sub

    Private Sub AccmulateAllGridFilesASCII()
        Dim ofrmPrograssBar As New fProgressBar
        ofrmPrograssBar.GRMToolsPrograssBar.Maximum = mdtRFFileInfo.Rows.Count
        ofrmPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
        ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Accumulate precipitation..."
        ofrmPrograssBar.Text = "Accumulate grid precipitation"
        ofrmPrograssBar.Show()
        System.Windows.Forms.Application.DoEvents()

        Dim aRow As TimeSeriesDS.RainfallFilesRow = CType(mdtRFFileInfo.Rows(0), TimeSeriesDS.RainfallFilesRow)
        Dim RefASCFile As New cTextFileReaderASC(Path.Combine(aRow.FilePath, aRow.FileName))
        Dim REFnCols As Integer = RefASCFile.Header.numberCols
        Dim REFnRows As Integer = RefASCFile.Header.numberRows
        Dim REFcellSize As Single = CSng(RefASCFile.Header.cellsize)
        Dim REFNullValue As Integer = CInt(RefASCFile.Header.nodataValue)
        Dim DataToSum(,) As Single
        ReDim DataToSum(REFnCols - 1, REFnRows - 1)
        DataToSum = InitialzeArray(DataToSum, REFnCols, REFnRows, REFNullValue)
        Dim nFile As Integer = 0

        Dim mASCfile As cTextFileReaderASC
        For Each r As TimeSeriesDS.RainfallFilesRow In mdtRFFileInfo
            Dim FPNsource As String
            FPNsource = Path.Combine(r.FilePath, r.FileName)
            mASCfile = New cTextFileReaderASC(FPNsource)
            If cTextFileReaderASC.CompareFiles(RefASCFile, mASCfile) = False Then
                MsgBox("Input file is different from first asc file.  ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                Exit Sub
            End If
            Dim nRow As Integer = 0
            For rowY As Integer = 0 To mASCfile.Header.numberRows - 1
                Dim ValuesInARow As String() = mASCfile.ValuesInOneRowFromTopLeft(nRow)
                For colX As Integer = 0 To mASCfile.Header.numberCols - 1
                    Dim currentRFmm As Single = mASCfile.ValueAtColumeXFormOneRow(colX, ValuesInARow)
                    If DataToSum(colX, rowY) = -9999 Then
                        If currentRFmm = -9999 Then
                            '과거가 null이고 현재도 null이면
                            DataToSum(colX, rowY) = -9999
                        Else
                            '과거가 null이고, 현재는 null이 아니면..
                            If currentRFmm < 0 Then currentRFmm = 0
                            DataToSum(colX, rowY) = currentRFmm
                        End If
                    Else
                        '과거가 null이 아니면.. 
                        If DataToSum(colX, rowY) < 0 Then DataToSum(colX, rowY) = 0
                        If currentRFmm < 0 Then currentRFmm = 0
                        DataToSum(colX, rowY) = DataToSum(colX, rowY) + currentRFmm
                    End If
                Next
                nRow += 1
            Next
            nFile += 1
            ofrmPrograssBar.GRMToolsPrograssBar.Value = nFile
            ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Processing " & CStr(nFile) & "/" & CStr(mdtRFFileInfo.Rows.Count) & " ..."
            System.Windows.Forms.Application.DoEvents()
        Next

        Dim FPNresult As String = Path.Combine(Trim(Me.txtDestinationFolderPathAcc.Text), Me.txtResultlGridFileNameAcc.Text.Trim + ".asc")
        Dim ArrayToPrint(REFnRows - 1) As String
        For nrY As Integer = 0 To REFnRows - 1
            Dim aLine As String = Format(DataToSum(0, nrY), "#0.##")
            If REFnCols > 1 Then
                For ncX As Integer = 1 To REFnCols - 1
                    aLine = aLine + " " + Format(DataToSum(ncX, nrY), "#0.##")
                Next
            End If
            ArrayToPrint(nrY) = aLine
        Next

        Call cTextFile.MakeASCTextFile(FPNresult,
                                                        RefASCFile.Header.numberCols, RefASCFile.Header.numberRows,
                                                        RefASCFile.Header.xllcorner, RefASCFile.Header.yllcorner,
                                                        RefASCFile.Header.cellsize, CStr(RefASCFile.Header.nodataValue),
                                                        ArrayToPrint)
        ofrmPrograssBar.Close()
        System.Windows.Forms.Application.DoEvents()
    End Sub



    Private Function CheckErrResizeTimeScale() As Boolean
        If Me.txtSourceTimeInterval.Text = "" OrElse
                Me.txtResultTimeInterval.Text = "" Then
            MsgBox("err", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Return False
        End If

        Return True
    End Function

    Private Sub rbAccAllFiles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAccAllFiles.CheckedChanged
        Me.txtResultlGridFileNameAcc.Enabled = rbAccAllFiles.Checked
        Me.gbSourceData.Enabled = rbAggregate.Checked
        Me.gbResultFile.Enabled = rbAggregate.Checked
        Me.labAgg.Enabled = rbAggregate.Checked
    End Sub

    Private Sub rbRGD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbGTiff.CheckedChanged
        If Me.rbGTiff.Checked Then
            mrfFilePattern = cFile.FilePattern.TIFFILE
        Else
            mrfFilePattern = cFile.FilePattern.ASCFILE
        End If

    End Sub

    Private Sub UpdateRFfileListBox()
        If txtFolderPathSource.Text.Trim <> "" AndAlso IO.Directory.Exists(txtFolderPathSource.Text.Trim) Then
            Me.lstRFfiles.DataSource = cFile.GetFileList(txtFolderPathSource.Text.Trim, mrfFilePattern)
        Else
            Me.lstRFfiles.DataSource = Nothing
        End If
    End Sub

    Private Sub txtFolderPathSource_TextChanged(sender As Object, e As EventArgs) Handles txtFolderPathSource.TextChanged
        UpdateRFfileListBox()
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

    Private Sub rbmmPh_CheckedChanged(sender As Object, e As EventArgs) Handles rbmmPh.CheckedChanged

    End Sub
End Class