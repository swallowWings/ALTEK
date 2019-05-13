<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fConvertCoordiSystem
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fConvertCoordiSystem))
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
        Me.btClose = New System.Windows.Forms.Button()
        Me.btStartProcess = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtResultFileTag = New System.Windows.Forms.TextBox()
        Me.txtResultFilePrefix = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDestinationFolderPath = New System.Windows.Forms.TextBox()
        Me.btOpenDestinationFolder = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbFileFormat_input = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFileFormat_output = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbProj4_output = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbProj4_input = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.chkCoordInfo_input = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDataType = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
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
        Me.GroupBox2.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 313)
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
        Me.btAddAllFiles.Location = New System.Drawing.Point(127, 278)
        Me.btAddAllFiles.Name = "btAddAllFiles"
        Me.btAddAllFiles.Size = New System.Drawing.Size(148, 25)
        Me.btAddAllFiles.TabIndex = 13
        Me.btAddAllFiles.Text = "Add all"
        Me.btAddAllFiles.UseVisualStyleBackColor = True
        '
        'btAddSelectedFile
        '
        Me.btAddSelectedFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddSelectedFile.Location = New System.Drawing.Point(281, 278)
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
        Me.GroupBox4.Location = New System.Drawing.Point(454, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(411, 313)
        Me.GroupBox4.TabIndex = 212
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Selected source files"
        '
        'dgvFileList
        '
        Me.dgvFileList.AllowUserToAddRows = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFileList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFileList.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvFileList.Location = New System.Drawing.Point(10, 22)
        Me.dgvFileList.Name = "dgvFileList"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFileList.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvFileList.RowHeadersVisible = False
        Me.dgvFileList.RowTemplate.Height = 23
        Me.dgvFileList.Size = New System.Drawing.Size(392, 249)
        Me.dgvFileList.TabIndex = 16
        '
        'btRemoveAll
        '
        Me.btRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveAll.Location = New System.Drawing.Point(112, 278)
        Me.btRemoveAll.Name = "btRemoveAll"
        Me.btRemoveAll.Size = New System.Drawing.Size(142, 25)
        Me.btRemoveAll.TabIndex = 17
        Me.btRemoveAll.Text = "Remove all"
        Me.btRemoveAll.UseVisualStyleBackColor = True
        '
        'btRemoveSelected
        '
        Me.btRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveSelected.Location = New System.Drawing.Point(260, 278)
        Me.btRemoveSelected.Name = "btRemoveSelected"
        Me.btRemoveSelected.Size = New System.Drawing.Size(142, 25)
        Me.btRemoveSelected.TabIndex = 18
        Me.btRemoveSelected.Text = "Remove selected"
        Me.btRemoveSelected.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btClose.Location = New System.Drawing.Point(774, 642)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(91, 26)
        Me.btClose.TabIndex = 214
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btStartProcess
        '
        Me.btStartProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btStartProcess.Location = New System.Drawing.Point(774, 593)
        Me.btStartProcess.Name = "btStartProcess"
        Me.btStartProcess.Size = New System.Drawing.Size(91, 46)
        Me.btStartProcess.TabIndex = 213
        Me.btStartProcess.Text = "Start"
        Me.btStartProcess.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbDataType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbFileFormat_output)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtResultFileTag)
        Me.GroupBox1.Controls.Add(Me.tbProj4_output)
        Me.GroupBox1.Controls.Add(Me.txtResultFilePrefix)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDestinationFolderPath)
        Me.GroupBox1.Controls.Add(Me.btOpenDestinationFolder)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 462)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 128)
        Me.GroupBox1.TabIndex = 215
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result files"
        '
        'txtResultFileTag
        '
        Me.txtResultFileTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultFileTag.Location = New System.Drawing.Point(153, 97)
        Me.txtResultFileTag.Multiline = True
        Me.txtResultFileTag.Name = "txtResultFileTag"
        Me.txtResultFileTag.Size = New System.Drawing.Size(98, 21)
        Me.txtResultFileTag.TabIndex = 225
        '
        'txtResultFilePrefix
        '
        Me.txtResultFilePrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultFilePrefix.Location = New System.Drawing.Point(153, 70)
        Me.txtResultFilePrefix.Multiline = True
        Me.txtResultFilePrefix.Name = "txtResultFilePrefix"
        Me.txtResultFilePrefix.Size = New System.Drawing.Size(98, 21)
        Me.txtResultFilePrefix.TabIndex = 224
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 12)
        Me.Label5.TabIndex = 226
        Me.Label5.Text = "Tail text of file name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 12)
        Me.Label4.TabIndex = 227
        Me.Label4.Text = "Head text of file name :"
        '
        'txtDestinationFolderPath
        '
        Me.txtDestinationFolderPath.BackColor = System.Drawing.SystemColors.Window
        Me.txtDestinationFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestinationFolderPath.Location = New System.Drawing.Point(396, 97)
        Me.txtDestinationFolderPath.Name = "txtDestinationFolderPath"
        Me.txtDestinationFolderPath.Size = New System.Drawing.Size(441, 21)
        Me.txtDestinationFolderPath.TabIndex = 30
        '
        'btOpenDestinationFolder
        '
        Me.btOpenDestinationFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btOpenDestinationFolder.Location = New System.Drawing.Point(269, 97)
        Me.btOpenDestinationFolder.Name = "btOpenDestinationFolder"
        Me.btOpenDestinationFolder.Size = New System.Drawing.Size(122, 21)
        Me.btOpenDestinationFolder.TabIndex = 29
        Me.btOpenDestinationFolder.Text = "Destination folder"
        Me.btOpenDestinationFolder.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkCoordInfo_input)
        Me.GroupBox5.Controls.Add(Me.TextBox3)
        Me.GroupBox5.Controls.Add(Me.cbFileFormat_input)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.tbProj4_input)
        Me.GroupBox5.Location = New System.Drawing.Point(18, 337)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(847, 108)
        Me.GroupBox5.TabIndex = 228
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Source files"
        '
        'cbFileFormat_input
        '
        Me.cbFileFormat_input.FormattingEnabled = True
        Me.cbFileFormat_input.Location = New System.Drawing.Point(113, 24)
        Me.cbFileFormat_input.Name = "cbFileFormat_input"
        Me.cbFileFormat_input.Size = New System.Drawing.Size(138, 20)
        Me.cbFileFormat_input.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 12)
        Me.Label2.TabIndex = 227
        Me.Label2.Text = "File format :"
        '
        'cbFileFormat_output
        '
        Me.cbFileFormat_output.FormattingEnabled = True
        Me.cbFileFormat_output.Location = New System.Drawing.Point(153, 20)
        Me.cbFileFormat_output.Name = "cbFileFormat_output"
        Me.cbFileFormat_output.Size = New System.Drawing.Size(98, 20)
        Me.cbFileFormat_output.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 12)
        Me.Label3.TabIndex = 227
        Me.Label3.Text = "File format :"
        '
        'tbProj4_output
        '
        Me.tbProj4_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbProj4_output.Location = New System.Drawing.Point(269, 32)
        Me.tbProj4_output.Multiline = True
        Me.tbProj4_output.Name = "tbProj4_output"
        Me.tbProj4_output.Size = New System.Drawing.Size(569, 59)
        Me.tbProj4_output.TabIndex = 224
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(267, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 12)
        Me.Label6.TabIndex = 227
        Me.Label6.Text = "Coordinate info. as Proj4 format :"
        '
        'tbProj4_input
        '
        Me.tbProj4_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbProj4_input.Enabled = False
        Me.tbProj4_input.Location = New System.Drawing.Point(269, 38)
        Me.tbProj4_input.Multiline = True
        Me.tbProj4_input.Name = "tbProj4_input"
        Me.tbProj4_input.Size = New System.Drawing.Size(569, 64)
        Me.tbProj4_input.TabIndex = 224
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(10, 50)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(253, 53)
        Me.TextBox3.TabIndex = 228
        Me.TextBox3.Text = "** If the source file is ESRI ASC file, it must have a project file(.prj). If you" &
    " do not have prj file, please define the coordinate system info as Proj4 format." &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(19, 596)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(749, 70)
        Me.TextBox4.TabIndex = 229
        Me.TextBox4.Text = resources.GetString("TextBox4.Text")
        '
        'chkCoordInfo_input
        '
        Me.chkCoordInfo_input.AutoSize = True
        Me.chkCoordInfo_input.Location = New System.Drawing.Point(271, 18)
        Me.chkCoordInfo_input.Name = "chkCoordInfo_input"
        Me.chkCoordInfo_input.Size = New System.Drawing.Size(210, 16)
        Me.chkCoordInfo_input.TabIndex = 229
        Me.chkCoordInfo_input.Text = "Coordinate info. as Proj4 format :"
        Me.chkCoordInfo_input.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 12)
        Me.Label1.TabIndex = 227
        Me.Label1.Text = "DataType :"
        '
        'cbDataType
        '
        Me.cbDataType.FormattingEnabled = True
        Me.cbDataType.Location = New System.Drawing.Point(153, 44)
        Me.cbDataType.Name = "cbDataType"
        Me.cbDataType.Size = New System.Drawing.Size(98, 20)
        Me.cbDataType.TabIndex = 3
        '
        'fConvertCoordiSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 677)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btStartProcess)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "fConvertCoordiSystem"
        Me.Text = "Convert coordinate system"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btClose As Button
    Friend WithEvents btStartProcess As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtResultFileTag As TextBox
    Friend WithEvents txtResultFilePrefix As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDestinationFolderPath As TextBox
    Friend WithEvents btOpenDestinationFolder As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cbFileFormat_input As ComboBox
    Friend WithEvents cbFileFormat_output As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbProj4_output As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents tbProj4_input As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents chkCoordInfo_input As CheckBox
    Friend WithEvents cbDataType As ComboBox
    Friend WithEvents Label1 As Label
End Class
