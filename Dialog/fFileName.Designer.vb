<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fFileName
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
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbTimeStart = New System.Windows.Forms.Label()
        Me.dtpResultStarting = New System.Windows.Forms.DateTimePicker()
        Me.lbTimeStep = New System.Windows.Forms.Label()
        Me.tbTimeStep = New System.Windows.Forms.TextBox()
        Me.chkUsingSourceFileName = New System.Windows.Forms.CheckBox()
        Me.tbTextToReplace = New System.Windows.Forms.TextBox()
        Me.tbTextToFind = New System.Windows.Forms.TextBox()
        Me.tbFileTail = New System.Windows.Forms.TextBox()
        Me.tbFileHead = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbFileNameFilter = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbExtensionFilter = New System.Windows.Forms.TextBox()
        Me.lstFiles = New System.Windows.Forms.ListBox()
        Me.txtFolderPathSource = New System.Windows.Forms.TextBox()
        Me.btOpenRfFolder = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btAddAllFiles = New System.Windows.Forms.Button()
        Me.btAddSelectedFile = New System.Windows.Forms.Button()
        Me.rbRenameToDateTimeFormat = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvFileList = New System.Windows.Forms.DataGridView()
        Me.btRemoveAll = New System.Windows.Forms.Button()
        Me.btRemoveSelected = New System.Windows.Forms.Button()
        Me.rbRename = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbMakeBatchFile = New System.Windows.Forms.RadioButton()
        Me.rbSaveFileList = New System.Windows.Forms.RadioButton()
        Me.rbChangeFileExt = New System.Windows.Forms.RadioButton()
        Me.gbConditions = New System.Windows.Forms.GroupBox()
        Me.lbBatchFile = New System.Windows.Forms.Label()
        Me.tbBatchTail = New System.Windows.Forms.TextBox()
        Me.tbBatchHead = New System.Windows.Forms.TextBox()
        Me.lbBatchFileList = New System.Windows.Forms.Label()
        Me.lbFileExt = New System.Windows.Forms.Label()
        Me.tbExtToChange = New System.Windows.Forms.TextBox()
        Me.lbSetTime = New System.Windows.Forms.Label()
        Me.lbTextToFind = New System.Windows.Forms.Label()
        Me.chkSetDestinationFolder = New System.Windows.Forms.CheckBox()
        Me.lbTextToReplace = New System.Windows.Forms.Label()
        Me.lbTail = New System.Windows.Forms.Label()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btStartProcess = New System.Windows.Forms.Button()
        Me.btResultFPN = New System.Windows.Forms.Button()
        Me.tbResultFPN = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbConditions.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbTimeStart
        '
        Me.lbTimeStart.AutoSize = True
        Me.lbTimeStart.Location = New System.Drawing.Point(251, 51)
        Me.lbTimeStart.Name = "lbTimeStart"
        Me.lbTimeStart.Size = New System.Drawing.Size(83, 12)
        Me.lbTimeStart.TabIndex = 211
        Me.lbTimeStart.Text = "Starting time :"
        '
        'dtpResultStarting
        '
        Me.dtpResultStarting.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.dtpResultStarting.Enabled = False
        Me.dtpResultStarting.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpResultStarting.Location = New System.Drawing.Point(337, 47)
        Me.dtpResultStarting.Name = "dtpResultStarting"
        Me.dtpResultStarting.ShowUpDown = True
        Me.dtpResultStarting.Size = New System.Drawing.Size(145, 21)
        Me.dtpResultStarting.TabIndex = 226
        '
        'lbTimeStep
        '
        Me.lbTimeStep.AutoSize = True
        Me.lbTimeStep.Location = New System.Drawing.Point(497, 52)
        Me.lbTimeStep.Name = "lbTimeStep"
        Me.lbTimeStep.Size = New System.Drawing.Size(103, 12)
        Me.lbTimeStep.TabIndex = 227
        Me.lbTimeStep.Text = "Time step[min] :"
        '
        'tbTimeStep
        '
        Me.tbTimeStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTimeStep.Location = New System.Drawing.Point(602, 46)
        Me.tbTimeStep.Name = "tbTimeStep"
        Me.tbTimeStep.Size = New System.Drawing.Size(139, 21)
        Me.tbTimeStep.TabIndex = 225
        Me.tbTimeStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkUsingSourceFileName
        '
        Me.chkUsingSourceFileName.AutoSize = True
        Me.chkUsingSourceFileName.Checked = True
        Me.chkUsingSourceFileName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUsingSourceFileName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkUsingSourceFileName.Location = New System.Drawing.Point(17, 22)
        Me.chkUsingSourceFileName.Name = "chkUsingSourceFileName"
        Me.chkUsingSourceFileName.Size = New System.Drawing.Size(594, 16)
        Me.chkUsingSourceFileName.TabIndex = 214
        Me.chkUsingSourceFileName.Text = "Using source file name as output file name (if not selected, serial numbers are a" &
    "pplied to file names)"
        Me.chkUsingSourceFileName.UseVisualStyleBackColor = True
        '
        'tbTextToReplace
        '
        Me.tbTextToReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTextToReplace.Location = New System.Drawing.Point(602, 74)
        Me.tbTextToReplace.Multiline = True
        Me.tbTextToReplace.Name = "tbTextToReplace"
        Me.tbTextToReplace.Size = New System.Drawing.Size(139, 21)
        Me.tbTextToReplace.TabIndex = 218
        '
        'tbTextToFind
        '
        Me.tbTextToFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTextToFind.Location = New System.Drawing.Point(337, 74)
        Me.tbTextToFind.Multiline = True
        Me.tbTextToFind.Name = "tbTextToFind"
        Me.tbTextToFind.Size = New System.Drawing.Size(145, 21)
        Me.tbTextToFind.TabIndex = 217
        '
        'tbFileTail
        '
        Me.tbFileTail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFileTail.Location = New System.Drawing.Point(602, 20)
        Me.tbFileTail.Multiline = True
        Me.tbFileTail.Name = "tbFileTail"
        Me.tbFileTail.Size = New System.Drawing.Size(139, 21)
        Me.tbFileTail.TabIndex = 216
        '
        'tbFileHead
        '
        Me.tbFileHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFileHead.Location = New System.Drawing.Point(310, 20)
        Me.tbFileHead.Multiline = True
        Me.tbFileHead.Name = "tbFileHead"
        Me.tbFileHead.Size = New System.Drawing.Size(145, 21)
        Me.tbFileHead.TabIndex = 215
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbFileNameFilter)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.tbExtensionFilter)
        Me.GroupBox2.Controls.Add(Me.lstFiles)
        Me.GroupBox2.Controls.Add(Me.txtFolderPathSource)
        Me.GroupBox2.Controls.Add(Me.btOpenRfFolder)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.btAddAllFiles)
        Me.GroupBox2.Controls.Add(Me.btAddSelectedFile)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 296)
        Me.GroupBox2.TabIndex = 209
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search source files"
        '
        'tbFileNameFilter
        '
        Me.tbFileNameFilter.Location = New System.Drawing.Point(198, 48)
        Me.tbFileNameFilter.Name = "tbFileNameFilter"
        Me.tbFileNameFilter.Size = New System.Drawing.Size(73, 21)
        Me.tbFileNameFilter.TabIndex = 206
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(99, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 12)
        Me.Label11.TabIndex = 207
        Me.Label11.Text = "File name filter :"
        '
        'tbExtensionFilter
        '
        Me.tbExtensionFilter.Location = New System.Drawing.Point(378, 48)
        Me.tbExtensionFilter.Name = "tbExtensionFilter"
        Me.tbExtensionFilter.Size = New System.Drawing.Size(42, 21)
        Me.tbExtensionFilter.TabIndex = 40
        '
        'lstFiles
        '
        Me.lstFiles.FormattingEnabled = True
        Me.lstFiles.HorizontalScrollbar = True
        Me.lstFiles.ItemHeight = 12
        Me.lstFiles.Location = New System.Drawing.Point(10, 75)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstFiles.Size = New System.Drawing.Size(410, 172)
        Me.lstFiles.TabIndex = 39
        '
        'txtFolderPathSource
        '
        Me.txtFolderPathSource.BackColor = System.Drawing.SystemColors.Window
        Me.txtFolderPathSource.Location = New System.Drawing.Point(101, 23)
        Me.txtFolderPathSource.Name = "txtFolderPathSource"
        Me.txtFolderPathSource.Size = New System.Drawing.Size(319, 21)
        Me.txtFolderPathSource.TabIndex = 38
        '
        'btOpenRfFolder
        '
        Me.btOpenRfFolder.Location = New System.Drawing.Point(10, 23)
        Me.btOpenRfFolder.Name = "btOpenRfFolder"
        Me.btOpenRfFolder.Size = New System.Drawing.Size(85, 21)
        Me.btOpenRfFolder.TabIndex = 37
        Me.btOpenRfFolder.Text = "Select folder"
        Me.btOpenRfFolder.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(279, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 12)
        Me.Label14.TabIndex = 203
        Me.Label14.Text = "Extension filter :"
        '
        'btAddAllFiles
        '
        Me.btAddAllFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddAllFiles.Location = New System.Drawing.Point(127, 258)
        Me.btAddAllFiles.Name = "btAddAllFiles"
        Me.btAddAllFiles.Size = New System.Drawing.Size(148, 25)
        Me.btAddAllFiles.TabIndex = 13
        Me.btAddAllFiles.Text = "Add all"
        Me.btAddAllFiles.UseVisualStyleBackColor = True
        '
        'btAddSelectedFile
        '
        Me.btAddSelectedFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddSelectedFile.Location = New System.Drawing.Point(281, 258)
        Me.btAddSelectedFile.Name = "btAddSelectedFile"
        Me.btAddSelectedFile.Size = New System.Drawing.Size(139, 25)
        Me.btAddSelectedFile.TabIndex = 14
        Me.btAddSelectedFile.Text = "Add selected"
        Me.btAddSelectedFile.UseVisualStyleBackColor = True
        '
        'rbRenameToDateTimeFormat
        '
        Me.rbRenameToDateTimeFormat.AutoSize = True
        Me.rbRenameToDateTimeFormat.Location = New System.Drawing.Point(136, 20)
        Me.rbRenameToDateTimeFormat.Name = "rbRenameToDateTimeFormat"
        Me.rbRenameToDateTimeFormat.Size = New System.Drawing.Size(208, 16)
        Me.rbRenameToDateTimeFormat.TabIndex = 213
        Me.rbRenameToDateTimeFormat.Text = "Rename files to DateTime format"
        Me.rbRenameToDateTimeFormat.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvFileList)
        Me.GroupBox4.Controls.Add(Me.btRemoveAll)
        Me.GroupBox4.Controls.Add(Me.btRemoveSelected)
        Me.GroupBox4.Location = New System.Drawing.Point(448, 106)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(411, 296)
        Me.GroupBox4.TabIndex = 210
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Selected source files"
        '
        'dgvFileList
        '
        Me.dgvFileList.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFileList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFileList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFileList.Location = New System.Drawing.Point(10, 22)
        Me.dgvFileList.Name = "dgvFileList"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFileList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFileList.RowHeadersVisible = False
        Me.dgvFileList.RowTemplate.Height = 23
        Me.dgvFileList.Size = New System.Drawing.Size(392, 225)
        Me.dgvFileList.TabIndex = 16
        '
        'btRemoveAll
        '
        Me.btRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveAll.Location = New System.Drawing.Point(112, 258)
        Me.btRemoveAll.Name = "btRemoveAll"
        Me.btRemoveAll.Size = New System.Drawing.Size(142, 25)
        Me.btRemoveAll.TabIndex = 17
        Me.btRemoveAll.Text = "Remove all"
        Me.btRemoveAll.UseVisualStyleBackColor = True
        '
        'btRemoveSelected
        '
        Me.btRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveSelected.Location = New System.Drawing.Point(260, 258)
        Me.btRemoveSelected.Name = "btRemoveSelected"
        Me.btRemoveSelected.Size = New System.Drawing.Size(142, 25)
        Me.btRemoveSelected.TabIndex = 18
        Me.btRemoveSelected.Text = "Remove selected"
        Me.btRemoveSelected.UseVisualStyleBackColor = True
        '
        'rbRename
        '
        Me.rbRename.AutoSize = True
        Me.rbRename.Checked = True
        Me.rbRename.Location = New System.Drawing.Point(16, 20)
        Me.rbRename.Name = "rbRename"
        Me.rbRename.Size = New System.Drawing.Size(97, 16)
        Me.rbRename.TabIndex = 208
        Me.rbRename.TabStop = True
        Me.rbRename.Text = "Rename files"
        Me.rbRename.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbMakeBatchFile)
        Me.GroupBox1.Controls.Add(Me.rbSaveFileList)
        Me.GroupBox1.Controls.Add(Me.rbChangeFileExt)
        Me.GroupBox1.Controls.Add(Me.rbRenameToDateTimeFormat)
        Me.GroupBox1.Controls.Add(Me.rbRename)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 74)
        Me.GroupBox1.TabIndex = 228
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select processing"
        '
        'rbMakeBatchFile
        '
        Me.rbMakeBatchFile.AutoSize = True
        Me.rbMakeBatchFile.Location = New System.Drawing.Point(385, 42)
        Me.rbMakeBatchFile.Name = "rbMakeBatchFile"
        Me.rbMakeBatchFile.Size = New System.Drawing.Size(231, 16)
        Me.rbMakeBatchFile.TabIndex = 216
        Me.rbMakeBatchFile.Text = "Make a batch file using file name list"
        Me.rbMakeBatchFile.UseVisualStyleBackColor = True
        '
        'rbSaveFileList
        '
        Me.rbSaveFileList.AutoSize = True
        Me.rbSaveFileList.Location = New System.Drawing.Point(16, 45)
        Me.rbSaveFileList.Name = "rbSaveFileList"
        Me.rbSaveFileList.Size = New System.Drawing.Size(255, 16)
        Me.rbSaveFileList.TabIndex = 215
        Me.rbSaveFileList.Text = "Save file list (full path and name) to a file"
        Me.rbSaveFileList.UseVisualStyleBackColor = True
        '
        'rbChangeFileExt
        '
        Me.rbChangeFileExt.AutoSize = True
        Me.rbChangeFileExt.Location = New System.Drawing.Point(385, 20)
        Me.rbChangeFileExt.Name = "rbChangeFileExt"
        Me.rbChangeFileExt.Size = New System.Drawing.Size(153, 16)
        Me.rbChangeFileExt.TabIndex = 214
        Me.rbChangeFileExt.Text = "Change file extensions"
        Me.rbChangeFileExt.UseVisualStyleBackColor = True
        '
        'gbConditions
        '
        Me.gbConditions.Controls.Add(Me.lbBatchFile)
        Me.gbConditions.Controls.Add(Me.tbBatchTail)
        Me.gbConditions.Controls.Add(Me.tbBatchHead)
        Me.gbConditions.Controls.Add(Me.lbBatchFileList)
        Me.gbConditions.Controls.Add(Me.lbFileExt)
        Me.gbConditions.Controls.Add(Me.tbExtToChange)
        Me.gbConditions.Controls.Add(Me.lbTimeStart)
        Me.gbConditions.Controls.Add(Me.lbSetTime)
        Me.gbConditions.Controls.Add(Me.lbTextToFind)
        Me.gbConditions.Controls.Add(Me.dtpResultStarting)
        Me.gbConditions.Controls.Add(Me.lbTimeStep)
        Me.gbConditions.Controls.Add(Me.tbTimeStep)
        Me.gbConditions.Controls.Add(Me.tbTextToReplace)
        Me.gbConditions.Controls.Add(Me.chkSetDestinationFolder)
        Me.gbConditions.Controls.Add(Me.chkUsingSourceFileName)
        Me.gbConditions.Controls.Add(Me.tbTextToFind)
        Me.gbConditions.Controls.Add(Me.lbTextToReplace)
        Me.gbConditions.Location = New System.Drawing.Point(12, 415)
        Me.gbConditions.Name = "gbConditions"
        Me.gbConditions.Size = New System.Drawing.Size(747, 159)
        Me.gbConditions.TabIndex = 229
        Me.gbConditions.TabStop = False
        Me.gbConditions.Text = "Conditions"
        '
        'lbBatchFile
        '
        Me.lbBatchFile.AutoSize = True
        Me.lbBatchFile.Location = New System.Drawing.Point(14, 134)
        Me.lbBatchFile.Name = "lbBatchFile"
        Me.lbBatchFile.Size = New System.Drawing.Size(124, 12)
        Me.lbBatchFile.TabIndex = 235
        Me.lbBatchFile.Text = "Batch file statement :"
        '
        'tbBatchTail
        '
        Me.tbBatchTail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBatchTail.Location = New System.Drawing.Point(468, 132)
        Me.tbBatchTail.Multiline = True
        Me.tbBatchTail.Name = "tbBatchTail"
        Me.tbBatchTail.Size = New System.Drawing.Size(273, 21)
        Me.tbBatchTail.TabIndex = 234
        '
        'tbBatchHead
        '
        Me.tbBatchHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbBatchHead.Location = New System.Drawing.Point(144, 132)
        Me.tbBatchHead.Multiline = True
        Me.tbBatchHead.Name = "tbBatchHead"
        Me.tbBatchHead.Size = New System.Drawing.Size(242, 21)
        Me.tbBatchHead.TabIndex = 234
        '
        'lbBatchFileList
        '
        Me.lbBatchFileList.AutoSize = True
        Me.lbBatchFileList.Location = New System.Drawing.Point(388, 136)
        Me.lbBatchFileList.Name = "lbBatchFileList"
        Me.lbBatchFileList.Size = New System.Drawing.Size(77, 12)
        Me.lbBatchFileList.TabIndex = 233
        Me.lbBatchFileList.Text = "+ file name +"
        '
        'lbFileExt
        '
        Me.lbFileExt.AutoSize = True
        Me.lbFileExt.Location = New System.Drawing.Point(571, 106)
        Me.lbFileExt.Name = "lbFileExt"
        Me.lbFileExt.Size = New System.Drawing.Size(92, 12)
        Me.lbFileExt.TabIndex = 233
        Me.lbFileExt.Text = "File extension :"
        '
        'tbExtToChange
        '
        Me.tbExtToChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbExtToChange.Location = New System.Drawing.Point(666, 101)
        Me.tbExtToChange.Name = "tbExtToChange"
        Me.tbExtToChange.Size = New System.Drawing.Size(75, 21)
        Me.tbExtToChange.TabIndex = 232
        Me.tbExtToChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbSetTime
        '
        Me.lbSetTime.AutoSize = True
        Me.lbSetTime.Location = New System.Drawing.Point(76, 50)
        Me.lbSetTime.Name = "lbSetTime"
        Me.lbSetTime.Size = New System.Drawing.Size(159, 12)
        Me.lbSetTime.TabIndex = 212
        Me.lbSetTime.Text = "Set time condition to apply."
        '
        'lbTextToFind
        '
        Me.lbTextToFind.AutoSize = True
        Me.lbTextToFind.Location = New System.Drawing.Point(189, 79)
        Me.lbTextToFind.Name = "lbTextToFind"
        Me.lbTextToFind.Size = New System.Drawing.Size(146, 12)
        Me.lbTextToFind.TabIndex = 224
        Me.lbTextToFind.Text = "Text in file name to find :"
        '
        'chkSetDestinationFolder
        '
        Me.chkSetDestinationFolder.AutoSize = True
        Me.chkSetDestinationFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSetDestinationFolder.Location = New System.Drawing.Point(17, 102)
        Me.chkSetDestinationFolder.Name = "chkSetDestinationFolder"
        Me.chkSetDestinationFolder.Size = New System.Drawing.Size(387, 16)
        Me.chkSetDestinationFolder.TabIndex = 214
        Me.chkSetDestinationFolder.Text = "Set desination folder (if not selected, the files will be overwritten)"
        Me.chkSetDestinationFolder.UseVisualStyleBackColor = True
        '
        'lbTextToReplace
        '
        Me.lbTextToReplace.AutoSize = True
        Me.lbTextToReplace.Location = New System.Drawing.Point(502, 79)
        Me.lbTextToReplace.Name = "lbTextToReplace"
        Me.lbTextToReplace.Size = New System.Drawing.Size(98, 12)
        Me.lbTextToReplace.TabIndex = 221
        Me.lbTextToReplace.Text = "Text to repalce :"
        '
        'lbTail
        '
        Me.lbTail.AutoSize = True
        Me.lbTail.Location = New System.Drawing.Point(472, 25)
        Me.lbTail.Name = "lbTail"
        Me.lbTail.Size = New System.Drawing.Size(128, 12)
        Me.lbTail.TabIndex = 230
        Me.lbTail.Text = "Tail text of file name :"
        '
        'lbHead
        '
        Me.lbHead.AutoSize = True
        Me.lbHead.Location = New System.Drawing.Point(171, 25)
        Me.lbHead.Name = "lbHead"
        Me.lbHead.Size = New System.Drawing.Size(136, 12)
        Me.lbHead.TabIndex = 231
        Me.lbHead.Text = "Head text of file name :"
        '
        'btClose
        '
        Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btClose.Location = New System.Drawing.Point(765, 605)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(97, 61)
        Me.btClose.TabIndex = 231
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btStartProcess
        '
        Me.btStartProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btStartProcess.Location = New System.Drawing.Point(765, 422)
        Me.btStartProcess.Name = "btStartProcess"
        Me.btStartProcess.Size = New System.Drawing.Size(97, 177)
        Me.btStartProcess.TabIndex = 230
        Me.btStartProcess.Text = "Start"
        Me.btStartProcess.UseVisualStyleBackColor = True
        '
        'btResultFPN
        '
        Me.btResultFPN.Enabled = False
        Me.btResultFPN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btResultFPN.Location = New System.Drawing.Point(11, 47)
        Me.btResultFPN.Name = "btResultFPN"
        Me.btResultFPN.Size = New System.Drawing.Size(135, 21)
        Me.btResultFPN.TabIndex = 235
        Me.btResultFPN.Text = "Destination folder"
        Me.btResultFPN.UseVisualStyleBackColor = True
        '
        'tbResultFPN
        '
        Me.tbResultFPN.Enabled = False
        Me.tbResultFPN.Location = New System.Drawing.Point(152, 47)
        Me.tbResultFPN.Name = "tbResultFPN"
        Me.tbResultFPN.Size = New System.Drawing.Size(589, 21)
        Me.tbResultFPN.TabIndex = 234
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btResultFPN)
        Me.GroupBox3.Controls.Add(Me.tbResultFPN)
        Me.GroupBox3.Controls.Add(Me.lbTail)
        Me.GroupBox3.Controls.Add(Me.tbFileTail)
        Me.GroupBox3.Controls.Add(Me.lbHead)
        Me.GroupBox3.Controls.Add(Me.tbFileHead)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 586)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(747, 80)
        Me.GroupBox3.TabIndex = 236
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Result"
        '
        'fFileName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 676)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btStartProcess)
        Me.Controls.Add(Me.gbConditions)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(890, 715)
        Me.MinimumSize = New System.Drawing.Size(890, 715)
        Me.Name = "fFileName"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "File name processing"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbConditions.ResumeLayout(False)
        Me.gbConditions.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbTimeStart As Label
    Friend WithEvents dtpResultStarting As DateTimePicker
    Friend WithEvents lbTimeStep As Label
    Friend WithEvents tbTimeStep As TextBox
    Friend WithEvents chkUsingSourceFileName As CheckBox
    Friend WithEvents tbTextToReplace As TextBox
    Friend WithEvents tbTextToFind As TextBox
    Friend WithEvents tbFileTail As TextBox
    Friend WithEvents tbFileHead As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbExtensionFilter As TextBox
    Friend WithEvents lstFiles As ListBox
    Friend WithEvents txtFolderPathSource As TextBox
    Friend WithEvents btOpenRfFolder As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents btAddAllFiles As Button
    Friend WithEvents btAddSelectedFile As Button
    Friend WithEvents rbRenameToDateTimeFormat As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvFileList As DataGridView
    Friend WithEvents btRemoveAll As Button
    Friend WithEvents btRemoveSelected As Button
    Friend WithEvents rbRename As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbConditions As GroupBox
    Friend WithEvents lbTail As Label
    Friend WithEvents lbHead As Label
    Friend WithEvents lbTextToFind As Label
    Friend WithEvents lbSetTime As Label
    Friend WithEvents lbTextToReplace As Label
    Friend WithEvents btClose As Button
    Friend WithEvents btStartProcess As Button
    Friend WithEvents rbChangeFileExt As RadioButton
    Friend WithEvents lbFileExt As Label
    Friend WithEvents tbExtToChange As TextBox
    Friend WithEvents tbFileNameFilter As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents rbSaveFileList As RadioButton
    Friend WithEvents btResultFPN As Button
    Friend WithEvents tbResultFPN As TextBox
    Friend WithEvents chkSetDestinationFolder As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbMakeBatchFile As RadioButton
    Friend WithEvents lbBatchFile As Label
    Friend WithEvents tbBatchHead As TextBox
    Friend WithEvents lbBatchFileList As Label
    Friend WithEvents tbBatchTail As TextBox
End Class
