'Option Strict Off

Public Class fGRMToolsGenerateRFfromSatelliteImage
    Private mdtRFFileInfo As New TimeSeriesDS.RainfallFilesDataTable
    Private mbSetupIsNormal As Boolean
    Private mRFinfoForSelectCell() As GridRFSummary
    Private mNAWTT10Value As Double
    Private mNAWTT50Value As Double
    Private mFilePattern As cFile.FilePattern

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


    Private Sub frmGRMToolsGenerateRFfromSatelliteImage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cMap.mwAppMain Is Nothing Then Return
        mFilePattern = cFile.FilePattern.TIFFILE
        Me.dgvRGDFileListToApply.AllowUserToAddRows = False
        Me.txtTSTepmK.Text = "235"
        Me.txtNAWTT50.Text = "0.9"
        Me.txtNAWTT10.Text = "4.5"
        Me.dgvRGDFileListToApply.DataSource = mdtRFFileInfo
        SetDataGridViewForm()
    End Sub

    Sub SetDataGridViewForm()

        With Me.dgvRGDFileListToApply
            .ReadOnly = True

            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AllowUserToDeleteRows = False
            .AllowUserToAddRows = False
            .RowHeadersVisible = False

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter '.MiddleLeft
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .AutoResizeRows()

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect '.CellSelect
            .MultiSelect = False

            .Columns(0).DefaultCellStyle.BackColor = System.Drawing.SystemColors.InactiveBorder
            .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(0).ReadOnly = True

            .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

    End Sub


    'Private Sub DrvlASCiiFiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim strDriveName As String
    '    strDriveName = cComTools.GetDriveName(Me.DrvlRGDFiles.Drive)
    '    Me.DirlRGDFiles.Path = strDriveName + "\"
    '    Me.filelRainfallRGDFiles.Path = Me.DirlRGDFiles.Path
    'End Sub


    'Private Sub DirlRGDFiles_Change(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Me.filelRainfallRGDFiles.Path = Me.DirlRGDFiles.Path
    'End Sub

    Private Sub btAddAllFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddAllFiles.Click
        Call AddFiles(False)
    End Sub


    Private Sub AddFiles(ByVal bSelectedFile As Boolean)
        Dim strFilePath As String = txtFolderPathSource.Text.Trim
        If IO.Directory.Exists(strFilePath) Then
            Dim obj As New cFile
            Dim items As String() = obj.GetFilesAndCheckDuplication(lstRFfiles, bSelectedFile, strFilePath, mdtRFFileInfo, "FileName", "FilePath")

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
        mdtRFFileInfo.Clear()
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



    Private Sub btStartRFGeneration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStartRFGeneration.Click
        If Trim(Me.txtDestinationFolderPath.Text) = "" Then
            MsgBox("Destination folder is invalid!     ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If

        If rbNAWT.Checked = True Then
            If Trim(Me.txtTSTepmK.Text) = "" Or Trim(Me.txtNAWTT50.Text) = "" Or Trim(Me.txtNAWTT10.Text) = "" Or
               IsNumeric(Me.txtTSTepmK.Text) = False Or IsNumeric(Me.txtNAWTT50.Text) = False Or IsNumeric(Me.txtNAWTT10.Text) = False Then
                MsgBox("NAWT pararmeters are invalid!     ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
                Exit Sub
            End If
        End If

        ProcessManager()
        MsgBox("Generating precipiation data is completed.    ", MsgBoxStyle.Exclamation, cGRM.BuildInfo.ProductName)
    End Sub

    Private Sub ProcessManager()
        Dim ofrmPrograssBar As New fProgressBar

        ofrmPrograssBar.GRMToolsPrograssBar.Maximum = mdtRFFileInfo.Rows.Count
        ofrmPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
        ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Generate 0/" & CStr(mdtRFFileInfo.Rows.Count) & "files..."
        ofrmPrograssBar.Text = "Generate precipitation"
        ofrmPrograssBar.Show()
        System.Windows.Forms.Application.DoEvents()

        Dim strPathName As String = Me.txtDestinationFolderPath.Text
        Dim strPrefix As String = Trim(Me.txtResultFilePrefix.Text)
        Dim strSuffix As String = Trim(Me.txtResultFileSuffix.Text)

        Dim strFPNSourceGrid As String = ""
        Dim strFPNResultGrid As String = ""

        If rbNAWT.Checked = True Then
            Dim sngTSTemperature_K As Single = CSng(Me.txtTSTepmK.Text)
            Dim sngRFT10_mm As Single = CSng(Me.txtNAWTT10.Text)
            Dim sngRFT50_mm As Single = CSng(Me.txtNAWTT50.Text)

            For Each r As TimeSeriesDS.RainfallFilesRow In mdtRFFileInfo
                strFPNSourceGrid = Path.Combine(r.FilePath, r.FileName)
                strFPNResultGrid = Path.Combine(strPathName, strPrefix + IO.Path.GetFileNameWithoutExtension(r.FileName) + strSuffix _
                                   + IO.Path.GetExtension(r.FileName))
                IO.File.Copy(strFPNSourceGrid, strFPNResultGrid)

                Call CalculateNAWTInfo(strFPNResultGrid, sngTSTemperature_K)
                Call AssignPrecipitationWithNAWT(strFPNResultGrid, sngRFT10_mm, sngRFT50_mm)

                ofrmPrograssBar.GRMToolsPrograssBar.Value = r.FileOrder
                ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Generate " + CStr(r.FileOrder) + "/" & CStr(mdtRFFileInfo.Rows.Count) & " files..."
                System.Windows.Forms.Application.DoEvents()
            Next
        End If

        If rbPowerLaw.Checked = True Then

            For Each r As TimeSeriesDS.RainfallFilesRow In mdtRFFileInfo

                strFPNSourceGrid = Path.Combine(r.FilePath, r.FileName)
                strFPNResultGrid = Path.Combine(strPathName, strPrefix + IO.Path.GetFileNameWithoutExtension(r.FileName) + strSuffix _
                                   + IO.Path.GetExtension(r.FileName))
                IO.File.Copy(strFPNSourceGrid, strFPNResultGrid)

                Call AssignPrecipitationWithPowerLaw(strFPNResultGrid)

                ofrmPrograssBar.GRMToolsPrograssBar.Value = r.FileOrder
                ofrmPrograssBar.labGRMToolsPrograssBar.Text = "Generate " + CStr(r.FileOrder) + "/" & CStr(mdtRFFileInfo.Rows.Count) & " files..."
                System.Windows.Forms.Application.DoEvents()
            Next
        End If
        ofrmPrograssBar.Close()
    End Sub


    Sub CalculateNAWTInfo(ByVal strTargetGridFNP As String, ByVal sngTSTemperature_K As Single)
        Dim oGrid As New MapWinGIS.Grid
        oGrid.Open(strTargetGridFNP, MapWinGIS.GridDataType.UnknownDataType, True, _
                     MapWinGIS.GridFileType.UseExtension)
        Dim rowCount As Integer = oGrid.Header.NumberRows
        Dim colCount As Integer = oGrid.Header.NumberCols
        Dim alCellValue As New ArrayList
        Dim dblValueIN As Double
        Dim bAlreadyExisted As Boolean
        For nRow As Integer = 0 To rowCount - 1
            For nCol As Integer = 0 To colCount - 1
                Dim dblCellValue As Double = CSng(oGrid.Value(nCol, nRow))
                If dblCellValue <> -9999 And dblCellValue < sngTSTemperature_K Then
                    bAlreadyExisted = False
                    For Each dblValueIN In alCellValue
                        If dblValueIN = dblCellValue Then
                            bAlreadyExisted = True
                            Exit For
                        End If
                    Next
                    If bAlreadyExisted = False Then
                        alCellValue.Add(dblCellValue)
                    End If
                End If
            Next
        Next
        alCellValue.Sort()
        Dim intCountValueClass As Integer = alCellValue.Count
        Dim intT10index As Integer
        Dim intT50index As Integer
        intT10index = CInt(cComTools.GetNumericRoundDown(intCountValueClass * 0.1))
        intT50index = CInt(cComTools.GetNumericRoundDown(intCountValueClass * 0.5))

        If intT10index = 0 Then
            mNAWTT10Value = -10 '절대 없는 운정 온도.. 그러므로 현재의 레이어에서는 -10K 보다 작은 셀은 없을 것이 확실함
        Else
            '10%에 해당하는 값을 얻고
            mNAWTT10Value = CSng(alCellValue.Item(intT10index - 1))
        End If

        If intT50index = 0 Then
            mNAWTT50Value = -10
        Else
            '50%에 해당하는 값을 얻고
            mNAWTT50Value = CSng(alCellValue.Item(intT50index - 1))
        End If
    End Sub


    Sub AssignPrecipitationWithNAWT(ByVal strTargetGridFNP As String, ByVal sngRFT10_mm As Single, ByVal sngRFT50_mm As Single)
        Dim oGrid As New MapWinGIS.Grid
        oGrid.Open(strTargetGridFNP, MapWinGIS.GridDataType.UnknownDataType, _
                     True, MapWinGIS.GridFileType.UseExtension)
        Dim alCellValue As New ArrayList
        Dim bAssigned As Boolean = False
        For nRowY As Integer = 0 To oGrid.Header.NumberRows - 1
            For nColX As Integer = 0 To oGrid.Header.NumberCols - 1
                Dim sngCellValue As Single = CSng(oGrid.Value(nColX, nRowY))
                bAssigned = False
                If sngCellValue > 50 Then '운정온도는 항상 0보다 크다.  안전하게 50 이상
                    If sngCellValue <= mNAWTT10Value Then
                        oGrid.Value(nColX, nRowY) = sngRFT10_mm
                        bAssigned = True
                    End If
                    If bAssigned = False Then
                        If sngCellValue > mNAWTT10Value And sngCellValue <= mNAWTT50Value Then
                            oGrid.Value(nColX, nRowY) = sngRFT50_mm
                            bAssigned = True
                        End If
                    End If
                    If bAssigned = False Then
                        oGrid.Value(nColX, nRowY) = 0
                    End If
                Else
                    oGrid.Value(nColX, nRowY) = 0
                End If
            Next
        Next
        oGrid = Nothing
    End Sub

    Sub AssignPrecipitationWithPowerLaw(ByVal strTargetGridFNP As String)
        Dim oGrid As New MapWinGIS.Grid
        oGrid.Open(strTargetGridFNP, MapWinGIS.GridDataType.UnknownDataType, _
                   True, MapWinGIS.GridFileType.UseExtension)
        For nRowY As Integer = 0 To oGrid.Header.NumberRows - 1
            For nColX As Integer = 0 To oGrid.Header.NumberCols - 1
                Dim sngCellValue As Single = CSng(oGrid.Value(nColX, nRowY))
                If sngCellValue > 50 Then '운정온도는 항상 0보다 크다. 안전하게 50 이상
                    Dim rf As Single = CSng(1.1183 * 10 ^ 11 * Math.Exp(-3.6382 * 0.01 * sngCellValue ^ 1.2))
                    oGrid.Value(nColX, nRowY) = rf
                Else
                    oGrid.Value(nColX, nRowY) = 0
                End If
            Next
        Next
        oGrid = Nothing
    End Sub


    Private Sub btOpenDestinationFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOpenDestinationFolder.Click
        Dim fb As New FolderBrowserDialog
        If fb.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtDestinationFolderPath.Text = fb.SelectedPath
        Else
            Exit Sub
        End If
    End Sub


    Private Sub rbNAWT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNAWT.CheckedChanged
        If Me.rbNAWT.Checked = True Then
            Me.gbNAWT.Enabled = True
        Else
            Me.gbNAWT.Enabled = False
        End If
    End Sub

    Private Sub txtFolderPathSource_TextChanged(sender As Object, e As EventArgs) Handles txtFolderPathSource.TextChanged
        If txtFolderPathSource.Text.Trim <> "" AndAlso IO.Directory.Exists(txtFolderPathSource.Text.Trim) Then
            Me.lstRFfiles.DataSource = cFile.GetFileList(txtFolderPathSource.Text.Trim, mFilePattern)
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