Imports System.IO
Imports gentle

Public Class fFileEdit
    Private mstrDestinationFolderPath As String
    Private mfileNameHead As String
    Private mfileNameTag As String

    Private mdtSourceFile As New FilesDS.FilesDataTable
    Private meProcessingType As cVars.ProcessingType
    'Private mFilePattern As cFile.FilePattern
    Private mLidxStarting As Integer = 0
    Private mLidxEnding As Integer = 0
    Private mTxtToFind As String = ""
    Private mTxtToReplace As String = ""
    Private mTLxCol As Integer = 0
    Private mTLyRow As Integer = 0
    Private mLRxCol As Integer = 0
    Private mLRyRow As Integer = 0
    Private mDecimalN As Integer = -1

    Private mStopProgress As Boolean
    Private WithEvents mfPrograssBar As fProgressBar

    Private Sub fDPT_FileEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvRainfallFileList.DataSource = mdtSourceFile
        SetDataGridViewForm()
    End Sub


    Private Sub btStartProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStartProcess.Click
        If Me.btOpenDestinationFolder.Enabled = True Then
            If Me.txtDestinationFolderPath.Text = "" Then
                MsgBox("Destination path is not entered!!!", MsgBoxStyle.Critical)
                Exit Sub
            Else
                mstrDestinationFolderPath = Me.txtDestinationFolderPath.Text.Trim
            End If

            If Directory.Exists(mstrDestinationFolderPath) = False Then
                MsgBox("Destination folder is not exist!!!  ", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        If Me.rbReplaceText.Checked OrElse Me.rbRemoveLines.Checked OrElse
                Me.rbReplaceLineByLine.Checked OrElse Me.rbInsertALine.Checked Then
            If Me.tbStartingLineidx.Text.Trim <> "" Then
                mLidxStarting = Me.tbStartingLineidx.Text.Trim
            Else
                mLidxStarting = 0
            End If
            If Me.tbEndingLineidx.Text.Trim <> "" Then
                mLidxEnding = Me.tbEndingLineidx.Text.Trim
                If mLidxEnding < mLidxStarting Then
                    MsgBox("Ending line index is smaller than starting line index.   ", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Else
                mLidxEnding = 0
            End If
            mTLxCol = 0
            mTLyRow = 0
            mLRxCol = 0
            mLRyRow = 0
        End If

        If Me.rbReplaceTextInASCII.Checked Then
            mTLxCol = Me.tbAscTLxCol.Text.Trim
            mTLyRow = Me.tbAscTLyRow.Text.Trim
            mLRxCol = Me.tbAscLRxCol.Text.Trim
            mLRyRow = Me.tbAscLRyRow.Text.Trim
            mLidxStarting = 0
            mLidxEnding = 0
            If mTLxCol > mLRxCol OrElse mTLyRow > mLRyRow Then
                MsgBox("Cell ranges are invalid.   ", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If

        If Me.rbReplaceText.Checked OrElse Me.rbReplaceLineByLine.Checked OrElse
            Me.rbReplaceTextInASCII.Checked OrElse Me.rbInsertALine.Checked Then
            mTxtToFind = Me.tbTextToFind.Text
            mTxtToReplace = Me.tbTextToReplace.Text
        Else
            mTxtToFind = ""
            mTxtToReplace = ""
        End If

        If Me.rbCutDecimal.Checked AndAlso Me.tbDecimalPartN.Text.Trim() <> "" Then
            mDecimalN = CInt(Me.tbDecimalPartN.Text)
        End If

        If Me.dgvRainfallFileList.RowCount > 0 Then
            Call DataProcessingManager()
        Else
            MsgBox("Source file is not selected.   ", MsgBoxStyle.Information)
        End If
    End Sub

    Sub DataProcessingManager()
        mfPrograssBar = New fProgressBar
        mStopProgress = False
        Try
            Dim strProcessingMsg As String = ""
            mfPrograssBar.GRMToolsPrograssBar.Maximum = mdtSourceFile.Rows.Count
            mfPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
            mfPrograssBar.labGRMToolsPrograssBar.Text = "Processing 0/" & CStr(mdtSourceFile.Rows.Count) & " file..."
            mfPrograssBar.Text = "Processing files"
            mfPrograssBar.Show()
            System.Windows.Forms.Application.DoEvents()
            meProcessingType = GetProcessType()

            Dim strStartingDateTime As String = ""
            Dim outputTimeStep As Integer = 0
            mfileNameHead = Trim(Me.txtResultFilePrefix.Text)
            mfileNameTag = Trim(Me.txtResultFileTag.Text)


            'Dim bIsConvertingError As Boolean = False
            For Each r As FilesDS.FilesRow In mdtSourceFile
                Dim sourceFPN As String
                Dim resultFName As String = ""
                Dim resultFPN As String = ""
                Dim resultFNWithoutExtension As String
                sourceFPN = Path.Combine(r.FilePath, r.FileName)
                resultFNWithoutExtension = mfileNameHead + IO.Path.GetFileNameWithoutExtension(r.FileName) + mfileNameTag
                resultFPN = mstrDestinationFolderPath + "\" + resultFNWithoutExtension + IO.Path.GetExtension(r.FileName)
                Select Case meProcessingType
                    Case cVars.ProcessingType.Replace
                        strProcessingMsg = "Replace in files"
                        Call cTextFile.ReplaceTextInTextFile(sourceFPN, resultFPN, mTxtToFind, mTxtToReplace, mLidxStarting, mLidxEnding)
                    Case cVars.ProcessingType.ReplaceLineByLine
                        strProcessingMsg = "Replace lines in files"
                        Call cTextFile.ReplaceLineByLineInTextFile(sourceFPN, resultFPN, mTxtToFind, mTxtToReplace, mLidxStarting, mLidxEnding)'이거 아직 작업 안된것임
                    Case cVars.ProcessingType.InsertALine
                        strProcessingMsg = "Insert a line into files"
                        Call cTextFile.InsertAlineIntoTextFile(sourceFPN, resultFPN, mTxtToReplace, mLidxStarting)
                    Case cVars.ProcessingType.RemoveLines
                        strProcessingMsg = "Remove a line from files"
                        Call cTextFile.RemoveAlineFromTextFile(sourceFPN, resultFPN, mLidxStarting, mLidxEnding)
                    Case cVars.ProcessingType.ReplaceInAscRange
                        strProcessingMsg = "Replace in files"
                        Dim ascDS As New cAscRasterReader(sourceFPN)
                        Call cTextFile.ReplaceTextInASCiiRasterRange(ascDS, resultFPN, mTxtToFind.Trim, mTxtToReplace.Trim, mTLxCol, mTLyRow, mLRxCol, mLRyRow)
                        'ascDS.Dispose()
                    Case cVars.ProcessingType.CutDecimalPart
                        strProcessingMsg = "Cutting decimal parts"
                        Dim ascDS As New cAscRasterReader(sourceFPN)
                        Call cTextFile.MakeASCTextFile(resultFPN, ascDS.HeaderStringAll, ascDS.ValuesFromTL, mDecimalN, ascDS.Header.nodataValue)
                        'ascDS.Dispose()
                    Case Else
                        strProcessingMsg = ""
                End Select
                mfPrograssBar.GRMToolsPrograssBar.Value = r.FileOrder
                mfPrograssBar.labGRMToolsPrograssBar.Text = strProcessingMsg + " " + CStr(r.FileOrder) + "/" & CStr(mdtSourceFile.Rows.Count) & " file..."
                System.Windows.Forms.Application.DoEvents()
                If File.Exists(resultFPN) = False Then
                    MsgBox(String.Format("An Error was occured.{0}Converting {1} {2}to {3} is failed.     ", vbCrLf, sourceFPN, vbCrLf, resultFPN), MsgBoxStyle.Exclamation)
                    mfPrograssBar.Close()
                    GC.Collect()
                    Exit Sub
                End If

                If mStopProgress = True Then
                    MsgBox("Process was stopped..   ", MsgBoxStyle.Exclamation)
                    mfPrograssBar.Close()
                    GC.Collect()
                    Exit Sub
                End If
            Next
            ''If bIsConvertingError = False Then
            mfPrograssBar.Close()
            MsgBox(strProcessingMsg + " " + CStr(mdtSourceFile.Rows.Count) + " files is completed!!!   ", MsgBoxStyle.Information)
            GC.Collect()
            'Else
            'MsgBox("Some errors were occured while converting file(s).   ", MsgBoxStyle.Exclamation)
            'End If
        Catch ex As Exception
            mfPrograssBar.Close()
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
            GC.Collect()
        End Try
    End Sub

    Private Function GetProcessType() As cVars.ProcessingType
        Dim pt As cVars.ProcessingType = Nothing
        If Me.rbReplaceText.Checked Then pt = cVars.ProcessingType.Replace
        If Me.rbReplaceLineByLine.Checked Then pt = cVars.ProcessingType.ReplaceLineByLine
        If Me.rbRemoveLines.Checked Then pt = cVars.ProcessingType.RemoveLines
        If Me.rbInsertALine.Checked Then pt = cVars.ProcessingType.InsertALine
        If Me.rbReplaceTextInASCII.Checked Then pt = cVars.ProcessingType.ReplaceInAscRange
        If Me.rbCutDecimal.Checked Then pt = cVars.ProcessingType.CutDecimalPart
        Return pt
    End Function


    Sub SetDataGridViewForm()
        With Me.dgvRainfallFileList
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AllowUserToDeleteRows = False
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            '.RowHeadersWidth = 10
            '.ColumnCount = 3

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter '.MiddleLeft
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .AutoResizeRows()
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect '.CellSelect
            .MultiSelect = True
            .ReadOnly = True
        End With
    End Sub


    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        MyBase.Close()
    End Sub


    Private Sub btOpenDestinationFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOpenDestinationFolder.Click
        Dim fb As New FolderBrowserDialog
        If fb.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtDestinationFolderPath.Text = fb.SelectedPath
        End If
    End Sub


    Private Sub btRemoveSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRemoveSelected.Click

        If dgvRainfallFileList.SelectedRows.Count <= 0 Then
            MsgBox("Please select rows to remove.     ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim rowsToRemove As New List(Of DataRow)

        For Each dgvRow As DataGridViewRow In dgvRainfallFileList.SelectedRows
            Dim drv As DataRowView = CType(dgvRow.DataBoundItem, DataRowView)
            rowsToRemove.Add(drv.Row)
        Next

        Dim dt As DataTable = CType(dgvRainfallFileList.DataSource, DataTable)
        For Each row As DataRow In rowsToRemove
            dt.Rows.Remove(row)
        Next

        cFile.RefreshOrderInDataTable(dt, "FileOrder")
    End Sub

    Private Sub btRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRemoveAll.Click
        mdtSourceFile.Rows.Clear()
    End Sub

    Sub SetProcessingOptionalIU()
        Me.txtResultFilePrefix.Enabled = True
        Me.txtResultFileTag.Enabled = True
        Me.tbTextToFind.Enabled = True
        Me.tbTextToReplace.Enabled = True
        Me.gbLineConditions.Enabled = True
        Me.gbASCIIRangeConditions.Enabled = True
        Me.tbStartingLineidx.Text = ""
        Me.tbStartingLineidx.Enabled = True
        Me.tbEndingLineidx.Text = ""
        Me.tbEndingLineidx.Enabled = True
        Me.btOpenDestinationFolder.Enabled = True
        Me.txtDestinationFolderPath.Enabled = True
        Me.lbTextToFind.Text = "Text to find : "
        Me.lbTextToReplace.Text = "Text to replace : "
        Me.tbDecimalPartN.Enabled = True

        If Me.rbReplaceText.Checked = True Then
            'mFilePattern = cFile.FilePattern.ALLFILE
            'Me.tbStartingLineNum.Text = ""
            'Me.tbStartingLineNum.Enabled = False
            'Me.tbEndingLineNum.Text = ""
            'Me.tbEndingLineNum.Enabled = False
            Me.tbAscLRxCol.Text = ""
            Me.tbAscLRyRow.Text = ""
            Me.tbAscTLxCol.Text = ""
            Me.tbAscTLyRow.Text = ""
            Me.gbASCIIRangeConditions.Enabled = False
            Me.tbDecimalPartN.Text = ""
            Me.tbDecimalPartN.Enabled = False
        End If

        If Me.rbReplaceLineByLine.Checked = True Then
            'mFilePattern = cFile.FilePattern.ALLFILE
            'Me.tbTextToFind.Text = ""
            'Me.tbTextToFind.Enabled = False
            'Me.tbStartingLineNum.Text = ""
            'Me.tbStartingLineNum.Enabled = False
            ''Me.tbEndingLineNum.Text = ""
            'Me.tbEndingLineNum.Enabled = True
            Me.gbASCIIRangeConditions.Enabled = False
            Me.tbDecimalPartN.Text = ""
            Me.tbDecimalPartN.Enabled = False
        End If

        If Me.rbRemoveLines.Checked = True Then
            'mFilePattern = cFile.FilePattern.ALLFILE
            Me.tbTextToFind.Text = ""
            Me.tbTextToFind.Enabled = False
            Me.tbTextToReplace.Text = ""
            Me.tbTextToReplace.Enabled = False
            'Me.tbStartingLineNum.Text = ""
            'Me.tbStartingLineNum.Enabled = False
            ''Me.tbEndingLineNum.Text = ""
            'Me.tbEndingLineNum.Enabled = True
            Me.gbASCIIRangeConditions.Enabled = False
            Me.tbDecimalPartN.Text = ""
            Me.tbDecimalPartN.Enabled = False
        End If

        If Me.rbInsertALine.Checked = True Then
            'mFilePattern = cFile.FilePattern.ALLFILE
            Me.tbTextToFind.Text = ""
            Me.tbTextToFind.Enabled = False
            'Me.tbStartingLineNum.Text = ""
            'Me.tbStartingLineNum.Enabled = False
            Me.tbEndingLineidx.Text = ""
            Me.tbEndingLineidx.Enabled = False
            Me.gbASCIIRangeConditions.Enabled = False
            Me.lbTextToReplace.Text = "Text to insert : "
            Me.tbDecimalPartN.Text = ""
            Me.tbDecimalPartN.Enabled = False
        End If

        If Me.rbReplaceTextInASCII.Checked = True Then
            Me.tbStartingLineidx.Text = ""
            Me.tbEndingLineidx.Text = ""
            Me.gbLineConditions.Enabled = False
            Me.tbDecimalPartN.Text = ""
            Me.tbDecimalPartN.Enabled = False
            Me.lbTextToFind.Text = "Value to find : "
            Me.lbTextToReplace.Text = "Value to replace : "
        End If

        If Me.rbCutDecimal.Checked = True Then
            Me.tbStartingLineidx.Text = ""
            Me.tbEndingLineidx.Text = ""
            Me.gbLineConditions.Enabled = False
            Me.gbASCIIRangeConditions.Enabled = False
            Me.tbTextToFind.Text = ""
            Me.tbTextToFind.Enabled = False
            Me.tbTextToReplace.Text = ""
            Me.tbTextToReplace.Enabled = False
        End If

    End Sub


    Private Sub txtFolderPathSource_TextChanged(sender As Object, e As EventArgs) _
        Handles txtFolderPathSource.TextChanged, tbExtensionFilter.TextChanged, tbFileNameFilter.TextChanged
        If txtFolderPathSource.Text.Trim <> "" AndAlso IO.Directory.Exists(txtFolderPathSource.Text.Trim) Then
            Dim filePattern As String = Me.tbExtensionFilter.Text.Trim  'mFilePattern.ToString
            If Trim(Me.tbExtensionFilter.Text) <> "" Then
                filePattern = Trim(Me.tbExtensionFilter.Text)
                If (filePattern.Contains(".")) = False Then
                    filePattern = "." + filePattern
                End If
            End If
            Dim fileFilter As String = Me.tbFileNameFilter.Text.Trim
            Me.lstRFfiles.DataSource = cFile.GetFileList(txtFolderPathSource.Text.Trim, fileFilter, filePattern)
        Else
            Me.lstRFfiles.DataSource = Nothing
        End If
    End Sub

    Private Sub btOpenFolder_Click(sender As Object, e As EventArgs) Handles btOpenFolder.Click
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


    Private Function GetGdalDataTypeFromGRMDataType(inType As gentle.cData.DataType) As cGdal.GdalDataType
        Select Case inType
            Case cData.DataType.DTByte
                Return cGdal.GdalDataType.GDT_Byte
            Case cData.DataType.DTShort
                Return cGdal.GdalDataType.GDT_Int16
            Case cData.DataType.DTInteger
                Return cGdal.GdalDataType.GDT_Int32
            Case cData.DataType.DTSingle
                Return cGdal.GdalDataType.GDT_Float32
            Case cData.DataType.DTDouble
                Return cGdal.GdalDataType.GDT_Float64
            Case Else
                Return Nothing
        End Select
    End Function



    Private Sub rbReplaceText_CheckedChanged(sender As Object, e As EventArgs) Handles rbReplaceText.CheckedChanged
        Call Me.SetProcessingOptionalIU()
    End Sub

    Private Sub rbReplaceLines_CheckedChanged(sender As Object, e As EventArgs) Handles rbReplaceLineByLine.CheckedChanged
        Call Me.SetProcessingOptionalIU()
    End Sub

    Private Sub rbRemoveLines_CheckedChanged(sender As Object, e As EventArgs) Handles rbRemoveLines.CheckedChanged
        Call Me.SetProcessingOptionalIU()
    End Sub

    Private Sub rbInsertLines_CheckedChanged(sender As Object, e As EventArgs) Handles rbInsertALine.CheckedChanged
        Call Me.SetProcessingOptionalIU()
    End Sub

    Private Sub rbReplaceTextInASCII_CheckedChanged(sender As Object, e As EventArgs) Handles rbReplaceTextInASCII.CheckedChanged
        Call Me.SetProcessingOptionalIU()
    End Sub

    Private Sub rbCutDecimal_CheckedChanged(sender As Object, e As EventArgs) Handles rbCutDecimal.CheckedChanged
        Call Me.SetProcessingOptionalIU()
    End Sub


    Private Sub btAddSelectedFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddSelectedFile.Click
        Call AddFiles(True)
    End Sub

    Private Sub btAddAllFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddAllFiles.Click

        Call AddFiles(False)
    End Sub


    Private Sub AddFiles(ByVal bSelectedFile As Boolean)
        If IO.Directory.Exists(txtFolderPathSource.Text.Trim) Then
            Dim strFilePath As String = txtFolderPathSource.Text.Trim
            Dim obj As New cFile
            Dim items As String() = obj.GetFilesAndCheckDuplication(lstRFfiles, bSelectedFile, strFilePath, mdtSourceFile, "FileName", "FilePath")
            If obj.DuplicationfileProcessMessage = MsgBoxResult.Cancel Then Exit Sub
            obj.AddToDataTable(items, strFilePath, mdtSourceFile, "FileOrder", "FileName", "FilePath")
        End If
    End Sub

    Private Sub mProcess_StopProcess(ByVal sender As fProgressBar) Handles mfPrograssBar.StopProcess
        mStopProgress = True
    End Sub


End Class