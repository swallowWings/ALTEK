<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fGRMToolsGRMMPtools
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbGRMProjectProcessing = New System.Windows.Forms.TabControl()
        Me.tpMakeProjectFiles = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTargetFP = New System.Windows.Forms.TextBox()
        Me.btMakeGRMProjectFiles = New System.Windows.Forms.Button()
        Me.dgvParameters = New System.Windows.Forms.DataGridView()
        Me.btViewCSVTextFileFormat = New System.Windows.Forms.Button()
        Me.tbCSVfpn = New System.Windows.Forms.TextBox()
        Me.btSelectParameterCSVFile = New System.Windows.Forms.Button()
        Me.tbBaseProjectFPN = New System.Windows.Forms.TextBox()
        Me.btSelectBaseGRMPrjFile = New System.Windows.Forms.Button()
        Me.tpSummarizeGRMresults = New System.Windows.Forms.TabPage()
        Me.cbColumnName = New System.Windows.Forms.CheckBox()
        Me.btMakeSummaryFile = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstbGRMresultsFileList = New System.Windows.Forms.ListBox()
        Me.dgvObservedValue = New System.Windows.Forms.DataGridView()
        Me.tbDestinationFPN = New System.Windows.Forms.TextBox()
        Me.btSelectDestinationFile = New System.Windows.Forms.Button()
        Me.tbFolderGRMresults = New System.Windows.Forms.TextBox()
        Me.btSelectGRMResultFolder = New System.Windows.Forms.Button()
        Me.btSample = New System.Windows.Forms.Button()
        Me.btSelectObsDataFile = New System.Windows.Forms.Button()
        Me.tbFPNObsData = New System.Windows.Forms.TextBox()
        Me.tbGRMProjectProcessing.SuspendLayout()
        Me.tpMakeProjectFiles.SuspendLayout()
        CType(Me.dgvParameters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpSummarizeGRMresults.SuspendLayout()
        CType(Me.dgvObservedValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbGRMProjectProcessing
        '
        Me.tbGRMProjectProcessing.Controls.Add(Me.tpMakeProjectFiles)
        Me.tbGRMProjectProcessing.Controls.Add(Me.tpSummarizeGRMresults)
        Me.tbGRMProjectProcessing.Location = New System.Drawing.Point(12, 12)
        Me.tbGRMProjectProcessing.Name = "tbGRMProjectProcessing"
        Me.tbGRMProjectProcessing.SelectedIndex = 0
        Me.tbGRMProjectProcessing.Size = New System.Drawing.Size(908, 668)
        Me.tbGRMProjectProcessing.TabIndex = 33
        '
        'tpMakeProjectFiles
        '
        Me.tpMakeProjectFiles.Controls.Add(Me.Label1)
        Me.tpMakeProjectFiles.Controls.Add(Me.tbTargetFP)
        Me.tpMakeProjectFiles.Controls.Add(Me.btMakeGRMProjectFiles)
        Me.tpMakeProjectFiles.Controls.Add(Me.dgvParameters)
        Me.tpMakeProjectFiles.Controls.Add(Me.btViewCSVTextFileFormat)
        Me.tpMakeProjectFiles.Controls.Add(Me.tbCSVfpn)
        Me.tpMakeProjectFiles.Controls.Add(Me.btSelectParameterCSVFile)
        Me.tpMakeProjectFiles.Controls.Add(Me.tbBaseProjectFPN)
        Me.tpMakeProjectFiles.Controls.Add(Me.btSelectBaseGRMPrjFile)
        Me.tpMakeProjectFiles.Location = New System.Drawing.Point(4, 22)
        Me.tpMakeProjectFiles.Name = "tpMakeProjectFiles"
        Me.tpMakeProjectFiles.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMakeProjectFiles.Size = New System.Drawing.Size(900, 642)
        Me.tpMakeProjectFiles.TabIndex = 0
        Me.tpMakeProjectFiles.Text = "Make project files"
        Me.tpMakeProjectFiles.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 589)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Destination folder "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbTargetFP
        '
        Me.tbTargetFP.BackColor = System.Drawing.SystemColors.Window
        Me.tbTargetFP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbTargetFP.Location = New System.Drawing.Point(318, 611)
        Me.tbTargetFP.Multiline = True
        Me.tbTargetFP.Name = "tbTargetFP"
        Me.tbTargetFP.Size = New System.Drawing.Size(569, 21)
        Me.tbTargetFP.TabIndex = 40
        '
        'btMakeGRMProjectFiles
        '
        Me.btMakeGRMProjectFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btMakeGRMProjectFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btMakeGRMProjectFiles.Location = New System.Drawing.Point(14, 589)
        Me.btMakeGRMProjectFiles.Name = "btMakeGRMProjectFiles"
        Me.btMakeGRMProjectFiles.Size = New System.Drawing.Size(292, 43)
        Me.btMakeGRMProjectFiles.TabIndex = 39
        Me.btMakeGRMProjectFiles.Text = "Make GRM project files"
        Me.btMakeGRMProjectFiles.UseVisualStyleBackColor = True
        '
        'dgvParameters
        '
        Me.dgvParameters.AllowUserToAddRows = False
        Me.dgvParameters.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParameters.Location = New System.Drawing.Point(14, 88)
        Me.dgvParameters.Name = "dgvParameters"
        Me.dgvParameters.RowTemplate.Height = 23
        Me.dgvParameters.Size = New System.Drawing.Size(873, 482)
        Me.dgvParameters.TabIndex = 38
        '
        'btViewCSVTextFileFormat
        '
        Me.btViewCSVTextFileFormat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btViewCSVTextFileFormat.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btViewCSVTextFileFormat.Location = New System.Drawing.Point(780, 43)
        Me.btViewCSVTextFileFormat.Name = "btViewCSVTextFileFormat"
        Me.btViewCSVTextFileFormat.Size = New System.Drawing.Size(107, 21)
        Me.btViewCSVTextFileFormat.TabIndex = 37
        Me.btViewCSVTextFileFormat.Text = "File format?"
        Me.btViewCSVTextFileFormat.UseVisualStyleBackColor = True
        '
        'tbCSVfpn
        '
        Me.tbCSVfpn.Location = New System.Drawing.Point(232, 43)
        Me.tbCSVfpn.Name = "tbCSVfpn"
        Me.tbCSVfpn.Size = New System.Drawing.Size(542, 21)
        Me.tbCSVfpn.TabIndex = 35
        '
        'btSelectParameterCSVFile
        '
        Me.btSelectParameterCSVFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSelectParameterCSVFile.Location = New System.Drawing.Point(14, 43)
        Me.btSelectParameterCSVFile.Name = "btSelectParameterCSVFile"
        Me.btSelectParameterCSVFile.Size = New System.Drawing.Size(212, 21)
        Me.btSelectParameterCSVFile.TabIndex = 36
        Me.btSelectParameterCSVFile.Text = "Select GRM parameter CSV file"
        Me.btSelectParameterCSVFile.UseVisualStyleBackColor = True
        '
        'tbBaseProjectFPN
        '
        Me.tbBaseProjectFPN.Location = New System.Drawing.Point(232, 16)
        Me.tbBaseProjectFPN.Name = "tbBaseProjectFPN"
        Me.tbBaseProjectFPN.Size = New System.Drawing.Size(655, 21)
        Me.tbBaseProjectFPN.TabIndex = 34
        '
        'btSelectBaseGRMPrjFile
        '
        Me.btSelectBaseGRMPrjFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSelectBaseGRMPrjFile.Location = New System.Drawing.Point(14, 15)
        Me.btSelectBaseGRMPrjFile.Name = "btSelectBaseGRMPrjFile"
        Me.btSelectBaseGRMPrjFile.Size = New System.Drawing.Size(212, 21)
        Me.btSelectBaseGRMPrjFile.TabIndex = 33
        Me.btSelectBaseGRMPrjFile.Text = "Select base GRM project file"
        Me.btSelectBaseGRMPrjFile.UseVisualStyleBackColor = True
        '
        'tpSummarizeGRMresults
        '
        Me.tpSummarizeGRMresults.Controls.Add(Me.cbColumnName)
        Me.tpSummarizeGRMresults.Controls.Add(Me.btMakeSummaryFile)
        Me.tpSummarizeGRMresults.Controls.Add(Me.Label3)
        Me.tpSummarizeGRMresults.Controls.Add(Me.Label2)
        Me.tpSummarizeGRMresults.Controls.Add(Me.lstbGRMresultsFileList)
        Me.tpSummarizeGRMresults.Controls.Add(Me.dgvObservedValue)
        Me.tpSummarizeGRMresults.Controls.Add(Me.tbDestinationFPN)
        Me.tpSummarizeGRMresults.Controls.Add(Me.btSelectDestinationFile)
        Me.tpSummarizeGRMresults.Controls.Add(Me.tbFolderGRMresults)
        Me.tpSummarizeGRMresults.Controls.Add(Me.btSelectGRMResultFolder)
        Me.tpSummarizeGRMresults.Controls.Add(Me.btSample)
        Me.tpSummarizeGRMresults.Controls.Add(Me.btSelectObsDataFile)
        Me.tpSummarizeGRMresults.Controls.Add(Me.tbFPNObsData)
        Me.tpSummarizeGRMresults.Location = New System.Drawing.Point(4, 22)
        Me.tpSummarizeGRMresults.Name = "tpSummarizeGRMresults"
        Me.tpSummarizeGRMresults.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSummarizeGRMresults.Size = New System.Drawing.Size(900, 642)
        Me.tpSummarizeGRMresults.TabIndex = 1
        Me.tpSummarizeGRMresults.Text = "Summarize GRM results"
        Me.tpSummarizeGRMresults.UseVisualStyleBackColor = True
        '
        'cbColumnName
        '
        Me.cbColumnName.AutoSize = True
        Me.cbColumnName.Checked = True
        Me.cbColumnName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbColumnName.Location = New System.Drawing.Point(376, 581)
        Me.cbColumnName.Name = "cbColumnName"
        Me.cbColumnName.Size = New System.Drawing.Size(278, 16)
        Me.cbColumnName.TabIndex = 45
        Me.cbColumnName.Text = "Get column name from the file name number"
        Me.cbColumnName.UseVisualStyleBackColor = True
        '
        'btMakeSummaryFile
        '
        Me.btMakeSummaryFile.Location = New System.Drawing.Point(700, 564)
        Me.btMakeSummaryFile.Name = "btMakeSummaryFile"
        Me.btMakeSummaryFile.Size = New System.Drawing.Size(165, 60)
        Me.btMakeSummaryFile.TabIndex = 44
        Me.btMakeSummaryFile.Text = "Make summary CSV file"
        Me.btMakeSummaryFile.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.Location = New System.Drawing.Point(195, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 20)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Simulation result file list"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Observed data"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstbGRMresultsFileList
        '
        Me.lstbGRMresultsFileList.FormattingEnabled = True
        Me.lstbGRMresultsFileList.ItemHeight = 12
        Me.lstbGRMresultsFileList.Location = New System.Drawing.Point(197, 105)
        Me.lstbGRMresultsFileList.Name = "lstbGRMresultsFileList"
        Me.lstbGRMresultsFileList.Size = New System.Drawing.Size(669, 448)
        Me.lstbGRMresultsFileList.TabIndex = 42
        '
        'dgvObservedValue
        '
        Me.dgvObservedValue.AllowUserToAddRows = False
        Me.dgvObservedValue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvObservedValue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvObservedValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvObservedValue.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvObservedValue.Location = New System.Drawing.Point(27, 105)
        Me.dgvObservedValue.Name = "dgvObservedValue"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvObservedValue.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvObservedValue.RowHeadersVisible = False
        Me.dgvObservedValue.RowTemplate.Height = 23
        Me.dgvObservedValue.Size = New System.Drawing.Size(164, 448)
        Me.dgvObservedValue.TabIndex = 39
        '
        'tbDestinationFPN
        '
        Me.tbDestinationFPN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDestinationFPN.BackColor = System.Drawing.SystemColors.Window
        Me.tbDestinationFPN.Location = New System.Drawing.Point(26, 603)
        Me.tbDestinationFPN.Name = "tbDestinationFPN"
        Me.tbDestinationFPN.Size = New System.Drawing.Size(668, 21)
        Me.tbDestinationFPN.TabIndex = 41
        '
        'btSelectDestinationFile
        '
        Me.btSelectDestinationFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSelectDestinationFile.Location = New System.Drawing.Point(26, 564)
        Me.btSelectDestinationFile.Name = "btSelectDestinationFile"
        Me.btSelectDestinationFile.Size = New System.Drawing.Size(322, 33)
        Me.btSelectDestinationFile.TabIndex = 40
        Me.btSelectDestinationFile.Text = "Select result summary CSV file path and name"
        Me.btSelectDestinationFile.UseVisualStyleBackColor = True
        '
        'tbFolderGRMresults
        '
        Me.tbFolderGRMresults.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFolderGRMresults.BackColor = System.Drawing.SystemColors.Window
        Me.tbFolderGRMresults.Location = New System.Drawing.Point(268, 51)
        Me.tbFolderGRMresults.Name = "tbFolderGRMresults"
        Me.tbFolderGRMresults.Size = New System.Drawing.Size(559, 21)
        Me.tbFolderGRMresults.TabIndex = 41
        '
        'btSelectGRMResultFolder
        '
        Me.btSelectGRMResultFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSelectGRMResultFolder.Location = New System.Drawing.Point(27, 50)
        Me.btSelectGRMResultFolder.Name = "btSelectGRMResultFolder"
        Me.btSelectGRMResultFolder.Size = New System.Drawing.Size(235, 21)
        Me.btSelectGRMResultFolder.TabIndex = 40
        Me.btSelectGRMResultFolder.Text = "Select GRM modeling results folder"
        Me.btSelectGRMResultFolder.UseVisualStyleBackColor = True
        '
        'btSample
        '
        Me.btSample.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSample.Location = New System.Drawing.Point(833, 23)
        Me.btSample.Name = "btSample"
        Me.btSample.Size = New System.Drawing.Size(33, 23)
        Me.btSample.TabIndex = 37
        Me.btSample.Text = "Ex."
        Me.btSample.UseVisualStyleBackColor = True
        '
        'btSelectObsDataFile
        '
        Me.btSelectObsDataFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSelectObsDataFile.Location = New System.Drawing.Point(27, 23)
        Me.btSelectObsDataFile.Name = "btSelectObsDataFile"
        Me.btSelectObsDataFile.Size = New System.Drawing.Size(235, 21)
        Me.btSelectObsDataFile.TabIndex = 35
        Me.btSelectObsDataFile.Text = "Select observed data file"
        Me.btSelectObsDataFile.UseVisualStyleBackColor = True
        '
        'tbFPNObsData
        '
        Me.tbFPNObsData.Location = New System.Drawing.Point(268, 23)
        Me.tbFPNObsData.Name = "tbFPNObsData"
        Me.tbFPNObsData.Size = New System.Drawing.Size(559, 21)
        Me.tbFPNObsData.TabIndex = 36
        '
        'fGRMToolsGRMMPtools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 689)
        Me.Controls.Add(Me.tbGRMProjectProcessing)
        Me.MaximizeBox = False
        Me.Name = "fGRMToolsGRMMPtools"
        Me.Text = "GRM MP tools"
        Me.tbGRMProjectProcessing.ResumeLayout(False)
        Me.tpMakeProjectFiles.ResumeLayout(False)
        Me.tpMakeProjectFiles.PerformLayout()
        CType(Me.dgvParameters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpSummarizeGRMresults.ResumeLayout(False)
        Me.tpSummarizeGRMresults.PerformLayout()
        CType(Me.dgvObservedValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbGRMProjectProcessing As System.Windows.Forms.TabControl
    Friend WithEvents tpMakeProjectFiles As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbTargetFP As System.Windows.Forms.TextBox
    Friend WithEvents btMakeGRMProjectFiles As System.Windows.Forms.Button
    Friend WithEvents dgvParameters As System.Windows.Forms.DataGridView
    Friend WithEvents btViewCSVTextFileFormat As System.Windows.Forms.Button
    Friend WithEvents tbCSVfpn As System.Windows.Forms.TextBox
    Friend WithEvents btSelectParameterCSVFile As System.Windows.Forms.Button
    Friend WithEvents tbBaseProjectFPN As System.Windows.Forms.TextBox
    Friend WithEvents btSelectBaseGRMPrjFile As System.Windows.Forms.Button
    Friend WithEvents tpSummarizeGRMresults As System.Windows.Forms.TabPage
    Friend WithEvents btSample As System.Windows.Forms.Button
    Friend WithEvents btSelectObsDataFile As System.Windows.Forms.Button
    Friend WithEvents tbFPNObsData As System.Windows.Forms.TextBox
    Friend WithEvents tbFolderGRMresults As System.Windows.Forms.TextBox
    Friend WithEvents btSelectGRMResultFolder As System.Windows.Forms.Button
    Friend WithEvents lstbGRMresultsFileList As System.Windows.Forms.ListBox
    Friend WithEvents dgvObservedValue As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btMakeSummaryFile As System.Windows.Forms.Button
    Friend WithEvents tbDestinationFPN As System.Windows.Forms.TextBox
    Friend WithEvents btSelectDestinationFile As System.Windows.Forms.Button
    Friend WithEvents cbColumnName As CheckBox
End Class
