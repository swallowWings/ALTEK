<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fAppendFiles
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvFileList = New System.Windows.Forms.DataGridView()
        Me.btRemoveAll = New System.Windows.Forms.Button()
        Me.btRemoveSelected = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbAppendAfileToAll = New System.Windows.Forms.RadioButton()
        Me.rbAppendAll = New System.Windows.Forms.RadioButton()
        Me.gbConditions = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbSepTab = New System.Windows.Forms.RadioButton()
        Me.rbSepText = New System.Windows.Forms.RadioButton()
        Me.tbSepText = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbPosHead = New System.Windows.Forms.RadioButton()
        Me.rbPosTail = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbColMode = New System.Windows.Forms.RadioButton()
        Me.rbRowMode = New System.Windows.Forms.RadioButton()
        Me.tbFileToAppend = New System.Windows.Forms.TextBox()
        Me.btSelectAfileToAppend = New System.Windows.Forms.Button()
        Me.lbTail = New System.Windows.Forms.Label()
        Me.lbHead = New System.Windows.Forms.Label()
        Me.tbFileTail = New System.Windows.Forms.TextBox()
        Me.tbFileHead = New System.Windows.Forms.TextBox()
        Me.btResultFPN = New System.Windows.Forms.Button()
        Me.tbResultFPN = New System.Windows.Forms.TextBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btStartProcess = New System.Windows.Forms.Button()
        Me.gbResult = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbConditions.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbResult.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox2.Location = New System.Drawing.Point(16, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 315)
        Me.GroupBox2.TabIndex = 211
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
        Me.lstFiles.Size = New System.Drawing.Size(410, 196)
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
        Me.btAddAllFiles.Location = New System.Drawing.Point(127, 279)
        Me.btAddAllFiles.Name = "btAddAllFiles"
        Me.btAddAllFiles.Size = New System.Drawing.Size(148, 25)
        Me.btAddAllFiles.TabIndex = 13
        Me.btAddAllFiles.Text = "Add all"
        Me.btAddAllFiles.UseVisualStyleBackColor = True
        '
        'btAddSelectedFile
        '
        Me.btAddSelectedFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddSelectedFile.Location = New System.Drawing.Point(281, 279)
        Me.btAddSelectedFile.Name = "btAddSelectedFile"
        Me.btAddSelectedFile.Size = New System.Drawing.Size(139, 25)
        Me.btAddSelectedFile.TabIndex = 14
        Me.btAddSelectedFile.Text = "Add selected"
        Me.btAddSelectedFile.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvFileList)
        Me.GroupBox4.Controls.Add(Me.btRemoveAll)
        Me.GroupBox4.Controls.Add(Me.btRemoveSelected)
        Me.GroupBox4.Location = New System.Drawing.Point(452, 95)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(411, 315)
        Me.GroupBox4.TabIndex = 212
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Selected source files"
        '
        'dgvFileList
        '
        Me.dgvFileList.AllowUserToAddRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFileList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFileList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvFileList.Location = New System.Drawing.Point(10, 22)
        Me.dgvFileList.Name = "dgvFileList"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFileList.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvFileList.RowHeadersVisible = False
        Me.dgvFileList.RowTemplate.Height = 23
        Me.dgvFileList.Size = New System.Drawing.Size(392, 249)
        Me.dgvFileList.TabIndex = 16
        '
        'btRemoveAll
        '
        Me.btRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveAll.Location = New System.Drawing.Point(112, 279)
        Me.btRemoveAll.Name = "btRemoveAll"
        Me.btRemoveAll.Size = New System.Drawing.Size(142, 25)
        Me.btRemoveAll.TabIndex = 17
        Me.btRemoveAll.Text = "Remove all"
        Me.btRemoveAll.UseVisualStyleBackColor = True
        '
        'btRemoveSelected
        '
        Me.btRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveSelected.Location = New System.Drawing.Point(260, 279)
        Me.btRemoveSelected.Name = "btRemoveSelected"
        Me.btRemoveSelected.Size = New System.Drawing.Size(142, 25)
        Me.btRemoveSelected.TabIndex = 18
        Me.btRemoveSelected.Text = "Remove selected"
        Me.btRemoveSelected.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbAppendAfileToAll)
        Me.GroupBox1.Controls.Add(Me.rbAppendAll)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 70)
        Me.GroupBox1.TabIndex = 229
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select processing"
        '
        'rbAppendAfileToAll
        '
        Me.rbAppendAfileToAll.AutoSize = True
        Me.rbAppendAfileToAll.Location = New System.Drawing.Point(15, 42)
        Me.rbAppendAfileToAll.Name = "rbAppendAfileToAll"
        Me.rbAppendAfileToAll.Size = New System.Drawing.Size(477, 16)
        Me.rbAppendAfileToAll.TabIndex = 213
        Me.rbAppendAfileToAll.Text = "Append a file to all selected files (Row lengths depend on selected source files)" &
    ""
        Me.rbAppendAfileToAll.UseVisualStyleBackColor = True
        '
        'rbAppendAll
        '
        Me.rbAppendAll.AutoSize = True
        Me.rbAppendAll.Checked = True
        Me.rbAppendAll.Location = New System.Drawing.Point(15, 20)
        Me.rbAppendAll.Name = "rbAppendAll"
        Me.rbAppendAll.Size = New System.Drawing.Size(803, 16)
        Me.rbAppendAll.TabIndex = 208
        Me.rbAppendAll.TabStop = True
        Me.rbAppendAll.Text = "Append all selected files and save it as a file (The files will be appened in ord" &
    "er of selected source files. Row length depends on first file)"
        Me.rbAppendAll.UseVisualStyleBackColor = True
        '
        'gbConditions
        '
        Me.gbConditions.Controls.Add(Me.GroupBox6)
        Me.gbConditions.Controls.Add(Me.GroupBox5)
        Me.gbConditions.Controls.Add(Me.GroupBox3)
        Me.gbConditions.Controls.Add(Me.tbFileToAppend)
        Me.gbConditions.Controls.Add(Me.btSelectAfileToAppend)
        Me.gbConditions.Location = New System.Drawing.Point(16, 420)
        Me.gbConditions.Name = "gbConditions"
        Me.gbConditions.Size = New System.Drawing.Size(757, 148)
        Me.gbConditions.TabIndex = 230
        Me.gbConditions.TabStop = False
        Me.gbConditions.Text = "Conditions"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbSepTab)
        Me.GroupBox6.Controls.Add(Me.rbSepText)
        Me.GroupBox6.Controls.Add(Me.tbSepText)
        Me.GroupBox6.Location = New System.Drawing.Point(303, 56)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(445, 88)
        Me.GroupBox6.TabIndex = 240
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Separator"
        '
        'rbSepTab
        '
        Me.rbSepTab.AutoSize = True
        Me.rbSepTab.Location = New System.Drawing.Point(10, 65)
        Me.rbSepTab.Name = "rbSepTab"
        Me.rbSepTab.Size = New System.Drawing.Size(45, 16)
        Me.rbSepTab.TabIndex = 234
        Me.rbSepTab.Text = "Tab"
        Me.rbSepTab.UseVisualStyleBackColor = True
        '
        'rbSepText
        '
        Me.rbSepText.AutoSize = True
        Me.rbSepText.Checked = True
        Me.rbSepText.Location = New System.Drawing.Point(10, 19)
        Me.rbSepText.Name = "rbSepText"
        Me.rbSepText.Size = New System.Drawing.Size(431, 16)
        Me.rbSepText.TabIndex = 235
        Me.rbSepText.TabStop = True
        Me.rbSepText.Text = "Text (If no text separator is set, the text in text file will not be separated)"
        Me.rbSepText.UseVisualStyleBackColor = True
        '
        'tbSepText
        '
        Me.tbSepText.Location = New System.Drawing.Point(10, 38)
        Me.tbSepText.Name = "tbSepText"
        Me.tbSepText.Size = New System.Drawing.Size(424, 21)
        Me.tbSepText.TabIndex = 238
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbPosHead)
        Me.GroupBox5.Controls.Add(Me.rbPosTail)
        Me.GroupBox5.Location = New System.Drawing.Point(167, 56)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(131, 88)
        Me.GroupBox5.TabIndex = 236
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Appending position"
        '
        'rbPosHead
        '
        Me.rbPosHead.AutoSize = True
        Me.rbPosHead.Checked = True
        Me.rbPosHead.Location = New System.Drawing.Point(18, 28)
        Me.rbPosHead.Name = "rbPosHead"
        Me.rbPosHead.Size = New System.Drawing.Size(52, 16)
        Me.rbPosHead.TabIndex = 234
        Me.rbPosHead.TabStop = True
        Me.rbPosHead.Text = "Head"
        Me.rbPosHead.UseVisualStyleBackColor = True
        '
        'rbPosTail
        '
        Me.rbPosTail.AutoSize = True
        Me.rbPosTail.Location = New System.Drawing.Point(18, 58)
        Me.rbPosTail.Name = "rbPosTail"
        Me.rbPosTail.Size = New System.Drawing.Size(44, 16)
        Me.rbPosTail.TabIndex = 235
        Me.rbPosTail.Text = "Tail"
        Me.rbPosTail.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbColMode)
        Me.GroupBox3.Controls.Add(Me.rbRowMode)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 88)
        Me.GroupBox3.TabIndex = 239
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Appending direction"
        '
        'rbColMode
        '
        Me.rbColMode.AutoSize = True
        Me.rbColMode.Location = New System.Drawing.Point(20, 58)
        Me.rbColMode.Name = "rbColMode"
        Me.rbColMode.Size = New System.Drawing.Size(103, 16)
        Me.rbColMode.TabIndex = 235
        Me.rbColMode.Text = "Column mode"
        Me.rbColMode.UseVisualStyleBackColor = True
        '
        'rbRowMode
        '
        Me.rbRowMode.AutoSize = True
        Me.rbRowMode.Checked = True
        Me.rbRowMode.Location = New System.Drawing.Point(20, 28)
        Me.rbRowMode.Name = "rbRowMode"
        Me.rbRowMode.Size = New System.Drawing.Size(84, 16)
        Me.rbRowMode.TabIndex = 234
        Me.rbRowMode.TabStop = True
        Me.rbRowMode.Text = "Row mode"
        Me.rbRowMode.UseVisualStyleBackColor = True
        '
        'tbFileToAppend
        '
        Me.tbFileToAppend.Location = New System.Drawing.Point(181, 20)
        Me.tbFileToAppend.Name = "tbFileToAppend"
        Me.tbFileToAppend.Size = New System.Drawing.Size(567, 21)
        Me.tbFileToAppend.TabIndex = 237
        '
        'btSelectAfileToAppend
        '
        Me.btSelectAfileToAppend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSelectAfileToAppend.Location = New System.Drawing.Point(13, 20)
        Me.btSelectAfileToAppend.Name = "btSelectAfileToAppend"
        Me.btSelectAfileToAppend.Size = New System.Drawing.Size(161, 21)
        Me.btSelectAfileToAppend.TabIndex = 236
        Me.btSelectAfileToAppend.Text = "Select a file to append"
        Me.btSelectAfileToAppend.UseVisualStyleBackColor = True
        '
        'lbTail
        '
        Me.lbTail.AutoSize = True
        Me.lbTail.Location = New System.Drawing.Point(479, 20)
        Me.lbTail.Name = "lbTail"
        Me.lbTail.Size = New System.Drawing.Size(128, 12)
        Me.lbTail.TabIndex = 230
        Me.lbTail.Text = "Tail text of file name :"
        '
        'lbHead
        '
        Me.lbHead.AutoSize = True
        Me.lbHead.Location = New System.Drawing.Point(178, 20)
        Me.lbHead.Name = "lbHead"
        Me.lbHead.Size = New System.Drawing.Size(136, 12)
        Me.lbHead.TabIndex = 231
        Me.lbHead.Text = "Head text of file name :"
        '
        'tbFileTail
        '
        Me.tbFileTail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFileTail.Location = New System.Drawing.Point(609, 15)
        Me.tbFileTail.Multiline = True
        Me.tbFileTail.Name = "tbFileTail"
        Me.tbFileTail.Size = New System.Drawing.Size(139, 21)
        Me.tbFileTail.TabIndex = 216
        '
        'tbFileHead
        '
        Me.tbFileHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFileHead.Location = New System.Drawing.Point(317, 15)
        Me.tbFileHead.Multiline = True
        Me.tbFileHead.Name = "tbFileHead"
        Me.tbFileHead.Size = New System.Drawing.Size(145, 21)
        Me.tbFileHead.TabIndex = 215
        '
        'btResultFPN
        '
        Me.btResultFPN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btResultFPN.Location = New System.Drawing.Point(10, 45)
        Me.btResultFPN.Name = "btResultFPN"
        Me.btResultFPN.Size = New System.Drawing.Size(135, 21)
        Me.btResultFPN.TabIndex = 237
        Me.btResultFPN.Text = "Result file"
        Me.btResultFPN.UseVisualStyleBackColor = True
        '
        'tbResultFPN
        '
        Me.tbResultFPN.Location = New System.Drawing.Point(151, 45)
        Me.tbResultFPN.Name = "tbResultFPN"
        Me.tbResultFPN.Size = New System.Drawing.Size(597, 21)
        Me.tbResultFPN.TabIndex = 236
        '
        'btClose
        '
        Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btClose.Location = New System.Drawing.Point(779, 621)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(86, 40)
        Me.btClose.TabIndex = 239
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btStartProcess
        '
        Me.btStartProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btStartProcess.Location = New System.Drawing.Point(779, 430)
        Me.btStartProcess.Name = "btStartProcess"
        Me.btStartProcess.Size = New System.Drawing.Size(86, 185)
        Me.btStartProcess.TabIndex = 238
        Me.btStartProcess.Text = "Start"
        Me.btStartProcess.UseVisualStyleBackColor = True
        '
        'gbResult
        '
        Me.gbResult.Controls.Add(Me.btResultFPN)
        Me.gbResult.Controls.Add(Me.tbResultFPN)
        Me.gbResult.Controls.Add(Me.lbTail)
        Me.gbResult.Controls.Add(Me.tbFileHead)
        Me.gbResult.Controls.Add(Me.tbFileTail)
        Me.gbResult.Controls.Add(Me.lbHead)
        Me.gbResult.Location = New System.Drawing.Point(16, 583)
        Me.gbResult.Name = "gbResult"
        Me.gbResult.Size = New System.Drawing.Size(757, 78)
        Me.gbResult.TabIndex = 240
        Me.gbResult.TabStop = False
        Me.gbResult.Text = "Result file"
        '
        'fAppendFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 671)
        Me.Controls.Add(Me.gbResult)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btStartProcess)
        Me.Controls.Add(Me.gbConditions)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.MaximumSize = New System.Drawing.Size(893, 710)
        Me.MinimumSize = New System.Drawing.Size(893, 710)
        Me.Name = "fAppendFiles"
        Me.Text = "Append files"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbConditions.ResumeLayout(False)
        Me.gbConditions.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbResult.ResumeLayout(False)
        Me.gbResult.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbFileNameFilter As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbExtensionFilter As TextBox
    Friend WithEvents lstFiles As ListBox
    Friend WithEvents txtFolderPathSource As TextBox
    Friend WithEvents btOpenRfFolder As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents btAddAllFiles As Button
    Friend WithEvents btAddSelectedFile As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvFileList As DataGridView
    Friend WithEvents btRemoveAll As Button
    Friend WithEvents btRemoveSelected As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbAppendAfileToAll As RadioButton
    Friend WithEvents rbAppendAll As RadioButton
    Friend WithEvents gbConditions As GroupBox
    Friend WithEvents lbTail As Label
    Friend WithEvents lbHead As Label
    Friend WithEvents tbFileTail As TextBox
    Friend WithEvents tbFileHead As TextBox
    Friend WithEvents btResultFPN As Button
    Friend WithEvents tbResultFPN As TextBox
    Friend WithEvents rbColMode As RadioButton
    Friend WithEvents rbRowMode As RadioButton
    Friend WithEvents btClose As Button
    Friend WithEvents btStartProcess As Button
    Friend WithEvents btSelectAfileToAppend As Button
    Friend WithEvents tbFileToAppend As TextBox
    Friend WithEvents tbSepText As TextBox
    Friend WithEvents rbSepTab As RadioButton
    Friend WithEvents rbPosHead As RadioButton
    Friend WithEvents rbPosTail As RadioButton
    Friend WithEvents rbSepText As RadioButton
    Friend WithEvents gbResult As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
