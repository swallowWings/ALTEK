Imports System.IO
Imports System.Text
Imports gentle

Public Class fAppendFiles
    Private mdtSourceFile As New FilesDS.FilesDataTable
    Private mAppMode As Integer '1 : row mode, 2: col mode
    Private mAppPos As Integer '1 : head, 2 : tail, 0 : none
    Private mSep As String
    Private mStopProgress As Boolean = False
    Private WithEvents mfPrograssBar As fProgressBar

    Private Sub fAppendFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dgvFileList.DataSource = mdtSourceFile
        SetDataGridViewForm()
    End Sub


    Private Sub btStartProcess_Click(sender As Object, e As EventArgs) Handles btStartProcess.Click
        mAppMode = 0
        mAppPos = 0
        mSep = ""

        If rbRowMode.Checked Then
            mAppMode = 1
        Else
            mAppMode = 2
        End If

        If rbSepTab.Checked Then
            mSep = vbTab
        Else
            mSep = Me.tbSepText.Text
        End If

        If Me.rbAppendAfileToAll.Checked Then
            If Me.rbPosHead.Enabled = True AndAlso Me.rbPosHead.Checked = True Then
                mAppPos = 1
            End If
            If Me.rbPosTail.Enabled = True AndAlso Me.rbPosTail.Checked = True Then
                mAppPos = 2
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

            If rbAppendAll.Checked Then
                Dim FinalValues As New List(Of String)
                For Each r As FilesDS.FilesRow In mdtSourceFile
                    Dim sourceFPN As String
                    sourceFPN = Path.Combine(r.FilePath, r.FileName)
                    Dim newFileValue As List(Of String) = File.ReadAllLines(sourceFPN).ToList
                    If mAppMode = 1 Then
                        FinalValues.AddRange(newFileValue)
                        If (mSep <> "") Then
                            FinalValues.Add(mSep)
                        End If
                    End If
                    If mAppMode = 2 Then
                        If FinalValues.Count = 0 Then
                            FinalValues.AddRange(newFileValue)
                        Else
                            For c = 0 To FinalValues.Count - 1
                                Dim aline As String = ""
                                If c > newFileValue.Count - 1 Then
                                    aline = FinalValues(c) + mSep + " "
                                Else
                                    aline = FinalValues(c) + mSep + newFileValue(c)
                                End If
                                FinalValues(c) = aline
                            Next
                        End If

                    End If
                    mfPrograssBar.GRMToolsPrograssBar.Value = r.FileOrder
                    mfPrograssBar.labGRMToolsPrograssBar.Text = strProcessingMsg + " " + CStr(r.FileOrder) + "/" & CStr(mdtSourceFile.Rows.Count) & " file..."
                    System.Windows.Forms.Application.DoEvents()
                    If mStopProgress = True Then
                        MsgBox("Process was stopped..   ", MsgBoxStyle.Exclamation)
                        mfPrograssBar.Close()
                        Exit Sub
                    End If
                Next
                Dim FPNresult As String = Me.tbResultFPN.Text.Trim()
                File.WriteAllLines(FPNresult, FinalValues.ToArray)
            End If

            If rbAppendAfileToAll.Checked Then
                Dim FPdestination As String = Me.tbResultFPN.Text.Trim
                Dim fnHead As String = Me.tbFileHead.Text.Trim
                Dim fnTail As String = Me.tbFileTail.Text.Trim
                Dim lstValuesToAdd As New List(Of String)
                lstValuesToAdd = File.ReadAllLines(Me.tbFileToAppend.Text.Trim).ToList
                For Each r As FilesDS.FilesRow In mdtSourceFile
                    Dim FinalValues As New List(Of String)
                    Dim sourceFPN As String
                    sourceFPN = Path.Combine(r.FilePath, r.FileName)
                    Dim lstValuesFromSourceFile As List(Of String) = File.ReadAllLines(sourceFPN).ToList
                    If mAppMode = 1 Then
                        If mAppPos = 1 Then
                            FinalValues.AddRange(lstValuesToAdd)
                            If (mSep <> "") Then
                                FinalValues.Add(mSep)
                            End If
                            FinalValues.AddRange(lstValuesFromSourceFile)
                        End If
                        If mAppPos = 2 Then
                            FinalValues.AddRange(lstValuesFromSourceFile)
                            If (mSep <> "") Then
                                FinalValues.Add(mSep)
                            End If
                            FinalValues.AddRange(lstValuesToAdd)
                        End If
                    End If

                    If mAppMode = 2 Then
                        For c = 0 To lstValuesFromSourceFile.Count - 1
                            Dim aline As String = ""
                            If c > lstValuesToAdd.Count - 1 Then
                                If mAppPos = 1 Then
                                    aline = " " + mSep + lstValuesFromSourceFile(c)
                                End If
                                If mAppPos = 2 Then
                                    aline = lstValuesFromSourceFile(c) + mSep + " "
                                End If
                            Else
                                If mAppPos = 1 Then
                                    aline = lstValuesToAdd(c) + mSep + lstValuesFromSourceFile(c)
                                End If
                                If mAppPos = 2 Then
                                    aline = lstValuesFromSourceFile(c) + mSep + lstValuesToAdd(c)
                                End If
                            End If
                            FinalValues.Add(aline)
                        Next
                    End If
                    Dim resultFName As String = fnHead + IO.Path.GetFileNameWithoutExtension(r.FileName) + fnTail + IO.Path.GetExtension(r.FileName)
                    Dim resultFPN As String = Path.Combine(FPdestination, resultFName)
                    If File.Exists(resultFPN) = True Then
                        MsgBox(String.Format("{0} is already exist. Stop processing.  ", resultFPN), MsgBoxStyle.Information)
                        mfPrograssBar.Close()
                        Exit Sub
                    End If
                    File.WriteAllLines(resultFPN, FinalValues.ToArray)
                    mfPrograssBar.GRMToolsPrograssBar.Value = r.FileOrder
                    mfPrograssBar.labGRMToolsPrograssBar.Text = strProcessingMsg + " " + CStr(r.FileOrder) + "/" & CStr(mdtSourceFile.Rows.Count) & " file..."
                    System.Windows.Forms.Application.DoEvents()
                    If mStopProgress = True Then
                        MsgBox("Process was stopped..   ", MsgBoxStyle.Exclamation)
                        mfPrograssBar.Close()
                        Exit Sub
                    End If
                Next
            End If
            mfPrograssBar.Close()
            MsgBox(strProcessingMsg + " " + CStr(mdtSourceFile.Rows.Count) + " files were completed!!!   ", MsgBoxStyle.Information)

        Catch ex As Exception
            mfPrograssBar.Close()
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try

    End Sub

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

    Private Sub txtFolderPathSource_TextChanged(sender As Object, e As EventArgs) _
        Handles txtFolderPathSource.TextChanged, tbExtensionFilter.TextChanged, tbFileNameFilter.TextChanged

        If txtFolderPathSource.Text.Trim <> "" AndAlso IO.Directory.Exists(txtFolderPathSource.Text.Trim) Then
            Dim naCom As New NaturalComparer
            Dim filePattern As String = Me.tbExtensionFilter.Text.Trim  'mFilePattern.ToString
            If Trim(Me.tbExtensionFilter.Text) <> "" Then
                filePattern = Trim(Me.tbExtensionFilter.Text)
                If (filePattern.Contains(".")) = False Then
                    filePattern = "." + filePattern
                End If
            End If
            Dim fileFilter As String = Me.tbFileNameFilter.Text.Trim
            Dim fileList As New List(Of String)
            fileList = cFile.GetFileList(txtFolderPathSource.Text.Trim, fileFilter, filePattern)
            fileList.Sort(naCom)
            Me.lstFiles.DataSource = fileList
        Else
            Me.lstFiles.DataSource = Nothing
        End If
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
            Dim items As String() = obj.GetFilesAndCheckDuplication(lstFiles, bSelectedFile, strFilePath, mdtSourceFile, "FileName", "FilePath")
            If obj.DuplicationfileProcessMessage = MsgBoxResult.Cancel Then Exit Sub
            obj.AddToDataTable(items, strFilePath, mdtSourceFile, "FileOrder", "FileName", "FilePath")
        End If
    End Sub

    Private Sub btRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRemoveAll.Click
        mdtSourceFile.Rows.Clear()
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

    Private Sub rbAppendAll_CheckedChanged(sender As Object, e As EventArgs) Handles rbAppendAll.CheckedChanged
        SetProcessingOptionalIU()
    End Sub


    Private Sub rbAppendAfileToAll_CheckedChanged(sender As Object, e As EventArgs) Handles rbAppendAfileToAll.CheckedChanged
        SetProcessingOptionalIU()
    End Sub

    Private Sub rbRowMode_CheckedChanged(sender As Object, e As EventArgs) Handles rbRowMode.CheckedChanged
        SetProcessingOptionalIU()
    End Sub

    Private Sub rbColMode_CheckedChanged(sender As Object, e As EventArgs) Handles rbColMode.CheckedChanged
        SetProcessingOptionalIU()
    End Sub

    Sub SetProcessingOptionalIU()
        If Me.rbAppendAll.Checked = True Then
            Me.rbPosHead.Checked = False
            Me.rbPosHead.Enabled = False
            Me.rbPosTail.Checked = False
            Me.rbPosTail.Enabled = False
            Me.rbSepTab.Enabled = True
            Me.rbSepTab.Checked = False
            Me.rbSepText.Enabled = True
            Me.rbSepText.Checked = True
            Me.btSelectAfileToAppend.Enabled = False
            Me.tbFileToAppend.Text = ""
            Me.tbFileToAppend.Enabled = False
            Me.btResultFPN.Text = "Result file"
            Me.lbHead.Enabled = False
            Me.tbFileHead.Text = ""
            Me.tbFileHead.Enabled = False
            Me.lbTail.Enabled = False
            Me.tbFileTail.Text = ""
            Me.tbFileTail.Enabled = False
        End If

        If Me.rbAppendAfileToAll.Checked = True Then
            Me.rbPosHead.Checked = True
            Me.rbPosHead.Enabled = True
            Me.rbPosTail.Checked = False
            Me.rbPosTail.Enabled = True
            Me.rbSepTab.Enabled = False
            Me.rbSepTab.Checked = False
            Me.rbSepText.Enabled = True
            Me.rbSepText.Checked = True
            Me.btSelectAfileToAppend.Enabled = True
            Me.tbFileToAppend.Text = ""
            Me.tbFileToAppend.Enabled = True
            Me.btResultFPN.Text = "Destination folder"
            Me.lbHead.Enabled = True
            Me.tbFileHead.Text = ""
            Me.tbFileHead.Enabled = True
            Me.lbTail.Enabled = True
            Me.tbFileTail.Text = ""
            Me.tbFileTail.Enabled = True
        End If

        If rbRowMode.Checked = True Then
            Me.rbSepTab.Enabled = False
            Me.rbSepTab.Checked = False
            Me.rbSepText.Enabled = True
            Me.rbSepText.Checked = True
        End If

        If rbColMode.Checked = True Then
            Me.rbSepTab.Enabled = True
            Me.rbSepTab.Checked = False
            Me.rbSepText.Enabled = True
            Me.rbSepText.Checked = True
        End If



    End Sub

    Private Sub btResultFPN_Click(sender As Object, e As EventArgs) Handles btResultFPN.Click
        If Me.rbAppendAll.Checked Then
            Dim fb As New SaveFileDialog
            If fb.ShowDialog() = DialogResult.OK Then
                tbResultFPN.Text = fb.FileName
            End If
        Else
            Dim fb As New FolderBrowserDialog
            If fb.ShowDialog() = Windows.Forms.DialogResult.OK Then
                tbResultFPN.Text = fb.SelectedPath
            End If
        End If
    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        MyBase.Close()
    End Sub

    Private Sub btSelectAfileToAppend_Click(sender As Object, e As EventArgs) Handles btSelectAfileToAppend.Click
        Dim fb As New OpenFileDialog
        If fb.ShowDialog() = DialogResult.OK Then
            tbFileToAppend.Text = fb.FileName
        End If
    End Sub


End Class