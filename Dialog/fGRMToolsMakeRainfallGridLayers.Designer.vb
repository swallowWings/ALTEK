<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGRMToolsMakeRainfallGridLayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGRMToolsMakeRainfallGridLayer))
        Me.cmbBaseGridLayer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvMatchRainGageAndData = New System.Windows.Forms.DataGridView()
        Me.btMakeRainfallGrid = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRFStartingTimeStep = New System.Windows.Forms.TextBox()
        Me.txtRainfallGridFilePrefix = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDestinationFolderPath = New System.Windows.Forms.TextBox()
        Me.dtpResultRFStarting = New System.Windows.Forms.DateTimePicker()
        Me.btOpenDestinationFolder = New System.Windows.Forms.Button()
        Me.chkSetStartingTime = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbRainfallGageNameField = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbRainfallGageLayer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labEndingTime = New System.Windows.Forms.Label()
        Me.dtpStartingTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndingTime = New System.Windows.Forms.DateTimePicker()
        Me.labStartingTime = New System.Windows.Forms.Label()
        Me.btSelectTSDB = New System.Windows.Forms.Button()
        Me.txtObservedTSDBPathName = New System.Windows.Forms.TextBox()
        Me.rbUseTSDB = New System.Windows.Forms.RadioButton()
        Me.rbUseCSVTxtFile = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCSVRFDataFPN = New System.Windows.Forms.TextBox()
        Me.btLoadTimeSeriesTextFile = New System.Windows.Forms.Button()
        Me.btViewCSVTextFileFormat = New System.Windows.Forms.Button()
        Me.btApplyProcessSetting = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtIDPowerCoeff = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbUsingKrigging = New System.Windows.Forms.RadioButton()
        Me.rbUsingIDW = New System.Windows.Forms.RadioButton()
        Me.rbUsingTPGridLayer = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvMatchRainGageAndData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbBaseGridLayer
        '
        Me.cmbBaseGridLayer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBaseGridLayer.FormattingEnabled = True
        Me.cmbBaseGridLayer.Location = New System.Drawing.Point(159, 23)
        Me.cmbBaseGridLayer.Name = "cmbBaseGridLayer"
        Me.cmbBaseGridLayer.Size = New System.Drawing.Size(151, 20)
        Me.cmbBaseGridLayer.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 12)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Base grid layer:"
        '
        'dgvMatchRainGageAndData
        '
        Me.dgvMatchRainGageAndData.AllowUserToAddRows = False
        Me.dgvMatchRainGageAndData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMatchRainGageAndData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMatchRainGageAndData.Location = New System.Drawing.Point(10, 21)
        Me.dgvMatchRainGageAndData.Name = "dgvMatchRainGageAndData"
        Me.dgvMatchRainGageAndData.RowTemplate.Height = 23
        Me.dgvMatchRainGageAndData.Size = New System.Drawing.Size(579, 231)
        Me.dgvMatchRainGageAndData.TabIndex = 28
        '
        'btMakeRainfallGrid
        '
        Me.btMakeRainfallGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btMakeRainfallGrid.Location = New System.Drawing.Point(520, 514)
        Me.btMakeRainfallGrid.Name = "btMakeRainfallGrid"
        Me.btMakeRainfallGrid.Size = New System.Drawing.Size(88, 62)
        Me.btMakeRainfallGrid.TabIndex = 1
        Me.btMakeRainfallGrid.Text = "Make Rainfall Grid"
        Me.btMakeRainfallGrid.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.Location = New System.Drawing.Point(520, 588)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(88, 23)
        Me.btClose.TabIndex = 2
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtRFStartingTimeStep)
        Me.GroupBox1.Controls.Add(Me.txtRainfallGridFilePrefix)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtDestinationFolderPath)
        Me.GroupBox1.Controls.Add(Me.dtpResultRFStarting)
        Me.GroupBox1.Controls.Add(Me.btOpenDestinationFolder)
        Me.GroupBox1.Controls.Add(Me.chkSetStartingTime)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 507)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 104)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Results"
        '
        'txtRFStartingTimeStep
        '
        Me.txtRFStartingTimeStep.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRFStartingTimeStep.Location = New System.Drawing.Point(408, 75)
        Me.txtRFStartingTimeStep.Name = "txtRFStartingTimeStep"
        Me.txtRFStartingTimeStep.Size = New System.Drawing.Size(84, 21)
        Me.txtRFStartingTimeStep.TabIndex = 35
        Me.txtRFStartingTimeStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRainfallGridFilePrefix
        '
        Me.txtRainfallGridFilePrefix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRainfallGridFilePrefix.Location = New System.Drawing.Point(174, 48)
        Me.txtRainfallGridFilePrefix.Name = "txtRainfallGridFilePrefix"
        Me.txtRainfallGridFilePrefix.Size = New System.Drawing.Size(318, 21)
        Me.txtRainfallGridFilePrefix.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(164, 12)
        Me.Label14.TabIndex = 195
        Me.Label14.Text = "Result file prefix(prefix0001):"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDestinationFolderPath
        '
        Me.txtDestinationFolderPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDestinationFolderPath.BackColor = System.Drawing.SystemColors.Window
        Me.txtDestinationFolderPath.Location = New System.Drawing.Point(101, 20)
        Me.txtDestinationFolderPath.Name = "txtDestinationFolderPath"
        Me.txtDestinationFolderPath.Size = New System.Drawing.Size(391, 21)
        Me.txtDestinationFolderPath.TabIndex = 31
        '
        'dtpResultRFStarting
        '
        Me.dtpResultRFStarting.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.dtpResultRFStarting.Enabled = False
        Me.dtpResultRFStarting.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpResultRFStarting.Location = New System.Drawing.Point(167, 76)
        Me.dtpResultRFStarting.Name = "dtpResultRFStarting"
        Me.dtpResultRFStarting.ShowUpDown = True
        Me.dtpResultRFStarting.Size = New System.Drawing.Size(120, 21)
        Me.dtpResultRFStarting.TabIndex = 34
        '
        'btOpenDestinationFolder
        '
        Me.btOpenDestinationFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btOpenDestinationFolder.Location = New System.Drawing.Point(10, 20)
        Me.btOpenDestinationFolder.Name = "btOpenDestinationFolder"
        Me.btOpenDestinationFolder.Size = New System.Drawing.Size(88, 21)
        Me.btOpenDestinationFolder.TabIndex = 30
        Me.btOpenDestinationFolder.Text = "Select folder"
        Me.btOpenDestinationFolder.UseVisualStyleBackColor = True
        '
        'chkSetStartingTime
        '
        Me.chkSetStartingTime.AutoSize = True
        Me.chkSetStartingTime.Location = New System.Drawing.Point(10, 78)
        Me.chkSetStartingTime.Name = "chkSetStartingTime"
        Me.chkSetStartingTime.Size = New System.Drawing.Size(398, 16)
        Me.chkSetStartingTime.TabIndex = 33
        Me.chkSetStartingTime.Text = "Set rainfall starting time                                     Time step[min]:"
        Me.chkSetStartingTime.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cmbRainfallGageNameField)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbRainfallGageLayer)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbBaseGridLayer)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(291, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(317, 107)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select layer"
        '
        'cmbRainfallGageNameField
        '
        Me.cmbRainfallGageNameField.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbRainfallGageNameField.FormattingEnabled = True
        Me.cmbRainfallGageNameField.Location = New System.Drawing.Point(159, 75)
        Me.cmbRainfallGageNameField.Name = "cmbRainfallGageNameField"
        Me.cmbRainfallGageNameField.Size = New System.Drawing.Size(151, 20)
        Me.cmbRainfallGageNameField.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 12)
        Me.Label4.TabIndex = 265
        Me.Label4.Text = "Rainfall gauge name field:"
        '
        'cmbRainfallGageLayer
        '
        Me.cmbRainfallGageLayer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbRainfallGageLayer.FormattingEnabled = True
        Me.cmbRainfallGageLayer.Location = New System.Drawing.Point(159, 49)
        Me.cmbRainfallGageLayer.Name = "cmbRainfallGageLayer"
        Me.cmbRainfallGageLayer.Size = New System.Drawing.Size(151, 20)
        Me.cmbRainfallGageLayer.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 12)
        Me.Label2.TabIndex = 263
        Me.Label2.Text = "Rainfall gauge layer:"
        '
        'labEndingTime
        '
        Me.labEndingTime.AutoSize = True
        Me.labEndingTime.Location = New System.Drawing.Point(173, 57)
        Me.labEndingTime.Name = "labEndingTime"
        Me.labEndingTime.Size = New System.Drawing.Size(15, 12)
        Me.labEndingTime.TabIndex = 261
        Me.labEndingTime.Text = "to"
        '
        'dtpStartingTime
        '
        Me.dtpStartingTime.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.dtpStartingTime.Enabled = False
        Me.dtpStartingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartingTime.Location = New System.Drawing.Point(47, 53)
        Me.dtpStartingTime.Name = "dtpStartingTime"
        Me.dtpStartingTime.ShowUpDown = True
        Me.dtpStartingTime.Size = New System.Drawing.Size(120, 21)
        Me.dtpStartingTime.TabIndex = 24
        '
        'dtpEndingTime
        '
        Me.dtpEndingTime.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.dtpEndingTime.Enabled = False
        Me.dtpEndingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndingTime.Location = New System.Drawing.Point(190, 53)
        Me.dtpEndingTime.Name = "dtpEndingTime"
        Me.dtpEndingTime.ShowUpDown = True
        Me.dtpEndingTime.Size = New System.Drawing.Size(120, 21)
        Me.dtpEndingTime.TabIndex = 25
        '
        'labStartingTime
        '
        Me.labStartingTime.AutoSize = True
        Me.labStartingTime.Location = New System.Drawing.Point(10, 58)
        Me.labStartingTime.Name = "labStartingTime"
        Me.labStartingTime.Size = New System.Drawing.Size(34, 12)
        Me.labStartingTime.TabIndex = 258
        Me.labStartingTime.Text = "From"
        '
        'btSelectTSDB
        '
        Me.btSelectTSDB.Enabled = False
        Me.btSelectTSDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSelectTSDB.Location = New System.Drawing.Point(9, 21)
        Me.btSelectTSDB.Name = "btSelectTSDB"
        Me.btSelectTSDB.Size = New System.Drawing.Size(82, 21)
        Me.btSelectTSDB.TabIndex = 22
        Me.btSelectTSDB.Text = "Select DB"
        Me.btSelectTSDB.UseVisualStyleBackColor = True
        '
        'txtObservedTSDBPathName
        '
        Me.txtObservedTSDBPathName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservedTSDBPathName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservedTSDBPathName.Enabled = False
        Me.txtObservedTSDBPathName.Location = New System.Drawing.Point(95, 21)
        Me.txtObservedTSDBPathName.Name = "txtObservedTSDBPathName"
        Me.txtObservedTSDBPathName.Size = New System.Drawing.Size(215, 21)
        Me.txtObservedTSDBPathName.TabIndex = 23
        '
        'rbUseTSDB
        '
        Me.rbUseTSDB.AutoSize = True
        Me.rbUseTSDB.Location = New System.Drawing.Point(57, 166)
        Me.rbUseTSDB.Name = "rbUseTSDB"
        Me.rbUseTSDB.Size = New System.Drawing.Size(147, 16)
        Me.rbUseTSDB.TabIndex = 15
        Me.rbUseTSDB.Text = "Time series database"
        Me.rbUseTSDB.UseVisualStyleBackColor = True
        Me.rbUseTSDB.Visible = False
        '
        'rbUseCSVTxtFile
        '
        Me.rbUseCSVTxtFile.AutoSize = True
        Me.rbUseCSVTxtFile.Checked = True
        Me.rbUseCSVTxtFile.Location = New System.Drawing.Point(12, 27)
        Me.rbUseCSVTxtFile.Name = "rbUseCSVTxtFile"
        Me.rbUseCSVTxtFile.Size = New System.Drawing.Size(92, 16)
        Me.rbUseCSVTxtFile.TabIndex = 9
        Me.rbUseCSVTxtFile.TabStop = True
        Me.rbUseCSVTxtFile.Text = "CSV text file"
        Me.rbUseCSVTxtFile.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCSVRFDataFPN)
        Me.GroupBox3.Controls.Add(Me.btLoadTimeSeriesTextFile)
        Me.GroupBox3.Controls.Add(Me.btViewCSVTextFileFormat)
        Me.GroupBox3.Controls.Add(Me.rbUseCSVTxtFile)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 125)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(425, 88)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gauge data source"
        '
        'txtCSVRFDataFPN
        '
        Me.txtCSVRFDataFPN.Location = New System.Drawing.Point(12, 48)
        Me.txtCSVRFDataFPN.Name = "txtCSVRFDataFPN"
        Me.txtCSVRFDataFPN.Size = New System.Drawing.Size(370, 21)
        Me.txtCSVRFDataFPN.TabIndex = 11
        '
        'btLoadTimeSeriesTextFile
        '
        Me.btLoadTimeSeriesTextFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btLoadTimeSeriesTextFile.Location = New System.Drawing.Point(388, 48)
        Me.btLoadTimeSeriesTextFile.Name = "btLoadTimeSeriesTextFile"
        Me.btLoadTimeSeriesTextFile.Size = New System.Drawing.Size(27, 21)
        Me.btLoadTimeSeriesTextFile.TabIndex = 12
        Me.btLoadTimeSeriesTextFile.Text = "..."
        Me.btLoadTimeSeriesTextFile.UseVisualStyleBackColor = True
        '
        'btViewCSVTextFileFormat
        '
        Me.btViewCSVTextFileFormat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btViewCSVTextFileFormat.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btViewCSVTextFileFormat.Location = New System.Drawing.Point(285, 26)
        Me.btViewCSVTextFileFormat.Name = "btViewCSVTextFileFormat"
        Me.btViewCSVTextFileFormat.Size = New System.Drawing.Size(130, 18)
        Me.btViewCSVTextFileFormat.TabIndex = 10
        Me.btViewCSVTextFileFormat.Text = "View file format"
        Me.btViewCSVTextFileFormat.UseVisualStyleBackColor = True
        '
        'btApplyProcessSetting
        '
        Me.btApplyProcessSetting.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btApplyProcessSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btApplyProcessSetting.Location = New System.Drawing.Point(462, 134)
        Me.btApplyProcessSetting.Name = "btApplyProcessSetting"
        Me.btApplyProcessSetting.Size = New System.Drawing.Size(146, 79)
        Me.btApplyProcessSetting.TabIndex = 26
        Me.btApplyProcessSetting.Text = "Apply process setting"
        Me.btApplyProcessSetting.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtIDPowerCoeff)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.rbUsingIDW)
        Me.GroupBox4.Controls.Add(Me.rbUsingTPGridLayer)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(273, 107)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Select processing tyep"
        '
        'txtIDPowerCoeff
        '
        Me.txtIDPowerCoeff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDPowerCoeff.Location = New System.Drawing.Point(225, 66)
        Me.txtIDPowerCoeff.Name = "txtIDPowerCoeff"
        Me.txtIDPowerCoeff.Size = New System.Drawing.Size(31, 21)
        Me.txtIDPowerCoeff.TabIndex = 6
        Me.txtIDPowerCoeff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 12)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "(ID power coeff.:         )"
        '
        'rbUsingKrigging
        '
        Me.rbUsingKrigging.AutoSize = True
        Me.rbUsingKrigging.Enabled = False
        Me.rbUsingKrigging.Location = New System.Drawing.Point(279, 156)
        Me.rbUsingKrigging.Name = "rbUsingKrigging"
        Me.rbUsingKrigging.Size = New System.Drawing.Size(246, 16)
        Me.rbUsingKrigging.TabIndex = 7
        Me.rbUsingKrigging.Text = "Kriging(Only Sufer is installed)(GeoTiff)"
        Me.rbUsingKrigging.UseVisualStyleBackColor = True
        Me.rbUsingKrigging.Visible = False
        '
        'rbUsingIDW
        '
        Me.rbUsingIDW.AutoSize = True
        Me.rbUsingIDW.Location = New System.Drawing.Point(14, 69)
        Me.rbUsingIDW.Name = "rbUsingIDW"
        Me.rbUsingIDW.Size = New System.Drawing.Size(94, 16)
        Me.rbUsingIDW.TabIndex = 5
        Me.rbUsingIDW.Text = "IDW(GeoTiff)"
        Me.rbUsingIDW.UseVisualStyleBackColor = True
        '
        'rbUsingTPGridLayer
        '
        Me.rbUsingTPGridLayer.AutoSize = True
        Me.rbUsingTPGridLayer.Checked = True
        Me.rbUsingTPGridLayer.Location = New System.Drawing.Point(14, 33)
        Me.rbUsingTPGridLayer.Name = "rbUsingTPGridLayer"
        Me.rbUsingTPGridLayer.Size = New System.Drawing.Size(219, 16)
        Me.rbUsingTPGridLayer.TabIndex = 4
        Me.rbUsingTPGridLayer.TabStop = True
        Me.rbUsingTPGridLayer.Text = "Using Thiessen grid layer(GeoTiff)"
        Me.rbUsingTPGridLayer.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtObservedTSDBPathName)
        Me.GroupBox5.Controls.Add(Me.btSelectTSDB)
        Me.GroupBox5.Controls.Add(Me.dtpEndingTime)
        Me.GroupBox5.Controls.Add(Me.labStartingTime)
        Me.GroupBox5.Controls.Add(Me.dtpStartingTime)
        Me.GroupBox5.Controls.Add(Me.labEndingTime)
        Me.GroupBox5.Location = New System.Drawing.Point(91, 51)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(317, 87)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Time series database"
        Me.GroupBox5.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.rbUseTSDB)
        Me.GroupBox6.Controls.Add(Me.GroupBox5)
        Me.GroupBox6.Controls.Add(Me.rbUsingKrigging)
        Me.GroupBox6.Controls.Add(Me.dgvMatchRainGageAndData)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 230)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(597, 260)
        Me.GroupBox6.TabIndex = 27
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Set rainfall data for each gage"
        '
        'frmGRMToolsMakeRainfallGridLayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 628)
        Me.Controls.Add(Me.btApplyProcessSetting)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btMakeRainfallGrid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGRMToolsMakeRainfallGridLayer"
        Me.Text = "Make Rainfall Grid Layers with Gage Time Series"
        CType(Me.dgvMatchRainGageAndData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbBaseGridLayer As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvMatchRainGageAndData As System.Windows.Forms.DataGridView
    Friend WithEvents btMakeRainfallGrid As System.Windows.Forms.Button
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDestinationFolderPath As System.Windows.Forms.TextBox
    Friend WithEvents btOpenDestinationFolder As System.Windows.Forms.Button
    Friend WithEvents txtRainfallGridFilePrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbUseTSDB As System.Windows.Forms.RadioButton
    Friend WithEvents rbUseCSVTxtFile As System.Windows.Forms.RadioButton
    Friend WithEvents btSelectTSDB As System.Windows.Forms.Button
    Friend WithEvents txtObservedTSDBPathName As System.Windows.Forms.TextBox
    Friend WithEvents labEndingTime As System.Windows.Forms.Label
    Friend WithEvents dtpStartingTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndingTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents labStartingTime As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbUsingKrigging As System.Windows.Forms.RadioButton
    Friend WithEvents rbUsingIDW As System.Windows.Forms.RadioButton
    Friend WithEvents rbUsingTPGridLayer As System.Windows.Forms.RadioButton
    Friend WithEvents cmbRainfallGageNameField As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbRainfallGageLayer As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIDPowerCoeff As System.Windows.Forms.TextBox
    Friend WithEvents dtpResultRFStarting As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkSetStartingTime As System.Windows.Forms.CheckBox
    Friend WithEvents txtRFStartingTimeStep As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btViewCSVTextFileFormat As System.Windows.Forms.Button
    Friend WithEvents txtCSVRFDataFPN As System.Windows.Forms.TextBox
    Friend WithEvents btLoadTimeSeriesTextFile As System.Windows.Forms.Button
    Friend WithEvents btApplyProcessSetting As System.Windows.Forms.Button
End Class
