<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fGRMToolsGenerateRFfromSatelliteImage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fGRMToolsGenerateRFfromSatelliteImage))
        Me.txtResultFilePrefix = New System.Windows.Forms.TextBox()
        Me.btStartRFGeneration = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gbNAWT = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNAWTT50 = New System.Windows.Forms.TextBox()
        Me.txtNAWTT10 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTSTepmK = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvRGDFileListToApply = New System.Windows.Forms.DataGridView()
        Me.ColOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btRemoveAll = New System.Windows.Forms.Button()
        Me.btRemoveSelected = New System.Windows.Forms.Button()
        Me.btAddAllFiles = New System.Windows.Forms.Button()
        Me.btAddSelectedFile = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtResultFileSuffix = New System.Windows.Forms.TextBox()
        Me.txtDestinationFolderPath = New System.Windows.Forms.TextBox()
        Me.btOpenDestinationFolder = New System.Windows.Forms.Button()
        Me.rbNAWT = New System.Windows.Forms.RadioButton()
        Me.rbPowerLaw = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gbSearchRFfile = New System.Windows.Forms.GroupBox()
        Me.lstRFfiles = New System.Windows.Forms.ListBox()
        Me.txtFolderPathSource = New System.Windows.Forms.TextBox()
        Me.btOpenRfFolder = New System.Windows.Forms.Button()
        Me.gbNAWT.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvRGDFileListToApply, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbSearchRFfile.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtResultFilePrefix
        '
        Me.txtResultFilePrefix.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResultFilePrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultFilePrefix.Location = New System.Drawing.Point(58, 21)
        Me.txtResultFilePrefix.Name = "txtResultFilePrefix"
        Me.txtResultFilePrefix.Size = New System.Drawing.Size(90, 21)
        Me.txtResultFilePrefix.TabIndex = 21
        '
        'btStartRFGeneration
        '
        Me.btStartRFGeneration.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btStartRFGeneration.Location = New System.Drawing.Point(409, 441)
        Me.btStartRFGeneration.Name = "btStartRFGeneration"
        Me.btStartRFGeneration.Size = New System.Drawing.Size(301, 24)
        Me.btStartRFGeneration.TabIndex = 1
        Me.btStartRFGeneration.Text = "Start calculation"
        Me.btStartRFGeneration.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 12)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Prefix:"
        '
        'gbNAWT
        '
        Me.gbNAWT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbNAWT.Controls.Add(Me.Label6)
        Me.gbNAWT.Controls.Add(Me.txtNAWTT50)
        Me.gbNAWT.Controls.Add(Me.txtNAWTT10)
        Me.gbNAWT.Controls.Add(Me.Label8)
        Me.gbNAWT.Controls.Add(Me.txtTSTepmK)
        Me.gbNAWT.Controls.Add(Me.Label1)
        Me.gbNAWT.Controls.Add(Me.Label7)
        Me.gbNAWT.Location = New System.Drawing.Point(168, 319)
        Me.gbNAWT.Name = "gbNAWT"
        Me.gbNAWT.Size = New System.Drawing.Size(233, 146)
        Me.gbNAWT.TabIndex = 16
        Me.gbNAWT.TabStop = False
        Me.gbNAWT.Text = "NAWT method parameters"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 12)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Threshold temperature[K] :"
        '
        'txtNAWTT50
        '
        Me.txtNAWTT50.Location = New System.Drawing.Point(180, 54)
        Me.txtNAWTT50.Name = "txtNAWTT50"
        Me.txtNAWTT50.Size = New System.Drawing.Size(39, 21)
        Me.txtNAWTT50.TabIndex = 18
        Me.txtNAWTT50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNAWTT10
        '
        Me.txtNAWTT10.Location = New System.Drawing.Point(180, 81)
        Me.txtNAWTT10.Name = "txtNAWTT10"
        Me.txtNAWTT10.Size = New System.Drawing.Size(39, 21)
        Me.txtNAWTT10.TabIndex = 19
        Me.txtNAWTT10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 12)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Rain depth for T50[mm] :"
        '
        'txtTSTepmK
        '
        Me.txtTSTepmK.Location = New System.Drawing.Point(180, 26)
        Me.txtTSTepmK.Name = "txtTSTepmK"
        Me.txtTSTepmK.Size = New System.Drawing.Size(39, 21)
        Me.txtTSTepmK.TabIndex = 17
        Me.txtTSTepmK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "(Rain depth for 0.5 hr data interval)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 12)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Rain depth for T10[mm] :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvRGDFileListToApply)
        Me.GroupBox1.Controls.Add(Me.btRemoveAll)
        Me.GroupBox1.Controls.Add(Me.btRemoveSelected)
        Me.GroupBox1.Location = New System.Drawing.Point(354, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 293)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selected precipitation files"
        '
        'dgvRGDFileListToApply
        '
        Me.dgvRGDFileListToApply.AllowUserToAddRows = False
        Me.dgvRGDFileListToApply.AllowUserToDeleteRows = False
        Me.dgvRGDFileListToApply.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRGDFileListToApply.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRGDFileListToApply.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRGDFileListToApply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRGDFileListToApply.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColOrder, Me.ColFileName, Me.ColPath})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRGDFileListToApply.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRGDFileListToApply.Location = New System.Drawing.Point(10, 22)
        Me.dgvRGDFileListToApply.Name = "dgvRGDFileListToApply"
        Me.dgvRGDFileListToApply.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRGDFileListToApply.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRGDFileListToApply.RowHeadersVisible = False
        Me.dgvRGDFileListToApply.RowTemplate.Height = 23
        Me.dgvRGDFileListToApply.Size = New System.Drawing.Size(337, 228)
        Me.dgvRGDFileListToApply.TabIndex = 9
        '
        'ColOrder
        '
        Me.ColOrder.DataPropertyName = "FileOrder"
        Me.ColOrder.HeaderText = "Order"
        Me.ColOrder.Name = "ColOrder"
        Me.ColOrder.ReadOnly = True
        Me.ColOrder.Width = 61
        '
        'ColFileName
        '
        Me.ColFileName.DataPropertyName = "FileName"
        Me.ColFileName.HeaderText = "File Name"
        Me.ColFileName.Name = "ColFileName"
        Me.ColFileName.ReadOnly = True
        Me.ColFileName.Width = 88
        '
        'ColPath
        '
        Me.ColPath.DataPropertyName = "FilePath"
        Me.ColPath.HeaderText = "File Path"
        Me.ColPath.Name = "ColPath"
        Me.ColPath.ReadOnly = True
        Me.ColPath.Width = 79
        '
        'btRemoveAll
        '
        Me.btRemoveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveAll.Location = New System.Drawing.Point(10, 258)
        Me.btRemoveAll.Name = "btRemoveAll"
        Me.btRemoveAll.Size = New System.Drawing.Size(166, 25)
        Me.btRemoveAll.TabIndex = 10
        Me.btRemoveAll.Text = "Remove all"
        Me.btRemoveAll.UseVisualStyleBackColor = True
        '
        'btRemoveSelected
        '
        Me.btRemoveSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveSelected.Location = New System.Drawing.Point(181, 258)
        Me.btRemoveSelected.Name = "btRemoveSelected"
        Me.btRemoveSelected.Size = New System.Drawing.Size(166, 25)
        Me.btRemoveSelected.TabIndex = 11
        Me.btRemoveSelected.Text = "Remove selected"
        Me.btRemoveSelected.UseVisualStyleBackColor = True
        '
        'btAddAllFiles
        '
        Me.btAddAllFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btAddAllFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddAllFiles.Location = New System.Drawing.Point(67, 258)
        Me.btAddAllFiles.Name = "btAddAllFiles"
        Me.btAddAllFiles.Size = New System.Drawing.Size(131, 25)
        Me.btAddAllFiles.TabIndex = 6
        Me.btAddAllFiles.Text = "Add all"
        Me.btAddAllFiles.UseVisualStyleBackColor = True
        '
        'btAddSelectedFile
        '
        Me.btAddSelectedFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btAddSelectedFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddSelectedFile.Location = New System.Drawing.Point(204, 258)
        Me.btAddSelectedFile.Name = "btAddSelectedFile"
        Me.btAddSelectedFile.Size = New System.Drawing.Size(127, 25)
        Me.btAddSelectedFile.TabIndex = 7
        Me.btAddSelectedFile.Text = "Add selected"
        Me.btAddSelectedFile.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(159, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 12)
        Me.Label5.TabIndex = 212
        Me.Label5.Text = "Suffix:"
        '
        'txtResultFileSuffix
        '
        Me.txtResultFileSuffix.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResultFileSuffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultFileSuffix.Location = New System.Drawing.Point(202, 21)
        Me.txtResultFileSuffix.Name = "txtResultFileSuffix"
        Me.txtResultFileSuffix.Size = New System.Drawing.Size(90, 21)
        Me.txtResultFileSuffix.TabIndex = 22
        '
        'txtDestinationFolderPath
        '
        Me.txtDestinationFolderPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDestinationFolderPath.BackColor = System.Drawing.SystemColors.Window
        Me.txtDestinationFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestinationFolderPath.Location = New System.Drawing.Point(16, 76)
        Me.txtDestinationFolderPath.Name = "txtDestinationFolderPath"
        Me.txtDestinationFolderPath.Size = New System.Drawing.Size(276, 21)
        Me.txtDestinationFolderPath.TabIndex = 24
        '
        'btOpenDestinationFolder
        '
        Me.btOpenDestinationFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btOpenDestinationFolder.Location = New System.Drawing.Point(16, 51)
        Me.btOpenDestinationFolder.Name = "btOpenDestinationFolder"
        Me.btOpenDestinationFolder.Size = New System.Drawing.Size(117, 21)
        Me.btOpenDestinationFolder.TabIndex = 23
        Me.btOpenDestinationFolder.Text = "Destination folder"
        Me.btOpenDestinationFolder.UseVisualStyleBackColor = True
        '
        'rbNAWT
        '
        Me.rbNAWT.AutoSize = True
        Me.rbNAWT.Checked = True
        Me.rbNAWT.Location = New System.Drawing.Point(18, 25)
        Me.rbNAWT.Name = "rbNAWT"
        Me.rbNAWT.Size = New System.Drawing.Size(104, 16)
        Me.rbNAWT.TabIndex = 14
        Me.rbNAWT.TabStop = True
        Me.rbNAWT.Text = "NAWT method"
        Me.rbNAWT.UseVisualStyleBackColor = True
        '
        'rbPowerLaw
        '
        Me.rbPowerLaw.AutoSize = True
        Me.rbPowerLaw.Location = New System.Drawing.Point(18, 53)
        Me.rbPowerLaw.Name = "rbPowerLaw"
        Me.rbPowerLaw.Size = New System.Drawing.Size(83, 16)
        Me.rbPowerLaw.TabIndex = 15
        Me.rbPowerLaw.Text = "Power law"
        Me.rbPowerLaw.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.rbNAWT)
        Me.GroupBox3.Controls.Add(Me.rbPowerLaw)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 319)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(149, 146)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select method"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtResultFilePrefix)
        Me.GroupBox4.Controls.Add(Me.txtDestinationFolderPath)
        Me.GroupBox4.Controls.Add(Me.txtResultFileSuffix)
        Me.GroupBox4.Controls.Add(Me.btOpenDestinationFolder)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(409, 319)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(301, 109)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Result file"
        '
        'gbSearchRFfile
        '
        Me.gbSearchRFfile.Controls.Add(Me.btAddAllFiles)
        Me.gbSearchRFfile.Controls.Add(Me.btAddSelectedFile)
        Me.gbSearchRFfile.Controls.Add(Me.lstRFfiles)
        Me.gbSearchRFfile.Controls.Add(Me.txtFolderPathSource)
        Me.gbSearchRFfile.Controls.Add(Me.btOpenRfFolder)
        Me.gbSearchRFfile.Location = New System.Drawing.Point(11, 17)
        Me.gbSearchRFfile.Name = "gbSearchRFfile"
        Me.gbSearchRFfile.Size = New System.Drawing.Size(337, 293)
        Me.gbSearchRFfile.TabIndex = 25
        Me.gbSearchRFfile.TabStop = False
        Me.gbSearchRFfile.Text = "Search rainfall files"
        '
        'lstRFfiles
        '
        Me.lstRFfiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstRFfiles.FormattingEnabled = True
        Me.lstRFfiles.HorizontalScrollbar = True
        Me.lstRFfiles.ItemHeight = 12
        Me.lstRFfiles.Location = New System.Drawing.Point(6, 54)
        Me.lstRFfiles.Name = "lstRFfiles"
        Me.lstRFfiles.Size = New System.Drawing.Size(325, 196)
        Me.lstRFfiles.TabIndex = 36
        '
        'txtFolderPathSource
        '
        Me.txtFolderPathSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFolderPathSource.BackColor = System.Drawing.SystemColors.Window
        Me.txtFolderPathSource.Location = New System.Drawing.Point(6, 25)
        Me.txtFolderPathSource.Name = "txtFolderPathSource"
        Me.txtFolderPathSource.Size = New System.Drawing.Size(233, 21)
        Me.txtFolderPathSource.TabIndex = 35
        '
        'btOpenRfFolder
        '
        Me.btOpenRfFolder.Location = New System.Drawing.Point(246, 24)
        Me.btOpenRfFolder.Name = "btOpenRfFolder"
        Me.btOpenRfFolder.Size = New System.Drawing.Size(85, 21)
        Me.btOpenRfFolder.TabIndex = 34
        Me.btOpenRfFolder.Text = "Select folder"
        Me.btOpenRfFolder.UseVisualStyleBackColor = True
        '
        'fGRMToolsGenerateRFfromSatelliteImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 480)
        Me.Controls.Add(Me.gbSearchRFfile)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbNAWT)
        Me.Controls.Add(Me.btStartRFGeneration)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fGRMToolsGenerateRFfromSatelliteImage"
        Me.Text = "Generate precipitation from satellite images"
        Me.gbNAWT.ResumeLayout(False)
        Me.gbNAWT.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvRGDFileListToApply, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbSearchRFfile.ResumeLayout(False)
        Me.gbSearchRFfile.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtResultFilePrefix As System.Windows.Forms.TextBox
    Friend WithEvents btStartRFGeneration As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gbNAWT As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNAWTT50 As System.Windows.Forms.TextBox
    Friend WithEvents txtNAWTT10 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTSTepmK As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvRGDFileListToApply As System.Windows.Forms.DataGridView
    Friend WithEvents btRemoveAll As System.Windows.Forms.Button
    Friend WithEvents btRemoveSelected As System.Windows.Forms.Button
    Friend WithEvents btAddAllFiles As System.Windows.Forms.Button
    Friend WithEvents btAddSelectedFile As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtResultFileSuffix As System.Windows.Forms.TextBox
    Friend WithEvents txtDestinationFolderPath As System.Windows.Forms.TextBox
    Friend WithEvents btOpenDestinationFolder As System.Windows.Forms.Button
    Friend WithEvents rbNAWT As System.Windows.Forms.RadioButton
    Friend WithEvents rbPowerLaw As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColFileName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gbSearchRFfile As System.Windows.Forms.GroupBox
    Friend WithEvents lstRFfiles As System.Windows.Forms.ListBox
    Friend WithEvents txtFolderPathSource As System.Windows.Forms.TextBox
    Friend WithEvents btOpenRfFolder As System.Windows.Forms.Button
End Class
