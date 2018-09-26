<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fGRMToolsGDSAnalyzer
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fGRMToolsGDSAnalyzer))
        Me.btRemoveAll = New System.Windows.Forms.Button()
        Me.btRemoveSelected = New System.Windows.Forms.Button()
        Me.dgvRGDFileListToApply = New System.Windows.Forms.DataGridView()
        Me.ColOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbSearchRFfile = New System.Windows.Forms.GroupBox()
        Me.lstRFfiles = New System.Windows.Forms.ListBox()
        Me.txtFolderPathSource = New System.Windows.Forms.TextBox()
        Me.btAddAllFiles = New System.Windows.Forms.Button()
        Me.btOpenRfFolder = New System.Windows.Forms.Button()
        Me.btAddSelectedFile = New System.Windows.Forms.Button()
        Me.gbDataType = New System.Windows.Forms.GroupBox()
        Me.rbASC = New System.Windows.Forms.RadioButton()
        Me.rbGTiff = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpGD = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btCellPosViewSample = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFNPCellPosTextfile = New System.Windows.Forms.TextBox()
        Me.cmbNameField = New System.Windows.Forms.ComboBox()
        Me.cmbPointLayer = New System.Windows.Forms.ComboBox()
        Me.btLoadCellPosTextfile = New System.Windows.Forms.Button()
        Me.rbLoadCellPosUsingPointLayer = New System.Windows.Forms.RadioButton()
        Me.rbLoadCellPosUsingTextFile = New System.Windows.Forms.RadioButton()
        Me.btSelectFloderAndSaveGP = New System.Windows.Forms.Button()
        Me.btStartGDExtraction = New System.Windows.Forms.Button()
        Me.dgvGPSummary = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpAM = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWSidsToCombine = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmbWSLayer = New System.Windows.Forms.ComboBox()
        Me.dgvMAPSummary = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btCombineAM = New System.Windows.Forms.Button()
        Me.btCalculateAM = New System.Windows.Forms.Button()
        Me.btSelectFloderAndSaveMAP = New System.Windows.Forms.Button()
        Me.tpAcc = New System.Windows.Forms.TabPage()
        Me.gbDataSelection = New System.Windows.Forms.GroupBox()
        Me.rbAggregate = New System.Windows.Forms.RadioButton()
        Me.rbAccAllFiles = New System.Windows.Forms.RadioButton()
        Me.gbResultFile = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtResultTimeInterval = New System.Windows.Forms.TextBox()
        Me.labAgg = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpStartingTime = New System.Windows.Forms.DateTimePicker()
        Me.gbSourceData = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSourceTimeInterval = New System.Windows.Forms.TextBox()
        Me.rbmmPh = New System.Windows.Forms.RadioButton()
        Me.txtResultlGridFileNameAcc = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDestinationFolderPathAcc = New System.Windows.Forms.TextBox()
        Me.btOpenDestinationFolder = New System.Windows.Forms.Button()
        Me.btStartAccumulation = New System.Windows.Forms.Button()
        CType(Me.dgvRGDFileListToApply, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbSearchRFfile.SuspendLayout()
        Me.gbDataType.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpGD.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvGPSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAM.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvMAPSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAcc.SuspendLayout()
        Me.gbDataSelection.SuspendLayout()
        Me.gbResultFile.SuspendLayout()
        Me.gbSourceData.SuspendLayout()
        Me.SuspendLayout()
        '
        'btRemoveAll
        '
        Me.btRemoveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveAll.Location = New System.Drawing.Point(16, 252)
        Me.btRemoveAll.Name = "btRemoveAll"
        Me.btRemoveAll.Size = New System.Drawing.Size(189, 25)
        Me.btRemoveAll.TabIndex = 9
        Me.btRemoveAll.Text = "Remove all"
        Me.btRemoveAll.UseVisualStyleBackColor = True
        '
        'btRemoveSelected
        '
        Me.btRemoveSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveSelected.Location = New System.Drawing.Point(209, 252)
        Me.btRemoveSelected.Name = "btRemoveSelected"
        Me.btRemoveSelected.Size = New System.Drawing.Size(178, 25)
        Me.btRemoveSelected.TabIndex = 10
        Me.btRemoveSelected.Text = "Remove selected"
        Me.btRemoveSelected.UseVisualStyleBackColor = True
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
        Me.dgvRGDFileListToApply.Location = New System.Drawing.Point(16, 22)
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
        Me.dgvRGDFileListToApply.Size = New System.Drawing.Size(371, 218)
        Me.dgvRGDFileListToApply.TabIndex = 8
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gbSearchRFfile)
        Me.GroupBox2.Controls.Add(Me.gbDataType)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 287)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search files"
        '
        'gbSearchRFfile
        '
        Me.gbSearchRFfile.Controls.Add(Me.lstRFfiles)
        Me.gbSearchRFfile.Controls.Add(Me.txtFolderPathSource)
        Me.gbSearchRFfile.Controls.Add(Me.btAddAllFiles)
        Me.gbSearchRFfile.Controls.Add(Me.btOpenRfFolder)
        Me.gbSearchRFfile.Controls.Add(Me.btAddSelectedFile)
        Me.gbSearchRFfile.Location = New System.Drawing.Point(6, 70)
        Me.gbSearchRFfile.Name = "gbSearchRFfile"
        Me.gbSearchRFfile.Size = New System.Drawing.Size(360, 207)
        Me.gbSearchRFfile.TabIndex = 24
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
        Me.lstRFfiles.Size = New System.Drawing.Size(344, 112)
        Me.lstRFfiles.TabIndex = 36
        '
        'txtFolderPathSource
        '
        Me.txtFolderPathSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFolderPathSource.BackColor = System.Drawing.SystemColors.Window
        Me.txtFolderPathSource.Location = New System.Drawing.Point(6, 25)
        Me.txtFolderPathSource.Name = "txtFolderPathSource"
        Me.txtFolderPathSource.Size = New System.Drawing.Size(256, 21)
        Me.txtFolderPathSource.TabIndex = 35
        '
        'btAddAllFiles
        '
        Me.btAddAllFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddAllFiles.Location = New System.Drawing.Point(83, 172)
        Me.btAddAllFiles.Name = "btAddAllFiles"
        Me.btAddAllFiles.Size = New System.Drawing.Size(126, 25)
        Me.btAddAllFiles.TabIndex = 5
        Me.btAddAllFiles.Text = "Add all"
        Me.btAddAllFiles.UseVisualStyleBackColor = True
        '
        'btOpenRfFolder
        '
        Me.btOpenRfFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btOpenRfFolder.Location = New System.Drawing.Point(265, 24)
        Me.btOpenRfFolder.Name = "btOpenRfFolder"
        Me.btOpenRfFolder.Size = New System.Drawing.Size(85, 21)
        Me.btOpenRfFolder.TabIndex = 34
        Me.btOpenRfFolder.Text = "Select folder"
        Me.btOpenRfFolder.UseVisualStyleBackColor = True
        '
        'btAddSelectedFile
        '
        Me.btAddSelectedFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddSelectedFile.Location = New System.Drawing.Point(224, 172)
        Me.btAddSelectedFile.Name = "btAddSelectedFile"
        Me.btAddSelectedFile.Size = New System.Drawing.Size(126, 25)
        Me.btAddSelectedFile.TabIndex = 6
        Me.btAddSelectedFile.Text = "Add selected"
        Me.btAddSelectedFile.UseVisualStyleBackColor = True
        '
        'gbDataType
        '
        Me.gbDataType.Controls.Add(Me.rbASC)
        Me.gbDataType.Controls.Add(Me.rbGTiff)
        Me.gbDataType.Location = New System.Drawing.Point(6, 20)
        Me.gbDataType.Name = "gbDataType"
        Me.gbDataType.Size = New System.Drawing.Size(360, 44)
        Me.gbDataType.TabIndex = 9
        Me.gbDataType.TabStop = False
        Me.gbDataType.Text = "Data type"
        '
        'rbASC
        '
        Me.rbASC.AutoSize = True
        Me.rbASC.Location = New System.Drawing.Point(201, 20)
        Me.rbASC.Name = "rbASC"
        Me.rbASC.Size = New System.Drawing.Size(74, 16)
        Me.rbASC.TabIndex = 8
        Me.rbASC.Text = "ASCII file"
        Me.rbASC.UseVisualStyleBackColor = True
        '
        'rbGTiff
        '
        Me.rbGTiff.AutoSize = True
        Me.rbGTiff.Checked = True
        Me.rbGTiff.Location = New System.Drawing.Point(27, 20)
        Me.rbGTiff.Name = "rbGTiff"
        Me.rbGTiff.Size = New System.Drawing.Size(83, 16)
        Me.rbGTiff.TabIndex = 7
        Me.rbGTiff.TabStop = True
        Me.rbGTiff.Text = "GeoTiff file"
        Me.rbGTiff.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvRGDFileListToApply)
        Me.GroupBox1.Controls.Add(Me.btRemoveAll)
        Me.GroupBox1.Controls.Add(Me.btRemoveSelected)
        Me.GroupBox1.Location = New System.Drawing.Point(393, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 287)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selected files"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tpGD)
        Me.TabControl1.Controls.Add(Me.tpAM)
        Me.TabControl1.Controls.Add(Me.tpAcc)
        Me.TabControl1.Location = New System.Drawing.Point(12, 305)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(783, 287)
        Me.TabControl1.TabIndex = 11
        '
        'tpGD
        '
        Me.tpGD.Controls.Add(Me.GroupBox3)
        Me.tpGD.Controls.Add(Me.btSelectFloderAndSaveGP)
        Me.tpGD.Controls.Add(Me.btStartGDExtraction)
        Me.tpGD.Controls.Add(Me.dgvGPSummary)
        Me.tpGD.Location = New System.Drawing.Point(4, 22)
        Me.tpGD.Name = "tpGD"
        Me.tpGD.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGD.Size = New System.Drawing.Size(775, 261)
        Me.tpGD.TabIndex = 0
        Me.tpGD.Text = "Extract grid data"
        Me.tpGD.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btCellPosViewSample)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtFNPCellPosTextfile)
        Me.GroupBox3.Controls.Add(Me.cmbNameField)
        Me.GroupBox3.Controls.Add(Me.cmbPointLayer)
        Me.GroupBox3.Controls.Add(Me.btLoadCellPosTextfile)
        Me.GroupBox3.Controls.Add(Me.rbLoadCellPosUsingPointLayer)
        Me.GroupBox3.Controls.Add(Me.rbLoadCellPosUsingTextFile)
        Me.GroupBox3.Location = New System.Drawing.Point(551, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(213, 153)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Set cell position"
        '
        'btCellPosViewSample
        '
        Me.btCellPosViewSample.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCellPosViewSample.Location = New System.Drawing.Point(125, 23)
        Me.btCellPosViewSample.Name = "btCellPosViewSample"
        Me.btCellPosViewSample.Size = New System.Drawing.Size(82, 21)
        Me.btCellPosViewSample.TabIndex = 15
        Me.btCellPosViewSample.Text = "Example..."
        Me.btCellPosViewSample.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name field:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Point layer:"
        '
        'txtFNPCellPosTextfile
        '
        Me.txtFNPCellPosTextfile.Location = New System.Drawing.Point(10, 47)
        Me.txtFNPCellPosTextfile.Name = "txtFNPCellPosTextfile"
        Me.txtFNPCellPosTextfile.Size = New System.Drawing.Size(164, 21)
        Me.txtFNPCellPosTextfile.TabIndex = 16
        '
        'cmbNameField
        '
        Me.cmbNameField.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNameField.FormattingEnabled = True
        Me.cmbNameField.Location = New System.Drawing.Point(81, 124)
        Me.cmbNameField.Name = "cmbNameField"
        Me.cmbNameField.Size = New System.Drawing.Size(126, 20)
        Me.cmbNameField.TabIndex = 20
        '
        'cmbPointLayer
        '
        Me.cmbPointLayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPointLayer.FormattingEnabled = True
        Me.cmbPointLayer.Location = New System.Drawing.Point(81, 100)
        Me.cmbPointLayer.Name = "cmbPointLayer"
        Me.cmbPointLayer.Size = New System.Drawing.Size(126, 20)
        Me.cmbPointLayer.TabIndex = 19
        '
        'btLoadCellPosTextfile
        '
        Me.btLoadCellPosTextfile.Location = New System.Drawing.Point(180, 47)
        Me.btLoadCellPosTextfile.Name = "btLoadCellPosTextfile"
        Me.btLoadCellPosTextfile.Size = New System.Drawing.Size(27, 23)
        Me.btLoadCellPosTextfile.TabIndex = 17
        Me.btLoadCellPosTextfile.Text = "..."
        Me.btLoadCellPosTextfile.UseVisualStyleBackColor = True
        '
        'rbLoadCellPosUsingPointLayer
        '
        Me.rbLoadCellPosUsingPointLayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbLoadCellPosUsingPointLayer.AutoSize = True
        Me.rbLoadCellPosUsingPointLayer.Location = New System.Drawing.Point(10, 79)
        Me.rbLoadCellPosUsingPointLayer.Name = "rbLoadCellPosUsingPointLayer"
        Me.rbLoadCellPosUsingPointLayer.Size = New System.Drawing.Size(108, 16)
        Me.rbLoadCellPosUsingPointLayer.TabIndex = 18
        Me.rbLoadCellPosUsingPointLayer.Text = "Use point layer"
        Me.rbLoadCellPosUsingPointLayer.UseVisualStyleBackColor = True
        '
        'rbLoadCellPosUsingTextFile
        '
        Me.rbLoadCellPosUsingTextFile.AutoSize = True
        Me.rbLoadCellPosUsingTextFile.Checked = True
        Me.rbLoadCellPosUsingTextFile.Location = New System.Drawing.Point(10, 25)
        Me.rbLoadCellPosUsingTextFile.Name = "rbLoadCellPosUsingTextFile"
        Me.rbLoadCellPosUsingTextFile.Size = New System.Drawing.Size(89, 16)
        Me.rbLoadCellPosUsingTextFile.TabIndex = 14
        Me.rbLoadCellPosUsingTextFile.TabStop = True
        Me.rbLoadCellPosUsingTextFile.Text = "Use text file"
        Me.rbLoadCellPosUsingTextFile.UseVisualStyleBackColor = True
        '
        'btSelectFloderAndSaveGP
        '
        Me.btSelectFloderAndSaveGP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelectFloderAndSaveGP.Location = New System.Drawing.Point(551, 233)
        Me.btSelectFloderAndSaveGP.Name = "btSelectFloderAndSaveGP"
        Me.btSelectFloderAndSaveGP.Size = New System.Drawing.Size(213, 23)
        Me.btSelectFloderAndSaveGP.TabIndex = 22
        Me.btSelectFloderAndSaveGP.Text = "Save calculation result"
        Me.btSelectFloderAndSaveGP.UseVisualStyleBackColor = True
        '
        'btStartGDExtraction
        '
        Me.btStartGDExtraction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btStartGDExtraction.Location = New System.Drawing.Point(551, 165)
        Me.btStartGDExtraction.Name = "btStartGDExtraction"
        Me.btStartGDExtraction.Size = New System.Drawing.Size(213, 23)
        Me.btStartGDExtraction.TabIndex = 21
        Me.btStartGDExtraction.Text = "Start calculation"
        Me.btStartGDExtraction.UseVisualStyleBackColor = True
        '
        'dgvGPSummary
        '
        Me.dgvGPSummary.AllowUserToAddRows = False
        Me.dgvGPSummary.AllowUserToDeleteRows = False
        Me.dgvGPSummary.AllowUserToResizeRows = False
        Me.dgvGPSummary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGPSummary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGPSummary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvGPSummary.ColumnHeadersHeight = 20
        Me.dgvGPSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvGPSummary.Location = New System.Drawing.Point(6, 10)
        Me.dgvGPSummary.MultiSelect = False
        Me.dgvGPSummary.Name = "dgvGPSummary"
        Me.dgvGPSummary.RowHeadersWidth = 10
        Me.dgvGPSummary.RowTemplate.Height = 23
        Me.dgvGPSummary.Size = New System.Drawing.Size(539, 246)
        Me.dgvGPSummary.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "Name"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.HeaderText = "ColX"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "RowY"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cumulative"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 70
        '
        'Column5
        '
        Me.Column5.HeaderText = "Maximum"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 70
        '
        'Column6
        '
        Me.Column6.HeaderText = "Minimum"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "Average"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 70
        '
        'Column8
        '
        Me.Column8.HeaderText = "Time series"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 85
        '
        'tpAM
        '
        Me.tpAM.Controls.Add(Me.GroupBox5)
        Me.tpAM.Controls.Add(Me.GroupBox4)
        Me.tpAM.Controls.Add(Me.dgvMAPSummary)
        Me.tpAM.Controls.Add(Me.btCombineAM)
        Me.tpAM.Controls.Add(Me.btCalculateAM)
        Me.tpAM.Controls.Add(Me.btSelectFloderAndSaveMAP)
        Me.tpAM.Location = New System.Drawing.Point(4, 22)
        Me.tpAM.Name = "tpAM"
        Me.tpAM.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAM.Size = New System.Drawing.Size(775, 261)
        Me.tpAM.TabIndex = 1
        Me.tpAM.Text = "Cal. areal mean in wateshed"
        Me.tpAM.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtWSidsToCombine)
        Me.GroupBox5.Location = New System.Drawing.Point(551, 102)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(213, 65)
        Me.GroupBox5.TabIndex = 27
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Watershed IDs to combine"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 12)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "(Example: 1, 2, 3 ...)"
        '
        'txtWSidsToCombine
        '
        Me.txtWSidsToCombine.Location = New System.Drawing.Point(7, 21)
        Me.txtWSidsToCombine.Name = "txtWSidsToCombine"
        Me.txtWSidsToCombine.Size = New System.Drawing.Size(200, 21)
        Me.txtWSidsToCombine.TabIndex = 28
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.cmbWSLayer)
        Me.GroupBox4.Location = New System.Drawing.Point(551, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(213, 51)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Select watershed layer"
        '
        'cmbWSLayer
        '
        Me.cmbWSLayer.FormattingEnabled = True
        Me.cmbWSLayer.Location = New System.Drawing.Point(7, 20)
        Me.cmbWSLayer.Name = "cmbWSLayer"
        Me.cmbWSLayer.Size = New System.Drawing.Size(200, 20)
        Me.cmbWSLayer.TabIndex = 25
        '
        'dgvMAPSummary
        '
        Me.dgvMAPSummary.AllowUserToAddRows = False
        Me.dgvMAPSummary.AllowUserToDeleteRows = False
        Me.dgvMAPSummary.AllowUserToResizeRows = False
        Me.dgvMAPSummary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMAPSummary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMAPSummary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMAPSummary.ColumnHeadersHeight = 20
        Me.dgvMAPSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgvMAPSummary.Location = New System.Drawing.Point(6, 10)
        Me.dgvMAPSummary.Name = "dgvMAPSummary"
        Me.dgvMAPSummary.RowHeadersWidth = 10
        Me.dgvMAPSummary.RowTemplate.Height = 23
        Me.dgvMAPSummary.Size = New System.Drawing.Size(539, 246)
        Me.dgvMAPSummary.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Watershed ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cell count"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cumulative"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Maximum"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Minimum"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Average"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Time series"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 85
        '
        'btCombineAM
        '
        Me.btCombineAM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCombineAM.Location = New System.Drawing.Point(551, 173)
        Me.btCombineAM.Name = "btCombineAM"
        Me.btCombineAM.Size = New System.Drawing.Size(213, 23)
        Me.btCombineAM.TabIndex = 29
        Me.btCombineAM.Text = "Combine areal mean"
        Me.btCombineAM.UseVisualStyleBackColor = True
        '
        'btCalculateAM
        '
        Me.btCalculateAM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCalculateAM.Location = New System.Drawing.Point(551, 64)
        Me.btCalculateAM.Name = "btCalculateAM"
        Me.btCalculateAM.Size = New System.Drawing.Size(213, 23)
        Me.btCalculateAM.TabIndex = 26
        Me.btCalculateAM.Text = "Calculate areal mean"
        Me.btCalculateAM.UseVisualStyleBackColor = True
        '
        'btSelectFloderAndSaveMAP
        '
        Me.btSelectFloderAndSaveMAP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelectFloderAndSaveMAP.Location = New System.Drawing.Point(551, 233)
        Me.btSelectFloderAndSaveMAP.Name = "btSelectFloderAndSaveMAP"
        Me.btSelectFloderAndSaveMAP.Size = New System.Drawing.Size(213, 23)
        Me.btSelectFloderAndSaveMAP.TabIndex = 30
        Me.btSelectFloderAndSaveMAP.Text = "Save calculation result"
        Me.btSelectFloderAndSaveMAP.UseVisualStyleBackColor = True
        '
        'tpAcc
        '
        Me.tpAcc.Controls.Add(Me.rbmmPh)
        Me.tpAcc.Controls.Add(Me.gbDataSelection)
        Me.tpAcc.Controls.Add(Me.gbResultFile)
        Me.tpAcc.Controls.Add(Me.gbSourceData)
        Me.tpAcc.Controls.Add(Me.txtResultlGridFileNameAcc)
        Me.tpAcc.Controls.Add(Me.Label14)
        Me.tpAcc.Controls.Add(Me.txtDestinationFolderPathAcc)
        Me.tpAcc.Controls.Add(Me.btOpenDestinationFolder)
        Me.tpAcc.Controls.Add(Me.btStartAccumulation)
        Me.tpAcc.Location = New System.Drawing.Point(4, 22)
        Me.tpAcc.Name = "tpAcc"
        Me.tpAcc.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAcc.Size = New System.Drawing.Size(775, 261)
        Me.tpAcc.TabIndex = 2
        Me.tpAcc.Text = "Accumulate grid data"
        Me.tpAcc.UseVisualStyleBackColor = True
        '
        'gbDataSelection
        '
        Me.gbDataSelection.Controls.Add(Me.rbAggregate)
        Me.gbDataSelection.Controls.Add(Me.rbAccAllFiles)
        Me.gbDataSelection.Location = New System.Drawing.Point(15, 17)
        Me.gbDataSelection.Name = "gbDataSelection"
        Me.gbDataSelection.Size = New System.Drawing.Size(248, 91)
        Me.gbDataSelection.TabIndex = 200
        Me.gbDataSelection.TabStop = False
        Me.gbDataSelection.Text = "Data selection"
        '
        'rbAggregate
        '
        Me.rbAggregate.AutoSize = True
        Me.rbAggregate.Location = New System.Drawing.Point(17, 57)
        Me.rbAggregate.Name = "rbAggregate"
        Me.rbAggregate.Size = New System.Drawing.Size(182, 16)
        Me.rbAggregate.TabIndex = 1
        Me.rbAggregate.Text = "Aggregate specifiled interval"
        Me.rbAggregate.UseVisualStyleBackColor = True
        '
        'rbAccAllFiles
        '
        Me.rbAccAllFiles.AutoSize = True
        Me.rbAccAllFiles.Checked = True
        Me.rbAccAllFiles.Location = New System.Drawing.Point(17, 26)
        Me.rbAccAllFiles.Name = "rbAccAllFiles"
        Me.rbAccAllFiles.Size = New System.Drawing.Size(134, 16)
        Me.rbAccAllFiles.TabIndex = 0
        Me.rbAccAllFiles.TabStop = True
        Me.rbAccAllFiles.Text = "Accumulate all files"
        Me.rbAccAllFiles.UseVisualStyleBackColor = True
        '
        'gbResultFile
        '
        Me.gbResultFile.Controls.Add(Me.Label5)
        Me.gbResultFile.Controls.Add(Me.txtResultTimeInterval)
        Me.gbResultFile.Controls.Add(Me.labAgg)
        Me.gbResultFile.Controls.Add(Me.Label3)
        Me.gbResultFile.Controls.Add(Me.dtpStartingTime)
        Me.gbResultFile.Location = New System.Drawing.Point(508, 17)
        Me.gbResultFile.Name = "gbResultFile"
        Me.gbResultFile.Size = New System.Drawing.Size(256, 148)
        Me.gbResultFile.TabIndex = 199
        Me.gbResultFile.TabStop = False
        Me.gbResultFile.Text = "Result data info."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 12)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Time interval[min] :"
        '
        'txtResultTimeInterval
        '
        Me.txtResultTimeInterval.Location = New System.Drawing.Point(148, 23)
        Me.txtResultTimeInterval.Name = "txtResultTimeInterval"
        Me.txtResultTimeInterval.Size = New System.Drawing.Size(74, 21)
        Me.txtResultTimeInterval.TabIndex = 28
        '
        'labAgg
        '
        Me.labAgg.Location = New System.Drawing.Point(5, 89)
        Me.labAgg.Name = "labAgg"
        Me.labAgg.Size = New System.Drawing.Size(245, 55)
        Me.labAgg.TabIndex = 26
        Me.labAgg.Text = "** First file is set on starting time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    without accumulation." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "** The units of" & _
    " result files are " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    mm/(result time interval)."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 12)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Start from :"
        '
        'dtpStartingTime
        '
        Me.dtpStartingTime.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.dtpStartingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartingTime.Location = New System.Drawing.Point(99, 54)
        Me.dtpStartingTime.Name = "dtpStartingTime"
        Me.dtpStartingTime.ShowUpDown = True
        Me.dtpStartingTime.Size = New System.Drawing.Size(123, 21)
        Me.dtpStartingTime.TabIndex = 25
        '
        'gbSourceData
        '
        Me.gbSourceData.Controls.Add(Me.Label6)
        Me.gbSourceData.Controls.Add(Me.txtSourceTimeInterval)
        Me.gbSourceData.Location = New System.Drawing.Point(285, 17)
        Me.gbSourceData.Name = "gbSourceData"
        Me.gbSourceData.Size = New System.Drawing.Size(185, 91)
        Me.gbSourceData.TabIndex = 198
        Me.gbSourceData.TabStop = False
        Me.gbSourceData.Text = "Source data info."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 12)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Time interval[min] :"
        '
        'txtSourceTimeInterval
        '
        Me.txtSourceTimeInterval.Location = New System.Drawing.Point(128, 39)
        Me.txtSourceTimeInterval.Name = "txtSourceTimeInterval"
        Me.txtSourceTimeInterval.Size = New System.Drawing.Size(42, 21)
        Me.txtSourceTimeInterval.TabIndex = 1
        '
        'rbmmPh
        '
        Me.rbmmPh.AutoSize = True
        Me.rbmmPh.Checked = True
        Me.rbmmPh.Location = New System.Drawing.Point(313, 145)
        Me.rbmmPh.Name = "rbmmPh"
        Me.rbmmPh.Size = New System.Drawing.Size(58, 16)
        Me.rbmmPh.TabIndex = 0
        Me.rbmmPh.TabStop = True
        Me.rbmmPh.Text = "mm/h"
        Me.rbmmPh.UseVisualStyleBackColor = True
        Me.rbmmPh.Visible = False
        '
        'txtResultlGridFileNameAcc
        '
        Me.txtResultlGridFileNameAcc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResultlGridFileNameAcc.Location = New System.Drawing.Point(187, 221)
        Me.txtResultlGridFileNameAcc.Name = "txtResultlGridFileNameAcc"
        Me.txtResultlGridFileNameAcc.Size = New System.Drawing.Size(310, 21)
        Me.txtResultlGridFileNameAcc.TabIndex = 196
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(77, 224)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 12)
        Me.Label14.TabIndex = 197
        Me.Label14.Text = "Result file name :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDestinationFolderPathAcc
        '
        Me.txtDestinationFolderPathAcc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDestinationFolderPathAcc.BackColor = System.Drawing.SystemColors.Window
        Me.txtDestinationFolderPathAcc.Location = New System.Drawing.Point(187, 184)
        Me.txtDestinationFolderPathAcc.Name = "txtDestinationFolderPathAcc"
        Me.txtDestinationFolderPathAcc.Size = New System.Drawing.Size(310, 21)
        Me.txtDestinationFolderPathAcc.TabIndex = 33
        '
        'btOpenDestinationFolder
        '
        Me.btOpenDestinationFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btOpenDestinationFolder.Location = New System.Drawing.Point(15, 184)
        Me.btOpenDestinationFolder.Name = "btOpenDestinationFolder"
        Me.btOpenDestinationFolder.Size = New System.Drawing.Size(166, 21)
        Me.btOpenDestinationFolder.TabIndex = 32
        Me.btOpenDestinationFolder.Text = "Select destination folder"
        Me.btOpenDestinationFolder.UseVisualStyleBackColor = True
        '
        'btStartAccumulation
        '
        Me.btStartAccumulation.Location = New System.Drawing.Point(532, 184)
        Me.btStartAccumulation.Name = "btStartAccumulation"
        Me.btStartAccumulation.Size = New System.Drawing.Size(232, 58)
        Me.btStartAccumulation.TabIndex = 12
        Me.btStartAccumulation.Text = "Start accumulation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(All cells in grid layer extent)"
        Me.btStartAccumulation.UseVisualStyleBackColor = True
        '
        'fGRMToolsGDSAnalyzer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 604)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(815, 631)
        Me.Name = "fGRMToolsGDSAnalyzer"
        Me.Text = "Gridded data series analyzer"
        CType(Me.dgvRGDFileListToApply, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbSearchRFfile.ResumeLayout(False)
        Me.gbSearchRFfile.PerformLayout()
        Me.gbDataType.ResumeLayout(False)
        Me.gbDataType.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tpGD.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvGPSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAM.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvMAPSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAcc.ResumeLayout(False)
        Me.tpAcc.PerformLayout()
        Me.gbDataSelection.ResumeLayout(False)
        Me.gbDataSelection.PerformLayout()
        Me.gbResultFile.ResumeLayout(False)
        Me.gbResultFile.PerformLayout()
        Me.gbSourceData.ResumeLayout(False)
        Me.gbSourceData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btRemoveAll As System.Windows.Forms.Button
    Friend WithEvents btRemoveSelected As System.Windows.Forms.Button
    Friend WithEvents dgvRGDFileListToApply As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btAddAllFiles As System.Windows.Forms.Button
    Friend WithEvents btAddSelectedFile As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpGD As System.Windows.Forms.TabPage
    Friend WithEvents tpAM As System.Windows.Forms.TabPage
    Friend WithEvents btLoadCellPosTextfile As System.Windows.Forms.Button
    Friend WithEvents dgvGPSummary As System.Windows.Forms.DataGridView
    Friend WithEvents btSelectFloderAndSaveGP As System.Windows.Forms.Button
    Friend WithEvents btStartGDExtraction As System.Windows.Forms.Button
    Friend WithEvents btSelectFloderAndSaveMAP As System.Windows.Forms.Button
    Friend WithEvents btCalculateAM As System.Windows.Forms.Button
    Friend WithEvents dgvMAPSummary As System.Windows.Forms.DataGridView
    Friend WithEvents cmbPointLayer As System.Windows.Forms.ComboBox
    Friend WithEvents rbLoadCellPosUsingPointLayer As System.Windows.Forms.RadioButton
    Friend WithEvents rbLoadCellPosUsingTextFile As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbWSLayer As System.Windows.Forms.ComboBox
    Friend WithEvents btCombineAM As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtWSidsToCombine As System.Windows.Forms.TextBox
    Friend WithEvents txtFNPCellPosTextfile As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNameField As System.Windows.Forms.ComboBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btCellPosViewSample As System.Windows.Forms.Button
    Friend WithEvents tpAcc As System.Windows.Forms.TabPage
    Friend WithEvents btStartAccumulation As System.Windows.Forms.Button
    Friend WithEvents txtDestinationFolderPathAcc As System.Windows.Forms.TextBox
    Friend WithEvents btOpenDestinationFolder As System.Windows.Forms.Button
    Friend WithEvents txtResultlGridFileNameAcc As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ColOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColFileName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gbDataType As System.Windows.Forms.GroupBox
    Friend WithEvents rbASC As System.Windows.Forms.RadioButton
    Friend WithEvents rbGTiff As System.Windows.Forms.RadioButton
    Friend WithEvents gbResultFile As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtResultTimeInterval As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpStartingTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbSourceData As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSourceTimeInterval As System.Windows.Forms.TextBox
    Friend WithEvents rbmmPh As System.Windows.Forms.RadioButton
    Friend WithEvents gbDataSelection As System.Windows.Forms.GroupBox
    Friend WithEvents rbAggregate As System.Windows.Forms.RadioButton
    Friend WithEvents rbAccAllFiles As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents labAgg As System.Windows.Forms.Label
    Friend WithEvents gbSearchRFfile As System.Windows.Forms.GroupBox
    Friend WithEvents lstRFfiles As System.Windows.Forms.ListBox
    Friend WithEvents txtFolderPathSource As System.Windows.Forms.TextBox
    Friend WithEvents btOpenRfFolder As System.Windows.Forms.Button
End Class
