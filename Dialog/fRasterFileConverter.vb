Imports System.IO
Imports gentle

Public Class fRasterFileConverter
    Private mbIsAllDataNormal As Boolean
    Private mstrBaseExtendFPN As String
    Private mstrDestinationFolderPath As String
    Private mFileNamePrefix As String
    Private mFileNameTag As String
    Private mBandN As Integer = 1
    Private mCutDecimalPart As Boolean = False
    Private mDecimalPartLength As Integer = 0

    Private mdtSourceFile As New FilesDS.FilesDataTable
    Private meProcessingType As cVars.ProcessingType
    Private mRendererRangeType As gentle.cImg.RendererRange
    Private mRendererIntervalType As gentle.cImg.RendererIntervalType
    Private mRendererType As cImg.RendererType = cImg.RendererType.Risk
    'Private mRendererClassType As cImg.RendererClassType = cImg.RendererClassType.Differentinterval
    Private mRendererMinValue As Double = 0
    Private mRendererMaxValue As Double = 0

    Private mFilePattern As cFile.FilePattern
    Private mResamplingMethod As cGdal.GdalResamplingMethod
    Private mFileFormatResampleClip As cGdal.GdalFormat

    Private mStopProgress As Boolean = False
    Private WithEvents mfPrograssBar As fProgressBar

    Private Sub frmGRMToolsRainfallFileProcessing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mbIsAllDataNormal = True
        Call InitializeComboBox()
        Me.dgvFileList.DataSource = mdtSourceFile
        SetDataGridViewForm()
    End Sub


    Private Sub btStartProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStartProcess.Click
        If Me.chkBaseGrid.Checked = True Then
            mstrBaseExtendFPN = Me.tbBaseGridFile.Text.Trim
            If mstrBaseExtendFPN = "" Then
                MsgBox("Base extend Grid layer is not selected!!!", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Else
            mstrBaseExtendFPN = ""
        End If
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

        If Me.rbResample.Checked = True And Me.chkBaseGrid.Checked = True And Me.chkResampleSize.Checked = True Then
            MsgBox("Select just one cell size information(base extent grid layer or resampling cell size).   ", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.chkResampleSize.Checked = True And Me.rbResample.Checked = True Then
            If IsNumeric(Me.txtResampleCellSize.Text) = False Or Trim(Me.txtResampleCellSize.Text) = "" Then
                MsgBox("Cell size is invalid.   ", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If
        If (Me.rbConvertGTiffToASCii.Checked OrElse Me.rbConvertGribToASCii.Checked) AndAlso Me.tbBandN.Enabled = True Then
            If Me.tbBandN.Text.Trim <> "" Then
                Dim outv As Integer
                If Integer.TryParse(Me.tbBandN.Text.Trim, outv) = True Then
                    mBandN = outv
                End If
            Else
                mBandN = 1
            End If
        End If

        mResamplingMethod = Nothing
        If Me.cbResamplingMethod.Enabled = True Then _
            mResamplingMethod = cGdal.GetGdalResamplingMethodByText(Me.cbResamplingMethod.Text.Trim)
        mFileFormatResampleClip = cGdal.GdalFormat.AAIGrid
        'If Me.cbFileFormat.Enabled = True Then _
        '    mFileFormatResampleClip = cGdal.GetGdalFileFormatByText(Me.cbFileFormat.Text.Trim)

        If Me.chkDecimalLength.Checked AndAlso Me.tbDecimalPartN.Text.Trim <> "" Then
            Dim dn As Integer
            If Integer.TryParse(Me.tbDecimalPartN.Text.Trim, dn) = True Then
                mDecimalPartLength = dn
                mCutDecimalPart = True
            Else
                mDecimalPartLength = -1
                mCutDecimalPart = False
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
            Dim cellSizeResult As Single
            Dim baseGridHeader As gentle.cAscRasterHeader ' MapWinGIS.Grid
            mfPrograssBar.GRMToolsPrograssBar.Maximum = mdtSourceFile.Rows.Count
            mfPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
            mfPrograssBar.labGRMToolsPrograssBar.Text = "Processing 0/" & CStr(mdtSourceFile.Rows.Count) & " raster file..."
            mfPrograssBar.Text = "Processing files"
            mfPrograssBar.Show()
            System.Windows.Forms.Application.DoEvents()
            meProcessingType = GetProcessType()
            If meProcessingType = cVars.ProcessingType.Resample OrElse meProcessingType = cVars.ProcessingType.ClipAndResample Then
                If Me.chkBaseGrid.Checked = True Then
                    baseGridHeader = cAscRasterReader.GetHeaderInfo(mstrBaseExtendFPN)
                    cellSizeResult = CSng(baseGridHeader.cellsize)
                Else
                    Dim r As FilesDS.FilesRow = CType(mdtSourceFile.Rows(0), FilesDS.FilesRow)
                    Dim bfpn As String = Path.Combine(r.FilePath, r.FileName)
                    baseGridHeader = cAscRasterReader.GetHeaderInfo(bfpn)

                    cellSizeResult = CSng(baseGridHeader.cellsize)
                End If
                If Me.chkResampleSize.Checked = True AndAlso Me.txtResampleCellSize.Text.Trim <> "" Then
                    cellSizeResult = CSng(Trim(Me.txtResampleCellSize.Text))
                End If
            Else
                baseGridHeader = Nothing
            End If

            Dim strTxtToFind As String = ""
            Dim strTxtToReplace As String = ""
            Dim strStartingDateTime As String = ""
            Dim outputTimeStep As Integer = 0
            mFileNamePrefix = Trim(Me.txtResultFilePrefix.Text)
            mFileNameTag = Trim(Me.txtResultFileTag.Text)

            Dim selectedDT As gentle.cData.DataType = cData.GetDataTypeByName(Me.cbODataType.SelectedItem.ToString.Trim)
            Dim oDataType As cGdal.GdalDataType = cGdal.GetGdalDataTypeFromGRMDataType(selectedDT)

            'Dim bIsConvertingError As Boolean = False
            For Each r As FilesDS.FilesRow In mdtSourceFile
                Dim sourceFPN As String
                Dim resultFName As String = ""
                Dim resultFPN As String = ""
                Dim resultFNWithoutExtension As String
                Dim prjFPNsource As String
                sourceFPN = Path.Combine(r.FilePath, r.FileName)
                resultFNWithoutExtension = mFileNamePrefix + IO.Path.GetFileNameWithoutExtension(r.FileName) + mFileNameTag
                prjFPNsource = Path.Combine(Path.GetDirectoryName(sourceFPN), Path.GetFileNameWithoutExtension(sourceFPN) + ".prj")
                Dim tmpResultFPN As String = ""
                Select Case meProcessingType
                    Case cVars.ProcessingType.ASCiiToGTiff
                        strProcessingMsg = "Converting"
                        resultFPN = mstrDestinationFolderPath + "\" + resultFNWithoutExtension + ".tif"
                        Call cGdal.ConvertASCIItoGTIFF(sourceFPN, resultFPN, oDataType)
                    Case cVars.ProcessingType.GTiffToASCii, cVars.ProcessingType.GribToASCii
                        strProcessingMsg = "Converting"
                        resultFPN = mstrDestinationFolderPath + "\" + resultFNWithoutExtension + ".asc"
                        If mCutDecimalPart = True Then
                            tmpResultFPN = mstrDestinationFolderPath + "\" + resultFNWithoutExtension + "_tmp.asc"
                            Dim tmpPrjFPN As String = Replace(tmpResultFPN, ".asc", ".prj")

                            Call cGdal.ConvertGtiffAndGribToASCII(sourceFPN, tmpResultFPN, mBandN, oDataType)
                            Dim ascDS As New cAscRasterReader(tmpResultFPN)
                            Call cTextFile.MakeASCTextFile(resultFPN, ascDS.HeaderStringAll, ascDS.ValuesFromTL, mDecimalPartLength, ascDS.Header.nodataValue)
                            If File.Exists(tmpResultFPN) = True Then File.Delete(tmpResultFPN)
                            If File.Exists(tmpPrjFPN) = True Then File.Delete(tmpPrjFPN)
                        Else
                                Call cGdal.ConvertGtiffAndGribToASCII(sourceFPN, resultFPN, mBandN, oDataType)
                        End If

                    Case cVars.ProcessingType.ASCiiToImg
                        strProcessingMsg = "Converting"
                        resultFPN = mstrDestinationFolderPath + "\" + resultFNWithoutExtension + ".png"
                        Dim imgMaker As New gentle.cImg(mRendererType)
                        Call imgMaker.MakeImgFileUsingASCfileFromTL_InParallel(sourceFPN, resultFPN, mRendererIntervalType, mRendererRangeType, mRendererMinValue, mRendererMaxValue)

                    Case cVars.ProcessingType.ClipAndResample
                        strProcessingMsg = "Clipping"
                        If mFileFormatResampleClip = cGdal.GdalFormat.GTiff Then _
                            resultFPN = Path.Combine(mstrDestinationFolderPath, resultFNWithoutExtension + ".tif")
                        If mFileFormatResampleClip = cGdal.GdalFormat.AAIGrid Then _
                            resultFPN = Path.Combine(mstrDestinationFolderPath, resultFNWithoutExtension + ".asc")
                        If mCutDecimalPart = True Then
                            tmpResultFPN = mstrDestinationFolderPath + "\" + resultFNWithoutExtension + "_tmp.asc"
                            Call cGdal.ClipGridAndResample(baseGridHeader, sourceFPN, tmpResultFPN, cellSizeResult, mResamplingMethod, mFileFormatResampleClip, oDataType)
                            Dim ascDS As New cAscRasterReader(tmpResultFPN)
                            Call cTextFile.MakeASCTextFile(resultFPN, ascDS.HeaderStringAll, ascDS.ValuesFromTL, mDecimalPartLength, ascDS.Header.nodataValue)
                            If File.Exists(tmpResultFPN) = True Then File.Delete(tmpResultFPN)
                        Else
                            Call cGdal.ClipGridAndResample(baseGridHeader, sourceFPN, resultFPN, cellSizeResult, mResamplingMethod, mFileFormatResampleClip, oDataType)
                        End If
                        Dim prjFPNout As String = Path.Combine(Path.GetDirectoryName(resultFPN), Path.GetFileNameWithoutExtension(resultFPN) + ".prj")
                        If File.Exists(prjFPNsource) = True Then
                            If File.Exists(prjFPNout) = True Then File.Delete(prjFPNout)
                            File.Copy(prjFPNsource, prjFPNout)
                        End If

                    Case cVars.ProcessingType.Resample
                        strProcessingMsg = "Resampling"
                        If mFileFormatResampleClip = cGdal.GdalFormat.GTiff Then _
                            resultFPN = Path.Combine(mstrDestinationFolderPath, resultFNWithoutExtension + ".tif")
                        If mFileFormatResampleClip = cGdal.GdalFormat.AAIGrid Then _
                            resultFPN = Path.Combine(mstrDestinationFolderPath, resultFNWithoutExtension + ".asc")
                        If mCutDecimalPart = True Then
                            tmpResultFPN = mstrDestinationFolderPath + "\" + resultFNWithoutExtension + "_tmp.asc"
                            cGdal.GridResample(baseGridHeader, sourceFPN, tmpResultFPN, cellSizeResult, mResamplingMethod, mFileFormatResampleClip, oDataType)
                            Dim ascDS As New cAscRasterReader(tmpResultFPN)
                            Call cTextFile.MakeASCTextFile(resultFPN, ascDS.HeaderStringAll, ascDS.ValuesFromTL, mDecimalPartLength, ascDS.Header.nodataValue)
                            If File.Exists(tmpResultFPN) = True Then File.Delete(tmpResultFPN)
                        Else
                            cGdal.GridResample(baseGridHeader, sourceFPN, resultFPN, cellSizeResult, mResamplingMethod, mFileFormatResampleClip, oDataType)
                        End If
                        Dim prjFPNout As String = Path.Combine(Path.GetDirectoryName(resultFPN), Path.GetFileNameWithoutExtension(resultFPN) + ".prj")
                        If File.Exists(prjFPNsource) = True Then
                            If File.Exists(prjFPNout) = True Then File.Delete(prjFPNout)
                            File.Copy(prjFPNsource, prjFPNout)
                        End If

                    Case cVars.ProcessingType.Gdalinfo
                        strProcessingMsg = "Get info..."
                        resultFPN = Path.Combine(mstrDestinationFolderPath, resultFNWithoutExtension + "_info" + ".txt")
                        cGdal.GetRasterInfo(sourceFPN, resultFPN)
                    Case Else
                        strProcessingMsg = ""
                End Select
                mfPrograssBar.GRMToolsPrograssBar.Value = r.FileOrder
                mfPrograssBar.labGRMToolsPrograssBar.Text = strProcessingMsg + " " + CStr(r.FileOrder) + "/" & CStr(mdtSourceFile.Rows.Count) & " file..."
                System.Windows.Forms.Application.DoEvents()
                If File.Exists(resultFPN) = False Then
                    MsgBox(String.Format("An Error was occured.{0}Processing {1} {2}to {3} is failed.     ", vbCrLf, sourceFPN, vbCrLf, resultFPN), MsgBoxStyle.Exclamation)
                    'bIsConvertingError = True
                    mfPrograssBar.Close()
                    Exit Sub
                End If
                If File.Exists(resultFPN + ".aux.xml") Then
                    File.Delete(resultFPN + ".aux.xml")
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
            'If bIsConvertingError = False Then
            MsgBox(strProcessingMsg + " " + CStr(mdtSourceFile.Rows.Count) + " files is completed!!!   ", MsgBoxStyle.Information)
            GC.Collect()
            'Else
            '    MsgBox("Some errors were occured while converting file(s).   ", MsgBoxStyle.Exclamation)
            'End If
        Catch ex As Exception
            mfPrograssBar.Close()
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
            GC.Collect()
        End Try
    End Sub

    Private Function GetProcessType() As cVars.ProcessingType
        Dim pt As cVars.ProcessingType = Nothing
        If Me.rbConvertGTiffToASCii.Checked Then pt = cVars.ProcessingType.GTiffToASCii
        If Me.rbConvertGribToASCii.Checked Then pt = cVars.ProcessingType.GribToASCii
        If Me.rbConvertASCiiToGTiff.Checked Then pt = cVars.ProcessingType.ASCiiToGTiff
        If Me.rbConvertASCtoImg.Checked Then pt = cVars.ProcessingType.ASCiiToImg
        If Me.rbClipAndResample.Checked Then pt = cVars.ProcessingType.ClipAndResample
        If Me.rbResample.Checked Then pt = cVars.ProcessingType.Resample
        If Me.rbGdalinfo.Checked Then pt = cVars.ProcessingType.Gdalinfo
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


    Private Sub InitializeComboBox()
        'cbFileFormat.DataSource = [Enum].GetNames(GetType(cGdal.GdalFormat))
        'cbFileFormat.Text = cGdal.GdalFormat.GTiff.ToString 'cGdal.GetGdalFormatName(cGdal.GdalFormat.GTiff)
        cbResamplingMethod.DataSource = [Enum].GetNames(GetType(cGdal.GdalResamplingMethod))
        cbResamplingMethod.Text = cGdal.GdalResamplingMethod.bilinear.ToString ' cGdal.GetGdalResamplingMethodName(cGdal.GdalResamplingMethod.bilinear)
        cbODataType.DataSource = [Enum].GetNames(GetType(cData.DataType))
        cbODataType.Text = gentle.cData.DataType.DTSingle.ToString 'cGRM.GetGRMDataTypeName(cGRM.DataType.DTSingle)
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


    Private Sub chkBaseGrid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBaseGrid.CheckedChanged

        If Me.chkBaseGrid.Enabled = True Then
            Me.tbBaseGridFile.Enabled = Me.chkBaseGrid.Checked
        Else
            Me.tbBaseGridFile.Enabled = False
        End If
    End Sub


    Private Sub chkResampleSize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkResampleSize.CheckedChanged

        If Me.chkResampleSize.Enabled = True Then
            Me.txtResampleCellSize.Enabled = Me.chkResampleSize.Checked
        Else
            Me.txtResampleCellSize.Enabled = False
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

    Private Sub btOpenDestinationFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOpenDestinationFolder.Click
        Dim fb As New FolderBrowserDialog
        If fb.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtDestinationFolderPath.Text = fb.SelectedPath
        End If
    End Sub

    Private Sub rbConvertASCiiToGRID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbConvertASCiiToGTiff.CheckedChanged
        Call SetProcessingOptionalIU()
    End Sub

    Private Sub rbClipGRID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbClipAndResample.CheckedChanged
        Call SetProcessingOptionalIU()
    End Sub

    Private Sub rbResampleGRID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbResample.CheckedChanged
        Call SetProcessingOptionalIU()
    End Sub

    Sub SetProcessingOptionalIU()
        Me.btSelectRenderer.Enabled = True
        Me.chkBaseGrid.Checked = True
        Me.chkBaseGrid.Enabled = True
        Me.txtResultFilePrefix.Enabled = True
        Me.txtResultFileTag.Enabled = True
        Me.chkResampleSize.Enabled = True
        Me.chkResampleSize.Checked = True
        Me.txtResampleCellSize.Enabled = True
        Me.btOpenDestinationFolder.Enabled = True
        Me.txtDestinationFolderPath.Enabled = True
        'Me.cbFileFormat.Enabled = True
        Me.cbResamplingMethod.Enabled = True
        Me.cbODataType.Enabled = True
        Me.tbBandN.Text = ""
        Me.tbBandN.Enabled = True

        If Me.rbConvertASCiiToGTiff.Checked = True Then
            Me.btSelectRenderer.Enabled = False
            Me.chkBaseGrid.Checked = False
            Me.chkBaseGrid.Enabled = False
            Me.chkResampleSize.Enabled = False
            Me.chkResampleSize.Checked = False
            Me.txtResampleCellSize.Enabled = False
            'Me.cbFileFormat.Enabled = False
            Me.cbResamplingMethod.Enabled = False
            Me.tbBandN.Text = ""
            Me.tbBandN.Enabled = False
        End If
        If Me.rbConvertASCtoImg.Checked = True Then
            Me.chkBaseGrid.Checked = False
            Me.chkBaseGrid.Enabled = False
            Me.chkResampleSize.Enabled = False
            Me.chkResampleSize.Checked = False
            Me.txtResampleCellSize.Enabled = False
            'Me.cbFileFormat.Enabled = False
            Me.cbResamplingMethod.Enabled = False
            Me.tbBandN.Text = ""
            Me.tbBandN.Enabled = False
            Me.cbODataType.Enabled = False
        End If
        If Me.rbConvertGTiffToASCii.Checked = True Then
            Me.btSelectRenderer.Enabled = False
            Me.chkBaseGrid.Checked = False
            Me.chkBaseGrid.Enabled = False
            Me.chkResampleSize.Enabled = False
            Me.chkResampleSize.Checked = False
            Me.txtResampleCellSize.Enabled = False
            'Me.cbFileFormat.Enabled = False
            Me.cbResamplingMethod.Enabled = False
        End If
        If Me.rbConvertGribToASCii.Checked = True Then
            Me.btSelectRenderer.Enabled = False
            Me.chkBaseGrid.Checked = False
            Me.chkBaseGrid.Enabled = False
            Me.chkResampleSize.Enabled = False
            Me.chkResampleSize.Checked = False
            Me.txtResampleCellSize.Enabled = False
            'Me.cbFileFormat.Enabled = False
            Me.cbResamplingMethod.Enabled = False
        End If
        If Me.rbClipAndResample.Checked = True OrElse Me.rbResample.Checked = True Then
            Me.chkBaseGrid.Checked = False
            Me.tbBaseGridFile.Enabled = False
            Me.chkResampleSize.Checked = False
            Me.txtResampleCellSize.Enabled = False
            Me.btSelectRenderer.Enabled = False
            Me.tbBandN.Text = ""
            Me.tbBandN.Enabled = False
        End If

        If Me.rbGdalinfo.Checked Then
            Me.chkBaseGrid.Checked = False
            Me.chkBaseGrid.Enabled = False
            Me.chkResampleSize.Enabled = False
            Me.chkResampleSize.Checked = False
            Me.txtResampleCellSize.Enabled = False
            'Me.cbFileFormat.Enabled = False
            Me.cbResamplingMethod.Enabled = False
            Me.tbBandN.Text = ""
            Me.tbBandN.Enabled = False
            Me.cbODataType.Enabled = False
        End If

    End Sub

    'Private Sub cbFileFormat_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If cbFileFormat.Enabled = True AndAlso cbFileFormat.Text.Trim <> "" Then
    '        Select Case cbFileFormat.Text.Trim
    '            Case cGdal.GdalFormat.GTiff.ToString
    '                mFilePattern = cFile.FilePattern.TIFFILE
    '            Case cGdal.GdalFormat.AAIGrid.ToString
    '                mFilePattern = cFile.FilePattern.ASCFILE
    '            Case Else
    '                mFilePattern = Nothing
    '        End Select
    '    End If
    'End Sub

    Private Sub rbConvertGridToASCii_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbConvertGTiffToASCii.CheckedChanged
        Call Me.SetProcessingOptionalIU()
    End Sub


    Private Sub rbConvertGribToASCii_CheckedChanged(sender As Object, e As EventArgs) Handles rbConvertGribToASCii.CheckedChanged
        Call Me.SetProcessingOptionalIU()
    End Sub

    Private Sub btSelectRenderer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSelectRenderer.Click
        Dim frm As New fImageRenderer
        If mRendererRangeType = gentle.cImg.RendererRange.RendererFrom0to1 Then
            frm.rb0_1.Checked = True
        ElseIf mRendererRangeType = gentle.cImg.RendererRange.RendererFrom0to100 Then
            frm.rb0_100.Checked = True
        ElseIf mRendererRangeType = gentle.cImg.RendererRange.RendererFrom0to200 Then
            frm.rb0_200.Checked = True
        ElseIf mRendererRangeType = gentle.cImg.RendererRange.RendererFrom0to500 Then
            frm.rb0_500.Checked = True
        End If
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.Cancel Then Exit Sub
        If frm.rb0_1.Checked Then
            mRendererRangeType = gentle.cImg.RendererRange.RendererFrom0to1
        ElseIf frm.rb0_100.Checked Then
            mRendererRangeType = gentle.cImg.RendererRange.RendererFrom0to100
        ElseIf frm.rb0_200.Checked Then
            mRendererRangeType = gentle.cImg.RendererRange.RendererFrom0to200
        ElseIf frm.rb0_500.Checked Then
            mRendererRangeType = gentle.cImg.RendererRange.RendererFrom0to500
        ElseIf frm.rbEqualinterval.Checked Then
            mRendererRangeType = cImg.RendererRange.MinMax
            mRendererIntervalType = cImg.RendererIntervalType.Equalinterval
            mRendererMaxValue = frm.nudMax.Value
            mRendererMinValue = frm.nudMin.Value
        End If
        If frm.rbDepth.Checked Then
            mRendererType = cImg.RendererType.WaterDepth
        Else
            mRendererType = cImg.RendererType.Risk
        End If
    End Sub

    Private Sub rbConvertASCtoBMP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbConvertASCtoImg.CheckedChanged
        Call SetProcessingOptionalIU()
        If Me.rbConvertASCtoImg.Checked Then
            mRendererRangeType = gentle.cImg.RendererRange.RendererFrom0to1
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




    Private Sub btSelectBaseRasterFile_Click(sender As Object, e As EventArgs) Handles btSelectBaseRasterFile.Click
        Dim fb As New OpenFileDialog
        If fb.ShowDialog() = DialogResult.OK Then
            tbBaseGridFile.Text = fb.FileName
        End If
    End Sub

    Private Sub mProcess_StopProcess(ByVal sender As fProgressBar) Handles mfPrograssBar.StopProcess
        mStopProgress = True
    End Sub

    Private Sub chkDecimalLength_CheckedChanged(sender As Object, e As EventArgs) Handles chkDecimalLength.CheckedChanged
        If Me.chkDecimalLength.Checked = True Then
            Me.tbDecimalPartN.Enabled = True
        Else
            Me.tbDecimalPartN.Text = ""
            Me.tbDecimalPartN.Enabled = False
        End If
    End Sub
End Class