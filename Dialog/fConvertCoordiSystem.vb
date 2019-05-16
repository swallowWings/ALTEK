Imports System.IO

Public Class fConvertCoordiSystem

    Private mdtSourceFile As New FilesDS.FilesDataTable
    Private WithEvents mfPrograssBar As fProgressBar
    Private mStopProgress As Boolean = False
    Private mFileNamePrefix As String
    Private mFileNameTag As String
    Private fileFormatInput As cGdal.GdalFormat
    Private fileFormatOutput As cGdal.GdalFormat
    Private mstrDestinationFolderPath As String


    Private Sub fConvertCoordiSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitiallizeComboBox()
        Me.dgvFileList.DataSource = mdtSourceFile
        SetDataGridViewForm()
    End Sub

    Private Sub InitiallizeComboBox()
        Me.cbFileFormat_input.Items.Clear()
        Me.cbFileFormat_output.Items.Clear()

        Me.cbFileFormat_input.Items.Add(cGdal.GdalFormat.AAIGrid.ToString)
        Me.cbFileFormat_input.Items.Add(cGdal.GdalFormat.GTiff.ToString)

        Me.cbFileFormat_output.Items.Add(cGdal.GdalFormat.AAIGrid.ToString)
        Me.cbFileFormat_output.Items.Add(cGdal.GdalFormat.GTiff.ToString)

        cbDataType.DataSource = [Enum].GetNames(GetType(cData.DataType))
        cbDataType.Text = gentle.cData.DataType.DTSingle.ToString

    End Sub

    Sub SetDataGridViewForm()
        With Me.dgvFileList
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AllowUserToDeleteRows = False
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .AutoResizeRows()
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
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

    Private Sub btOpenDestinationFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOpenDestinationFolder.Click
        Dim fb As New FolderBrowserDialog
        If fb.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtDestinationFolderPath.Text = fb.SelectedPath
        End If
    End Sub


    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        MyBase.Close()
    End Sub

    Private Sub txtFolderPathSource_TextChanged(sender As Object, e As EventArgs) Handles txtFolderPathSource.TextChanged
        If txtFolderPathSource.Text.Trim <> "" AndAlso IO.Directory.Exists(txtFolderPathSource.Text.Trim) Then
            Dim filePattern As String = Me.tbExtensionFilter.Text.Trim
            If Trim(Me.tbExtensionFilter.Text) <> "" Then
                filePattern = Trim(Me.tbExtensionFilter.Text)
                If (filePattern.Contains(".")) = False Then
                    filePattern = "." + filePattern
                End If
            End If
            Dim fileFilter As String = Me.tbFileNameFilter.Text.Trim
            Me.lstFiles.DataSource = cFile.GetFileList(txtFolderPathSource.Text.Trim, fileFilter, filePattern)
        Else
            Me.lstFiles.DataSource = Nothing
        End If
    End Sub

    Private Sub tbFileNameFilter_TextChanged(sender As Object, e As EventArgs) Handles tbFileNameFilter.TextChanged

        If txtFolderPathSource.Text.Trim <> "" AndAlso IO.Directory.Exists(txtFolderPathSource.Text.Trim) Then
            Dim filePattern As String = Me.tbExtensionFilter.Text.Trim
            If Trim(Me.tbExtensionFilter.Text) <> "" Then
                filePattern = Trim(Me.tbExtensionFilter.Text)
                If (filePattern.Contains(".")) = False Then
                    filePattern = "." + filePattern
                End If
            End If
            Dim fileFilter As String = Me.tbFileNameFilter.Text.Trim
            Me.lstFiles.DataSource = cFile.GetFileList(txtFolderPathSource.Text.Trim, fileFilter, filePattern)
        Else
            Me.lstFiles.DataSource = Nothing
        End If
    End Sub

    Private Sub tbExtensionFilter_TextChanged(sender As Object, e As EventArgs) Handles tbExtensionFilter.TextChanged
        If txtFolderPathSource.Text.Trim <> "" AndAlso IO.Directory.Exists(txtFolderPathSource.Text.Trim) Then
            Dim filePattern As String = Me.tbExtensionFilter.Text.Trim
            If Trim(Me.tbExtensionFilter.Text) <> "" Then
                filePattern = Trim(Me.tbExtensionFilter.Text)
                If (filePattern.Contains(".")) = False Then
                    filePattern = "." + filePattern
                End If
            End If
            Dim fileFilter As String = Me.tbFileNameFilter.Text.Trim
            Me.lstFiles.DataSource = cFile.GetFileList(txtFolderPathSource.Text.Trim, fileFilter, filePattern)
        Else
            Me.lstFiles.DataSource = Nothing
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkCoordInfo_input.CheckedChanged
        If Me.chkCoordInfo_input.Checked Then
            Me.tbProj4_input.Enabled = True
        Else
            Me.tbProj4_input.Enabled = False
        End If
    End Sub

    Private Sub cbFileFormat_input_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFileFormat_input.SelectedIndexChanged
        If Me.cbFileFormat_input.Text = cGdal.GdalFormat.AAIGrid.ToString() Then
            Me.chkCoordInfo_input.Enabled = True
        End If
        If Me.cbFileFormat_input.Text = cGdal.GdalFormat.GTiff.ToString() Then
            Me.chkCoordInfo_input.Checked = False
            Me.chkCoordInfo_input.Enabled = False
        End If
    End Sub

    Private Sub btStartProcess_Click(sender As Object, e As EventArgs) Handles btStartProcess.Click
        mfPrograssBar = New fProgressBar
        mStopProgress = False
        Try
            Dim strProcessingMsg As String = ""
            Dim cellSizeResult As Single
            Dim baseGridHeader As gentle.cAscRasterHeader
            mfPrograssBar.GRMToolsPrograssBar.Maximum = mdtSourceFile.Rows.Count
            mfPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
            mfPrograssBar.labGRMToolsPrograssBar.Text = "Processing 0/" & CStr(mdtSourceFile.Rows.Count) & " raster file..."
            mfPrograssBar.Text = "Processing files"
            mfPrograssBar.Show()
            System.Windows.Forms.Application.DoEvents()
            mFileNamePrefix = Trim(Me.txtResultFilePrefix.Text)
            mFileNameTag = Trim(Me.txtResultFileTag.Text)

            If Me.txtDestinationFolderPath.Text = "" Then
                MsgBox("Destination path is not entered!!!", MsgBoxStyle.Critical)
                Exit Sub
            Else
                mstrDestinationFolderPath = Me.txtDestinationFolderPath.Text.Trim
            End If

            If cbFileFormat_input.Text = cGdal.GdalFormat.AAIGrid.ToString Then
                fileFormatInput = cGdal.GdalFormat.AAIGrid
            End If

            If cbFileFormat_input.Text = cGdal.GdalFormat.GTiff.ToString Then
                fileFormatInput = cGdal.GdalFormat.GTiff
            End If

            If cbFileFormat_output.Text = cGdal.GdalFormat.AAIGrid.ToString Then
                fileFormatOutput = cGdal.GdalFormat.AAIGrid
            End If

            If cbFileFormat_output.Text = cGdal.GdalFormat.GTiff.ToString Then
                fileFormatOutput = cGdal.GdalFormat.GTiff
            End If
            Dim selectedDT As gentle.cData.DataType = cData.GetDataTypeByName(Me.cbDataType.SelectedItem.ToString.Trim)
            Dim outputDataType As cGdal.GdalDataType = cGdal.GetGdalDataTypeFromGRMDataType(selectedDT)
            Dim bUseInputSRS As Boolean = False
            If Me.tbProj4_input.Enabled = True AndAlso Me.tbProj4_input.Text.Trim <> "" Then
                bUseInputSRS = True
            End If
            Dim srsInput As String = ""
            If bUseInputSRS = True Then
                srsInput = Me.tbProj4_input.Text.Trim
            End If
            Dim srsOutput As String = Me.tbProj4_output.Text.Trim

            For Each r As FilesDS.FilesRow In mdtSourceFile
                Dim sourceFPN As String
                Dim resultFName As String = ""
                Dim resultFPN As String = ""
                Dim resultFNWithoutExtension As String
                Dim prjFPNsource As String
                sourceFPN = Path.Combine(r.FilePath, r.FileName)
                resultFNWithoutExtension = mFileNamePrefix + IO.Path.GetFileNameWithoutExtension(r.FileName) + mFileNameTag
                prjFPNsource = Path.Combine(Path.GetDirectoryName(sourceFPN), Path.GetFileNameWithoutExtension(sourceFPN) + ".prj")

                If fileFormatInput = cGdal.GdalFormat.GTiff Then
                    srsInput = ""
                    If fileFormatOutput = cGdal.GdalFormat.GTiff Then
                        resultFPN = Path.Combine(mstrDestinationFolderPath, resultFNWithoutExtension + ".tif")
                    End If
                    If fileFormatOutput = cGdal.GdalFormat.AAIGrid Then
                        resultFPN = Path.Combine(mstrDestinationFolderPath, resultFNWithoutExtension + ".asc")
                    End If
                    cGdal.ConvertCoordSystem(sourceFPN, resultFPN, fileFormatOutput, srsOutput, outputDataType, srsInput)
                End If
                If fileFormatInput = cGdal.GdalFormat.AAIGrid Then
                    If fileFormatOutput = cGdal.GdalFormat.GTiff Then
                        resultFPN = Path.Combine(mstrDestinationFolderPath, resultFNWithoutExtension + ".tif")
                    End If

                    If fileFormatOutput = cGdal.GdalFormat.AAIGrid Then
                        resultFPN = Path.Combine(mstrDestinationFolderPath, resultFNWithoutExtension + ".asc")
                    End If
                    If bUseInputSRS = False AndAlso File.Exists(prjFPNsource) = False Then
                        MsgBox(String.Format("Source file ({0}) coordinate system info. was invalid.     ", sourceFPN), MsgBoxStyle.Exclamation)
                        mfPrograssBar.Close()
                        Exit Sub
                    End If
                    cGdal.ConvertCoordSystem(sourceFPN, resultFPN, fileFormatOutput, srsOutput, outputDataType, srsInput)
                End If

                mfPrograssBar.GRMToolsPrograssBar.Value = r.FileOrder
                mfPrograssBar.labGRMToolsPrograssBar.Text = strProcessingMsg + " " + CStr(r.FileOrder) + "/" & CStr(mdtSourceFile.Rows.Count) & " file..."
                System.Windows.Forms.Application.DoEvents()
                If File.Exists(resultFPN) = False Then
                    MsgBox(String.Format("An Error was occured.{0}Processing {1} {2}to {3} is failed.     ", vbCrLf, sourceFPN, vbCrLf, resultFPN), MsgBoxStyle.Exclamation)
                    mfPrograssBar.Close()
                    Exit Sub
                End If

                If mStopProgress = True Then
                    MsgBox("Process was stopped..   ", MsgBoxStyle.Exclamation)
                    mfPrograssBar.Close()
                    GC.Collect()
                    Exit Sub
                End If
                GC.Collect()
            Next
            mfPrograssBar.Close()
            MsgBox(strProcessingMsg + " " + CStr(mdtSourceFile.Rows.Count) + " files is completed!!!   ", MsgBoxStyle.Information)
            GC.Collect()
        Catch ex As Exception
            mfPrograssBar.Close()
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
            GC.Collect()
        End Try
    End Sub
End Class