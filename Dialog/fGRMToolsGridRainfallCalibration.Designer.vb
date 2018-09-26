<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fGRMToolsGridRainfallCalibration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fGRMToolsGridRainfallCalibration))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvSelectedDataListForDRFCal = New System.Windows.Forms.DataGridView()
        Me.btClearAllList = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstRFfiles = New System.Windows.Forms.ListBox()
        Me.txtFolderPathSource = New System.Windows.Forms.TextBox()
        Me.btOpenRfFolder = New System.Windows.Forms.Button()
        Me.btAddAllFiles = New System.Windows.Forms.Button()
        Me.btAddSelectedFile = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btViewGagePositionTextFileExample = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFNPGagePosTextfile = New System.Windows.Forms.TextBox()
        Me.cmbNameField = New System.Windows.Forms.ComboBox()
        Me.cmbPointLayer = New System.Windows.Forms.ComboBox()
        Me.btLoadGagePosTextfile = New System.Windows.Forms.Button()
        Me.rbLoadGagePosUsingPointLayer = New System.Windows.Forms.RadioButton()
        Me.rbLoadGageUsingTextFile = New System.Windows.Forms.RadioButton()
        Me.btLoadTimeSeriesTextFile = New System.Windows.Forms.Button()
        Me.txtTimeSeriesFPN = New System.Windows.Forms.TextBox()
        Me.btViewTSTextFileExample = New System.Windows.Forms.Button()
        Me.txtResultFileTag = New System.Windows.Forms.TextBox()
        Me.txtResultFilePrefix = New System.Windows.Forms.TextBox()
        Me.txtDestinationFolderPath = New System.Windows.Forms.TextBox()
        Me.btOpenDestinationFolder = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btStartCM = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btApplyGageDataInfo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSelectedDataListForDRFCal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvSelectedDataListForDRFCal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 339)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 215)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selected data"
        '
        'dgvSelectedDataListForDRFCal
        '
        Me.dgvSelectedDataListForDRFCal.AllowUserToAddRows = False
        Me.dgvSelectedDataListForDRFCal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSelectedDataListForDRFCal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelectedDataListForDRFCal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSelectedDataListForDRFCal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSelectedDataListForDRFCal.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSelectedDataListForDRFCal.Location = New System.Drawing.Point(16, 22)
        Me.dgvSelectedDataListForDRFCal.Name = "dgvSelectedDataListForDRFCal"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelectedDataListForDRFCal.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSelectedDataListForDRFCal.RowHeadersVisible = False
        Me.dgvSelectedDataListForDRFCal.RowTemplate.Height = 23
        Me.dgvSelectedDataListForDRFCal.Size = New System.Drawing.Size(598, 178)
        Me.dgvSelectedDataListForDRFCal.TabIndex = 26
        '
        'btClearAllList
        '
        Me.btClearAllList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClearAllList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btClearAllList.Location = New System.Drawing.Point(165, 561)
        Me.btClearAllList.Name = "btClearAllList"
        Me.btClearAllList.Size = New System.Drawing.Size(113, 25)
        Me.btClearAllList.TabIndex = 27
        Me.btClearAllList.Text = "Clear data grid"
        Me.btClearAllList.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstRFfiles)
        Me.GroupBox2.Controls.Add(Me.txtFolderPathSource)
        Me.GroupBox2.Controls.Add(Me.btOpenRfFolder)
        Me.GroupBox2.Controls.Add(Me.btAddAllFiles)
        Me.GroupBox2.Controls.Add(Me.btAddSelectedFile)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 321)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search rainfall grid files"
        '
        'lstRFfiles
        '
        Me.lstRFfiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstRFfiles.FormattingEnabled = True
        Me.lstRFfiles.HorizontalScrollbar = True
        Me.lstRFfiles.ItemHeight = 12
        Me.lstRFfiles.Location = New System.Drawing.Point(6, 50)
        Me.lstRFfiles.Name = "lstRFfiles"
        Me.lstRFfiles.Size = New System.Drawing.Size(325, 232)
        Me.lstRFfiles.TabIndex = 39
        '
        'txtFolderPathSource
        '
        Me.txtFolderPathSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFolderPathSource.BackColor = System.Drawing.SystemColors.Window
        Me.txtFolderPathSource.Location = New System.Drawing.Point(6, 21)
        Me.txtFolderPathSource.Name = "txtFolderPathSource"
        Me.txtFolderPathSource.Size = New System.Drawing.Size(233, 21)
        Me.txtFolderPathSource.TabIndex = 38
        '
        'btOpenRfFolder
        '
        Me.btOpenRfFolder.Location = New System.Drawing.Point(246, 20)
        Me.btOpenRfFolder.Name = "btOpenRfFolder"
        Me.btOpenRfFolder.Size = New System.Drawing.Size(85, 21)
        Me.btOpenRfFolder.TabIndex = 37
        Me.btOpenRfFolder.Text = "Select folder"
        Me.btOpenRfFolder.UseVisualStyleBackColor = True
        '
        'btAddAllFiles
        '
        Me.btAddAllFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddAllFiles.Location = New System.Drawing.Point(100, 287)
        Me.btAddAllFiles.Name = "btAddAllFiles"
        Me.btAddAllFiles.Size = New System.Drawing.Size(110, 25)
        Me.btAddAllFiles.TabIndex = 6
        Me.btAddAllFiles.Text = "Add all"
        Me.btAddAllFiles.UseVisualStyleBackColor = True
        '
        'btAddSelectedFile
        '
        Me.btAddSelectedFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddSelectedFile.Location = New System.Drawing.Point(216, 287)
        Me.btAddSelectedFile.Name = "btAddSelectedFile"
        Me.btAddSelectedFile.Size = New System.Drawing.Size(115, 25)
        Me.btAddSelectedFile.TabIndex = 7
        Me.btAddSelectedFile.Text = "Add selected"
        Me.btAddSelectedFile.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btViewGagePositionTextFileExample)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtFNPGagePosTextfile)
        Me.GroupBox3.Controls.Add(Me.cmbNameField)
        Me.GroupBox3.Controls.Add(Me.cmbPointLayer)
        Me.GroupBox3.Controls.Add(Me.btLoadGagePosTextfile)
        Me.GroupBox3.Controls.Add(Me.rbLoadGagePosUsingPointLayer)
        Me.GroupBox3.Controls.Add(Me.rbLoadGageUsingTextFile)
        Me.GroupBox3.Location = New System.Drawing.Point(359, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(282, 153)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Set gage position"
        '
        'btViewGagePositionTextFileExample
        '
        Me.btViewGagePositionTextFileExample.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btViewGagePositionTextFileExample.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btViewGagePositionTextFileExample.Font = New System.Drawing.Font("굴림", 8.0!)
        Me.btViewGagePositionTextFileExample.Location = New System.Drawing.Point(192, 20)
        Me.btViewGagePositionTextFileExample.Name = "btViewGagePositionTextFileExample"
        Me.btViewGagePositionTextFileExample.Size = New System.Drawing.Size(82, 21)
        Me.btViewGagePositionTextFileExample.TabIndex = 10
        Me.btViewGagePositionTextFileExample.Text = "Example..."
        Me.btViewGagePositionTextFileExample.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name field:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Point layer:"
        '
        'txtFNPGagePosTextfile
        '
        Me.txtFNPGagePosTextfile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFNPGagePosTextfile.Location = New System.Drawing.Point(10, 47)
        Me.txtFNPGagePosTextfile.Name = "txtFNPGagePosTextfile"
        Me.txtFNPGagePosTextfile.Size = New System.Drawing.Size(231, 21)
        Me.txtFNPGagePosTextfile.TabIndex = 11
        '
        'cmbNameField
        '
        Me.cmbNameField.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNameField.FormattingEnabled = True
        Me.cmbNameField.Location = New System.Drawing.Point(87, 124)
        Me.cmbNameField.Name = "cmbNameField"
        Me.cmbNameField.Size = New System.Drawing.Size(187, 20)
        Me.cmbNameField.TabIndex = 15
        '
        'cmbPointLayer
        '
        Me.cmbPointLayer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPointLayer.FormattingEnabled = True
        Me.cmbPointLayer.Location = New System.Drawing.Point(87, 100)
        Me.cmbPointLayer.Name = "cmbPointLayer"
        Me.cmbPointLayer.Size = New System.Drawing.Size(187, 20)
        Me.cmbPointLayer.TabIndex = 14
        '
        'btLoadGagePosTextfile
        '
        Me.btLoadGagePosTextfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLoadGagePosTextfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btLoadGagePosTextfile.Location = New System.Drawing.Point(247, 45)
        Me.btLoadGagePosTextfile.Name = "btLoadGagePosTextfile"
        Me.btLoadGagePosTextfile.Size = New System.Drawing.Size(27, 23)
        Me.btLoadGagePosTextfile.TabIndex = 12
        Me.btLoadGagePosTextfile.Text = "..."
        Me.btLoadGagePosTextfile.UseVisualStyleBackColor = True
        '
        'rbLoadGagePosUsingPointLayer
        '
        Me.rbLoadGagePosUsingPointLayer.AutoSize = True
        Me.rbLoadGagePosUsingPointLayer.Location = New System.Drawing.Point(10, 78)
        Me.rbLoadGagePosUsingPointLayer.Name = "rbLoadGagePosUsingPointLayer"
        Me.rbLoadGagePosUsingPointLayer.Size = New System.Drawing.Size(108, 16)
        Me.rbLoadGagePosUsingPointLayer.TabIndex = 13
        Me.rbLoadGagePosUsingPointLayer.Text = "Use point layer"
        Me.rbLoadGagePosUsingPointLayer.UseVisualStyleBackColor = True
        '
        'rbLoadGageUsingTextFile
        '
        Me.rbLoadGageUsingTextFile.AutoSize = True
        Me.rbLoadGageUsingTextFile.Checked = True
        Me.rbLoadGageUsingTextFile.Location = New System.Drawing.Point(10, 25)
        Me.rbLoadGageUsingTextFile.Name = "rbLoadGageUsingTextFile"
        Me.rbLoadGageUsingTextFile.Size = New System.Drawing.Size(89, 16)
        Me.rbLoadGageUsingTextFile.TabIndex = 9
        Me.rbLoadGageUsingTextFile.TabStop = True
        Me.rbLoadGageUsingTextFile.Text = "Use text file"
        Me.rbLoadGageUsingTextFile.UseVisualStyleBackColor = True
        '
        'btLoadTimeSeriesTextFile
        '
        Me.btLoadTimeSeriesTextFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btLoadTimeSeriesTextFile.Location = New System.Drawing.Point(10, 20)
        Me.btLoadTimeSeriesTextFile.Name = "btLoadTimeSeriesTextFile"
        Me.btLoadTimeSeriesTextFile.Size = New System.Drawing.Size(166, 23)
        Me.btLoadTimeSeriesTextFile.TabIndex = 17
        Me.btLoadTimeSeriesTextFile.Text = "Load time series text file"
        Me.btLoadTimeSeriesTextFile.UseVisualStyleBackColor = True
        '
        'txtTimeSeriesFPN
        '
        Me.txtTimeSeriesFPN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTimeSeriesFPN.Location = New System.Drawing.Point(9, 48)
        Me.txtTimeSeriesFPN.Name = "txtTimeSeriesFPN"
        Me.txtTimeSeriesFPN.Size = New System.Drawing.Size(264, 21)
        Me.txtTimeSeriesFPN.TabIndex = 19
        '
        'btViewTSTextFileExample
        '
        Me.btViewTSTextFileExample.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btViewTSTextFileExample.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btViewTSTextFileExample.Font = New System.Drawing.Font("굴림", 8.0!)
        Me.btViewTSTextFileExample.Location = New System.Drawing.Point(193, 20)
        Me.btViewTSTextFileExample.Name = "btViewTSTextFileExample"
        Me.btViewTSTextFileExample.Size = New System.Drawing.Size(81, 23)
        Me.btViewTSTextFileExample.TabIndex = 18
        Me.btViewTSTextFileExample.Text = "Example..."
        Me.btViewTSTextFileExample.UseVisualStyleBackColor = True
        '
        'txtResultFileTag
        '
        Me.txtResultFileTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultFileTag.Location = New System.Drawing.Point(195, 16)
        Me.txtResultFileTag.Name = "txtResultFileTag"
        Me.txtResultFileTag.Size = New System.Drawing.Size(77, 21)
        Me.txtResultFileTag.TabIndex = 22
        '
        'txtResultFilePrefix
        '
        Me.txtResultFilePrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultFilePrefix.Location = New System.Drawing.Point(59, 16)
        Me.txtResultFilePrefix.Name = "txtResultFilePrefix"
        Me.txtResultFilePrefix.Size = New System.Drawing.Size(77, 21)
        Me.txtResultFilePrefix.TabIndex = 21
        '
        'txtDestinationFolderPath
        '
        Me.txtDestinationFolderPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDestinationFolderPath.BackColor = System.Drawing.SystemColors.Window
        Me.txtDestinationFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestinationFolderPath.Location = New System.Drawing.Point(135, 43)
        Me.txtDestinationFolderPath.Name = "txtDestinationFolderPath"
        Me.txtDestinationFolderPath.Size = New System.Drawing.Size(137, 21)
        Me.txtDestinationFolderPath.TabIndex = 24
        '
        'btOpenDestinationFolder
        '
        Me.btOpenDestinationFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btOpenDestinationFolder.Location = New System.Drawing.Point(12, 43)
        Me.btOpenDestinationFolder.Name = "btOpenDestinationFolder"
        Me.btOpenDestinationFolder.Size = New System.Drawing.Size(117, 21)
        Me.btOpenDestinationFolder.TabIndex = 23
        Me.btOpenDestinationFolder.Text = "Destination folder"
        Me.btOpenDestinationFolder.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 12)
        Me.Label5.TabIndex = 208
        Me.Label5.Text = "Suffix :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 12)
        Me.Label4.TabIndex = 207
        Me.Label4.Text = "Prefix :"
        '
        'btStartCM
        '
        Me.btStartCM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btStartCM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btStartCM.Location = New System.Drawing.Point(504, 561)
        Me.btStartCM.Name = "btStartCM"
        Me.btStartCM.Size = New System.Drawing.Size(137, 25)
        Me.btStartCM.TabIndex = 1
        Me.btStartCM.Text = "Start CM"
        Me.btStartCM.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.btLoadTimeSeriesTextFile)
        Me.GroupBox4.Controls.Add(Me.txtTimeSeriesFPN)
        Me.GroupBox4.Controls.Add(Me.btViewTSTextFileExample)
        Me.GroupBox4.Location = New System.Drawing.Point(359, 171)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(282, 83)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Set gage rainfall time series"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtResultFilePrefix)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtDestinationFolderPath)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.txtResultFileTag)
        Me.GroupBox5.Controls.Add(Me.btOpenDestinationFolder)
        Me.GroupBox5.Location = New System.Drawing.Point(359, 260)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(282, 73)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Set result files"
        '
        'btApplyGageDataInfo
        '
        Me.btApplyGageDataInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btApplyGageDataInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btApplyGageDataInfo.Location = New System.Drawing.Point(12, 561)
        Me.btApplyGageDataInfo.Name = "btApplyGageDataInfo"
        Me.btApplyGageDataInfo.Size = New System.Drawing.Size(147, 25)
        Me.btApplyGageDataInfo.TabIndex = 28
        Me.btApplyGageDataInfo.Text = "Update process setting"
        Me.btApplyGageDataInfo.UseVisualStyleBackColor = True
        '
        'fGRMToolsGridRainfallCalibration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 597)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btApplyGageDataInfo)
        Me.Controls.Add(Me.btClearAllList)
        Me.Controls.Add(Me.btStartCM)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fGRMToolsGridRainfallCalibration"
        Me.Text = "Grid rainfall calibration with conditional merging"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSelectedDataListForDRFCal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSelectedDataListForDRFCal As System.Windows.Forms.DataGridView
    Friend WithEvents btClearAllList As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btAddAllFiles As System.Windows.Forms.Button
    Friend WithEvents btAddSelectedFile As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFNPGagePosTextfile As System.Windows.Forms.TextBox
    Friend WithEvents cmbNameField As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPointLayer As System.Windows.Forms.ComboBox
    Friend WithEvents btLoadGagePosTextfile As System.Windows.Forms.Button
    Friend WithEvents rbLoadGagePosUsingPointLayer As System.Windows.Forms.RadioButton
    Friend WithEvents rbLoadGageUsingTextFile As System.Windows.Forms.RadioButton
    Friend WithEvents btLoadTimeSeriesTextFile As System.Windows.Forms.Button
    Friend WithEvents btViewGagePositionTextFileExample As System.Windows.Forms.Button
    Friend WithEvents txtTimeSeriesFPN As System.Windows.Forms.TextBox
    Friend WithEvents btViewTSTextFileExample As System.Windows.Forms.Button
    Friend WithEvents txtResultFileTag As System.Windows.Forms.TextBox
    Friend WithEvents txtResultFilePrefix As System.Windows.Forms.TextBox
    Friend WithEvents txtDestinationFolderPath As System.Windows.Forms.TextBox
    Friend WithEvents btOpenDestinationFolder As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btStartCM As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btApplyGageDataInfo As System.Windows.Forms.Button
    Friend WithEvents lstRFfiles As System.Windows.Forms.ListBox
    Friend WithEvents txtFolderPathSource As System.Windows.Forms.TextBox
    Friend WithEvents btOpenRfFolder As System.Windows.Forms.Button
End Class
