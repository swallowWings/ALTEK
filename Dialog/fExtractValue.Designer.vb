<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fExtractValue
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvRainfallFileList = New System.Windows.Forms.DataGridView()
        Me.btRemoveAll = New System.Windows.Forms.Button()
        Me.btRemoveSelected = New System.Windows.Forms.Button()
        Me.gbExtractFromASCII = New System.Windows.Forms.GroupBox()
        Me.chkAllowNegativeInCalCellAverage = New System.Windows.Forms.CheckBox()
        Me.btHelpExtractCellsAverageValue = New System.Windows.Forms.Button()
        Me.btSelectBaseRasterFile = New System.Windows.Forms.Button()
        Me.tbBaseGridFile = New System.Windows.Forms.TextBox()
        Me.rbExtractCellsAverage = New System.Windows.Forms.RadioButton()
        Me.rbExtractFromAcell = New System.Windows.Forms.RadioButton()
        Me.tbrowy = New System.Windows.Forms.TextBox()
        Me.tbcolx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbDest_FP_or_FPN = New System.Windows.Forms.TextBox()
        Me.tbFileNameTail = New System.Windows.Forms.TextBox()
        Me.tbFileNameHead = New System.Windows.Forms.TextBox()
        Me.btOpenDestFolderOrFile = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbFileNameFilter = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbExtensionFilter = New System.Windows.Forms.TextBox()
        Me.lstRFfiles = New System.Windows.Forms.ListBox()
        Me.txtFolderPathSource = New System.Windows.Forms.TextBox()
        Me.btOpenFolder = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btAddAllFiles = New System.Windows.Forms.Button()
        Me.btAddSelectedFile = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btStartProcess = New System.Windows.Forms.Button()
        Me.rbValueFromASCIIFiles = New System.Windows.Forms.RadioButton()
        Me.rbValueFromTextFile = New System.Windows.Forms.RadioButton()
        Me.gbExtractFromTextFile = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkOnlyNumericValue = New System.Windows.Forms.CheckBox()
        Me.tbColidxInTextFile = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbStartingLineText = New System.Windows.Forms.RadioButton()
        Me.rbStartingIndex = New System.Windows.Forms.RadioButton()
        Me.tbEndingLineText = New System.Windows.Forms.TextBox()
        Me.tbStartingLineText = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbEndingLineidx = New System.Windows.Forms.TextBox()
        Me.tbStartingLineidx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rbAccAscRaster = New System.Windows.Forms.RadioButton()
        Me.gbAcc = New System.Windows.Forms.GroupBox()
        Me.tbFileNumToAgg = New System.Windows.Forms.TextBox()
        Me.chkAllowNegativeInAcc = New System.Windows.Forms.CheckBox()
        Me.rbAggregate = New System.Windows.Forms.RadioButton()
        Me.rbAccAllFiles = New System.Windows.Forms.RadioButton()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvRainfallFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbExtractFromASCII.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbExtractFromTextFile.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gbAcc.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.dgvRainfallFileList)
        Me.GroupBox4.Controls.Add(Me.btRemoveAll)
        Me.GroupBox4.Controls.Add(Me.btRemoveSelected)
        Me.GroupBox4.Location = New System.Drawing.Point(449, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(411, 290)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Selected source files"
        '
        'dgvRainfallFileList
        '
        Me.dgvRainfallFileList.AllowUserToAddRows = False
        Me.dgvRainfallFileList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRainfallFileList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRainfallFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRainfallFileList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRainfallFileList.Location = New System.Drawing.Point(9, 22)
        Me.dgvRainfallFileList.Name = "dgvRainfallFileList"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRainfallFileList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRainfallFileList.RowHeadersVisible = False
        Me.dgvRainfallFileList.RowTemplate.Height = 23
        Me.dgvRainfallFileList.Size = New System.Drawing.Size(392, 221)
        Me.dgvRainfallFileList.TabIndex = 16
        '
        'btRemoveAll
        '
        Me.btRemoveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveAll.Location = New System.Drawing.Point(111, 255)
        Me.btRemoveAll.Name = "btRemoveAll"
        Me.btRemoveAll.Size = New System.Drawing.Size(142, 25)
        Me.btRemoveAll.TabIndex = 17
        Me.btRemoveAll.Text = "Remove all"
        Me.btRemoveAll.UseVisualStyleBackColor = True
        '
        'btRemoveSelected
        '
        Me.btRemoveSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveSelected.Location = New System.Drawing.Point(259, 255)
        Me.btRemoveSelected.Name = "btRemoveSelected"
        Me.btRemoveSelected.Size = New System.Drawing.Size(142, 25)
        Me.btRemoveSelected.TabIndex = 18
        Me.btRemoveSelected.Text = "Remove selected"
        Me.btRemoveSelected.UseVisualStyleBackColor = True
        '
        'gbExtractFromASCII
        '
        Me.gbExtractFromASCII.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbExtractFromASCII.Controls.Add(Me.chkAllowNegativeInCalCellAverage)
        Me.gbExtractFromASCII.Controls.Add(Me.btHelpExtractCellsAverageValue)
        Me.gbExtractFromASCII.Controls.Add(Me.btSelectBaseRasterFile)
        Me.gbExtractFromASCII.Controls.Add(Me.tbBaseGridFile)
        Me.gbExtractFromASCII.Controls.Add(Me.rbExtractCellsAverage)
        Me.gbExtractFromASCII.Controls.Add(Me.rbExtractFromAcell)
        Me.gbExtractFromASCII.Controls.Add(Me.tbrowy)
        Me.gbExtractFromASCII.Controls.Add(Me.tbcolx)
        Me.gbExtractFromASCII.Controls.Add(Me.Label6)
        Me.gbExtractFromASCII.Controls.Add(Me.Label1)
        Me.gbExtractFromASCII.Location = New System.Drawing.Point(13, 334)
        Me.gbExtractFromASCII.Name = "gbExtractFromASCII"
        Me.gbExtractFromASCII.Size = New System.Drawing.Size(847, 70)
        Me.gbExtractFromASCII.TabIndex = 38
        Me.gbExtractFromASCII.TabStop = False
        '
        'chkAllowNegativeInCalCellAverage
        '
        Me.chkAllowNegativeInCalCellAverage.AutoSize = True
        Me.chkAllowNegativeInCalCellAverage.Location = New System.Drawing.Point(686, 44)
        Me.chkAllowNegativeInCalCellAverage.Name = "chkAllowNegativeInCalCellAverage"
        Me.chkAllowNegativeInCalCellAverage.Size = New System.Drawing.Size(147, 16)
        Me.chkAllowNegativeInCalCellAverage.TabIndex = 221
        Me.chkAllowNegativeInCalCellAverage.Text = "Allow negative values"
        Me.chkAllowNegativeInCalCellAverage.UseVisualStyleBackColor = True
        '
        'btHelpExtractCellsAverageValue
        '
        Me.btHelpExtractCellsAverageValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btHelpExtractCellsAverageValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btHelpExtractCellsAverageValue.Location = New System.Drawing.Point(202, 41)
        Me.btHelpExtractCellsAverageValue.Name = "btHelpExtractCellsAverageValue"
        Me.btHelpExtractCellsAverageValue.Size = New System.Drawing.Size(78, 21)
        Me.btHelpExtractCellsAverageValue.TabIndex = 220
        Me.btHelpExtractCellsAverageValue.Text = "Help?"
        Me.btHelpExtractCellsAverageValue.UseVisualStyleBackColor = True
        '
        'btSelectBaseRasterFile
        '
        Me.btSelectBaseRasterFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btSelectBaseRasterFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSelectBaseRasterFile.Location = New System.Drawing.Point(286, 41)
        Me.btSelectBaseRasterFile.Name = "btSelectBaseRasterFile"
        Me.btSelectBaseRasterFile.Size = New System.Drawing.Size(147, 21)
        Me.btSelectBaseRasterFile.TabIndex = 219
        Me.btSelectBaseRasterFile.Text = "Select a base raster file "
        Me.btSelectBaseRasterFile.UseVisualStyleBackColor = True
        '
        'tbBaseGridFile
        '
        Me.tbBaseGridFile.Location = New System.Drawing.Point(435, 41)
        Me.tbBaseGridFile.Name = "tbBaseGridFile"
        Me.tbBaseGridFile.Size = New System.Drawing.Size(243, 21)
        Me.tbBaseGridFile.TabIndex = 218
        '
        'rbExtractCellsAverage
        '
        Me.rbExtractCellsAverage.AutoSize = True
        Me.rbExtractCellsAverage.Location = New System.Drawing.Point(20, 44)
        Me.rbExtractCellsAverage.Name = "rbExtractCellsAverage"
        Me.rbExtractCellsAverage.Size = New System.Drawing.Size(176, 16)
        Me.rbExtractCellsAverage.TabIndex = 215
        Me.rbExtractCellsAverage.Text = "Extract cells average value"
        Me.rbExtractCellsAverage.UseVisualStyleBackColor = True
        '
        'rbExtractFromAcell
        '
        Me.rbExtractFromAcell.AutoSize = True
        Me.rbExtractFromAcell.Checked = True
        Me.rbExtractFromAcell.Location = New System.Drawing.Point(18, 18)
        Me.rbExtractFromAcell.Name = "rbExtractFromAcell"
        Me.rbExtractFromAcell.Size = New System.Drawing.Size(266, 16)
        Me.rbExtractFromAcell.TabIndex = 214
        Me.rbExtractFromAcell.TabStop = True
        Me.rbExtractFromAcell.Text = "Extract a value in a cell(starting from (0,0))"
        Me.rbExtractFromAcell.UseVisualStyleBackColor = True
        '
        'tbrowy
        '
        Me.tbrowy.Location = New System.Drawing.Point(446, 15)
        Me.tbrowy.Name = "tbrowy"
        Me.tbrowy.Size = New System.Drawing.Size(56, 21)
        Me.tbrowy.TabIndex = 212
        '
        'tbcolx
        '
        Me.tbcolx.Location = New System.Drawing.Point(332, 15)
        Me.tbcolx.Name = "tbcolx"
        Me.tbcolx.Size = New System.Drawing.Size(56, 21)
        Me.tbcolx.TabIndex = 211
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(397, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 12)
        Me.Label6.TabIndex = 209
        Me.Label6.Text = "RowY :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(289, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 12)
        Me.Label1.TabIndex = 210
        Me.Label1.Text = "ColX :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbDest_FP_or_FPN)
        Me.GroupBox1.Controls.Add(Me.tbFileNameTail)
        Me.GroupBox1.Controls.Add(Me.tbFileNameHead)
        Me.GroupBox1.Controls.Add(Me.btOpenDestFolderOrFile)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 652)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 84)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result files"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(399, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 12)
        Me.Label5.TabIndex = 228
        Me.Label5.Text = "Tail text of file name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 12)
        Me.Label4.TabIndex = 229
        Me.Label4.Text = "Head text of file name :"
        '
        'tbDest_FP_or_FPN
        '
        Me.tbDest_FP_or_FPN.BackColor = System.Drawing.SystemColors.Window
        Me.tbDest_FP_or_FPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDest_FP_or_FPN.Location = New System.Drawing.Point(146, 50)
        Me.tbDest_FP_or_FPN.Name = "tbDest_FP_or_FPN"
        Me.tbDest_FP_or_FPN.Size = New System.Drawing.Size(536, 21)
        Me.tbDest_FP_or_FPN.TabIndex = 30
        '
        'tbFileNameTail
        '
        Me.tbFileNameTail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFileNameTail.Location = New System.Drawing.Point(530, 23)
        Me.tbFileNameTail.Multiline = True
        Me.tbFileNameTail.Name = "tbFileNameTail"
        Me.tbFileNameTail.Size = New System.Drawing.Size(152, 21)
        Me.tbFileNameTail.TabIndex = 26
        '
        'tbFileNameHead
        '
        Me.tbFileNameHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFileNameHead.Location = New System.Drawing.Point(231, 23)
        Me.tbFileNameHead.Multiline = True
        Me.tbFileNameHead.Name = "tbFileNameHead"
        Me.tbFileNameHead.Size = New System.Drawing.Size(158, 21)
        Me.tbFileNameHead.TabIndex = 25
        '
        'btOpenDestFolderOrFile
        '
        Me.btOpenDestFolderOrFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btOpenDestFolderOrFile.Location = New System.Drawing.Point(18, 49)
        Me.btOpenDestFolderOrFile.Name = "btOpenDestFolderOrFile"
        Me.btOpenDestFolderOrFile.Size = New System.Drawing.Size(122, 21)
        Me.btOpenDestFolderOrFile.TabIndex = 29
        Me.btOpenDestFolderOrFile.Text = "Destination folder"
        Me.btOpenDestFolderOrFile.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.tbFileNameFilter)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.tbExtensionFilter)
        Me.GroupBox2.Controls.Add(Me.lstRFfiles)
        Me.GroupBox2.Controls.Add(Me.txtFolderPathSource)
        Me.GroupBox2.Controls.Add(Me.btOpenFolder)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.btAddAllFiles)
        Me.GroupBox2.Controls.Add(Me.btAddSelectedFile)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(13, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 290)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search source files"
        '
        'tbFileNameFilter
        '
        Me.tbFileNameFilter.Location = New System.Drawing.Point(198, 50)
        Me.tbFileNameFilter.Name = "tbFileNameFilter"
        Me.tbFileNameFilter.Size = New System.Drawing.Size(73, 21)
        Me.tbFileNameFilter.TabIndex = 206
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(99, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 12)
        Me.Label11.TabIndex = 207
        Me.Label11.Text = "File name filter :"
        '
        'tbExtensionFilter
        '
        Me.tbExtensionFilter.Location = New System.Drawing.Point(378, 51)
        Me.tbExtensionFilter.Name = "tbExtensionFilter"
        Me.tbExtensionFilter.Size = New System.Drawing.Size(42, 21)
        Me.tbExtensionFilter.TabIndex = 40
        '
        'lstRFfiles
        '
        Me.lstRFfiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstRFfiles.FormattingEnabled = True
        Me.lstRFfiles.HorizontalScrollbar = True
        Me.lstRFfiles.ItemHeight = 12
        Me.lstRFfiles.Location = New System.Drawing.Point(10, 81)
        Me.lstRFfiles.Name = "lstRFfiles"
        Me.lstRFfiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstRFfiles.Size = New System.Drawing.Size(410, 160)
        Me.lstRFfiles.TabIndex = 39
        '
        'txtFolderPathSource
        '
        Me.txtFolderPathSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFolderPathSource.BackColor = System.Drawing.SystemColors.Window
        Me.txtFolderPathSource.Location = New System.Drawing.Point(101, 23)
        Me.txtFolderPathSource.Name = "txtFolderPathSource"
        Me.txtFolderPathSource.Size = New System.Drawing.Size(319, 21)
        Me.txtFolderPathSource.TabIndex = 38
        '
        'btOpenFolder
        '
        Me.btOpenFolder.Location = New System.Drawing.Point(10, 23)
        Me.btOpenFolder.Name = "btOpenFolder"
        Me.btOpenFolder.Size = New System.Drawing.Size(85, 21)
        Me.btOpenFolder.TabIndex = 37
        Me.btOpenFolder.Text = "Select folder"
        Me.btOpenFolder.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(280, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 12)
        Me.Label14.TabIndex = 203
        Me.Label14.Text = "Extension filter :"
        '
        'btAddAllFiles
        '
        Me.btAddAllFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btAddAllFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddAllFiles.Location = New System.Drawing.Point(127, 255)
        Me.btAddAllFiles.Name = "btAddAllFiles"
        Me.btAddAllFiles.Size = New System.Drawing.Size(148, 25)
        Me.btAddAllFiles.TabIndex = 13
        Me.btAddAllFiles.Text = "Add all"
        Me.btAddAllFiles.UseVisualStyleBackColor = True
        '
        'btAddSelectedFile
        '
        Me.btAddSelectedFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btAddSelectedFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddSelectedFile.Location = New System.Drawing.Point(281, 255)
        Me.btAddSelectedFile.Name = "btAddSelectedFile"
        Me.btAddSelectedFile.Size = New System.Drawing.Size(139, 25)
        Me.btAddSelectedFile.TabIndex = 14
        Me.btAddSelectedFile.Text = "Add selected"
        Me.btAddSelectedFile.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btClose.Location = New System.Drawing.Point(740, 709)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(120, 27)
        Me.btClose.TabIndex = 43
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btStartProcess
        '
        Me.btStartProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btStartProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btStartProcess.Location = New System.Drawing.Point(740, 658)
        Me.btStartProcess.Name = "btStartProcess"
        Me.btStartProcess.Size = New System.Drawing.Size(120, 43)
        Me.btStartProcess.TabIndex = 42
        Me.btStartProcess.Text = "Start"
        Me.btStartProcess.UseVisualStyleBackColor = True
        '
        'rbValueFromASCIIFiles
        '
        Me.rbValueFromASCIIFiles.AutoSize = True
        Me.rbValueFromASCIIFiles.Checked = True
        Me.rbValueFromASCIIFiles.Location = New System.Drawing.Point(13, 319)
        Me.rbValueFromASCIIFiles.Name = "rbValueFromASCIIFiles"
        Me.rbValueFromASCIIFiles.Size = New System.Drawing.Size(331, 16)
        Me.rbValueFromASCIIFiles.TabIndex = 44
        Me.rbValueFromASCIIFiles.TabStop = True
        Me.rbValueFromASCIIFiles.Text = "Extract values from ASCII raster files and save in a file"
        Me.rbValueFromASCIIFiles.UseVisualStyleBackColor = True
        '
        'rbValueFromTextFile
        '
        Me.rbValueFromTextFile.AutoSize = True
        Me.rbValueFromTextFile.Location = New System.Drawing.Point(12, 491)
        Me.rbValueFromTextFile.Name = "rbValueFromTextFile"
        Me.rbValueFromTextFile.Size = New System.Drawing.Size(471, 16)
        Me.rbValueFromTextFile.TabIndex = 46
        Me.rbValueFromTextFile.Text = "Extract text from the files contain values separated by comma, tab, and space."
        Me.rbValueFromTextFile.UseVisualStyleBackColor = True
        '
        'gbExtractFromTextFile
        '
        Me.gbExtractFromTextFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbExtractFromTextFile.Controls.Add(Me.GroupBox6)
        Me.gbExtractFromTextFile.Controls.Add(Me.GroupBox5)
        Me.gbExtractFromTextFile.Location = New System.Drawing.Point(12, 506)
        Me.gbExtractFromTextFile.Name = "gbExtractFromTextFile"
        Me.gbExtractFromTextFile.Size = New System.Drawing.Size(847, 135)
        Me.gbExtractFromTextFile.TabIndex = 45
        Me.gbExtractFromTextFile.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.chkOnlyNumericValue)
        Me.GroupBox6.Controls.Add(Me.tbColidxInTextFile)
        Me.GroupBox6.Location = New System.Drawing.Point(526, 16)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(312, 113)
        Me.GroupBox6.TabIndex = 216
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Column condition"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 12)
        Me.Label7.TabIndex = 222
        Me.Label7.Text = "Column index(starts from 0) :"
        '
        'chkOnlyNumericValue
        '
        Me.chkOnlyNumericValue.AutoSize = True
        Me.chkOnlyNumericValue.Checked = True
        Me.chkOnlyNumericValue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOnlyNumericValue.Location = New System.Drawing.Point(22, 23)
        Me.chkOnlyNumericValue.Name = "chkOnlyNumericValue"
        Me.chkOnlyNumericValue.Size = New System.Drawing.Size(175, 16)
        Me.chkOnlyNumericValue.TabIndex = 47
        Me.chkOnlyNumericValue.Text = "Extract numeric value only"
        Me.chkOnlyNumericValue.UseVisualStyleBackColor = True
        '
        'tbColidxInTextFile
        '
        Me.tbColidxInTextFile.Location = New System.Drawing.Point(198, 46)
        Me.tbColidxInTextFile.Name = "tbColidxInTextFile"
        Me.tbColidxInTextFile.Size = New System.Drawing.Size(78, 21)
        Me.tbColidxInTextFile.TabIndex = 221
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.rbStartingLineText)
        Me.GroupBox5.Controls.Add(Me.rbStartingIndex)
        Me.GroupBox5.Controls.Add(Me.tbEndingLineText)
        Me.GroupBox5.Controls.Add(Me.tbStartingLineText)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.tbEndingLineidx)
        Me.GroupBox5.Controls.Add(Me.tbStartingLineidx)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(509, 113)
        Me.GroupBox5.TabIndex = 215
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Line condition"
        '
        'rbStartingLineText
        '
        Me.rbStartingLineText.AutoSize = True
        Me.rbStartingLineText.Checked = True
        Me.rbStartingLineText.Location = New System.Drawing.Point(10, 61)
        Me.rbStartingLineText.Name = "rbStartingLineText"
        Me.rbStartingLineText.Size = New System.Drawing.Size(219, 16)
        Me.rbStartingLineText.TabIndex = 228
        Me.rbStartingLineText.TabStop = True
        Me.rbStartingLineText.Text = "Text contained in the starting line :"
        Me.rbStartingLineText.UseVisualStyleBackColor = True
        '
        'rbStartingIndex
        '
        Me.rbStartingIndex.AutoSize = True
        Me.rbStartingIndex.Location = New System.Drawing.Point(10, 87)
        Me.rbStartingIndex.Name = "rbStartingIndex"
        Me.rbStartingIndex.Size = New System.Drawing.Size(177, 16)
        Me.rbStartingIndex.TabIndex = 227
        Me.rbStartingIndex.Text = "Starting line index(from 0) :"
        Me.rbStartingIndex.UseVisualStyleBackColor = True
        '
        'tbEndingLineText
        '
        Me.tbEndingLineText.Location = New System.Drawing.Point(426, 59)
        Me.tbEndingLineText.Name = "tbEndingLineText"
        Me.tbEndingLineText.Size = New System.Drawing.Size(75, 21)
        Me.tbEndingLineText.TabIndex = 226
        '
        'tbStartingLineText
        '
        Me.tbStartingLineText.Location = New System.Drawing.Point(232, 59)
        Me.tbStartingLineText.Name = "tbStartingLineText"
        Me.tbStartingLineText.Size = New System.Drawing.Size(78, 21)
        Me.tbStartingLineText.TabIndex = 225
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(322, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 12)
        Me.Label8.TabIndex = 223
        Me.Label8.Text = "Ending line text :"
        '
        'tbEndingLineidx
        '
        Me.tbEndingLineidx.Location = New System.Drawing.Point(426, 84)
        Me.tbEndingLineidx.Name = "tbEndingLineidx"
        Me.tbEndingLineidx.Size = New System.Drawing.Size(75, 21)
        Me.tbEndingLineidx.TabIndex = 222
        '
        'tbStartingLineidx
        '
        Me.tbStartingLineidx.Location = New System.Drawing.Point(232, 84)
        Me.tbStartingLineidx.Name = "tbStartingLineidx"
        Me.tbStartingLineidx.Size = New System.Drawing.Size(78, 21)
        Me.tbStartingLineidx.TabIndex = 221
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 12)
        Me.Label3.TabIndex = 219
        Me.Label3.Text = "Ending line index :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(331, 12)
        Me.Label9.TabIndex = 217
        Me.Label9.Text = "Defined line conditions are included in the sanning range."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(227, 12)
        Me.Label10.TabIndex = 218
        Me.Label10.Text = "If not defined, all lines will be scanned."
        '
        'rbAccAscRaster
        '
        Me.rbAccAscRaster.AutoSize = True
        Me.rbAccAscRaster.Location = New System.Drawing.Point(13, 416)
        Me.rbAccAscRaster.Name = "rbAccAscRaster"
        Me.rbAccAscRaster.Size = New System.Drawing.Size(181, 16)
        Me.rbAccAscRaster.TabIndex = 48
        Me.rbAccAscRaster.Text = "Accumulate ASCII raster file"
        Me.rbAccAscRaster.UseVisualStyleBackColor = True
        '
        'gbAcc
        '
        Me.gbAcc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbAcc.Controls.Add(Me.tbFileNumToAgg)
        Me.gbAcc.Controls.Add(Me.chkAllowNegativeInAcc)
        Me.gbAcc.Controls.Add(Me.rbAggregate)
        Me.gbAcc.Controls.Add(Me.rbAccAllFiles)
        Me.gbAcc.Location = New System.Drawing.Point(13, 431)
        Me.gbAcc.Name = "gbAcc"
        Me.gbAcc.Size = New System.Drawing.Size(847, 47)
        Me.gbAcc.TabIndex = 47
        Me.gbAcc.TabStop = False
        '
        'tbFileNumToAgg
        '
        Me.tbFileNumToAgg.Enabled = False
        Me.tbFileNumToAgg.Location = New System.Drawing.Point(462, 16)
        Me.tbFileNumToAgg.Name = "tbFileNumToAgg"
        Me.tbFileNumToAgg.Size = New System.Drawing.Size(42, 21)
        Me.tbFileNumToAgg.TabIndex = 217
        '
        'chkAllowNegativeInAcc
        '
        Me.chkAllowNegativeInAcc.AutoSize = True
        Me.chkAllowNegativeInAcc.Location = New System.Drawing.Point(526, 19)
        Me.chkAllowNegativeInAcc.Name = "chkAllowNegativeInAcc"
        Me.chkAllowNegativeInAcc.Size = New System.Drawing.Size(147, 16)
        Me.chkAllowNegativeInAcc.TabIndex = 216
        Me.chkAllowNegativeInAcc.Text = "Allow negative values"
        Me.chkAllowNegativeInAcc.UseVisualStyleBackColor = True
        '
        'rbAggregate
        '
        Me.rbAggregate.AutoSize = True
        Me.rbAggregate.Location = New System.Drawing.Point(193, 19)
        Me.rbAggregate.Name = "rbAggregate"
        Me.rbAggregate.Size = New System.Drawing.Size(268, 16)
        Me.rbAggregate.TabIndex = 214
        Me.rbAggregate.Text = "Aggregate files. File number to aggregate : "
        Me.rbAggregate.UseVisualStyleBackColor = True
        '
        'rbAccAllFiles
        '
        Me.rbAccAllFiles.AutoSize = True
        Me.rbAccAllFiles.Checked = True
        Me.rbAccAllFiles.Location = New System.Drawing.Point(20, 20)
        Me.rbAccAllFiles.Name = "rbAccAllFiles"
        Me.rbAccAllFiles.Size = New System.Drawing.Size(134, 16)
        Me.rbAccAllFiles.TabIndex = 213
        Me.rbAccAllFiles.TabStop = True
        Me.rbAccAllFiles.Text = "Accumulate all files"
        Me.rbAccAllFiles.UseVisualStyleBackColor = True
        '
        'fExtractValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 743)
        Me.Controls.Add(Me.rbAccAscRaster)
        Me.Controls.Add(Me.gbAcc)
        Me.Controls.Add(Me.rbValueFromTextFile)
        Me.Controls.Add(Me.gbExtractFromTextFile)
        Me.Controls.Add(Me.rbValueFromASCIIFiles)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btStartProcess)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbExtractFromASCII)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(888, 782)
        Me.MinimumSize = New System.Drawing.Size(888, 782)
        Me.Name = "fExtractValue"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Extract values from text files"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvRainfallFileList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbExtractFromASCII.ResumeLayout(False)
        Me.gbExtractFromASCII.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbExtractFromTextFile.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.gbAcc.ResumeLayout(False)
        Me.gbAcc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvRainfallFileList As DataGridView
    Friend WithEvents btRemoveAll As Button
    Friend WithEvents btRemoveSelected As Button
    Friend WithEvents gbExtractFromASCII As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbDest_FP_or_FPN As TextBox
    Friend WithEvents tbFileNameTail As TextBox
    Friend WithEvents tbFileNameHead As TextBox
    Friend WithEvents btOpenDestFolderOrFile As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbExtensionFilter As TextBox
    Friend WithEvents lstRFfiles As ListBox
    Friend WithEvents txtFolderPathSource As TextBox
    Friend WithEvents btOpenFolder As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents btAddAllFiles As Button
    Friend WithEvents btAddSelectedFile As Button
    Friend WithEvents btClose As Button
    Friend WithEvents btStartProcess As Button
    Friend WithEvents rbValueFromASCIIFiles As RadioButton
    Friend WithEvents tbrowy As TextBox
    Friend WithEvents tbcolx As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbValueFromTextFile As RadioButton
    Friend WithEvents gbExtractFromTextFile As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents rbStartingLineText As RadioButton
    Friend WithEvents rbStartingIndex As RadioButton
    Friend WithEvents tbEndingLineText As TextBox
    Friend WithEvents tbStartingLineText As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbEndingLineidx As TextBox
    Friend WithEvents tbStartingLineidx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents tbColidxInTextFile As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkOnlyNumericValue As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rbAccAscRaster As RadioButton
    Friend WithEvents gbAcc As GroupBox
    Friend WithEvents rbAggregate As RadioButton
    Friend WithEvents rbAccAllFiles As RadioButton
    Friend WithEvents chkAllowNegativeInAcc As CheckBox
    Friend WithEvents tbFileNumToAgg As TextBox
    Friend WithEvents rbExtractFromAcell As RadioButton
    Friend WithEvents rbExtractCellsAverage As RadioButton
    Friend WithEvents btHelpExtractCellsAverageValue As Button
    Friend WithEvents btSelectBaseRasterFile As Button
    Friend WithEvents tbBaseGridFile As TextBox
    Friend WithEvents chkAllowNegativeInCalCellAverage As CheckBox
    Friend WithEvents tbFileNameFilter As TextBox
    Friend WithEvents Label11 As Label
End Class
