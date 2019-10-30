Option Strict Off

Imports System.Text

''' <summary>
''' 지점 강우자료를 이용해서 격자형 강우레이어 생성
''' ''' </summary>
''' <remarks> 데이터 소스틑 csv, TS mdb를 사용한다. 
''' tsmdb는 관측소별로 각 시계열 텍스트 파일을 생성하고, 
''' 이를 이용한다. </remarks>
Public Class frmGRMToolsMakeRainfallGridLayer

    Private mbIsAllDataNormal As Boolean

    Private mstrBaseExtendGridLayerName As String
    Private mlEffectiveGridValueForTP As List(Of Integer)

    'Private mbUpdateDGV As Boolean
    Private WithEvents mofrmPrograssBar As fProgressBar
    Private WithEvents mRFprocess As cGRMToolsMakeRFGridLayersWithPointTS
    Private mdtRFseries As DataTable

    Private Sub frmGRMToolsMakeRainfallGrids_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cMap.mwAppMain Is Nothing Then
            MsgBox("Open workspace and map first!!!!       ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If
        'mTargetMap = mGMApp.Workspace.Maps(1)
        mbIsAllDataNormal = True
        Me.txtRFStartingTimeStep.Enabled = False
        Me.txtIDPowerCoeff.Text = "2"
        Call SetDataGridViewForm()
        Call InitializeComboBox()
    End Sub


    Sub ReadGridLayerAndSetTPcondition()
        Dim intID As Integer
        Dim dblGridValue As Double
        Dim intValueCount As Integer
        Dim baseGridName As String
        Dim lstBaseGridValueList As New List(Of Integer)
        baseGridName = Me.cmbBaseGridLayer.Text

        Dim baseGrid As New MapWinGIS.Grid
        baseGrid = cMap.GetMWGridWithLayerName(cMap.mwAppMain, baseGridName)
        lstBaseGridValueList = cMap.GetValueListIntegerInGridLayer(baseGrid)
        lstBaseGridValueList.Sort()
        intValueCount = lstBaseGridValueList.Count

        Dim intNRow As Integer = 0
        Dim nGage As Integer = 0

        mlEffectiveGridValueForTP = New List(Of Integer)
        For intID = 0 To intValueCount - 1 'oGCDValueRenderer.ValueCount
            dblGridValue = lstBaseGridValueList.Item(intID) 'oGridValueRenderer.Value(intID)
            If dblGridValue = -9999 Or dblGridValue <= 0 Then
                'mintCountRFGroup = mintCountRFGroup - 1
            Else
                intNRow += 1
                nGage += 1
                mlEffectiveGridValueForTP.Add(dblGridValue)
            End If
        Next intID

        mRFprocess.mRainGageCount = nGage
        Dim vatFPN As String = Path.Combine( _
            Path.GetDirectoryName(baseGrid.Filename), _
            Path.GetFileNameWithoutExtension(baseGrid.Filename) & ".vat")

        If File.Exists(vatFPN) Then
            Dim values As SortedList(Of Integer, String) = cTextFile.ReadVatFile(vatFPN)
            For intID = 0 To mRFprocess.mRainGageCount - 1
                Dim nowInfo As New cGRMToolsRFDataInfo
                nowInfo.GridValue = values.Keys(intID)
                nowInfo.GageName = values(values.Keys(intID))
                mRFprocess.mRFDataInfo.Add(nowInfo)
            Next
        Else
            For intID = 0 To mRFprocess.mRainGageCount - 1
                Dim nowInfo As New cGRMToolsRFDataInfo
                nowInfo.GridValue = CInt(mlEffectiveGridValueForTP.Item(intID))
                nowInfo.GageName = CInt(mlEffectiveGridValueForTP.Item(intID))
                mRFprocess.mRFDataInfo.Add(nowInfo)
            Next
        End If
    End Sub


    Sub SetDataGridViewForm()

        With Me.dgvMatchRainGageAndData
            .ReadOnly = False
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AllowUserToDeleteRows = False
            .AllowUserToAddRows = False
            .RowHeadersVisible = True

            .RowHeadersWidth = 10
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

            .AllowUserToResizeColumns = True
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter '.MiddleLeft
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .AutoResizeRows()

            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .MultiSelect = False
            '.Columns(0).DefaultCellStyle.BackColor = System.Drawing.SystemColors.InactiveBorder
            '.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            '.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            ''.Columns(0).ReadOnly = True

            '.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            '.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            '.Columns(1).Width = dgvMatchRainGageAndData.Width - .Columns(0).Width
            '.DataSource = mdtRFseries
        End With


        'Me.dgvMatchRainGageAndData.Update()
        'Me.dgvMatchRainGageAndData.Refresh()

    End Sub


    Private Sub InitializeComboBox()
        Dim lyrLayer As MapWindow.Interfaces.Layer
        Me.cmbBaseGridLayer.Items.Clear()
        For Each lyrLayer In cMap.mwAppMain.Layers
            Select Case lyrLayer.LayerType
                Case MapWindow.Interfaces.eLayerType.Grid, MapWindow.Interfaces.eLayerType.Image
                    Me.cmbBaseGridLayer.Items.Add(lyrLayer.Name)
                Case MapWindow.Interfaces.eLayerType.PointShapefile 'gmLayerType.gmFeatureLayer
                    Me.cmbRainfallGageLayer.Items.Add(lyrLayer.Name)
                    'Case gmLayerType.gmDemLayer '.gmGcdLayer
                    '    Me.cmbBaseGridLayer.Items.Add(lyrLayer.Name)
                Case Else
            End Select
        Next
    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        MyBase.Close()
    End Sub

    Private Sub frmGRMToolsMakeRainfallGrids_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub


    Private Sub btMakeRainfallGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMakeRainfallGrid.Click
        mbIsAllDataNormal = True
        If Me.dgvMatchRainGageAndData.RowCount < 1 Then
            MsgBox("Process setting table is not updated!!!    ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If
        For r As Integer = 0 To Me.dgvMatchRainGageAndData.RowCount - 1
            For c As Integer = 0 To Me.dgvMatchRainGageAndData.ColumnCount - 1
                If mdtRFseries.Rows(r).IsNull(c) Then
                    MsgBox("Process setting is invalid!!! Fill process setting table.   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                    Exit Sub
                End If
            Next
        Next
        If CStr(Me.dgvMatchRainGageAndData.Rows(0).Cells(1).Value) = "" Then
            MsgBox("Process setting is invalid!!! Fill process setting table.   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If
        If Me.rbUsingIDW.Checked = True Then
            If Trim(Me.txtIDPowerCoeff.Text) = "" Then
                MsgBox(" Inverse distance power coefficient is not entered.    ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                Exit Sub
            Else
                If IsNumeric(Me.txtIDPowerCoeff.Text) = True And CInt(Me.txtIDPowerCoeff.Text) > 0 Then
                    mRFprocess.mIDPowerCoeff = CInt(Val(Me.txtIDPowerCoeff.Text))
                Else
                    MsgBox(" Inverse distance power coefficient is invalid.    ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                    Exit Sub
                End If
            End If
        End If

        If Trim(Me.txtDestinationFolderPath.Text) = "" Then
            MsgBox("Result folder is not selected.    ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        Else
            mRFprocess.mDestinationPath = Trim(Me.txtDestinationFolderPath.Text)
        End If

        If Directory.Exists(mRFprocess.mDestinationPath) = False Then
            MsgBox("Destination folder is not exist!!!  ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If
        mRFprocess.mOutputPrefix = Trim(Me.txtRainfallGridFilePrefix.Text)
        mRFprocess.mTimeIsSet = False
        If Me.chkSetStartingTime.Checked = True Then
            If IsNumeric(Me.txtRFStartingTimeStep.Text) = True AndAlso CInt(Me.txtRFStartingTimeStep.Text) > 0 Then
                mRFprocess.mstrStartingTime = Me.dtpResultRFStarting.Text
                mRFprocess.mOutputTimeStep = CInt(Me.txtRFStartingTimeStep.Text)
                mRFprocess.mTimeIsSet = True
            Else
                mRFprocess.mstrStartingTime = ""
                mRFprocess.mOutputTimeStep = 0

                MsgBox("Output rainfall time step is invalid.       ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                Exit Sub
            End If
        End If

        If Me.rbUseTSDB.Checked = True Then
            If Me.txtObservedTSDBPathName.Text = "" Then
                MsgBox("Timeseries database is invalid!!!    ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
                Exit Sub
            Else
                Call ReadTSDBAndMakeTxtFile(mRFprocess.mDestinationPath)
                If mbIsAllDataNormal = False Then Exit Sub
                Call TestRainfallValueInTxtFileSetTSArrayList()
                If mbIsAllDataNormal = False Then Exit Sub
            End If
        End If

        If mbIsAllDataNormal = False Then Exit Sub

        mofrmPrograssBar = New fProgressBar

        mofrmPrograssBar.GRMToolsPrograssBar.Maximum = mRFprocess.mRFRecordCount
        mofrmPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
        mofrmPrograssBar.labGRMToolsPrograssBar.Text = "Making 0/" & CStr(mRFprocess.mRFRecordCount) & " rainfall grid layer..."
        mofrmPrograssBar.Text = "Making rainfall grid layer"
        mofrmPrograssBar.Show()

        Try
            mRFprocess.mGridBase = cMap.GetMWGridWithLayerName(cMap.mwAppMain, mstrBaseExtendGridLayerName)
            If rbUsingTPGridLayer.Checked = True Then
                mRFprocess.MakeRFGridLayerWithTPGridLayer()
            End If

            If rbUsingIDW.Checked = True Then
                mRFprocess.mGagePointLayerShapeFile = cMap.GetMWShapeFileWithLayerName(cMap.mwAppMain, mRFprocess.mstrRainfallGageLayerName)
                If mRFprocess.mGagePointLayerShapeFile Is Nothing Then Exit Sub
                '여기서 rs에 필드 추가
                mRFprocess.mFieldNameRF = cMap.GetNewFieldNameToAddToShapeFile(mRFprocess.mGagePointLayerShapeFile, "tempRF")
                If mRFprocess.mFieldNameRF = "-1" Then Exit Sub
                mRFprocess.mGagePointLayerShapeFile.StartEditingShapes()
                mRFprocess.mGagePointLayerShapeFile.EditAddField(mRFprocess.mFieldNameRF, MapWinGIS.FieldType.DOUBLE_FIELD, 0, 15)
                mRFprocess.mGagePointLayerShapeFile.Save()
                mRFprocess.mGagePointLayerShapeFile.StopEditingShapes(True, True)
                Dim idxField As Integer = cMap.GetFieldIndexByName(mRFprocess.mGagePointLayerShapeFile, mRFprocess.mFieldNameGage)
                mRFprocess.mGSSGageNameFieldType = mRFprocess.mGagePointLayerShapeFile.Field(idxField).Type
                mRFprocess.MakeRFGridLayerWithIDW() 'MakeRFGridLayerWithIDWInner()
            End If

            If rbUsingKrigging.Checked = True Then
                mRFprocess.mGagePointLayerShapeFile = cMap.GetMWShapeFileWithLayerName(cMap.mwAppMain, mRFprocess.mstrRainfallGageLayerName)
                If mRFprocess.mGagePointLayerShapeFile Is Nothing Then Exit Sub
                Call mRFprocess.CreateGagePositionInfoFile()
                'Call mRFprocess.MakeRFGridLayerWithKrigging()
            End If


        Catch ex As Exception
            MsgBox("An error was occured. Please update user's settings and try again.  ", _
                   MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
        End Try
    End Sub


    Private Sub ReadTSDBAndMakeTxtFile(ByVal strPathToMakeFile As String)
        Try
            Dim intRowCount As Integer = Me.dgvMatchRainGageAndData.Rows.Count
            Dim intN As Integer

            For intN = 0 To intRowCount - 1
                mRFprocess.mRFDataInfo(intN).TSID = LTrim(RTrim(Me.dgvMatchRainGageAndData.Rows(intN).Cells(1).Value.ToString))
                mRFprocess.mRFDataInfo(intN).GageName = Trim(Me.dgvMatchRainGageAndData.Rows(intN).Cells(0).Value)
            Next

            Dim strCNNString_ObTSDB As String

            strCNNString_ObTSDB = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=" + LTrim(RTrim(Me.txtObservedTSDBPathName.Text))

            Dim dsTSfromTSDB() As System.Data.DataSet '("TSData")
            Dim daTSFromTSDB() As OleDbDataAdapter '(strSelectString, strCnnString)
            ReDim dsTSfromTSDB(intRowCount - 1)
            ReDim daTSFromTSDB(intRowCount - 1)

            Dim strSelectString As String
            Dim intNRec As Integer
            Dim strStartingTime As String
            Dim strEndingTime As String
            Dim intNTable As Integer
            'Dim intFNum As Integer
            'Dim strFName As String
            Dim sngRainfallValue As Single

            '각 tsid 마다 하나씩의 dataset을 만들고..
            intNRec = 0
            intNTable = 0

            'Me.dtpStartingTime.CustomFormat = "yyyyMMddHHmm" ' = DateTimePickerFormat.Custom
            'Me.dtpEndingTime.CustomFormat = "yyyyMMddHHmm"
            'strStartingTime = Me.dtpStartingTime.Text
            strStartingTime = Replace(Me.dtpStartingTime.Text, "/", "")
            strStartingTime = Replace(strStartingTime, " ", "")
            strStartingTime = Replace(strStartingTime, ":", "")


            strEndingTime = Replace(Me.dtpEndingTime.Text, "/", "")
            strEndingTime = Replace(strEndingTime, " ", "")
            strEndingTime = Replace(strEndingTime, ":", "")



            For intNTable = 0 To intRowCount - 1

                strSelectString = "Select * from TSData where TSID = " & mRFprocess.mRFDataInfo(intNTable).TSID _
                                & " and DateTime >= '" & strStartingTime & "' and DateTime <= '" & strEndingTime & "' order by DateTime asc" '여기서 -1 하는 것은 TSDB의 시간과 자리수가 다를 경우 처리를 위해서..
                dsTSfromTSDB(intNTable) = New System.Data.DataSet("TSData")
                daTSFromTSDB(intNTable) = New OleDbDataAdapter(strSelectString, strCNNString_ObTSDB)

                daTSFromTSDB(intNTable).Fill(dsTSfromTSDB(intNTable), "TSData") '여기서 obs

                If dsTSfromTSDB(intNTable).Tables(0).Rows.Count = 0 Then
                    MsgBox("There is no observed data selected!!!   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)

                    mbIsAllDataNormal = False
                    Exit Sub
                End If

                mRFprocess.mRFDataInfo(intNTable).TxtPathName = strPathToMakeFile & "\GridValue_" & CStr(mRFprocess.mRFDataInfo(intNTable).GageName) & ".txt"
                If File.Exists(mRFprocess.mRFDataInfo(intNTable).TxtPathName) Then
                    File.Delete(mRFprocess.mRFDataInfo(intNTable).TxtPathName)
                End If

                For intNRec = 0 To dsTSfromTSDB(intNTable).Tables(0).Rows.Count - 1
                    With dsTSfromTSDB(intNTable).Tables(0).Rows(intNRec)
                        sngRainfallValue = CSng(.Item("value").ToString)
                        If sngRainfallValue = -9999 Then
                            mRFprocess.mRFDataInfo(intNTable).MissingCount += 1
                            sngRainfallValue = 0   '결측치는 0으로 입력함.
                        End If
                        IO.File.AppendAllText(mRFprocess.mRFDataInfo(intNTable).TxtPathName, CStr(sngRainfallValue) & vbCrLf, Encoding.Default)
                    End With
                Next

            Next

        Catch ex As Exception
            MsgBox(ex.ToString, , cGRM.BuildInfo.ProductName)
            mbIsAllDataNormal = False
        End Try

    End Sub

    Private Sub TestRainfallValueInTxtFileSetTSArrayList()
        Dim intN As Integer
        Dim intRowCountInFile_BAK As Integer
        Dim intRowCount As Integer
        Dim intFNum As Integer
        Try
            For intN = 0 To mRFprocess.mRainGageCount - 1
                intFNum = FreeFile()
                FileOpen(intFNum, mRFprocess.mRFDataInfo(intN).TxtPathName, OpenMode.Input, OpenAccess.Default, OpenShare.Shared)
                intRowCount = 0
                Dim strL As String

                While Not EOF(intFNum)
                    strL = Trim(LineInput(intFNum))
                    If Len(strL) = 0 Then '하나라도 빈열이 들어오면 종료한다.
                        Exit While
                    End If

                    mRFprocess.mRFDataInfo(intN).rfValue.Add(strL)
                    intRowCount += 1
                End While
                If intN > 0 Then
                    If intRowCount <> intRowCountInFile_BAK Then
                        mbIsAllDataNormal = False
                        MsgBox("Different number of rainfall data is selected for each gauge!!!     ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
                        Exit Sub
                    End If
                End If
                intRowCountInFile_BAK = intRowCount
                FileClose(intFNum)
            Next
            mRFprocess.mRFRecordCount = intRowCountInFile_BAK
            mbIsAllDataNormal = True
        Catch ex As Exception
            MsgBox(ex.ToString, , cGRM.BuildInfo.ProductName)
            mbIsAllDataNormal = False
        End Try
    End Sub


    Private Sub btOpenDestinationFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOpenDestinationFolder.Click
        Dim fb As New FolderBrowserDialog
        If fb.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtDestinationFolderPath.Text = fb.SelectedPath
        End If
    End Sub



    Private Sub dgvMatchGridValueToTextFile_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMatchRainGageAndData.CellDoubleClick
        'Dim strPathName As String = ""
        'If Me.rbUseTextFile.Checked = True Then
        '    With Me.dlgFileOpenMakeGridRainfall
        '        .Title = "Select rainfall text file"
        '        Me.dlgFileOpenMakeGridRainfall.RestoreDirectory = True
        '        .FileName = ""
        '        .Filter = "Text files (*.txt)|*.txt"
        '    End With
        '    If Me.dlgFileOpenMakeGridRainfall.ShowDialog() = DialogResult.OK Then
        '        strPathName = dlgFileOpenMakeGridRainfall.FileName
        '    End If
        '    Dim intSelectedRow As Integer
        '    If strPathName <> "" Then
        '        intSelectedRow = Me.dgvMatchRainGageAndData.SelectedRows(0).Index
        '        Me.dgvMatchRainGageAndData.SelectedRows.Item(0).Cells(1).Value = strPathName
        '        Me.dgvMatchRainGageAndData.Rows(intSelectedRow).Cells(0).Selected = True
        '    Else
        '    End If
        'End If
        If Me.rbUseTSDB.Checked = True Then
            Dim ofrmSearchTSDB As New fGRMToolsSearchTSDB
            MyBase.Cursor = Cursors.WaitCursor
            ofrmSearchTSDB.SearchTSDB_Start(Me.txtObservedTSDBPathName.Text)
            If ofrmSearchTSDB.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then Exit Sub
            Dim obst As cSetTSData.TimeSeriesInfoInTSDB
            obst = ofrmSearchTSDB.obst
            'Dim currentTSID As Integer = obst.TSID
            'Call ofrmSearchTSDB.SearchTSDB_Start(Me.txtObservedTSDBPathName.Text) ', Me.dtpStartingTime.Text, Me.dtpEndingTime.Text)
            MyBase.Cursor = Cursors.Default
            Me.dgvMatchRainGageAndData.CurrentRow.Cells(1).Value = obst.TSID 'cProject.Current.gstObTSfromDB.TSID '& ", HydroCode = " & cProject.Current.gstObTSfromDB.HydroCode & ", Name = " & cProject.Current.gstObTSfromDB.StationName
        End If
    End Sub



    Private Sub rbUseTxtFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbUseCSVTxtFile.CheckedChanged
        Call SetSourceDataOptionUI()
    End Sub


    Private Sub btSelectTSDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSelectTSDB.Click
        Dim dlg As New OpenFileDialog
        With dlg
            .Title = "Open rainfall flow database"
            If IO.Directory.Exists("C:\HyGIS\Database\TimeSeries") Then
                .InitialDirectory = "C:\HyGIS\Database\TimeSeries"
            Else
                .InitialDirectory = My.Application.Info.DirectoryPath
            End If
            .Filter = "HyGIS TimeSeries MDB(*.MDB) | *.MDB"
            .ShowDialog()
        End With
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            If dlg.FileName <> "" Then
                Me.txtObservedTSDBPathName.Text = dlg.FileName
            End If
        End If
    End Sub



    Private Sub rbUsingTPGridLayer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbUsingTPGridLayer.CheckedChanged

        Call SetFormUI()


    End Sub

    Private Sub rbUsingIDW_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbUsingIDW.CheckedChanged
        Call SetFormUI()
    End Sub

    Private Sub rbUsingKrigging_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbUsingKrigging.CheckedChanged
        Call SetFormUI()
    End Sub

    Sub SetFormUI()
        Me.cmbRainfallGageLayer.Enabled = Not rbUsingTPGridLayer.Checked
        Me.cmbRainfallGageNameField.Enabled = Not rbUsingTPGridLayer.Checked
        If Me.rbUsingIDW.Checked = True Then
            Me.txtIDPowerCoeff.Enabled = True
        Else
            Me.txtIDPowerCoeff.Enabled = False
        End If
    End Sub


    Private Sub cmbRainfallGageLayer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRainfallGageLayer.SelectedIndexChanged
        Try
            If Me.cmbRainfallGageLayer.Text <> "" Then
                Me.cmbRainfallGageNameField.Items.Clear()
                If Trim(Me.cmbRainfallGageLayer.Text) <> "" Then
                    Dim GageShapeFile As MapWinGIS.Shapefile = cMap.GetMWShapeFileWithLayerName(cMap.mwAppMain, Me.cmbRainfallGageLayer.Text.Trim)
                    For nf As Integer = 0 To GageShapeFile.NumFields - 1
                        Me.cmbRainfallGageNameField.Items.Add(GageShapeFile.Field(nf).Name)
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, , cGRM.BuildInfo.ProductName)
        End Try
    End Sub


    Private Sub SetGageNameWithInputPointGageName()
        Try
            Dim GageShapeFile As MapWinGIS.Shapefile = cMap.GetMWShapeFileWithLayerName(cMap.mwAppMain, Me.cmbRainfallGageLayer.Text.Trim)
            Dim indexFieldGageName As Integer = cMap.GetFieldIndexByName(GageShapeFile, mRFprocess.mFieldNameGage)
            mRFprocess.mRainGageCount = GageShapeFile.NumShapes
            For ns As Integer = 0 To GageShapeFile.NumShapes - 1
                Dim nowInfo As New cGRMToolsRFDataInfo
                nowInfo.GageName = CStr(GageShapeFile.CellValue(indexFieldGageName, ns))
                mRFprocess.mRFDataInfo.Add(nowInfo)
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, , cGRM.BuildInfo.ProductName)
        End Try
    End Sub

    Private Sub chkSetStartingTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSetStartingTime.CheckedChanged
        If Me.chkSetStartingTime.Checked = True Then
            Me.dtpResultRFStarting.Enabled = True
            Me.txtRFStartingTimeStep.Enabled = True
        Else
            Me.dtpResultRFStarting.Enabled = False
            Me.txtRFStartingTimeStep.Enabled = False
        End If
    End Sub

    Private Sub btViewCSVTextFileFormat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewCSVTextFileFormat.Click
        Dim ofrmTextBox As New fTextBox
        Dim strOut As String

        'If rbUsingTPGridLayer.Checked Then
        '    strOut = "GridValue1,GridValue2,GridValue3,...." + vbCrLf
        'Else
        strOut = "GageName1,GageName2,GageName3,...." + vbCrLf
        'End If


        strOut = strOut + "Rainfall11,Rainfall2,Rainfall13,..." + vbCrLf
        strOut = strOut + "Rainfall21,Rainfal22,Rainfall23,..." + vbCrLf
        strOut = strOut + "Rainfall31,Rainfal32,Rainfall33,..." + vbCrLf
        strOut = strOut + "    .     ,     .   ,     .    ,..." + vbCrLf
        strOut = strOut + "    .     ,     .   ,     .    ,..." + vbCrLf
        strOut = strOut + "    .     ,     .   ,     .    ,..." + vbCrLf + vbCrLf

        strOut = strOut + "First line contains gauge name(or raster layer cell value) separated with comma(,)." + vbCrLf
        strOut = strOut + "For Thiessen polygon method, if you have not VAT file that matches grid value to gauge name, " + vbCrLf
        strOut = strOut + "    only raster cell value is available for gauge name." + vbCrLf
        strOut = strOut + "Write rainfall data for each gage from second line." + vbCrLf
        strOut = strOut + "Rainfall data number for each gage must be equal."

        ofrmTextBox.txtTextBox.Text = strOut
        ofrmTextBox.Text = "CSV file format"
        ofrmTextBox.txtTextBox.ReadOnly = True
        ofrmTextBox.txtTextBox.Font = System.Drawing.SystemFonts.DefaultFont
        ofrmTextBox.txtTextBox.Select(Len(strOut), 0)
        ofrmTextBox.Show()

    End Sub


    Private Sub btApplyProcessSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btApplyProcessSetting.Click

        mbIsAllDataNormal = True
        mdtRFseries = Nothing
        'Me.dgvMatchRainGageAndData.Rows.Clear()
        Me.dgvMatchRainGageAndData.Columns.Clear()
        Me.dgvMatchRainGageAndData.ReadOnly = True

        If mRFprocess IsNot Nothing Then
            mRFprocess = Nothing
        End If
        mRFprocess = New cGRMToolsMakeRFGridLayersWithPointTS

        If rbUseTSDB.Checked AndAlso IO.File.Exists(Trim(Me.txtObservedTSDBPathName.Text)) = False Then
            MsgBox("Rainfall database file is not exist!!!     ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            mbIsAllDataNormal = False
            Exit Sub
        End If

        If Me.cmbBaseGridLayer.Text = "" Then
            MsgBox("Base grid layer is not selected!!!     ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            mbIsAllDataNormal = False
            Exit Sub
        Else
            mstrBaseExtendGridLayerName = Trim(Me.cmbBaseGridLayer.Text)
        End If

        If Me.rbUsingTPGridLayer.Checked = True Then
            Call ReadGridLayerAndSetTPcondition()
        Else
            If Trim(Me.cmbRainfallGageLayer.Text) = "" Then
                MsgBox("Rainfall gauge layer is invalid.    ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                Exit Sub
            Else
                mRFprocess.mstrRainfallGageLayerName = Trim(Me.cmbRainfallGageLayer.Text)
            End If

            If Trim(Me.cmbRainfallGageNameField.Text) = "" Then
                MsgBox("Rainfall gage name field is invalid.    ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                Exit Sub
            Else
                mRFprocess.mFieldNameGage = Trim(Me.cmbRainfallGageNameField.Text)
            End If
            Call SetGageNameWithInputPointGageName()
        End If
        'mbUpdateDGV = chkUpdateDGV.Checked

        '여기서 강우 arraylis 초기화 함
        If Me.rbUseCSVTxtFile.Checked = True Then
            Call ReadAndSetGegeTimeSeriesFromCSVTextfile()
            If mbIsAllDataNormal = False Then Exit Sub
        End If
        Call UpdateDgvWithRFInfo()
        If mRFprocess.mStopProgress = True Then Exit Sub

        MsgBox("Process setup is completed.   ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
    End Sub



    Sub UpdateDgvWithRFInfo()
        mRFprocess.mStopProgress = False
        mdtRFseries = Nothing
        mdtRFseries = New DataTable
        Me.dgvMatchRainGageAndData.DataSource = mdtRFseries
        mdtRFseries.Columns.Add()

        If Me.rbUsingTPGridLayer.Checked = True Then
            mdtRFseries.Columns(0).ColumnName = "Grid value"
        Else
            mdtRFseries.Columns(0).ColumnName = "Gage name"
        End If

        If Me.rbUseTSDB.Checked = True Then
            mdtRFseries.Columns.Add()
            mdtRFseries.Columns(1).ColumnName = "TSID from Timeseries Database"

            mdtRFseries.BeginLoadData()
            For intR As Integer = 0 To mRFprocess.mRainGageCount - 1
                Dim nr As Data.DataRow = mdtRFseries.NewRow
                nr.Item(mdtRFseries.Columns(0).ColumnName) = mRFprocess.mRFDataInfo(intR).GageName
                mRFprocess.mRFDataInfo(intR).rfValue = New ArrayList
                mdtRFseries.Rows.Add(nr)
            Next intR
            mdtRFseries.EndLoadData()
        Else
            For intC As Integer = 1 To mRFprocess.mRainGageCount
                With mdtRFseries
                    .Columns.Add()
                    .Columns(intC).ColumnName = mRFprocess.mRFDataInfo(intC - 1).GageName
                End With
            Next intC
            cGRMToolsMakeRFGridLayersWithPointTS.AddRFdataToDataTable(mRFprocess.mRFDataInfo, mRFprocess.mRainGageCount, mdtRFseries)
        End If

    End Sub

    'Private Sub SetDgvForNotCSVRFdata()

    '    Dim intR As Integer

    '    With Me.dgvMatchRainGageAndData
    '        '.ColumnCount = 2
    '        'If Me.rbUsingTPGridLayer.Checked = True Then
    '        '    .Columns(0).HeaderText = "Grid value"
    '        'Else
    '        '    .Columns(0).HeaderText = "Gage name"
    '        'End If
    '        .Columns(1).ReadOnly = False
    '        .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    '        .SelectionMode = DataGridViewSelectionMode.FullRowSelect '.CellSelect

    '        If Me.rbUseTSDB.Checked = True Then
    '            .Columns(1).HeaderText = "TSID from Timeseries Database"
    '        End If

    '        For intR = 0 To mRFprocess.mRainGageCount - 1
    '            .Rows.Add()
    '            .Rows(intR).Cells(0).Value = mRFprocess.mRFDataInfo(intR).GageName
    '            mRFprocess.mRFDataInfo(intR).rfValue = New ArrayList
    '        Next intR
    '    End With
    '    dgvMatchRainGageAndData.Columns(1).Width = dgvMatchRainGageAndData.Width - dgvMatchRainGageAndData.Columns(0).Width
    '    Me.dgvMatchRainGageAndData.Update()
    '    Me.dgvMatchRainGageAndData.Refresh()

    'End Sub




    Sub ReadAndSetGegeTimeSeriesFromCSVTextfile()

        Try
            Dim strInFNPgageTS As String = Trim(Me.txtCSVRFDataFPN.Text)
            If strInFNPgageTS = "" Then
                MsgBox("Gage time series text file is not selected.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
                mbIsAllDataNormal = False
                Exit Sub
            End If

            If File.Exists(strInFNPgageTS) = False Then
                MsgBox("Selected gage time series file is not existed.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
                mbIsAllDataNormal = False
                Exit Sub
            End If

            Dim intL As Integer = 0
            Dim nGageCount As Integer = 0
            Dim gaugeNames(mRFprocess.mRainGageCount - 1) As String
            Dim bGageNameIS As Boolean

            Using oTextReader As New FileIO.TextFieldParser(strInFNPgageTS, Encoding.Default)
                oTextReader.TextFieldType = FileIO.FieldType.Delimited
                oTextReader.SetDelimiters(",")
                oTextReader.TrimWhiteSpace = True
                Dim TextIncurrentRow As String()
                While Not oTextReader.EndOfData
                    TextIncurrentRow = oTextReader.ReadFields
                    For Each ele As String In TextIncurrentRow
                        If Trim(TextIncurrentRow(0)).ToString = "" Then
                            MsgBox(String.Format("{0} line has empty value. Exit reading CSV file process", intL + 1))
                            Exit While
                        End If
                    Next
                    If intL = 0 Then
                        nGageCount = TextIncurrentRow.Length
                        If nGageCount <> mRFprocess.mRainGageCount Then
                            '여기서 gage 개수와 입력된 시계열 개수 검증
                            MsgBox("Time series number is different with gage number.   ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                            mbIsAllDataNormal = False
                            Exit Sub
                        End If
                        gaugeNames = TextIncurrentRow
                        For nGage As Integer = 0 To nGageCount - 1
                            mRFprocess.mRFDataInfo(nGage).rfValue = New ArrayList
                        Next nGage
                    Else
                        For nG1 As Integer = 0 To nGageCount - 1
                            bGageNameIS = False
                            For nG2 As Integer = 0 To nGageCount - 1
                                If gaugeNames(nG1).ToString = mRFprocess.mRFDataInfo(nG2).GageName Then
                                    bGageNameIS = True
                                    mRFprocess.mRFDataInfo(nG2).rfValue.Add(TextIncurrentRow(nG1).ToString)
                                    Exit For
                                End If
                            Next nG2
                            If bGageNameIS = False Then
                                MsgBox("Gage name from rainfall data file is different with gauge position information(" + gaugeNames(nG1) + ").    ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                                mbIsAllDataNormal = False
                                Exit Sub
                            End If
                        Next nG1
                    End If
                    intL += 1
                End While
            End Using

            For intNGage As Integer = 0 To nGageCount - 1
                If mRFprocess.mRFDataInfo(intNGage).rfValue.Count = 0 Then
                    MsgBox("There is no rainfall record in (" + CStr(mRFprocess.mRFDataInfo(intNGage).GageName) + ").    ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                    mbIsAllDataNormal = False
                    Exit Sub
                End If
            Next intNGage
            mRFprocess.mRFRecordCount = mRFprocess.mRFDataInfo(0).rfValue.Count
        Catch ex As Exception
            mbIsAllDataNormal = False
        End Try
    End Sub

    Private Sub btLoadTimeSeriesTextFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLoadTimeSeriesTextFile.Click
        Dim dlg As New OpenFileDialog
        dlg.Filter = "CSV files (*.csv)|*.csv|txt files (*.txt)|*.txt"
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            If dlg.FileName <> "" Then
                Me.txtCSVRFDataFPN.Text = dlg.FileName
            End If
        End If
    End Sub


    Sub SetSourceDataOptionUI()
        If Me.rbUseTSDB.Checked = True Then
            Me.labStartingTime.ForeColor = System.Drawing.SystemColors.ControlText
            Me.labEndingTime.ForeColor = System.Drawing.SystemColors.ControlText
        Else
            Me.labStartingTime.ForeColor = System.Drawing.SystemColors.InactiveCaption
            Me.labEndingTime.ForeColor = System.Drawing.SystemColors.InactiveCaption
        End If

        Me.btViewCSVTextFileFormat.Enabled = rbUseCSVTxtFile.Checked
        Me.txtCSVRFDataFPN.Enabled = rbUseCSVTxtFile.Checked
        Me.btLoadTimeSeriesTextFile.Enabled = rbUseCSVTxtFile.Checked

        Me.btSelectTSDB.Enabled = rbUseTSDB.Checked
        Me.txtObservedTSDBPathName.Enabled = rbUseTSDB.Checked
        Me.dtpStartingTime.Enabled = rbUseTSDB.Checked
        Me.dtpEndingTime.Enabled = rbUseTSDB.Checked

    End Sub


    Private Sub mProcess_SimulationStep(ByVal sender As cGRMToolsMakeRFGridLayersWithPointTS, _
                                      ByVal nowProcess As Integer, _
                                      ByVal MaxProcess As Integer) Handles mRFprocess.SimulationStep
        If mofrmPrograssBar.InvokeRequired Then
            Dim d As New UpdateStatusAndProgressDelegate(AddressOf UpdateStatusAndProgress)
            mofrmPrograssBar.Invoke(d, nowProcess, MaxProcess)
        Else
            UpdateStatusAndProgress(nowProcess, MaxProcess)
        End If
    End Sub

    Private Delegate Sub UpdateStatusAndProgressDelegate(ByVal nowProcess As Integer, ByVal MaxProcess As Integer)

    Private Sub UpdateStatusAndProgress(ByVal nowProcess As Integer, ByVal MaxProcess As Integer)
        mofrmPrograssBar.GRMToolsPrograssBar.Value = nowProcess
        mofrmPrograssBar.labGRMToolsPrograssBar.Text = _
            "Making " & CStr(nowProcess) & "/" & CStr(MaxProcess) & " rainfall grid layer..."
    End Sub


    Private Sub mProcess_StopProcess(ByVal sender As fProgressBar) Handles mofrmPrograssBar.StopProcess
        mRFprocess.mStopProgress = True
    End Sub


    Private Sub mProcess_CompleteProcess(ByVal sender As cGRMToolsMakeRFGridLayersWithPointTS) _
                                        Handles mRFprocess.SimulationComplete
        If mofrmPrograssBar.InvokeRequired Then
            Dim d As New CloseProgressDelegate(AddressOf CompleteAndCloseProgress)
            mofrmPrograssBar.Invoke(d)
        Else
            CompleteAndCloseProgress()
        End If
    End Sub

    Private Delegate Sub CloseProgressDelegate()

    Private Sub CompleteAndCloseProgress()
        mRFprocess.mGagePointLayerShapeFile.StartEditingShapes()
        mRFprocess.mGagePointLayerShapeFile.EditDeleteField(cMap.GetFieldIndexByName(mRFprocess.mGagePointLayerShapeFile, mRFprocess.mFieldNameRF))
        mRFprocess.mGagePointLayerShapeFile.StopEditingShapes(True, True)
        mRFprocess.mGagePointLayerShapeFile.Save()
        MsgBox("Making " + CStr(mRFprocess.mRFRecordCount) + " rainfall grid layers completed!!!   ", _
               MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
        mofrmPrograssBar.Close()
    End Sub



    Private Sub mProcess_StopProcess(ByVal sender As cGRMToolsMakeRFGridLayersWithPointTS) _
                                    Handles mRFprocess.SimulationStop
        If mofrmPrograssBar.InvokeRequired Then
            Dim d As New StopProgressDelegate(AddressOf StopAndCloseProgress)
            mofrmPrograssBar.Invoke(d)
        Else
            StopAndCloseProgress()
        End If
    End Sub

    Private Delegate Sub StopProgressDelegate()


    Private Sub StopAndCloseProgress()
        MsgBox("Making rainfall grid layer is stopped!     ", _
                       MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
        mofrmPrograssBar.Close()
    End Sub


    Private Sub txtCSVRFDataFPN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCSVRFDataFPN.TextChanged

    End Sub
End Class
