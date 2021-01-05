<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fFileEdit
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvRainfallFileList = New System.Windows.Forms.DataGridView()
        Me.btRemoveAll = New System.Windows.Forms.Button()
        Me.btRemoveSelected = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbCutDecimal = New System.Windows.Forms.RadioButton()
        Me.rbReplaceTextInASCII = New System.Windows.Forms.RadioButton()
        Me.rbReplaceLineByLine = New System.Windows.Forms.RadioButton()
        Me.rbInsertALine = New System.Windows.Forms.RadioButton()
        Me.rbRemoveLines = New System.Windows.Forms.RadioButton()
        Me.rbReplaceText = New System.Windows.Forms.RadioButton()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btStartProcess = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDestinationFolderPath = New System.Windows.Forms.TextBox()
        Me.txtResultFileTag = New System.Windows.Forms.TextBox()
        Me.txtResultFilePrefix = New System.Windows.Forms.TextBox()
        Me.btOpenDestinationFolder = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbFileNameFilter = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbExtensionFilter = New System.Windows.Forms.TextBox()
        Me.lstFiles = New System.Windows.Forms.ListBox()
        Me.txtFolderPathSource = New System.Windows.Forms.TextBox()
        Me.btOpenFolder = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btAddAllFiles = New System.Windows.Forms.Button()
        Me.btAddSelectedFile = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tbDecimalPartN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTextToReplace = New System.Windows.Forms.TextBox()
        Me.tbTextToFind = New System.Windows.Forms.TextBox()
        Me.lbTextToReplace = New System.Windows.Forms.Label()
        Me.lbTextToFind = New System.Windows.Forms.Label()
        Me.gbLineConditions = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbEndingLineidx = New System.Windows.Forms.TextBox()
        Me.tbStartingLineidx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbASCIIRangeConditions = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbAscLRyRow = New System.Windows.Forms.TextBox()
        Me.tbAscLRxCol = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbAscTLyRow = New System.Windows.Forms.TextBox()
        Me.tbAscTLxCol = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvRainfallFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gbLineConditions.SuspendLayout()
        Me.gbASCIIRangeConditions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvRainfallFileList)
        Me.GroupBox4.Controls.Add(Me.btRemoveAll)
        Me.GroupBox4.Controls.Add(Me.btRemoveSelected)
        Me.GroupBox4.Location = New System.Drawing.Point(514, 125)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(470, 349)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Selected source files"
        '
        'dgvRainfallFileList
        '
        Me.dgvRainfallFileList.AllowUserToAddRows = False
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
        Me.dgvRainfallFileList.Location = New System.Drawing.Point(10, 28)
        Me.dgvRainfallFileList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.dgvRainfallFileList.Size = New System.Drawing.Size(448, 262)
        Me.dgvRainfallFileList.TabIndex = 16
        '
        'btRemoveAll
        '
        Me.btRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveAll.Location = New System.Drawing.Point(127, 305)
        Me.btRemoveAll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btRemoveAll.Name = "btRemoveAll"
        Me.btRemoveAll.Size = New System.Drawing.Size(162, 31)
        Me.btRemoveAll.TabIndex = 17
        Me.btRemoveAll.Text = "Remove all"
        Me.btRemoveAll.UseVisualStyleBackColor = True
        '
        'btRemoveSelected
        '
        Me.btRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveSelected.Location = New System.Drawing.Point(296, 305)
        Me.btRemoveSelected.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btRemoveSelected.Name = "btRemoveSelected"
        Me.btRemoveSelected.Size = New System.Drawing.Size(162, 31)
        Me.btRemoveSelected.TabIndex = 18
        Me.btRemoveSelected.Text = "Remove selected"
        Me.btRemoveSelected.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbCutDecimal)
        Me.GroupBox3.Controls.Add(Me.rbReplaceTextInASCII)
        Me.GroupBox3.Controls.Add(Me.rbReplaceLineByLine)
        Me.GroupBox3.Controls.Add(Me.rbInsertALine)
        Me.GroupBox3.Controls.Add(Me.rbRemoveLines)
        Me.GroupBox3.Controls.Add(Me.rbReplaceText)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 14)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(968, 99)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select processing"
        '
        'rbCutDecimal
        '
        Me.rbCutDecimal.AutoSize = True
        Me.rbCutDecimal.Location = New System.Drawing.Point(381, 60)
        Me.rbCutDecimal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbCutDecimal.Name = "rbCutDecimal"
        Me.rbCutDecimal.Size = New System.Drawing.Size(261, 19)
        Me.rbCutDecimal.TabIndex = 10
        Me.rbCutDecimal.Text = "Cut decimal parts in ASCII raster file"
        Me.rbCutDecimal.UseVisualStyleBackColor = True
        '
        'rbReplaceTextInASCII
        '
        Me.rbReplaceTextInASCII.AutoSize = True
        Me.rbReplaceTextInASCII.Location = New System.Drawing.Point(38, 60)
        Me.rbReplaceTextInASCII.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbReplaceTextInASCII.Name = "rbReplaceTextInASCII"
        Me.rbReplaceTextInASCII.Size = New System.Drawing.Size(333, 19)
        Me.rbReplaceTextInASCII.TabIndex = 9
        Me.rbReplaceTextInASCII.Text = "Relpace values in a region of ASCII raster files"
        Me.rbReplaceTextInASCII.UseVisualStyleBackColor = True
        '
        'rbReplaceLineByLine
        '
        Me.rbReplaceLineByLine.AutoSize = True
        Me.rbReplaceLineByLine.Location = New System.Drawing.Point(287, 25)
        Me.rbReplaceLineByLine.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbReplaceLineByLine.Name = "rbReplaceLineByLine"
        Me.rbReplaceLineByLine.Size = New System.Drawing.Size(230, 19)
        Me.rbReplaceLineByLine.TabIndex = 8
        Me.rbReplaceLineByLine.Text = "Search and replace line by line"
        Me.rbReplaceLineByLine.UseVisualStyleBackColor = True
        '
        'rbInsertALine
        '
        Me.rbInsertALine.AutoSize = True
        Me.rbInsertALine.Location = New System.Drawing.Point(584, 25)
        Me.rbInsertALine.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbInsertALine.Name = "rbInsertALine"
        Me.rbInsertALine.Size = New System.Drawing.Size(103, 19)
        Me.rbInsertALine.TabIndex = 7
        Me.rbInsertALine.Text = "Insert a line"
        Me.rbInsertALine.UseVisualStyleBackColor = True
        '
        'rbRemoveLines
        '
        Me.rbRemoveLines.AutoSize = True
        Me.rbRemoveLines.Location = New System.Drawing.Point(783, 25)
        Me.rbRemoveLines.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbRemoveLines.Name = "rbRemoveLines"
        Me.rbRemoveLines.Size = New System.Drawing.Size(117, 19)
        Me.rbRemoveLines.TabIndex = 7
        Me.rbRemoveLines.Text = "Remove lines"
        Me.rbRemoveLines.UseVisualStyleBackColor = True
        '
        'rbReplaceText
        '
        Me.rbReplaceText.AutoSize = True
        Me.rbReplaceText.Checked = True
        Me.rbReplaceText.Location = New System.Drawing.Point(38, 25)
        Me.rbReplaceText.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbReplaceText.Name = "rbReplaceText"
        Me.rbReplaceText.Size = New System.Drawing.Size(188, 19)
        Me.rbReplaceText.TabIndex = 6
        Me.rbReplaceText.TabStop = True
        Me.rbReplaceText.Text = "Relpace text in text files"
        Me.rbReplaceText.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btClose.Location = New System.Drawing.Point(810, 818)
        Me.btClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(174, 35)
        Me.btClose.TabIndex = 33
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btStartProcess
        '
        Me.btStartProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btStartProcess.Location = New System.Drawing.Point(810, 758)
        Me.btStartProcess.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btStartProcess.Name = "btStartProcess"
        Me.btStartProcess.Size = New System.Drawing.Size(174, 54)
        Me.btStartProcess.TabIndex = 32
        Me.btStartProcess.Text = "Start"
        Me.btStartProcess.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDestinationFolderPath)
        Me.GroupBox1.Controls.Add(Me.txtResultFileTag)
        Me.GroupBox1.Controls.Add(Me.txtResultFilePrefix)
        Me.GroupBox1.Controls.Add(Me.btOpenDestinationFolder)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 749)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(790, 105)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result files"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(457, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 15)
        Me.Label5.TabIndex = 228
        Me.Label5.Text = "Tail text of file name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 15)
        Me.Label4.TabIndex = 229
        Me.Label4.Text = "Head text of file name :"
        '
        'txtDestinationFolderPath
        '
        Me.txtDestinationFolderPath.BackColor = System.Drawing.SystemColors.Window
        Me.txtDestinationFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestinationFolderPath.Location = New System.Drawing.Point(167, 62)
        Me.txtDestinationFolderPath.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDestinationFolderPath.Name = "txtDestinationFolderPath"
        Me.txtDestinationFolderPath.Size = New System.Drawing.Size(616, 25)
        Me.txtDestinationFolderPath.TabIndex = 30
        '
        'txtResultFileTag
        '
        Me.txtResultFileTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultFileTag.Location = New System.Drawing.Point(608, 25)
        Me.txtResultFileTag.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtResultFileTag.Multiline = True
        Me.txtResultFileTag.Name = "txtResultFileTag"
        Me.txtResultFileTag.Size = New System.Drawing.Size(173, 26)
        Me.txtResultFileTag.TabIndex = 26
        '
        'txtResultFilePrefix
        '
        Me.txtResultFilePrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultFilePrefix.Location = New System.Drawing.Point(265, 25)
        Me.txtResultFilePrefix.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtResultFilePrefix.Multiline = True
        Me.txtResultFilePrefix.Name = "txtResultFilePrefix"
        Me.txtResultFilePrefix.Size = New System.Drawing.Size(180, 26)
        Me.txtResultFilePrefix.TabIndex = 25
        '
        'btOpenDestinationFolder
        '
        Me.btOpenDestinationFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btOpenDestinationFolder.Location = New System.Drawing.Point(21, 61)
        Me.btOpenDestinationFolder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btOpenDestinationFolder.Name = "btOpenDestinationFolder"
        Me.btOpenDestinationFolder.Size = New System.Drawing.Size(139, 26)
        Me.btOpenDestinationFolder.TabIndex = 29
        Me.btOpenDestinationFolder.Text = "Destination folder"
        Me.btOpenDestinationFolder.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbFileNameFilter)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.tbExtensionFilter)
        Me.GroupBox2.Controls.Add(Me.lstFiles)
        Me.GroupBox2.Controls.Add(Me.txtFolderPathSource)
        Me.GroupBox2.Controls.Add(Me.btOpenFolder)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.btAddAllFiles)
        Me.GroupBox2.Controls.Add(Me.btAddSelectedFile)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(16, 125)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(491, 349)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search source files"
        '
        'tbFileNameFilter
        '
        Me.tbFileNameFilter.Location = New System.Drawing.Point(225, 60)
        Me.tbFileNameFilter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbFileNameFilter.Name = "tbFileNameFilter"
        Me.tbFileNameFilter.Size = New System.Drawing.Size(83, 25)
        Me.tbFileNameFilter.TabIndex = 204
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(112, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 15)
        Me.Label11.TabIndex = 205
        Me.Label11.Text = "File name filter :"
        '
        'tbExtensionFilter
        '
        Me.tbExtensionFilter.Location = New System.Drawing.Point(432, 60)
        Me.tbExtensionFilter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbExtensionFilter.Name = "tbExtensionFilter"
        Me.tbExtensionFilter.Size = New System.Drawing.Size(47, 25)
        Me.tbExtensionFilter.TabIndex = 40
        '
        'lstFiles
        '
        Me.lstFiles.FormattingEnabled = True
        Me.lstFiles.HorizontalScrollbar = True
        Me.lstFiles.ItemHeight = 15
        Me.lstFiles.Location = New System.Drawing.Point(11, 94)
        Me.lstFiles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstFiles.Size = New System.Drawing.Size(468, 184)
        Me.lstFiles.TabIndex = 39
        '
        'txtFolderPathSource
        '
        Me.txtFolderPathSource.BackColor = System.Drawing.SystemColors.Window
        Me.txtFolderPathSource.Location = New System.Drawing.Point(115, 29)
        Me.txtFolderPathSource.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFolderPathSource.Name = "txtFolderPathSource"
        Me.txtFolderPathSource.Size = New System.Drawing.Size(364, 25)
        Me.txtFolderPathSource.TabIndex = 1
        '
        'btOpenFolder
        '
        Me.btOpenFolder.Location = New System.Drawing.Point(11, 29)
        Me.btOpenFolder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btOpenFolder.Name = "btOpenFolder"
        Me.btOpenFolder.Size = New System.Drawing.Size(97, 26)
        Me.btOpenFolder.TabIndex = 37
        Me.btOpenFolder.Text = "Select folder"
        Me.btOpenFolder.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(315, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 15)
        Me.Label14.TabIndex = 203
        Me.Label14.Text = "Extenstion filter :"
        '
        'btAddAllFiles
        '
        Me.btAddAllFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddAllFiles.Location = New System.Drawing.Point(145, 305)
        Me.btAddAllFiles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btAddAllFiles.Name = "btAddAllFiles"
        Me.btAddAllFiles.Size = New System.Drawing.Size(169, 31)
        Me.btAddAllFiles.TabIndex = 13
        Me.btAddAllFiles.Text = "Add all"
        Me.btAddAllFiles.UseVisualStyleBackColor = True
        '
        'btAddSelectedFile
        '
        Me.btAddSelectedFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddSelectedFile.Location = New System.Drawing.Point(321, 305)
        Me.btAddSelectedFile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btAddSelectedFile.Name = "btAddSelectedFile"
        Me.btAddSelectedFile.Size = New System.Drawing.Size(159, 31)
        Me.btAddSelectedFile.TabIndex = 14
        Me.btAddSelectedFile.Text = "Add selected"
        Me.btAddSelectedFile.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.tbDecimalPartN)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.tbTextToReplace)
        Me.GroupBox5.Controls.Add(Me.tbTextToFind)
        Me.GroupBox5.Controls.Add(Me.lbTextToReplace)
        Me.GroupBox5.Controls.Add(Me.lbTextToFind)
        Me.GroupBox5.Location = New System.Drawing.Point(14, 619)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(970, 122)
        Me.GroupBox5.TabIndex = 209
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Contents"
        '
        'tbDecimalPartN
        '
        Me.tbDecimalPartN.Location = New System.Drawing.Point(912, 32)
        Me.tbDecimalPartN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbDecimalPartN.Name = "tbDecimalPartN"
        Me.tbDecimalPartN.Size = New System.Drawing.Size(45, 25)
        Me.tbDecimalPartN.TabIndex = 207
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(769, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 15)
        Me.Label3.TabIndex = 208
        Me.Label3.Text = "Decimal part length :"
        '
        'tbTextToReplace
        '
        Me.tbTextToReplace.Location = New System.Drawing.Point(133, 74)
        Me.tbTextToReplace.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbTextToReplace.Multiline = True
        Me.tbTextToReplace.Name = "tbTextToReplace"
        Me.tbTextToReplace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbTextToReplace.Size = New System.Drawing.Size(616, 37)
        Me.tbTextToReplace.TabIndex = 204
        '
        'tbTextToFind
        '
        Me.tbTextToFind.Location = New System.Drawing.Point(133, 29)
        Me.tbTextToFind.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbTextToFind.Multiline = True
        Me.tbTextToFind.Name = "tbTextToFind"
        Me.tbTextToFind.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbTextToFind.Size = New System.Drawing.Size(616, 37)
        Me.tbTextToFind.TabIndex = 203
        '
        'lbTextToReplace
        '
        Me.lbTextToReplace.AutoSize = True
        Me.lbTextToReplace.Location = New System.Drawing.Point(14, 76)
        Me.lbTextToReplace.Name = "lbTextToReplace"
        Me.lbTextToReplace.Size = New System.Drawing.Size(116, 15)
        Me.lbTextToReplace.TabIndex = 205
        Me.lbTextToReplace.Text = "Text to repalce :"
        '
        'lbTextToFind
        '
        Me.lbTextToFind.AutoSize = True
        Me.lbTextToFind.Location = New System.Drawing.Point(38, 31)
        Me.lbTextToFind.Name = "lbTextToFind"
        Me.lbTextToFind.Size = New System.Drawing.Size(92, 15)
        Me.lbTextToFind.TabIndex = 206
        Me.lbTextToFind.Text = "Text to find :"
        '
        'gbLineConditions
        '
        Me.gbLineConditions.Controls.Add(Me.Label9)
        Me.gbLineConditions.Controls.Add(Me.Label7)
        Me.gbLineConditions.Controls.Add(Me.tbEndingLineidx)
        Me.gbLineConditions.Controls.Add(Me.tbStartingLineidx)
        Me.gbLineConditions.Controls.Add(Me.Label6)
        Me.gbLineConditions.Controls.Add(Me.Label1)
        Me.gbLineConditions.Location = New System.Drawing.Point(14, 487)
        Me.gbLineConditions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbLineConditions.Name = "gbLineConditions"
        Me.gbLineConditions.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbLineConditions.Size = New System.Drawing.Size(494, 124)
        Me.gbLineConditions.TabIndex = 210
        Me.gbLineConditions.TabStop = False
        Me.gbLineConditions.Text = "Line conditions"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(361, 15)
        Me.Label9.TabIndex = 214
        Me.Label9.Text = "Defined line indices are included in the sanning range."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(262, 15)
        Me.Label7.TabIndex = 215
        Me.Label7.Text = "If not defined, all lines will be scanned."
        '
        'tbEndingLineidx
        '
        Me.tbEndingLineidx.Location = New System.Drawing.Point(432, 84)
        Me.tbEndingLineidx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbEndingLineidx.Name = "tbEndingLineidx"
        Me.tbEndingLineidx.Size = New System.Drawing.Size(47, 25)
        Me.tbEndingLineidx.TabIndex = 212
        '
        'tbStartingLineidx
        '
        Me.tbStartingLineidx.Location = New System.Drawing.Point(232, 84)
        Me.tbStartingLineidx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbStartingLineidx.Name = "tbStartingLineidx"
        Me.tbStartingLineidx.Size = New System.Drawing.Size(47, 25)
        Me.tbStartingLineidx.TabIndex = 211
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(301, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 15)
        Me.Label6.TabIndex = 209
        Me.Label6.Text = "Ending line index :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 15)
        Me.Label1.TabIndex = 210
        Me.Label1.Text = "Starting line index(from 0) :"
        '
        'gbASCIIRangeConditions
        '
        Me.gbASCIIRangeConditions.Controls.Add(Me.Label12)
        Me.gbASCIIRangeConditions.Controls.Add(Me.tbAscLRyRow)
        Me.gbASCIIRangeConditions.Controls.Add(Me.tbAscLRxCol)
        Me.gbASCIIRangeConditions.Controls.Add(Me.Label8)
        Me.gbASCIIRangeConditions.Controls.Add(Me.tbAscTLyRow)
        Me.gbASCIIRangeConditions.Controls.Add(Me.tbAscTLxCol)
        Me.gbASCIIRangeConditions.Controls.Add(Me.Label10)
        Me.gbASCIIRangeConditions.Location = New System.Drawing.Point(514, 487)
        Me.gbASCIIRangeConditions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbASCIIRangeConditions.Name = "gbASCIIRangeConditions"
        Me.gbASCIIRangeConditions.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbASCIIRangeConditions.Size = New System.Drawing.Size(470, 124)
        Me.gbASCIIRangeConditions.TabIndex = 211
        Me.gbASCIIRangeConditions.TabStop = False
        Me.gbASCIIRangeConditions.Text = "ASCII raster range conditions"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(348, 15)
        Me.Label12.TabIndex = 217
        Me.Label12.Text = "Defined positions are included in the sanning range."
        '
        'tbAscLRyRow
        '
        Me.tbAscLRyRow.Location = New System.Drawing.Point(394, 85)
        Me.tbAscLRyRow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbAscLRyRow.Name = "tbAscLRyRow"
        Me.tbAscLRyRow.Size = New System.Drawing.Size(63, 25)
        Me.tbAscLRyRow.TabIndex = 216
        '
        'tbAscLRxCol
        '
        Me.tbAscLRxCol.Location = New System.Drawing.Point(323, 85)
        Me.tbAscLRxCol.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbAscLRxCol.Name = "tbAscLRxCol"
        Me.tbAscLRxCol.Size = New System.Drawing.Size(63, 25)
        Me.tbAscLRxCol.TabIndex = 215
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(83, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(235, 15)
        Me.Label8.TabIndex = 214
        Me.Label8.Text = "Low right position [xCol, yRow] : "
        '
        'tbAscTLyRow
        '
        Me.tbAscTLyRow.Location = New System.Drawing.Point(394, 51)
        Me.tbAscTLyRow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbAscTLyRow.Name = "tbAscTLyRow"
        Me.tbAscTLyRow.Size = New System.Drawing.Size(63, 25)
        Me.tbAscTLyRow.TabIndex = 213
        '
        'tbAscTLxCol
        '
        Me.tbAscTLxCol.Location = New System.Drawing.Point(323, 51)
        Me.tbAscTLxCol.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbAscTLxCol.Name = "tbAscTLxCol"
        Me.tbAscTLxCol.Size = New System.Drawing.Size(63, 25)
        Me.tbAscTLxCol.TabIndex = 211
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(310, 15)
        Me.Label10.TabIndex = 210
        Me.Label10.Text = "Top left position [xCol, yRow](from [0, 0]) : "
        '
        'fFileEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 863)
        Me.Controls.Add(Me.gbASCIIRangeConditions)
        Me.Controls.Add(Me.gbLineConditions)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btStartProcess)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1015, 910)
        Me.MinimumSize = New System.Drawing.Size(1015, 910)
        Me.Name = "fFileEdit"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Edit text files"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvRainfallFileList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.gbLineConditions.ResumeLayout(False)
        Me.gbLineConditions.PerformLayout()
        Me.gbASCIIRangeConditions.ResumeLayout(False)
        Me.gbASCIIRangeConditions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvRainfallFileList As DataGridView
    Friend WithEvents btRemoveAll As Button
    Friend WithEvents btRemoveSelected As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbReplaceText As RadioButton
    Friend WithEvents btClose As Button
    Friend WithEvents btStartProcess As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDestinationFolderPath As TextBox
    Friend WithEvents txtResultFileTag As TextBox
    Friend WithEvents txtResultFilePrefix As TextBox
    Friend WithEvents btOpenDestinationFolder As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbExtensionFilter As TextBox
    Friend WithEvents lstFiles As ListBox
    Friend WithEvents txtFolderPathSource As TextBox
    Friend WithEvents btOpenFolder As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents btAddAllFiles As Button
    Friend WithEvents btAddSelectedFile As Button
    Friend WithEvents rbReplaceLineByLine As RadioButton
    Friend WithEvents rbInsertALine As RadioButton
    Friend WithEvents rbRemoveLines As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents tbTextToReplace As TextBox
    Friend WithEvents tbTextToFind As TextBox
    Friend WithEvents lbTextToReplace As Label
    Friend WithEvents lbTextToFind As Label
    Friend WithEvents rbReplaceTextInASCII As RadioButton
    Friend WithEvents gbLineConditions As GroupBox
    Friend WithEvents tbEndingLineidx As TextBox
    Friend WithEvents tbStartingLineidx As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbASCIIRangeConditions As GroupBox
    Friend WithEvents tbAscTLyRow As TextBox
    Friend WithEvents tbAscTLxCol As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbAscLRyRow As TextBox
    Friend WithEvents tbAscLRxCol As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbFileNameFilter As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents rbCutDecimal As RadioButton
    Friend WithEvents tbDecimalPartN As TextBox
    Friend WithEvents Label3 As Label
End Class
