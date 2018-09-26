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
        Me.lstRFfiles = New System.Windows.Forms.ListBox()
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
        Me.rbSaveFileList = New System.Windows.Forms.RadioButton()
        Me.rbChangeFileExt = New System.Windows.Forms.RadioButton()
        Me.gbConditions = New System.Windows.Forms.GroupBox()
        Me.lbFileExt = New System.Windows.Forms.Label()
        Me.tbExtToChange = New System.Windows.Forms.TextBox()
        Me.lbTail = New System.Windows.Forms.Label()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.lbSetTime = New System.Windows.Forms.Label()
        Me.lbTextToFind = New System.Windows.Forms.Label()
        Me.lbTextToReplace = New System.Windows.Forms.Label()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btStartProcess = New System.Windows.Forms.Button()
        Me.btResultFPN = New System.Windows.Forms.Button()
        Me.tbResultFPN = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbConditions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbTimeStart
        '
        Me.lbTimeStart.AutoSize = True
        Me.lbTimeStart.Location = New System.Drawing.Point(193, 51)
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
        Me.dtpResultStarting.Location = New System.Drawing.Point(279, 47)
        Me.dtpResultStarting.Name = "dtpResultStarting"
        Me.dtpResultStarting.ShowUpDown = True
        Me.dtpResultStarting.Size = New System.Drawing.Size(145, 21)
        Me.dtpResultStarting.TabIndex = 226
        '
        'lbTimeStep
        '
        Me.lbTimeStep.AutoSize = True
        Me.lbTimeStep.Location = New System.Drawing.Point(466, 52)
        Me.lbTimeStep.Name = "lbTimeStep"
        Me.lbTimeStep.Size = New System.Drawing.Size(103, 12)
        Me.lbTimeStep.TabIndex = 227
        Me.lbTimeStep.Text = "Time step[min] :"
        '
        'tbTimeStep
        '
        Me.tbTimeStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTimeStep.Location = New System.Drawing.Point(571, 46)
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
        Me.tbTextToReplace.Location = New System.Drawing.Point(571, 74)
        Me.tbTextToReplace.Multiline = True
        Me.tbTextToReplace.Name = "tbTextToReplace"
        Me.tbTextToReplace.Size = New System.Drawing.Size(139, 21)
        Me.tbTextToReplace.TabIndex = 218
        '
        'tbTextToFind
        '
        Me.tbTextToFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTextToFind.Location = New System.Drawing.Point(279, 74)
        Me.tbTextToFind.Multiline = True
        Me.tbTextToFind.Name = "tbTextToFind"
        Me.tbTextToFind.Size = New System.Drawing.Size(145, 21)
        Me.tbTextToFind.TabIndex = 217
        '
        'tbFileTail
        '
        Me.tbFileTail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFileTail.Location = New System.Drawing.Point(571, 101)
        Me.tbFileTail.Multiline = True
        Me.tbFileTail.Name = "tbFileTail"
        Me.tbFileTail.Size = New System.Drawing.Size(139, 21)
        Me.tbFileTail.TabIndex = 216
        '
        'tbFileHead
        '
        Me.tbFileHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFileHead.Location = New System.Drawing.Point(279, 101)
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
        Me.GroupBox2.Controls.Add(Me.lstRFfiles)
        Me.GroupBox2.Controls.Add(Me.txtFolderPathSource)
        Me.GroupBox2.Controls.Add(Me.btOpenRfFolder)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.btAddAllFiles)
        Me.GroupBox2.Controls.Add(Me.btAddSelectedFile)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 351)
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
        'lstRFfiles
        '
        Me.lstRFfiles.FormattingEnabled = True
        Me.lstRFfiles.HorizontalScrollbar = True
        Me.lstRFfiles.ItemHeight = 12
        Me.lstRFfiles.Location = New System.Drawing.Point(10, 75)
        Me.lstRFfiles.Name = "lstRFfiles"
        Me.lstRFfiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstRFfiles.Size = New System.Drawing.Size(410, 232)
        Me.lstRFfiles.TabIndex = 39
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
        Me.btAddAllFiles.Location = New System.Drawing.Point(127, 317)
        Me.btAddAllFiles.Name = "btAddAllFiles"
        Me.btAddAllFiles.Size = New System.Drawing.Size(148, 25)
        Me.btAddAllFiles.TabIndex = 13
        Me.btAddAllFiles.Text = "Add all"
        Me.btAddAllFiles.UseVisualStyleBackColor = True
        '
        'btAddSelectedFile
        '
        Me.btAddSelectedFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddSelectedFile.Location = New System.Drawing.Point(281, 317)
        Me.btAddSelectedFile.Name = "btAddSelectedFile"
        Me.btAddSelectedFile.Size = New System.Drawing.Size(139, 25)
        Me.btAddSelectedFile.TabIndex = 14
        Me.btAddSelectedFile.Text = "Add selected"
        Me.btAddSelectedFile.UseVisualStyleBackColor = True
        '
        'rbRenameToDateTimeFormat
        '
        Me.rbRenameToDateTimeFormat.AutoSize = True
        Me.rbRenameToDateTimeFormat.Location = New System.Drawing.Point(192, 20)
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
        Me.GroupBox4.Location = New System.Drawing.Point(448, 89)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(411, 351)
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
        Me.dgvFileList.Size = New System.Drawing.Size(392, 285)
        Me.dgvFileList.TabIndex = 16
        '
        'btRemoveAll
        '
        Me.btRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveAll.Location = New System.Drawing.Point(112, 317)
        Me.btRemoveAll.Name = "btRemoveAll"
        Me.btRemoveAll.Size = New System.Drawing.Size(142, 25)
        Me.btRemoveAll.TabIndex = 17
        Me.btRemoveAll.Text = "Remove all"
        Me.btRemoveAll.UseVisualStyleBackColor = True
        '
        'btRemoveSelected
        '
        Me.btRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveSelected.Location = New System.Drawing.Point(260, 317)
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
        Me.rbRename.Location = New System.Drawing.Point(47, 20)
        Me.rbRename.Name = "rbRename"
        Me.rbRename.Size = New System.Drawing.Size(97, 16)
        Me.rbRename.TabIndex = 208
        Me.rbRename.TabStop = True
        Me.rbRename.Text = "Rename files"
        Me.rbRename.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbSaveFileList)
        Me.GroupBox1.Controls.Add(Me.rbChangeFileExt)
        Me.GroupBox1.Controls.Add(Me.rbRenameToDateTimeFormat)
        Me.GroupBox1.Controls.Add(Me.rbRename)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 53)
        Me.GroupBox1.TabIndex = 228
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select processing"
        '
        'rbSaveFileList
        '
        Me.rbSaveFileList.AutoSize = True
        Me.rbSaveFileList.Location = New System.Drawing.Point(656, 20)
        Me.rbSaveFileList.Name = "rbSaveFileList"
        Me.rbSaveFileList.Size = New System.Drawing.Size(136, 16)
        Me.rbSaveFileList.TabIndex = 215
        Me.rbSaveFileList.Text = "Save file list to a file"
        Me.rbSaveFileList.UseVisualStyleBackColor = True
        '
        'rbChangeFileExt
        '
        Me.rbChangeFileExt.AutoSize = True
        Me.rbChangeFileExt.Location = New System.Drawing.Point(448, 20)
        Me.rbChangeFileExt.Name = "rbChangeFileExt"
        Me.rbChangeFileExt.Size = New System.Drawing.Size(153, 16)
        Me.rbChangeFileExt.TabIndex = 214
        Me.rbChangeFileExt.Text = "Change file extensions"
        Me.rbChangeFileExt.UseVisualStyleBackColor = True
        '
        'gbConditions
        '
        Me.gbConditions.Controls.Add(Me.lbFileExt)
        Me.gbConditions.Controls.Add(Me.tbExtToChange)
        Me.gbConditions.Controls.Add(Me.lbTail)
        Me.gbConditions.Controls.Add(Me.lbHead)
        Me.gbConditions.Controls.Add(Me.lbTimeStart)
        Me.gbConditions.Controls.Add(Me.lbSetTime)
        Me.gbConditions.Controls.Add(Me.tbFileTail)
        Me.gbConditions.Controls.Add(Me.lbTextToFind)
        Me.gbConditions.Controls.Add(Me.dtpResultStarting)
        Me.gbConditions.Controls.Add(Me.lbTimeStep)
        Me.gbConditions.Controls.Add(Me.tbTimeStep)
        Me.gbConditions.Controls.Add(Me.tbTextToReplace)
        Me.gbConditions.Controls.Add(Me.chkUsingSourceFileName)
        Me.gbConditions.Controls.Add(Me.tbTextToFind)
        Me.gbConditions.Controls.Add(Me.lbTextToReplace)
        Me.gbConditions.Controls.Add(Me.tbFileHead)
        Me.gbConditions.Location = New System.Drawing.Point(12, 460)
        Me.gbConditions.Name = "gbConditions"
        Me.gbConditions.Size = New System.Drawing.Size(716, 158)
        Me.gbConditions.TabIndex = 229
        Me.gbConditions.TabStop = False
        Me.gbConditions.Text = "Conditions"
        '
        'lbFileExt
        '
        Me.lbFileExt.AutoSize = True
        Me.lbFileExt.Location = New System.Drawing.Point(19, 131)
        Me.lbFileExt.Name = "lbFileExt"
        Me.lbFileExt.Size = New System.Drawing.Size(92, 12)
        Me.lbFileExt.TabIndex = 233
        Me.lbFileExt.Text = "File extension :"
        '
        'tbExtToChange
        '
        Me.tbExtToChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbExtToChange.Location = New System.Drawing.Point(114, 126)
        Me.tbExtToChange.Name = "tbExtToChange"
        Me.tbExtToChange.Size = New System.Drawing.Size(75, 21)
        Me.tbExtToChange.TabIndex = 232
        Me.tbExtToChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbTail
        '
        Me.lbTail.AutoSize = True
        Me.lbTail.Location = New System.Drawing.Point(441, 106)
        Me.lbTail.Name = "lbTail"
        Me.lbTail.Size = New System.Drawing.Size(128, 12)
        Me.lbTail.TabIndex = 230
        Me.lbTail.Text = "Tail text of file name :"
        '
        'lbHead
        '
        Me.lbHead.AutoSize = True
        Me.lbHead.Location = New System.Drawing.Point(140, 106)
        Me.lbHead.Name = "lbHead"
        Me.lbHead.Size = New System.Drawing.Size(136, 12)
        Me.lbHead.TabIndex = 231
        Me.lbHead.Text = "Head text of file name :"
        '
        'lbSetTime
        '
        Me.lbSetTime.AutoSize = True
        Me.lbSetTime.Location = New System.Drawing.Point(18, 50)
        Me.lbSetTime.Name = "lbSetTime"
        Me.lbSetTime.Size = New System.Drawing.Size(159, 12)
        Me.lbSetTime.TabIndex = 212
        Me.lbSetTime.Text = "Set time condition to apply."
        '
        'lbTextToFind
        '
        Me.lbTextToFind.AutoSize = True
        Me.lbTextToFind.Location = New System.Drawing.Point(131, 79)
        Me.lbTextToFind.Name = "lbTextToFind"
        Me.lbTextToFind.Size = New System.Drawing.Size(146, 12)
        Me.lbTextToFind.TabIndex = 224
        Me.lbTextToFind.Text = "Text in file name to find :"
        '
        'lbTextToReplace
        '
        Me.lbTextToReplace.AutoSize = True
        Me.lbTextToReplace.Location = New System.Drawing.Point(471, 79)
        Me.lbTextToReplace.Name = "lbTextToReplace"
        Me.lbTextToReplace.Size = New System.Drawing.Size(98, 12)
        Me.lbTextToReplace.TabIndex = 221
        Me.lbTextToReplace.Text = "Text to repalce :"
        '
        'btClose
        '
        Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btClose.Location = New System.Drawing.Point(735, 621)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(127, 32)
        Me.btClose.TabIndex = 231
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btStartProcess
        '
        Me.btStartProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btStartProcess.Location = New System.Drawing.Point(735, 468)
        Me.btStartProcess.Name = "btStartProcess"
        Me.btStartProcess.Size = New System.Drawing.Size(127, 147)
        Me.btStartProcess.TabIndex = 230
        Me.btStartProcess.Text = "Start"
        Me.btStartProcess.UseVisualStyleBackColor = True
        '
        'btResultFPN
        '
        Me.btResultFPN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btResultFPN.Location = New System.Drawing.Point(13, 632)
        Me.btResultFPN.Name = "btResultFPN"
        Me.btResultFPN.Size = New System.Drawing.Size(97, 21)
        Me.btResultFPN.TabIndex = 235
        Me.btResultFPN.Text = "Result file"
        Me.btResultFPN.UseVisualStyleBackColor = True
        '
        'tbResultFPN
        '
        Me.tbResultFPN.Location = New System.Drawing.Point(116, 632)
        Me.tbResultFPN.Name = "tbResultFPN"
        Me.tbResultFPN.Size = New System.Drawing.Size(612, 21)
        Me.tbResultFPN.TabIndex = 234
        '
        'fFileName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 669)
        Me.Controls.Add(Me.btResultFPN)
        Me.Controls.Add(Me.tbResultFPN)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btStartProcess)
        Me.Controls.Add(Me.gbConditions)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(890, 671)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents lstRFfiles As ListBox
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
End Class
