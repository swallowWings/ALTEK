Imports System.Threading
Imports System.Text
Imports gentle


Public Class fGRMToolsGRMMPtools
    Private mdtParametersSets As DataTable
    Dim mBaseProjectFPN As String
    Dim mTargetFP As String

    'Private mdtFileList As DataTable
    Private mdtQobs As DataTable
    Private mGRMOutFileList As List(Of String)
    Private mdtSummary As DataTable

    Public mStopProgress As Boolean
    Private WithEvents mofrmPrograssBar As fProgressBar

    Private Event ProcessStep(ByVal sender As fGRMToolsGRMMPtools, ByVal nowProcess As Integer, ByVal maxProcess As Integer)
    Private Event ProcessStop(ByVal sender As fGRMToolsGRMMPtools)
    Private Event ProcessComplete(ByVal sender As fGRMToolsGRMMPtools)


    Private Sub tbCSVfpn_TextChanged(sender As Object, e As EventArgs) Handles tbCSVfpn.TextChanged
        If File.Exists(Me.tbCSVfpn.Text.Trim) = True Then Call updateDataGridView()
    End Sub



    Private Sub btSelectParameterCSVFile_Click(sender As Object, e As EventArgs) Handles btSelectParameterCSVFile.Click
        Dim dlg As New OpenFileDialog
        dlg.Filter = "CSV files (*.csv)|*.csv|txt files (*.txt)|*.txt"
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            If dlg.FileName <> "" Then
                Me.tbCSVfpn.Text = dlg.FileName
            End If
        End If
    End Sub


    Private Sub updateDataGridView()
        mdtParametersSets = Nothing
        Me.dgvParameters.Columns.Clear()
        Me.dgvParameters.ReadOnly = True
        mdtParametersSets = cTextFile.ReadTextFileAndSetDataTable(Me.tbCSVfpn.Text.Trim, cTextFile.ValueSeparator.CSV)
        If mdtParametersSets Is Nothing Then
            MsgBox("Reading parameters in the CSV file was failed.   ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
            Exit Sub
        Else
            Dim allNameIsNormal As Boolean = False
            For nc As Integer = 0 To mdtParametersSets.Columns.Count - 1
                allNameIsNormal = False
                For Each pn As String In [Enum].GetNames(GetType(cGRM.GRMParametersAbbreviation))
                    If mdtParametersSets.Columns(nc).ColumnName = pn Then
                        allNameIsNormal = True
                        Exit For
                    End If
                Next
            Next
            If allNameIsNormal = False Then
                MsgBox("Parameters names in the CSV file is not acceptable.   ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
                Exit Sub
            End If
        End If

        Me.dgvParameters.DataSource = mdtParametersSets
        If dgvParameters.ColumnCount > 0 Then
            For n As Integer = 0 To dgvParameters.ColumnCount - 1
                dgvParameters.Columns(n).SortMode = DataGridViewColumnSortMode.NotSortable
            Next
        End If
        MsgBox("Reading parameters in the CSV file is completed.   ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
    End Sub

    Private Sub btMakeGRMProjectFiles_Click(sender As Object, e As EventArgs) Handles btMakeGRMProjectFiles.Click

        Dim ts As New ThreadStart(AddressOf MakeGRMProjectFilesInner)
        Dim th As New Thread(ts)
        th.Start()
    End Sub

    Private Sub MakeGRMProjectFilesInner()
        mBaseProjectFPN = Me.tbBaseProjectFPN.Text.Trim
        If IO.File.Exists(mBaseProjectFPN) = False Then
            MsgBox("Base project file is not exist.   ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If
        Dim maxFileCount As Integer = mdtParametersSets.Rows.Count
        mofrmPrograssBar = New fProgressBar
        mofrmPrograssBar.GRMToolsPrograssBar.Maximum = maxFileCount
        mofrmPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
        mofrmPrograssBar.labGRMToolsPrograssBar.Text = "Making 0/" & CStr(maxFileCount) & " project file..."
        mofrmPrograssBar.Text = "Making GRM project file"
        mofrmPrograssBar.Show()
        mStopProgress = False

        mTargetFP = Trim(Me.tbTargetFP.Text)
        If IO.Directory.Exists(mTargetFP) Then Directory.Delete(mTargetFP, True)
        Directory.CreateDirectory(mTargetFP)

        For nr As Integer = 0 To maxFileCount - 1
            Dim targetFPN As String = Path.Combine(mTargetFP, String.Format("{0}_{1}{2}", mdtParametersSets.Rows(nr).Item(0), Path.GetFileNameWithoutExtension(mBaseProjectFPN), ".gmp"))
            File.Copy(mBaseProjectFPN, targetFPN)
            Dim Lines() As String = System.IO.File.ReadAllLines(targetFPN)
            Lines = cTextFile.ReplaceALineInStringArray(Lines, "<ProjectName>",
                                  String.Format("{0}{1}{2}", "    <ProjectName>", Path.GetFileName(targetFPN), "</ProjectName>"))
            Lines = cTextFile.ReplaceALineInStringArray(Lines, "<ProjectPath>",
                                  String.Format("{0}{1}{2}", "    <ProjectPath>", mTargetFP, "</ProjectPath>"))
            Lines = cTextFile.ReplaceALineInStringArray(Lines, "<GRMProjectMDB>",
                                  String.Format("{0}{1}{2}", "    <GRMProjectMDB>", Path.GetFileName(targetFPN.Replace(".gmp", ".mdb")), "</GRMProjectMDB>"))
            For nc As Integer = 1 To mdtParametersSets.Columns.Count - 1
                Select Case mdtParametersSets.Columns(nc).ColumnName
                    Case cGRM.GRMParametersAbbreviation.CLCRC.ToString
                        Lines = cTextFile.ReplaceALineInStringArray(Lines, "<CalCoefLCRoughness>",
                                   String.Format("{0}{1}{2}", "    <CalCoefLCRoughness>", mdtParametersSets.Rows(nr).Item(nc).ToString, "</CalCoefLCRoughness>"))
                    Case cGRM.GRMParametersAbbreviation.CRC.ToString
                        Lines = cTextFile.ReplaceALineInStringArray(Lines, "<ChRoughness>",
                                   String.Format("{0}{1}{2}", "    <ChRoughness>", mdtParametersSets.Rows(nr).Item(nc).ToString, "</ChRoughness>"))
                    Case cGRM.GRMParametersAbbreviation.CSD.ToString
                        Lines = cTextFile.ReplaceALineInStringArray(Lines, "<CalCoefSoilDepth>",
                                   String.Format("{0}{1}{2}", "    <CalCoefSoilDepth>", mdtParametersSets.Rows(nr).Item(nc).ToString, "</CalCoefSoilDepth>"))
                    Case cGRM.GRMParametersAbbreviation.CSHC.ToString
                        Lines = cTextFile.ReplaceALineInStringArray(Lines, "<CalCoefHydraulicK>",
                                   String.Format("{0}{1}{2}", "    <CalCoefHydraulicK>", mdtParametersSets.Rows(nr).Item(nc).ToString, "</CalCoefHydraulicK>"))
                    Case cGRM.GRMParametersAbbreviation.CSP.ToString
                        Lines = cTextFile.ReplaceALineInStringArray(Lines, "<CalCoefPorosity>",
                                   String.Format("{0}{1}{2}", "    <CalCoefPorosity>", mdtParametersSets.Rows(nr).Item(nc).ToString, "</CalCoefPorosity>"))
                    Case cGRM.GRMParametersAbbreviation.CSWS.ToString
                        Lines = cTextFile.ReplaceALineInStringArray(Lines, "<CalCoefWFSuctionHead>",
                                   String.Format("{0}{1}{2}", "    <CalCoefWFSuctionHead>", mdtParametersSets.Rows(nr).Item(nc).ToString, "</CalCoefWFSuctionHead>"))
                    Case cGRM.GRMParametersAbbreviation.ISSR.ToString
                        Lines = cTextFile.ReplaceALineInStringArray(Lines, "<IniSaturation>",
                                   String.Format("{0}{1}{2}", "    <IniSaturation>", mdtParametersSets.Rows(nr).Item(nc).ToString, "</IniSaturation>"))
                    Case cGRM.GRMParametersAbbreviation.MCW.ToString
                        Lines = cTextFile.ReplaceALineInStringArray(Lines, "<MinChBaseWidth>",
                                   String.Format("{0}{1}{2}", "    <MinChBaseWidth>", mdtParametersSets.Rows(nr).Item(nc).ToString, "</MinChBaseWidth>"))
                    Case cGRM.GRMParametersAbbreviation.MSCB.ToString
                        Lines = cTextFile.ReplaceALineInStringArray(Lines, "<MinSlopeChBed>",
                                   String.Format("{0}{1}{2}", "    <MinSlopeChBed>", mdtParametersSets.Rows(nr).Item(nc).ToString, "</MinSlopeChBed>"))
                    Case cGRM.GRMParametersAbbreviation.MSLS.ToString
                        Lines = cTextFile.ReplaceALineInStringArray(Lines, "<MinSlopeOF>",
                                   String.Format("{0}{1}{2}", "     <MinSlopeOF>", mdtParametersSets.Rows(nr).Item(nc).ToString, "</MinSlopeOF>"))
                End Select
            Next
            System.IO.File.WriteAllLines(targetFPN, Lines)
            mofrmPrograssBar.GRMToolsPrograssBar.Value = (nr + 1)
            mofrmPrograssBar.labGRMToolsPrograssBar.Text =
                "Making " & CStr((nr + 1)) & "/" & CStr(maxFileCount) & " project files..."
            RaiseEvent ProcessStep(Me, nr + 1, maxFileCount)
            If (nr + 1) Mod 100 = 0 Then System.Windows.Forms.Application.DoEvents()
            If mStopProgress = True Then Exit For
        Next
        If mStopProgress = True Then
            RaiseEvent ProcessStop(Me)
            MsgBox("Making project file is stopped!     ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
        Else
            RaiseEvent ProcessComplete(Me)
            MsgBox("Making " + CStr(mdtParametersSets.Rows.Count) + " project files were completed!!!   ",
                 MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
        End If
        mofrmPrograssBar.Close()
    End Sub

    Private Sub btSelectBaseGRMPrjFile_Click(sender As Object, e As EventArgs) Handles btSelectBaseGRMPrjFile.Click
        Dim dlg As New OpenFileDialog
        With dlg
            .Title = "Select GRM project file (.gmp)"
            .FileName = ""
            If cProject.Current IsNot Nothing AndAlso cProject.Current.ProjectPathName <> "" Then
                .InitialDirectory = IO.Path.GetDirectoryName(cProject.Current.ProjectPathName)
            End If
            .Filter = "GRM project files (*.gmp)|*.gmp"
        End With
        If dlg.ShowDialog() = DialogResult.OK Then
            Me.tbBaseProjectFPN.Text = dlg.FileName
        End If
    End Sub

    Private Sub tbBaseProjectFPN_TextChanged(sender As Object, e As EventArgs) Handles tbBaseProjectFPN.TextChanged
        Dim baseProjectNameOnly As String
        baseProjectNameOnly = IO.Path.GetFileNameWithoutExtension(Me.tbBaseProjectFPN.Text.Trim)
        Me.tbTargetFP.Text = Path.Combine(Path.GetDirectoryName(Me.tbBaseProjectFPN.Text.Trim), baseProjectNameOnly & "_MP")
    End Sub


    Private Sub btViewCSVTextFileFormat_Click(sender As Object, e As EventArgs) Handles btViewCSVTextFileFormat.Click
        Dim ofrmTextBox As New fTextBox
        Dim strOut As String
        strOut = "RowNo, ParameterName1, ParameterName2, ParameterName2, ..." + vbCrLf
        strOut = strOut + "1, ParameterValue11, ParameterValue12, ParameterValue13, ..." + vbCrLf
        strOut = strOut + "2, ParameterValue21, ParameterValue22, ParameterValue23, ..." + vbCrLf
        strOut = strOut + "3, ParameterValue31, ParameterValue32, ParameterValue33, ..." + vbCrLf
        strOut = strOut + "    .     ,     .   ,     .    ,..." + vbCrLf
        strOut = strOut + "    .     ,     .   ,     .    ,..." + vbCrLf
        strOut = strOut + "    .     ,     .   ,     .    ,..." + vbCrLf + vbCrLf

        strOut = strOut + "First line contains [RowNo] and parameter names separated with comma(,)." + vbCrLf
        strOut = strOut + "    10 parameters can be applied, and the  abbreviations below must be used as [ParameterName]" + vbCrLf
        strOut = strOut + "         1. Initial soil saturation ratio(ISSR)                2. Minimum slope of land surface(MSLS)" + vbCrLf
        strOut = strOut + "         3. Minimum slope of channel bed(MSCB)      4. Minimum channel width(MCW)" + vbCrLf
        strOut = strOut + "         5. Channel roughness coefficient(CRC)          6. Calibration coefficient of Land cover roughness coefficient(CLCRC)" + vbCrLf
        strOut = strOut + "         7. Calibration coefficient of soil depth(CSD)   8. Calibration coefficient of soil porosity(CSP)" + vbCrLf
        strOut = strOut + "         9. Calibration coefficient of soil wetting front suction head(CSWS)  " + vbCrLf
        strOut = strOut + "         10. Calibration coefficient of soil hydraulic conductivity(CSHC)" + vbCrLf
        strOut = strOut + "Write the row numbers and parameters values to apply from second line." + vbCrLf

        ofrmTextBox.txtTextBox.Text = strOut
        ofrmTextBox.txtTextBox.ReadOnly = True
        ofrmTextBox.Text = "GRM parameter CSV file format"
        ofrmTextBox.txtTextBox.Font = System.Drawing.SystemFonts.DefaultFont
        ofrmTextBox.txtTextBox.Select(Len(strOut), 0)
        ofrmTextBox.Show()
    End Sub


    'Private Delegate Sub UpdateStatusAndProgressDelegate(ByVal nowProcess As Integer, ByVal MaxProcess As Integer)
    'Private Sub fGRMToolsGRMprojectProcessing_SimulationStep(sender As fGRMToolsGRMMPtools, _
    '                                                         nowProcess As Integer, maxProcess As Integer) Handles Me.SimulationStep
    '    If mofrmPrograssBar.InvokeRequired Then
    '        Dim d As New UpdateStatusAndProgressDelegate(AddressOf UpdateStatusAndProgress)
    '        mofrmPrograssBar.Invoke(d, nowProcess, maxProcess)
    '    Else
    '        UpdateStatusAndProgress(nowProcess, maxProcess)
    '    End If
    'End Sub

    'Private Sub UpdateStatusAndProgress(ByVal nowProcess As Integer, ByVal MaxProcess As Integer)
    '    mofrmPrograssBar.GRMToolsPrograssBar.Value = nowProcess
    '    mofrmPrograssBar.labGRMToolsPrograssBar.Text = _
    '        "Making " & CStr(nowProcess) & "/" & CStr(MaxProcess) & " project files..."
    'End Sub

    Private Sub mProcess_StopProcess(ByVal sender As fProgressBar) Handles mofrmPrograssBar.StopProcess
        mStopProgress = True
    End Sub

    'Private Delegate Sub StopProgressDelegate()
    'Private Sub fGRMToolsGRMprojectProcessing_ProcessStop(sender As fGRMToolsGRMMPtools) Handles Me.ProcessStop
    '    If mofrmPrograssBar.InvokeRequired Then
    '        Dim d As New StopProgressDelegate(AddressOf StopAndCloseProgress)
    '        mofrmPrograssBar.Invoke(d)
    '    Else
    '        StopAndCloseProgress()
    '    End If
    'End Sub

    'Private Sub StopAndCloseProgress()
    '    MsgBox("Making project file is stopped!     ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
    '    mofrmPrograssBar.Close()
    'End Sub

    'Private Delegate Sub CloseProgressDelegate()
    'Private Sub fGRMToolsGRMprojectProcessing_SimulationComplete(sender As fGRMToolsGRMMPtools) Handles Me.ProcessComplete
    '    If mofrmPrograssBar.InvokeRequired Then
    '        Dim d As New CloseProgressDelegate(AddressOf CompleteAndCloseProgress)
    '        mofrmPrograssBar.Invoke(d)
    '    Else
    '        CompleteAndCloseProgress()
    '    End If
    'End Sub

    'Private Sub CompleteAndCloseProgress()


    'End Sub



    Private Sub btSample_Click(sender As Object, e As EventArgs) Handles btSample.Click
        Dim ofrmTextBox As New fTextBox
        Dim strOut As String

        strOut = "GaugeName" + vbCrLf
        strOut = strOut + "Value" + vbCrLf
        strOut = strOut + "Value" + vbCrLf
        strOut = strOut + "   .   " + vbCrLf
        strOut = strOut + "   .   " + vbCrLf + vbCrLf

        strOut = strOut + "Make observed data file as TEXT file type(using notepad, etc.)" + vbCrLf
        strOut = strOut + "GaugeName : observatory name. Variant data type" + vbCrLf
        strOut = strOut + "Value : observed data value. Integer or float data type."

        ofrmTextBox.txtTextBox.Text = strOut
        ofrmTextBox.txtTextBox.ReadOnly = True
        ofrmTextBox.txtTextBox.Font = System.Drawing.SystemFonts.DefaultFont
        ofrmTextBox.txtTextBox.Select(Len(strOut), 0)
        ofrmTextBox.Show()
    End Sub

    Private Sub txtFolderPathSource_TextChanged(sender As Object, e As EventArgs) Handles tbFolderGRMresults.TextChanged
        Call AddFilesToDGV()
    End Sub

    Private Sub AddFilesToDGV()
        If IO.Directory.Exists(tbFolderGRMresults.Text.Trim) Then
            Dim filePath As String = tbFolderGRMresults.Text.Trim
            'mdtFileList = cFile.GetFileListDataTable(filePath, cFile.FilePattern.OUT_Discharge)
            'Me.dgvGRMResultFileList.DataSource = mdtFileList
            mGRMOutFileList = cFile.GetFileList(filePath, cFile.FilePattern.OUT_Discharge)
            Dim bN As Boolean = True '모든 파일명의 머리글을 숫자로 변환할 수 있으면..
            For Each fs As String In mGRMOutFileList
                Dim n As Integer
                If Integer.TryParse(IO.Path.GetFileNameWithoutExtension(fs).Split(CChar("_")).First, n) = False Then
                    bN = False
                    Exit For
                End If
            Next
            If bN = True Then '숫자 순으로 정렬
                mGRMOutFileList = mGRMOutFileList.OrderBy(Function(fn) Int32.Parse(IO.Path.GetFileNameWithoutExtension(fn).Split(CChar("_")).First)).ToList
            End If
            Me.lstbGRMresultsFileList.DataSource = mGRMOutFileList
        End If
    End Sub

    Private Sub txtFPNObsData_TextChanged(sender As Object, e As EventArgs) Handles tbFPNObsData.TextChanged
        UpdateDGVObservedData()
    End Sub

    Private Sub UpdateDGVObservedData()
        If File.Exists(Me.tbFPNObsData.Text.Trim) Then
            Dim fpnQobs As String = Me.tbFPNObsData.Text.Trim
            Me.dgvObservedValue.ReadOnly = True
            mdtQobs = cTextFile.ReadTextFileAndSetDataTable(fpnQobs, cTextFile.ValueSeparator.CSV, 1)
            If mdtQobs Is Nothing Then
                MsgBox("Observed data setup was failed.   ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
                Exit Sub
            End If
            dgvObservedValue.DataSource = mdtQobs
            dgvObservedValue.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            MsgBox("Observed data setup is completed.   ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
        End If
    End Sub

    Private Sub btSelectDestinationFile_Click(sender As Object, e As EventArgs) Handles btSelectDestinationFile.Click
        Dim dlg As New SaveFileDialog
        dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|CSV files (*.csv)|*.csv"
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            If dlg.FileName <> "" Then
                Me.tbDestinationFPN.Text = dlg.FileName
            End If
        End If
    End Sub


    Private Sub btSelectObsDataFile_Click(sender As Object, e As EventArgs) Handles btSelectObsDataFile.Click
        Dim dlg As New OpenFileDialog
        dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|CSV files (*.csv)|*.csv"
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            If dlg.FileName <> "" Then
                Me.tbFPNObsData.Text = dlg.FileName
            End If
        End If
    End Sub

    Private Sub btSelectGRMResultFolder_Click(sender As Object, e As EventArgs) Handles btSelectGRMResultFolder.Click
        Dim fb As New FolderBrowserDialog
        If IO.Directory.Exists(tbFolderGRMresults.Text.Trim) Then
            fb.SelectedPath = tbFolderGRMresults.Text.Trim
        Else
            fb.SelectedPath = My.Application.Info.DirectoryPath
        End If
        If fb.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.tbFolderGRMresults.Text = fb.SelectedPath
        End If
    End Sub

    Private Sub btMakeSummaryFile_Click(sender As Object, e As EventArgs) Handles btMakeSummaryFile.Click

        Dim ts As New ThreadStart(AddressOf ReadGRMoutFileAndFillSummaryDataTableAndMakeTextFileInner)
        Dim th As New Thread(ts)
        th.Start()
    End Sub

    Private Sub ReadGRMoutFileAndFillSummaryDataTableAndMakeTextFileInner()
        Dim maxFileCount As Integer = mGRMOutFileList.Count
        mofrmPrograssBar = New fProgressBar
        mofrmPrograssBar.GRMToolsPrograssBar.Maximum = maxFileCount
        mofrmPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
        mofrmPrograssBar.labGRMToolsPrograssBar.Text = "Summary 0/" & CStr(maxFileCount) & " project file..."
        mofrmPrograssBar.Text = "Making GRM results summary file"
        mofrmPrograssBar.Show()
        mStopProgress = False
        If MakeSummaryDataTableAndFillTimeField() = False Then '컬럼 이름은 일련번호 설정
            Exit Sub
        End If
        Dim lines As String() = IO.File.ReadAllLines(Me.tbFPNObsData.Text.Trim)
        Dim baseStrArray(lines.Length) As String '해더+파일개수
        Dim valueSeparatorInArray As String = ","
        Dim valueSeparatorInSourceFile As String() = {vbTab}
        Dim fpn As String = Path.Combine(Me.tbFolderGRMresults.Text.Trim, mGRMOutFileList(0).ToString)
        Dim valueRowNumber As Integer = cTextFile.GetValueStartingRowNumber(fpn, cTextFile.ValueSeparator.ALL)
        If valueRowNumber < 2 Then
            MsgBox("First grm output file contains no simulation results or has no [DataTime] field.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
            Exit Sub
        End If

        '여기서 시간입력
        baseStrArray = cTextFile.ReadGRMoutFileAndMakeStringArray(baseStrArray, fpn,
                                                                  valueRowNumber, 1, cGRM.CONST_OUTPUT_TABLE_TIME_FIELD_NAME.ToString,
                                                                   valueSeparatorInSourceFile, valueSeparatorInArray, False)
        '여기서 관측값 입력
        baseStrArray = cTextFile.ReadGRMoutFileAndMakeStringArray(baseStrArray, Me.tbFPNObsData.Text.Trim, 2, 1, "OBS",
                                                                    valueSeparatorInSourceFile, valueSeparatorInArray, False)
        For n As Integer = 0 To mGRMOutFileList.Count - 1
            Dim FNnow As String = mGRMOutFileList(n).ToString
            fpn = Path.Combine(Me.tbFolderGRMresults.Text.Trim, FNnow)
            Dim ColumnName As Integer
            If Me.cbColumnName.Checked Then
                Dim nc As Integer
                If Integer.TryParse(IO.Path.GetFileNameWithoutExtension(FNnow).Split(CChar("_")).First, nc) = False Then nc = n + 1
                ColumnName = nc
            Else
                '컬럼 이름이 일련번호로 들어가 있음.
                ColumnName = n + 1
            End If
            baseStrArray = cTextFile.ReadGRMoutFileAndMakeStringArray(baseStrArray, fpn, valueRowNumber, 2, ColumnName.ToString,
                                                                    valueSeparatorInSourceFile, valueSeparatorInArray, False)
            mofrmPrograssBar.labGRMToolsPrograssBar.Text = String.Format("Summarize {0}/{1} project files...", (n + 1), maxFileCount)
            mofrmPrograssBar.GRMToolsPrograssBar.Value = (n + 1)
            If mStopProgress = True Then Exit For
            If n Mod 50 = 0 Then System.Windows.Forms.Application.DoEvents()
        Next
        '        cTextFile.MakeTextFileUsingDataTable(mdtSummary, cTextFile.ValueSeparator.CSV, Me.tbDestinationFPN.Text.Trim, True, False)
        If mStopProgress = False Then
            mofrmPrograssBar.labGRMToolsPrograssBar.Text = String.Format("Write to text file.....", maxFileCount, maxFileCount)
            File.WriteAllLines(Me.tbDestinationFPN.Text.Trim, baseStrArray, Encoding.Default)
        End If
        mofrmPrograssBar.Close()
        If mStopProgress = True Then
            RaiseEvent ProcessStop(Me)
            MsgBox("Making summary file is stopped!     ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
        Else
            RaiseEvent ProcessComplete(Me)
            MsgBox("Making summary file was completed!!!   ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
        End If
    End Sub

    'Private Sub ReadGRMoutFileAndFillSummaryDataTableAndMakeTextFileInner()
    '    Dim maxFileCount As Integer = mGRMOutFileList.Count
    '    mofrmPrograssBar = New fGRMToolsProgressBar
    '    mofrmPrograssBar.GRMToolsPrograssBar.Maximum = maxFileCount
    '    mofrmPrograssBar.GRMToolsPrograssBar.Style = ProgressBarStyle.Blocks
    '    mofrmPrograssBar.labGRMToolsPrograssBar.Text = "Summary 0/" & CStr(maxFileCount) & " project file..."
    '    mofrmPrograssBar.Text = "Making GRM results summary file"
    '    mofrmPrograssBar.Show()
    '    mStopProgress = False
    '    If MakeSummaryDataTableAndFillTimeField() = False Then '컬럼 이름은 일련번호 설정
    '        Exit Sub
    '    End If
    '    '여기서 관측값 입력
    '    mdtSummary = cTextFile.ReadGRMoutFileAndFillUpDataTable(mdtSummary,
    '                                                          Me.tbFPNObsData.Text.Trim, cTextFile.ValueSeparator.ALL, 1, "OBS", 2, False)
    '    For n As Integer = 0 To mGRMOutFileList.Count - 1
    '        Dim FNnow As String = mGRMOutFileList(n).ToString
    '        Dim fpn As String = Path.Combine(Me.tbFolderGRMresults.Text.Trim, FNnow)
    '        Dim valueRowNumber As Integer = cTextFile.GetValueStartingRowNumber(fpn, cTextFile.ValueSeparator.ALL)
    '        Dim targetColName As String
    '        If Me.cbColumnName.Checked Then
    '            Dim nc As Integer
    '            If Integer.TryParse(IO.Path.GetFileNameWithoutExtension(FNnow).Split(CChar("_")).First, nc) = False Then nc = n + 1
    '            targetColName = nc.ToString
    '        Else
    '            '컬럼 이름이 일련번호로 들어가 있음.
    '            targetColName = (n + 1).ToString
    '        End If
    '        mdtSummary = cTextFile.ReadGRMoutFileAndFillUpDataTable(mdtSummary,
    '                                                          fpn, cTextFile.ValueSeparator.TAB, 2, targetColName, valueRowNumber, False)
    '        mofrmPrograssBar.labGRMToolsPrograssBar.Text = String.Format("Summary {0}/{1} project file...", (n + 1), maxFileCount)
    '        mofrmPrograssBar.GRMToolsPrograssBar.Value = (n + 1)
    '        If mStopProgress = True Then Exit For
    '    Next
    '    If mStopProgress = False Then
    '        mofrmPrograssBar.labGRMToolsPrograssBar.Text = String.Format("Summary {0}/{1} project file...", maxFileCount, maxFileCount)
    '        cTextFile.MakeTextFileUsingDataTable(mdtSummary, cTextFile.ValueSeparator.CSV, Me.tbDestinationFPN.Text.Trim, True, False)
    '    End If
    '    mofrmPrograssBar.Close()
    '    If mStopProgress = True Then
    '        RaiseEvent ProcessStop(Me)
    '        MsgBox("Making summary file is stopped!     ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
    '    Else
    '        RaiseEvent ProcessComplete(Me)
    '        MsgBox("Making summary file was completed!!!   ", MsgBoxStyle.Information, cGRM.BuildInfo.ProductName)
    '    End If
    'End Sub

    Private Function MakeSummaryDataTableAndFillTimeField() As Boolean
        '여기서 필드 생성하고
        mdtSummary = New DataTable
        mdtSummary.Columns.Add(cGRM.CONST_OUTPUT_TABLE_TIME_FIELD_NAME.ToString)
        mdtSummary.Columns.Add("OBS")
        For n As Integer = 0 To mGRMOutFileList.Count - 1
            Dim nc As Integer = 0
            nc = n + 1
            If Me.cbColumnName.Checked Then
                Dim FNnow As String = Path.GetFileNameWithoutExtension(mGRMOutFileList(n))
                If Integer.TryParse(IO.Path.GetFileNameWithoutExtension(FNnow).Split(CChar("_")).First, nc) = False Then nc = n + 1
            End If
            '컬럼 이름은 일련번호 설정
            mdtSummary.Columns.Add((nc).ToString)
        Next
        '여기서 시간 채우고
        Dim fpn As String = Path.Combine(Me.tbFolderGRMresults.Text.Trim, mGRMOutFileList(0).ToString)
        If fpn = "" OrElse File.Exists(fpn) = False Then
            MsgBox("Source text file and data is invalid.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
            Return False
            Exit Function
        Else
            Dim Lines() As String = System.IO.File.ReadAllLines(fpn)
            Dim sepArray As String() = {vbTab}
            mdtSummary.BeginLoadData()
            Dim valueRowNumber As Integer = cTextFile.GetValueStartingRowNumber(fpn, cTextFile.ValueSeparator.ALL)
            If valueRowNumber < 2 Then
                MsgBox("First grm output file contains no simulation results or has no [DataTime] field.   ", MsgBoxStyle.Critical, cGRM.BuildInfo.ProductName)
                Return False
            End If
            For nl As Integer = 0 To Lines.Length - 1
                If nl >= valueRowNumber - 1 Then
                    Dim aLine As String = Lines(nl)
                    Dim parts() As String = aLine.Split(sepArray, StringSplitOptions.RemoveEmptyEntries)
                    Dim nr As DataRow = mdtSummary.NewRow
                    nr.Item(0) = parts(0)
                    mdtSummary.Rows.Add(nr)
                End If
            Next nl
        End If
        Return True
    End Function

End Class