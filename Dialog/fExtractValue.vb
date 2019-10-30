﻿Imports System.IO
Imports System.Text
Imports gentle

Public Class fExtractValue
    Private mbIsAllDataNormal As Boolean
    Private mDestinationFolderPath As String
    Private mDestinationFPN As String
    Private mfilePrefix As String
    Private mfileTag As String

    Private mdtSourceFile As New FilesDS.FilesDataTable
    Private meProcessingType As cVars.ProcessingType

    Private msb As StringBuilder
    Private mcolx As Integer = 0
    Private mrowy As Integer = 0
    Private mFPNbase As String = ""
    Private mBaseASC As cAscRasterReader
    Private mBaseCellsPos() As CellPosition

    Private mfileNagg As Integer = 0
    Private mNextFileOrderToStartAgg = 1
    Private mArrayToAcc(,) As Double
    Private mbAllowNegative As Boolean = False
    Private mNodataValue As Double = -9999
    Private mHeaderStringAll As String = ""

    Private mstartingLineIndex As Integer = 0
    Private mendingLindIndex As Integer = 0
    Private mstartingLineText As String = ""
    Private mendingLindText As String = ""
    Private mNumericOnly As Boolean = False
    Private mColidxsInTextFile() As Integer
    Private mUsingLineIndex As Boolean = False
    Private mSeparatorResult As cTextFile.ValueSeparator = cTextFile.ValueSeparator.NONE
    Private mSeparatorSource As cTextFile.ValueSeparator = cTextFile.ValueSeparator.NONE

    Private mStopProgress As Boolean = False
    Private WithEvents mfPrograssBar As fProgressBar

    Private Sub frmGRMToolsRainfallFileProcessing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mbIsAllDataNormal = True
        Me.dgvRainfallFileList.DataSource = mdtSourceFile
        SetDataGridViewForm()
    End Sub


    Private Sub btStartProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStartProcess.Click
        If Me.tbDest_FP_or_FPN.Text = "" Then
            MsgBox("Destination path or file name were not entered!!!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Me.rbValueFromASCIIFiles.Checked Then
            If Me.rbExtractFromAcell.Checked Then
                mDestinationFolderPath = ""
                mDestinationFPN = Me.tbDest_FP_or_FPN.Text.Trim
                If File.Exists(mDestinationFPN) = True Then File.Delete(mDestinationFPN)
                mcolx = Me.tbcolx.Text.Trim
                mrowy = Me.tbrowy.Text.Trim
                msb = New StringBuilder
            End If
            If Me.rbExtractCellsAverage.Checked Then
                mFPNbase = Me.tbBaseGridFile.Text.Trim
                mBaseASC = New cAscRasterReader(mFPNbase)
                mBaseCellsPos = cAscRasterReader.GetPositiveCellsPositions(mBaseASC)
                If mBaseCellsPos.Length < 1 Then
                    MsgBox("No positive cell.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                msb = New StringBuilder
                mbAllowNegative = Me.chkAllowNegativeInCalCellAverage.Checked
                mDestinationFPN = Me.tbDest_FP_or_FPN.Text.Trim
                If File.Exists(mDestinationFPN) = True Then File.Delete(mDestinationFPN)
            End If
        End If


        If Me.rbAccAscRaster.Checked Then
            If rbAccAllFiles.Checked Then
                mfileNagg = 0
                mDestinationFPN = Me.tbDest_FP_or_FPN.Text.Trim
                If File.Exists(mDestinationFPN) = True Then File.Delete(mDestinationFPN)
            End If
            If rbAggregate.Checked Then
                mfileNagg = Me.tbFileNumToAgg.Text.Trim
                mNextFileOrderToStartAgg = 1
                mDestinationFolderPath = Me.tbDest_FP_or_FPN.Text.Trim
            End If
            mbAllowNegative = Me.chkAllowNegativeInAcc.Checked
        End If

        If Me.rbValueFromTextFile.Checked Then
            mDestinationFolderPath = Me.tbDest_FP_or_FPN.Text.Trim
            mDestinationFPN = ""
            mcolx = 0
            mrowy = 0

            If Me.rbStartingIndex.Checked Then
                mUsingLineIndex = True
                If Me.tbStartingLineidx.Text.Trim = "" Then
                    mstartingLineIndex = 0
                Else
                    mstartingLineIndex = CInt(Me.tbStartingLineidx.Text.Trim)
                End If

                If Me.tbEndingLineidx.Text.Trim = "" Then
                    mendingLindIndex = 0
                Else
                    mendingLindIndex = CInt(Me.tbEndingLineidx.Text.Trim)
                End If
                mstartingLineText = ""
                mendingLindText = ""
            End If
            If Me.rbStartingLineText.Checked Then
                mUsingLineIndex = False
                mstartingLineIndex = 0
                mendingLindIndex = 0
                mstartingLineText = Me.tbStartingLineText.Text
                mendingLindText = Me.tbEndingLineText.Text
            End If

            mSeparatorSource = cTextFile.ValueSeparator.NONE
            If Me.rbSepTabSource.Checked Then mSeparatorSource = cTextFile.ValueSeparator.TAB
            If Me.rbSepCommaSource.Checked Then mSeparatorSource = cTextFile.ValueSeparator.COMMA
            If Me.rbSepSpaceSource.Checked Then mSeparatorSource = cTextFile.ValueSeparator.SPACE

            If Me.tbColidxInTextFile.Text.Trim = "" Then
                mColidxsInTextFile = New Integer() {-1}
            Else
                Dim strCols As String()
                strCols = Me.tbColidxInTextFile.Text.Trim.Split({","}, StringSplitOptions.RemoveEmptyEntries)
                mColidxsInTextFile = strCols.ToList().ConvertAll(Function(x) Convert.ToInt32(x)).ToArray()
                'mColidxInTextFile = CInt(Me.tbColidxInTextFile.Text.Trim)
            End If

            mNumericOnly = Me.chkOnlyNumericValue.Checked
            If Me.rbSepTabResult.Checked Then mSeparatorResult = cTextFile.ValueSeparator.TAB
            If Me.rbSepCommaResult.Checked Then mSeparatorResult = cTextFile.ValueSeparator.COMMA
            If Me.rbSepSpaceResult.Checked Then mSeparatorResult = cTextFile.ValueSeparator.SPACE

            If Directory.Exists(mDestinationFolderPath) = False Then
                MsgBox("Destination folder is not exist!!!  ", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        If Me.dgvRainfallFileList.RowCount > 0 Then
            Call DataProcessingManager()
        Else
            MsgBox("Source file was not selected.   ", MsgBoxStyle.Information)
        End If
    End Sub



    Private Sub btShowColumns_Click(sender As Object, e As EventArgs) Handles btShowColumns.Click

        If mdtSourceFile.Rows.Count < 1 Then
            MsgBox("Source file was not selected.   ", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim r As FilesDS.FilesRow
        r = mdtSourceFile.Rows(0)
        mSeparatorSource = cTextFile.ValueSeparator.NONE
        If Me.rbSepTabSource.Checked Then mSeparatorSource = cTextFile.ValueSeparator.TAB
        If Me.rbSepCommaSource.Checked Then mSeparatorSource = cTextFile.ValueSeparator.COMMA
        If Me.rbSepSpaceSource.Checked Then mSeparatorSource = cTextFile.ValueSeparator.SPACE
        Dim sourceFPN As String = Path.Combine(r.FilePath, r.FileName)
        Dim sepsSource As String() = cTextFile.GetTextFileValueSeparator(mSeparatorSource)
        Dim Lines As String() = System.IO.File.ReadAllLines(sourceFPN)
        Dim texts As String()
        If Me.rbStartingIndex.Checked Then
            Dim Lidx As Integer = CInt(Me.tbStartingLineidx.Text)
            If Lidx < 0 Then Lidx = 0
            texts = Lines(Lidx).Split(sepsSource, StringSplitOptions.RemoveEmptyEntries)
        Else
            For Lidx As Integer = 0 To Lines.Length - 1

                If Lines(Lidx).Contains(mstartingLineText) Then
                    texts = Lines(Lidx).Split(sepsSource, StringSplitOptions.RemoveEmptyEntries)
                End If
            Next
            texts = Nothing
        End If

        Dim sb As New StringBuilder
        For idx As Integer = 0 To texts.Length - 1
            sb.Append(idx.ToString() + ", " + texts(idx) + vbCrLf)
        Next

        Dim f As New fHelp
        f.tbTextToShow.Text = sb.ToString()
        f.tbTextToShow.Font = System.Drawing.SystemFonts.DefaultFont
        f.tbTextToShow.Select(Len(sb.ToString()), 0)
        f.Show()
    End Sub

    Sub DataProcessingManager()
        mfPrograssBar = New fProgressBar
        mStopProgress = False
        Try
            Dim rFPN_First As String

            If rbValueFromTextFile.Checked Then
                Dim r0 As FilesDS.FilesRow
                r0 = mdtSourceFile.Rows(0)
                Dim sFPN As String = Path.Combine(r0.FilePath, r0.FileName)
                Dim rFNWithoutExtension As String = mfilePrefix + IO.Path.GetFileNameWithoutExtension(r0.FileName) + mfileTag
                rFPN_First = mDestinationFolderPath + "\" + rFNWithoutExtension + ".out"
            Else
                rFPN_First = mDestinationFPN
            End If
            If File.Exists(rFPN_First) Then
                Dim mbr As MsgBoxResult = MsgBox(String.Format("Output file [{0}] is already exist. Overwrite and contiune? ", rFPN_First), MessageBoxButtons.YesNo+ MsgBoxStyle.Exclamation)
                If mbr = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            Dim strProcessingMsg As String = ""
            mfPrograssBar.GRMToolsPrograssBar.Maximum = mdtSourceFile.Rows.Count
            mfPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
            mfPrograssBar.labGRMToolsPrograssBar.Text = "Processing 0/" & CStr(mdtSourceFile.Rows.Count) & " file..."
            mfPrograssBar.Text = "Processing files"
            mfPrograssBar.Show()
            System.Windows.Forms.Application.DoEvents()
            meProcessingType = GetProcessType()
            mfilePrefix = Trim(Me.tbFileNameHead.Text)
            mfileTag = Trim(Me.tbFileNameTail.Text)

            For Each r As FilesDS.FilesRow In mdtSourceFile
                Dim sourceFPN As String
                Dim resultFName As String = ""
                Dim resultFPN As String = ""
                Dim resultFNWithoutExtension As String
                sourceFPN = Path.Combine(r.FilePath, r.FileName)
                resultFNWithoutExtension = mfilePrefix + IO.Path.GetFileNameWithoutExtension(r.FileName) + mfileTag

                Select Case meProcessingType
                    Case cVars.ProcessingType.ExtractAcellValueFromASCIIFile
                        strProcessingMsg = "Extracting"
                        Dim ascfile As New cAscRasterReader(sourceFPN)
                        Dim avalue As String = ascfile.ValueFromTL(mcolx, mrowy).ToString
                        msb.Append(avalue + vbCrLf)

                    Case cVars.ProcessingType.ExtractCellsAverageFromASCIIfile
                        strProcessingMsg = "Extracting"
                        Dim ascfile As New cAscRasterReader(sourceFPN)
                        If cAscRasterReader.CheckTwoGridLayerExtentUsingRowAndColNum(mBaseASC, ascfile) = True Then
                            Dim avalue As Double = cAscRasterReader.CellsAverageValue(mBaseCellsPos, ascfile, mbAllowNegative)
                            msb.Append(avalue.ToString + vbCrLf)
                        Else
                            MsgBox(String.Format("Current asc file {0} has different region from base asc file. ", ascfile), MsgBoxStyle.Exclamation)
                            mfPrograssBar.Close()
                            Exit Sub
                        End If

                    Case cVars.ProcessingType.AccAllAsc
                        strProcessingMsg = "Accumulating"
                        Dim ascfile As New cAscRasterReader(sourceFPN)
                        If r.FileOrder = 1 Then
                            mArrayToAcc = New Double(ascfile.Header.numberCols - 1, ascfile.Header.numberRows - 1) {}
                            mArrayToAcc = ascfile.ValuesFromTL
                            mNodataValue = ascfile.Header.nodataValue
                            mHeaderStringAll = ascfile.HeaderStringAll
                        Else
                            mArrayToAcc = cTextFile.addTwoDimArrayOfASCraster(mArrayToAcc, ascfile.ValuesFromTL,
                                                                              mNodataValue, mbAllowNegative)
                        End If

                    Case cVars.ProcessingType.AggAscFiles
                        strProcessingMsg = "Aggregating"
                        Dim ascfile As New cAscRasterReader(sourceFPN)
                        If r.FileOrder = mNextFileOrderToStartAgg Then
                            mArrayToAcc = New Double(ascfile.Header.numberCols - 1, ascfile.Header.numberRows - 1) {}
                            mArrayToAcc = ascfile.ValuesFromTL
                            mNodataValue = ascfile.Header.nodataValue
                            mHeaderStringAll = ascfile.HeaderStringAll
                            mNextFileOrderToStartAgg = mNextFileOrderToStartAgg + mfileNagg
                        Else
                            mArrayToAcc = cTextFile.addTwoDimArrayOfASCraster(mArrayToAcc, ascfile.ValuesFromTL,
                                                                              mNodataValue, mbAllowNegative)
                        End If

                        If mNextFileOrderToStartAgg - 1 = r.FileOrder OrElse r.FileOrder = mdtSourceFile.Rows.Count Then
                            resultFPN = mDestinationFolderPath + "\" + resultFNWithoutExtension + IO.Path.GetExtension(r.FileName)
                            cTextFile.MakeASCTextFile(resultFPN, mHeaderStringAll, mArrayToAcc, -1, mNodataValue)
                        End If

                    Case cVars.ProcessingType.ExtractValueFromTextFile
                        resultFPN = mDestinationFolderPath + "\" + resultFNWithoutExtension + ".out"
                        If mUsingLineIndex = True Then
                            cTextFile.MakeTextFileUisngTextInTextFile(sourceFPN, resultFPN, mstartingLineIndex,
                                                                      mendingLindIndex, mColidxsInTextFile, mSeparatorSource,
                                                                      mNumericOnly, mSeparatorResult)
                        Else
                            cTextFile.MakeTextFileUisngTextInTextFile(sourceFPN, resultFPN, mstartingLineText,
                                                                      mendingLindText, mColidxsInTextFile, mSeparatorSource,
                                                                      mNumericOnly, mSeparatorResult)
                        End If
                    Case Else
                        strProcessingMsg = ""
                End Select
                mfPrograssBar.GRMToolsPrograssBar.Value = r.FileOrder
                mfPrograssBar.labGRMToolsPrograssBar.Text = strProcessingMsg + " " + CStr(r.FileOrder) + "/" & CStr(mdtSourceFile.Rows.Count) & " file..."
                System.Windows.Forms.Application.DoEvents()
                If meProcessingType = cVars.ProcessingType.ExtractValueFromTextFile AndAlso File.Exists(resultFPN) = False Then
                    MsgBox(String.Format("An Error was occured.{0}Converting {1} {2}to {3} is failed.     ", vbCrLf, sourceFPN, vbCrLf, resultFPN), MsgBoxStyle.Exclamation)
                    mfPrograssBar.Close()
                    Exit Sub
                End If
                If mStopProgress = True Then
                    MsgBox("Process was stopped..   ", MsgBoxStyle.Exclamation)
                    mfPrograssBar.Close()
                    Exit Sub
                End If

            Next

            If meProcessingType = cVars.ProcessingType.ExtractAcellValueFromASCIIFile OrElse
               meProcessingType = cVars.ProcessingType.ExtractCellsAverageFromASCIIfile Then
                File.AppendAllText(mDestinationFPN, msb.ToString())
            End If

            If meProcessingType = cVars.ProcessingType.AccAllAsc Then
                cTextFile.MakeASCTextFile(mDestinationFPN, mHeaderStringAll, mArrayToAcc, -1, mNodataValue)
            End If

            mfPrograssBar.Close()
            'If bIsConvertingError = False Then
            MsgBox(strProcessingMsg + " " + CStr(mdtSourceFile.Rows.Count) + " files is completed!!!   ", MsgBoxStyle.Information)
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
        If Me.rbValueFromASCIIFiles.Checked Then
            If Me.rbExtractFromAcell.Checked Then Return cVars.ProcessingType.ExtractAcellValueFromASCIIFile
            If Me.rbExtractCellsAverage.Checked Then Return cVars.ProcessingType.ExtractCellsAverageFromASCIIfile
        End If
        If rbAccAscRaster.Checked Then
            If rbAccAllFiles.Checked Then Return cVars.ProcessingType.AccAllAsc
            If rbAggregate.Checked Then Return cVars.ProcessingType.AggAscFiles
        End If
        If Me.rbValueFromTextFile.Checked Then Return cVars.ProcessingType.ExtractValueFromTextFile
        Return pt
    End Function


    Sub SetDataGridViewForm()
        With Me.dgvRainfallFileList
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


    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        MyBase.Close()
    End Sub


    Private Sub btOpenDestinationFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOpenDestFolderOrFile.Click
        If Me.rbValueFromASCIIFiles.Checked Then
            Dim fb As New SaveFileDialog
            fb.DefaultExt = "txt"
            fb.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            If fb.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.tbDest_FP_or_FPN.Text = fb.FileName
            End If
        Else
            Dim fb As New FolderBrowserDialog
            If fb.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.tbDest_FP_or_FPN.Text = fb.SelectedPath
            End If
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
        Me.tbFileNameHead.Enabled = True
        Me.tbFileNameTail.Enabled = True
        Me.btOpenDestFolderOrFile.Enabled = True
        Me.btOpenDestFolderOrFile.Text = "Destination folder"
        Me.tbDest_FP_or_FPN.Enabled = True
        Me.gbExtractFromASCII.Enabled = False
        Me.gbLineCon.Enabled = False
        Me.gbColCon.Enabled = False
        Me.gbResultValue.Enabled = False
        Me.gbAcc.Enabled = False
        Me.rbAccAllFiles.Enabled = True
        Me.rbAggregate.Enabled = True

        If Me.rbValueFromASCIIFiles.Checked = True Then
            'Me.tbStartingLineidx.Text = ""
            'Me.tbEndingLineidx.Text = ""
            Me.tbStartingLineText.Text = ""
            Me.tbEndingLineText.Text = ""
            Me.gbExtractFromASCII.Enabled = True
            Me.tbFileNumToAgg.Text = ""
            Me.tbFileNameHead.Text = ""
            Me.tbFileNameTail.Text = ""
            Me.tbFileNameHead.Enabled = False
            Me.tbFileNameTail.Enabled = False
            Me.btOpenDestFolderOrFile.Text = "Destination file"
        End If

        If Me.rbAccAscRaster.Checked Then
            Me.gbAcc.Enabled = True
            'Me.tbStartingLineidx.Text = ""
            'Me.tbEndingLineidx.Text = ""
            Me.tbStartingLineText.Text = ""
            Me.tbEndingLineText.Text = ""
            Me.tbFileNameHead.Text = ""
            Me.tbFileNameTail.Text = ""
            Me.tbFileNameHead.Enabled = False
            Me.tbFileNameTail.Enabled = False
        End If

        If Me.rbValueFromTextFile.Checked Then
            Me.gbLineCon.Enabled = True
            Me.gbColCon.Enabled = True
            Me.gbResultValue.Enabled = True
            Me.tbcolx.Text = ""
            Me.tbrowy.Text = ""
            Me.tbFileNumToAgg.Text = ""
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


    Private Sub rbValueFromASCIIFiles_CheckedChanged(sender As Object, e As EventArgs) Handles rbValueFromASCIIFiles.CheckedChanged
        Call Me.SetProcessingOptionalIU()
    End Sub

    Private Sub rbAccAasRaster_CheckedChanged(sender As Object, e As EventArgs) Handles rbAccAscRaster.CheckedChanged
        Call Me.SetProcessingOptionalIU()
    End Sub

    Private Sub rbValueFromTextFile_CheckedChanged(sender As Object, e As EventArgs) Handles rbValueFromTextFile.CheckedChanged
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
            Dim items As String() = obj.GetFilesAndCheckDuplication(lstFiles, bSelectedFile, strFilePath, mdtSourceFile, "FileName", "FilePath")
            If obj.DuplicationfileProcessMessage = MsgBoxResult.Cancel Then Exit Sub
            obj.AddToDataTable(items, strFilePath, mdtSourceFile, "FileOrder", "FileName", "FilePath")
        End If
    End Sub

    Private Sub rbStartingIndex_CheckedChanged(sender As Object, e As EventArgs)
        setUIingbExtractFromTextFile()
    End Sub
    Private Sub rbStartingLineText_CheckedChanged(sender As Object, e As EventArgs)
        setUIingbExtractFromTextFile()
    End Sub
    Private Sub setUIingbExtractFromTextFile()
        Me.tbStartingLineidx.Enabled = True
        Me.tbStartingLineText.Enabled = True
        Me.tbEndingLineidx.Enabled = True
        Me.tbEndingLineText.Enabled = True
        If rbStartingIndex.Checked Then
            Me.tbStartingLineText.Text = ""
            Me.tbStartingLineText.Enabled = False
            Me.tbEndingLineText.Text = ""
            Me.tbEndingLineText.Enabled = False
        End If
        If rbStartingLineText.Checked Then
            Me.tbStartingLineidx.Text = ""
            Me.tbStartingLineidx.Enabled = False
            Me.tbEndingLineidx.Text = ""
            Me.tbEndingLineidx.Enabled = False
        End If
    End Sub

    Private Sub rbAccAllFiles_CheckedChanged(sender As Object, e As EventArgs) Handles rbAccAllFiles.CheckedChanged
        setUIingbAcc()
    End Sub


    Private Sub rbAggregate_CheckedChanged(sender As Object, e As EventArgs) Handles rbAggregate.CheckedChanged
        setUIingbAcc()
    End Sub


    Private Sub setUIingbAcc()
        Me.tbFileNumToAgg.Enabled = True
        Me.chkAllowNegativeInAcc.Enabled = True
        Me.tbFileNameHead.Enabled = False
        Me.tbFileNameTail.Enabled = False
        Me.btOpenDestFolderOrFile.Text = "Destination folder"
        If rbAccAllFiles.Checked Then
            Me.tbFileNumToAgg.Text = ""
            Me.tbFileNumToAgg.Enabled = False
            Me.chkAllowNegativeInAcc.Checked = False
            Me.chkAllowNegativeInAcc.Enabled = False
            Me.btOpenDestFolderOrFile.Text = "Destination file"
        End If

        If rbAggregate.Checked Then
            Me.tbFileNameHead.Enabled = True
            Me.tbFileNameTail.Enabled = True
        End If

    End Sub

    Private Sub btHelpExtractCellsAverageValue_Click(sender As Object, e As EventArgs) Handles btHelpExtractCellsAverageValue.Click
        Dim f As New fHelp
        Dim helpString As String = "Calculate a average value from the cells located in the base raster file selected." + vbCrLf
        helpString = helpString + "In the base raster file, the target cells have to be defined as positive value." + vbCrLf
        helpString = helpString + "The input raster files and the base raster file must have same extent and spatial resolution."
        f.tbTextToShow.Text = helpString
        'f.tbTextToShow.ReadOnly = True
        f.tbTextToShow.Font = System.Drawing.SystemFonts.DefaultFont
        f.tbTextToShow.Select(Len(helpString), 0)
        f.Show()
    End Sub

    Private Sub btSelectBaseRasterFile_Click(sender As Object, e As EventArgs) Handles btSelectBaseRasterFile.Click
        Dim fb As New OpenFileDialog
        If fb.ShowDialog() = DialogResult.OK Then
            tbBaseGridFile.Text = fb.FileName
        End If
    End Sub

    Private Sub rbExtractFromAcell_CheckedChanged(sender As Object, e As EventArgs) Handles rbExtractFromAcell.CheckedChanged

        setUIinGbExtractFromASC()
    End Sub


    Private Sub setUIinGbExtractFromASC()
        Me.tbcolx.Enabled = True
        Me.tbrowy.Enabled = True
        Me.btSelectBaseRasterFile.Enabled = True
        Me.tbBaseGridFile.Enabled = True
        Me.btHelpExtractCellsAverageValue.Enabled = True
        Me.chkAllowNegativeInCalCellAverage.Enabled = True

        If rbExtractFromAcell.Checked Then
            Me.tbBaseGridFile.Text = ""
            Me.tbBaseGridFile.Enabled = False
            Me.btHelpExtractCellsAverageValue.Enabled = False
            Me.btSelectBaseRasterFile.Enabled = False
            Me.chkAllowNegativeInCalCellAverage.Checked = False
            Me.chkAllowNegativeInCalCellAverage.Enabled = False
        End If

        If rbExtractCellsAverage.Checked Then
            Me.tbcolx.Text = ""
            Me.tbrowy.Text = ""
            Me.tbcolx.Enabled = False
            Me.tbrowy.Enabled = False
        End If

    End Sub

    Private Sub rbExtractCellsAverage_CheckedChanged(sender As Object, e As EventArgs) Handles rbExtractCellsAverage.CheckedChanged
        setUIinGbExtractFromASC()
    End Sub

    Private Sub mProcess_StopProcess(ByVal sender As fProgressBar) Handles mfPrograssBar.StopProcess
        mStopProgress = True
    End Sub

    Private Sub rbStartingLineText_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbStartingLineText.CheckedChanged
        setUIinGbLineCon()
    End Sub

    Private Sub rbStartingIndex_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbStartingIndex.CheckedChanged
        setUIinGbLineCon()
    End Sub

    Private Sub setUIinGbLineCon()
        If Me.rbValueFromTextFile.Checked Then
            If Me.rbStartingLineText.Checked Then
                Me.tbStartingLineText.Enabled = True
                Me.tbEndingLineText.Enabled = True
                Me.tbStartingLineidx.Enabled = False
                Me.tbEndingLineidx.Enabled = False
            End If

            If Me.rbStartingIndex.Checked Then
                Me.tbStartingLineText.Enabled = False
                Me.tbEndingLineText.Enabled = False
                Me.tbStartingLineidx.Enabled = True
                Me.tbEndingLineidx.Enabled = True
            End If
        End If
    End Sub
End Class