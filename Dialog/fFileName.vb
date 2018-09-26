Imports System.IO
Imports gentle

Public Class fFileName
    Private mDestinationFPN_fileList As String
    Private mFileNameHead As String
    Private mFileNameTail As String
    Private mFileExtToChange As String = ""
    Private mdtSourceFile As New FilesDS.FilesDataTable
    Private meProcessingType As cVars.ProcessingType

    Private mStopProgress As Boolean = False
    Private WithEvents mfPrograssBar As fProgressBar

    Private Sub frmGRMToolsRainfallFileProcessing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvFileList.DataSource = mdtSourceFile
        SetDataGridViewForm()
    End Sub


    Private Sub btStartProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStartProcess.Click

        mDestinationFPN_fileList = ""

        If Me.rbChangeFileExt.Checked Then
            mFileExtToChange = Me.tbExtToChange.Text.Trim
            If mFileExtToChange = "" Then
                MsgBox("File extension was not entered.   ", MsgBoxStyle.Information)
                Exit Sub
            End If
            If mFileExtToChange.ToArray(0) <> "." Then
                mFileExtToChange = "." + mFileExtToChange
            End If
        End If

        If rbSaveFileList.Checked = True Then
            If Me.tbResultFPN.Text = "" Then
                MsgBox("Destination file was not entered.   ", MsgBoxStyle.Information)
                Exit Sub
            Else
                mDestinationFPN_fileList = Me.tbResultFPN.Text.Trim
                If File.Exists(mDestinationFPN_fileList) Then
                    File.Delete(mDestinationFPN_fileList)
                End If
            End If
        End If


            If Me.dgvFileList.RowCount > 0 Then
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

            Dim strTxtToFind As String = ""
            Dim strTxtToReplace As String = ""
            Dim strStartingDateTime As String = ""
            Dim outputTimeStep As Integer = 0
            mFileNameHead = Trim(Me.tbFileHead.Text)
            mFileNameTail = Trim(Me.tbFileTail.Text)
            If meProcessingType = cVars.ProcessingType.Rename OrElse
                meProcessingType = cVars.ProcessingType.Replace OrElse
                meProcessingType = cVars.ProcessingType.RenameToDateTime Then
                strTxtToFind = Me.tbTextToFind.Text
                strTxtToReplace = Me.tbTextToReplace.Text
                If meProcessingType = cVars.ProcessingType.RenameToDateTime Then
                    strStartingDateTime = Me.dtpResultStarting.Text
                    outputTimeStep = CInt(Me.tbTimeStep.Text)
                End If
            End If

            Dim bIsConvertingError As Boolean = False
            For Each r As FilesDS.FilesRow In mdtSourceFile
                Dim sourceFPN As String
                Dim resultFName As String = ""
                Dim resultFPN As String = ""
                'Dim resultFNWithoutExtension As String
                sourceFPN = Path.Combine(r.FilePath, r.FileName)
                If Me.chkUsingSourceFileName.Checked = True AndAlso Me.rbRenameToDateTimeFormat.Checked = False Then
                    resultFName = r.FileName
                Else
                    resultFName = Format(r.FileOrder, "0000#") + Path.GetExtension(r.FileName)
                End If
                Select Case meProcessingType
                    Case cVars.ProcessingType.Rename
                        strProcessingMsg = "Rename files"
                        resultFName = Replace(resultFName, strTxtToFind, strTxtToReplace)
                        resultFName = mFileNameHead + IO.Path.GetFileNameWithoutExtension(resultFName) +
                                           mFileNameTail + IO.Path.GetExtension(resultFName)
                        If IO.Path.GetFileName(resultFName) <> IO.Path.GetFileName(sourceFPN) AndAlso File.Exists(resultFName) = False Then
                            My.Computer.FileSystem.RenameFile(sourceFPN, resultFName)
                        Else
                            MsgBox(String.Format("{0} is already exist. Stop processing.  ", resultFName), MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        resultFPN = Path.Combine(r.FilePath, resultFName)
                    Case cVars.ProcessingType.RenameToDateTime
                        strProcessingMsg = "Rename files to DateTime format"
                        Dim strNowDateTime As String _
                            = cComTools.GetNowTimeToPrintOut(strStartingDateTime, outputTimeStep, r.FileOrder - 1)
                        strNowDateTime = strNowDateTime.ToString()
                        resultFName = mFileNameHead + strNowDateTime +
                                           mFileNameTail + IO.Path.GetExtension(r.FileName)

                        If IO.Path.GetFileName(resultFName) <> IO.Path.GetFileName(sourceFPN) AndAlso File.Exists(resultFName) = False Then
                            My.Computer.FileSystem.RenameFile(sourceFPN, resultFName)
                        Else
                            MsgBox(String.Format("{0} is already exist. Stop processing.  ", resultFName), MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        resultFPN = Path.Combine(r.FilePath, resultFName)

                    Case cVars.ProcessingType.ChangeFileExt
                        strProcessingMsg = "Change file extensions"
                        resultFName = IO.Path.GetFileNameWithoutExtension(resultFName) + mFileExtToChange
                        If IO.Path.GetFileName(resultFName) <> IO.Path.GetFileName(sourceFPN) AndAlso File.Exists(resultFName) = False Then
                            My.Computer.FileSystem.RenameFile(sourceFPN, resultFName)
                        Else
                            MsgBox(String.Format("{0} is already exist. Stop processing.  ", resultFName), MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        resultFPN = Path.Combine(r.FilePath, resultFName)

                    Case cVars.ProcessingType.SaveFileList
                        strProcessingMsg = "Saving file list"
                        File.AppendAllText(mDestinationFPN_fileList, sourceFPN + vbCrLf)
                    Case Else
                        strProcessingMsg = ""
                End Select

                mfPrograssBar.GRMToolsPrograssBar.Value = r.FileOrder
                mfPrograssBar.labGRMToolsPrograssBar.Text = strProcessingMsg + " " + CStr(r.FileOrder) + "/" & CStr(mdtSourceFile.Rows.Count) & " file..."
                System.Windows.Forms.Application.DoEvents()
                If meProcessingType <> cVars.ProcessingType.SaveFileList Then
                    If File.Exists(resultFPN) = False Then
                        MsgBox(String.Format("An Error was occured.{0}Converting {1} {2}to {3} is failed.     ", vbCrLf, sourceFPN, vbCrLf, resultFPN), MsgBoxStyle.Exclamation)
                        mfPrograssBar.Close()
                        Exit Sub
                    End If
                End If

                If mStopProgress = True Then
                    MsgBox("Process was stopped..   ", MsgBoxStyle.Exclamation)
                    mfPrograssBar.Close()
                    Exit Sub
                End If
            Next
            mfPrograssBar.Close()
            'If bIsConvertingError = False Then
            MsgBox(strProcessingMsg + " " + CStr(mdtSourceFile.Rows.Count) + " files were completed!!!   ", MsgBoxStyle.Information)
            'Else
            '    MsgBox("Some errors were occured while converting file(s).   ", MsgBoxStyle.Exclamation)
            'End If
        Catch ex As Exception
            mfPrograssBar.Close()
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Function GetProcessType() As cVars.ProcessingType
        Dim pt As cVars.ProcessingType = Nothing
        If Me.rbRename.Checked Then pt = cVars.ProcessingType.Rename
        If Me.rbRenameToDateTimeFormat.Checked Then pt = cVars.ProcessingType.RenameToDateTime
        If Me.rbChangeFileExt.Checked Then pt = cVars.ProcessingType.ChangeFileExt
        If Me.rbSaveFileList.Checked Then pt = cVars.ProcessingType.SaveFileList
        Return pt
    End Function


    Sub SetDataGridViewForm()
        With Me.dgvFileList
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AllowUserToDeleteRows = False
            .AllowUserToAddRows = False
            .RowHeadersVisible = False

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter '.MiddleLeft
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .AutoResizeRows()
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect '.CellSelect
            .MultiSelect = True
            .ReadOnly = True
        End With
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


    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        MyBase.Close()
    End Sub


    Private Sub btRemoveSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRemoveSelected.Click

        If dgvFileList.SelectedRows.Count <= 0 Then
            MsgBox("Please select rows to remove.     ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim rowsToRemove As New List(Of DataRow)

        For Each dgvRow As DataGridViewRow In dgvFileList.SelectedRows
            Dim drv As DataRowView = CType(dgvRow.DataBoundItem, DataRowView)
            rowsToRemove.Add(drv.Row)
        Next

        Dim dt As DataTable = CType(dgvFileList.DataSource, DataTable)
        For Each row As DataRow In rowsToRemove
            dt.Rows.Remove(row)
        Next

        cFile.RefreshOrderInDataTable(dt, "FileOrder")
    End Sub

    Private Sub btRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRemoveAll.Click
        mdtSourceFile.Rows.Clear()
    End Sub


    Sub SetProcessingOptionalIU()

        Me.tbFileHead.Enabled = True
        Me.tbFileTail.Enabled = True
        Me.tbTextToFind.Enabled = True
        Me.tbTextToReplace.Enabled = True
        Me.chkUsingSourceFileName.Enabled = True
        Me.chkUsingSourceFileName.Checked = True
        Me.dtpResultStarting.Enabled = True
        Me.tbTimeStep.Enabled = True
        Me.tbExtToChange.Enabled = True
        Me.lbFileExt.Enabled = True
        Me.lbSetTime.Enabled = True
        Me.lbTimeStart.Enabled = True
        Me.lbTimeStep.Enabled = True
        Me.lbTextToFind.Enabled = True
        Me.lbTextToReplace.Enabled = True
        Me.lbHead.Enabled = True
        Me.lbTail.Enabled = True
        Me.btResultFPN.Enabled = True
        Me.tbResultFPN.Text = ""
        Me.tbResultFPN.Enabled = True

        If Me.rbRename.Checked = True Then
            Me.lbSetTime.Enabled = False
            Me.lbTimeStart.Enabled = False
            Me.lbTimeStep.Enabled = False
            Me.dtpResultStarting.Enabled = False
            Me.tbTimeStep.Text = ""
            Me.tbTimeStep.Enabled = False
            Me.lbFileExt.Enabled = False
            Me.tbExtToChange.Text = ""
            Me.tbExtToChange.Enabled = False
            Me.btResultFPN.Enabled = False
            Me.tbResultFPN.Text = ""
            Me.tbResultFPN.Enabled = False
        End If

        If Me.rbRenameToDateTimeFormat.Checked = True Then
            Me.chkUsingSourceFileName.Enabled = False
            Me.chkUsingSourceFileName.Checked = False
            Me.lbTextToReplace.Enabled = False
            Me.tbTextToReplace.Text = ""
            Me.tbTextToReplace.Enabled = False
            Me.lbTextToFind.Enabled = False
            Me.tbTextToFind.Text = ""
            Me.tbTextToFind.Enabled = False
            Me.lbFileExt.Enabled = False
            Me.tbExtToChange.Text = ""
            Me.tbExtToChange.Enabled = False
            Me.btResultFPN.Enabled = False
            Me.tbResultFPN.Text = ""
            Me.tbResultFPN.Enabled = False
        End If

        If Me.rbChangeFileExt.Checked Then
            Me.chkUsingSourceFileName.Enabled = False
            Me.lbTextToReplace.Enabled = False
            Me.tbTextToReplace.Text = ""
            Me.tbTextToReplace.Enabled = False
            Me.lbTextToFind.Enabled = False
            Me.tbTextToFind.Text = ""
            Me.tbTextToFind.Enabled = False
            Me.lbSetTime.Enabled = False
            Me.lbTimeStart.Enabled = False
            Me.lbTimeStep.Enabled = False
            Me.dtpResultStarting.Enabled = False
            Me.tbTimeStep.Text = ""
            Me.tbTimeStep.Enabled = False
            Me.lbHead.Enabled = False
            Me.lbTail.Enabled = False
            Me.tbFileHead.Text = ""
            Me.tbFileHead.Enabled = False
            Me.tbFileTail.Text = ""
            Me.tbFileTail.Enabled = False
            Me.btResultFPN.Enabled = False
            Me.tbResultFPN.Text = ""
            Me.tbResultFPN.Enabled = False
        End If

        If Me.rbSaveFileList.Checked Then
            Me.chkUsingSourceFileName.Enabled = False
            Me.lbTextToReplace.Enabled = False
            Me.tbTextToReplace.Text = ""
            Me.tbTextToReplace.Enabled = False
            Me.lbTextToFind.Enabled = False
            Me.tbTextToFind.Text = ""
            Me.tbTextToFind.Enabled = False
            Me.lbSetTime.Enabled = False
            Me.lbTimeStart.Enabled = False
            Me.lbTimeStep.Enabled = False
            Me.dtpResultStarting.Enabled = False
            Me.tbTimeStep.Text = ""
            Me.tbTimeStep.Enabled = False
            Me.lbHead.Enabled = False
            Me.lbTail.Enabled = False
            Me.tbFileHead.Text = ""
            Me.tbFileHead.Enabled = False
            Me.tbFileTail.Text = ""
            Me.tbFileTail.Enabled = False
            Me.lbFileExt.Enabled = False
            Me.tbExtToChange.Text = ""
            Me.tbExtToChange.Enabled = False
        End If

    End Sub

    Private Sub chkUsingSourceFileName_CheckedChanged(sender As Object, e As EventArgs) Handles chkUsingSourceFileName.CheckedChanged
        If Me.chkUsingSourceFileName.Checked Then
            Me.tbTextToFind.Enabled = True
            Me.tbTextToReplace.Enabled = True
            Me.lbTextToFind.Enabled = True
            Me.lbTextToReplace.Enabled = True

        Else
            Me.tbTextToFind.Text = ""
            Me.tbTextToReplace.Text = ""
            Me.tbTextToFind.Enabled = False
            Me.tbTextToReplace.Enabled = False
            Me.lbTextToFind.Enabled = False
            Me.lbTextToReplace.Enabled = False

        End If
    End Sub


    Private Sub rbRename_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRename.CheckedChanged
        Call Me.SetProcessingOptionalIU()
    End Sub


    Private Sub rbRenameToDateTimeFormat_CheckedChanged(sender As Object, e As EventArgs) Handles rbRenameToDateTimeFormat.CheckedChanged
        Call Me.SetProcessingOptionalIU()
    End Sub



    Private Sub rbChangeFileExt_CheckedChanged(sender As Object, e As EventArgs) Handles rbChangeFileExt.CheckedChanged
        Call Me.SetProcessingOptionalIU()
    End Sub

    Private Sub rbSaveFileList_CheckedChanged(sender As Object, e As EventArgs) Handles rbSaveFileList.CheckedChanged
        Call Me.SetProcessingOptionalIU()
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

    Private Sub mProcess_StopProcess(ByVal sender As fProgressBar) Handles mfPrograssBar.StopProcess
        mStopProgress = True
    End Sub

    Private Sub btResultFPN_Click(sender As Object, e As EventArgs) Handles btResultFPN.Click
        Dim fb As New SaveFileDialog
        If fb.ShowDialog() = DialogResult.OK Then
            tbResultFPN.Text = fb.FileName
        End If
    End Sub
End Class