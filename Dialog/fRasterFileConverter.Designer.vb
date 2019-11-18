<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fRasterFileConverter
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
        Me.dgvFileList = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbFileNameFilter = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbExtensionFilter = New System.Windows.Forms.TextBox()
        Me.lstFiles = New System.Windows.Forms.ListBox()
        Me.txtFolderPathSource = New System.Windows.Forms.TextBox()
        Me.btOpenRfFolder = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btAddAllFiles = New System.Windows.Forms.Button()
        Me.btAddSelectedFile = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtResultFileTag = New System.Windows.Forms.TextBox()
        Me.txtResultFilePrefix = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDestinationFolderPath = New System.Windows.Forms.TextBox()
        Me.btOpenDestinationFolder = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btStartProcess = New System.Windows.Forms.Button()
        Me.btRemoveSelected = New System.Windows.Forms.Button()
        Me.btRemoveAll = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbGdalinfo = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rbConvertGribToASCii = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btSelectRenderer = New System.Windows.Forms.Button()
        Me.rbConvertASCtoImg = New System.Windows.Forms.RadioButton()
        Me.rbResample = New System.Windows.Forms.RadioButton()
        Me.rbClipAndResample = New System.Windows.Forms.RadioButton()
        Me.rbConvertGTiffToASCii = New System.Windows.Forms.RadioButton()
        Me.rbConvertASCiiToGTiff = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbResamplingMethod = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkDecimalLength = New System.Windows.Forms.CheckBox()
        Me.tbDecimalPartN = New System.Windows.Forms.TextBox()
        Me.tbBandN = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btSelectBaseRasterFile = New System.Windows.Forms.Button()
        Me.tbBaseGridFile = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbODataType = New System.Windows.Forms.ComboBox()
        Me.chkBaseGrid = New System.Windows.Forms.CheckBox()
        Me.txtResampleCellSize = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkResampleSize = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgvFileList.Location = New System.Drawing.Point(9, 22)
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
        Me.dgvFileList.Size = New System.Drawing.Size(392, 237)
        Me.dgvFileList.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbFileNameFilter)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbExtensionFilter)
        Me.GroupBox2.Controls.Add(Me.lstFiles)
        Me.GroupBox2.Controls.Add(Me.txtFolderPathSource)
        Me.GroupBox2.Controls.Add(Me.btOpenRfFolder)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.btAddAllFiles)
        Me.GroupBox2.Controls.Add(Me.btAddSelectedFile)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(12, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 304)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search source files"
        '
        'tbFileNameFilter
        '
        Me.tbFileNameFilter.Location = New System.Drawing.Point(198, 49)
        Me.tbFileNameFilter.Name = "tbFileNameFilter"
        Me.tbFileNameFilter.Size = New System.Drawing.Size(73, 21)
        Me.tbFileNameFilter.TabIndex = 206
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(99, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 12)
        Me.Label8.TabIndex = 207
        Me.Label8.Text = "File name filter :"
        '
        'tbExtensionFilter
        '
        Me.tbExtensionFilter.Location = New System.Drawing.Point(378, 49)
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
        Me.lstFiles.Size = New System.Drawing.Size(410, 184)
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
        Me.btAddAllFiles.Location = New System.Drawing.Point(127, 266)
        Me.btAddAllFiles.Name = "btAddAllFiles"
        Me.btAddAllFiles.Size = New System.Drawing.Size(148, 25)
        Me.btAddAllFiles.TabIndex = 13
        Me.btAddAllFiles.Text = "Add all"
        Me.btAddAllFiles.UseVisualStyleBackColor = True
        '
        'btAddSelectedFile
        '
        Me.btAddSelectedFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddSelectedFile.Location = New System.Drawing.Point(281, 266)
        Me.btAddSelectedFile.Name = "btAddSelectedFile"
        Me.btAddSelectedFile.Size = New System.Drawing.Size(139, 25)
        Me.btAddSelectedFile.TabIndex = 14
        Me.btAddSelectedFile.Text = "Add selected"
        Me.btAddSelectedFile.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtResultFileTag)
        Me.GroupBox1.Controls.Add(Me.txtResultFilePrefix)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDestinationFolderPath)
        Me.GroupBox1.Controls.Add(Me.btOpenDestinationFolder)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 591)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 80)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result files"
        '
        'txtResultFileTag
        '
        Me.txtResultFileTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultFileTag.Location = New System.Drawing.Point(550, 20)
        Me.txtResultFileTag.Multiline = True
        Me.txtResultFileTag.Name = "txtResultFileTag"
        Me.txtResultFileTag.Size = New System.Drawing.Size(119, 21)
        Me.txtResultFileTag.TabIndex = 225
        '
        'txtResultFilePrefix
        '
        Me.txtResultFilePrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultFilePrefix.Location = New System.Drawing.Point(282, 20)
        Me.txtResultFilePrefix.Multiline = True
        Me.txtResultFilePrefix.Name = "txtResultFilePrefix"
        Me.txtResultFilePrefix.Size = New System.Drawing.Size(125, 21)
        Me.txtResultFilePrefix.TabIndex = 224
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(419, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 12)
        Me.Label5.TabIndex = 226
        Me.Label5.Text = "Tail text of file name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 12)
        Me.Label4.TabIndex = 227
        Me.Label4.Text = "Head text of file name :"
        '
        'txtDestinationFolderPath
        '
        Me.txtDestinationFolderPath.BackColor = System.Drawing.SystemColors.Window
        Me.txtDestinationFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestinationFolderPath.Location = New System.Drawing.Point(144, 48)
        Me.txtDestinationFolderPath.Name = "txtDestinationFolderPath"
        Me.txtDestinationFolderPath.Size = New System.Drawing.Size(525, 21)
        Me.txtDestinationFolderPath.TabIndex = 30
        '
        'btOpenDestinationFolder
        '
        Me.btOpenDestinationFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btOpenDestinationFolder.Location = New System.Drawing.Point(16, 47)
        Me.btOpenDestinationFolder.Name = "btOpenDestinationFolder"
        Me.btOpenDestinationFolder.Size = New System.Drawing.Size(122, 21)
        Me.btOpenDestinationFolder.TabIndex = 29
        Me.btOpenDestinationFolder.Text = "Destination folder"
        Me.btOpenDestinationFolder.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btClose.Location = New System.Drawing.Point(695, 642)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(164, 27)
        Me.btClose.TabIndex = 2
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btStartProcess
        '
        Me.btStartProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btStartProcess.Location = New System.Drawing.Point(695, 599)
        Me.btStartProcess.Name = "btStartProcess"
        Me.btStartProcess.Size = New System.Drawing.Size(164, 39)
        Me.btStartProcess.TabIndex = 1
        Me.btStartProcess.Text = "Start"
        Me.btStartProcess.UseVisualStyleBackColor = True
        '
        'btRemoveSelected
        '
        Me.btRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveSelected.Location = New System.Drawing.Point(259, 266)
        Me.btRemoveSelected.Name = "btRemoveSelected"
        Me.btRemoveSelected.Size = New System.Drawing.Size(142, 25)
        Me.btRemoveSelected.TabIndex = 18
        Me.btRemoveSelected.Text = "Remove selected"
        Me.btRemoveSelected.UseVisualStyleBackColor = True
        '
        'btRemoveAll
        '
        Me.btRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemoveAll.Location = New System.Drawing.Point(111, 266)
        Me.btRemoveAll.Name = "btRemoveAll"
        Me.btRemoveAll.Size = New System.Drawing.Size(142, 25)
        Me.btRemoveAll.TabIndex = 17
        Me.btRemoveAll.Text = "Remove all"
        Me.btRemoveAll.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbGdalinfo)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.rbConvertGribToASCii)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.btSelectRenderer)
        Me.GroupBox3.Controls.Add(Me.rbConvertASCtoImg)
        Me.GroupBox3.Controls.Add(Me.rbResample)
        Me.GroupBox3.Controls.Add(Me.rbClipAndResample)
        Me.GroupBox3.Controls.Add(Me.rbConvertGTiffToASCii)
        Me.GroupBox3.Controls.Add(Me.rbConvertASCiiToGTiff)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(847, 113)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select processing"
        '
        'rbGdalinfo
        '
        Me.rbGdalinfo.AutoSize = True
        Me.rbGdalinfo.Location = New System.Drawing.Point(119, 85)
        Me.rbGdalinfo.Name = "rbGdalinfo"
        Me.rbGdalinfo.Size = New System.Drawing.Size(69, 16)
        Me.rbGdalinfo.TabIndex = 219
        Me.rbGdalinfo.Text = "Gdalinfo"
        Me.rbGdalinfo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Info
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(10, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 218
        Me.Label9.Text = "Get raster info."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbConvertGribToASCii
        '
        Me.rbConvertGribToASCii.AutoSize = True
        Me.rbConvertGribToASCii.Location = New System.Drawing.Point(256, 25)
        Me.rbConvertGribToASCii.Name = "rbConvertGribToASCii"
        Me.rbConvertGribToASCii.Size = New System.Drawing.Size(140, 16)
        Me.rbConvertGribToASCii.TabIndex = 217
        Me.rbConvertGribToASCii.Text = "GRIB/GRIB2 to ASCII"
        Me.rbConvertGribToASCii.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(337, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 12)
        Me.Label3.TabIndex = 216
        Me.Label3.Text = "(Only ASCII raster files are availabe)"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Info
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(10, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Clip/resample"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Info
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(10, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Convert format"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btSelectRenderer
        '
        Me.btSelectRenderer.Location = New System.Drawing.Point(747, 22)
        Me.btSelectRenderer.Name = "btSelectRenderer"
        Me.btSelectRenderer.Size = New System.Drawing.Size(90, 23)
        Me.btSelectRenderer.TabIndex = 20
        Me.btSelectRenderer.Text = "Renderer"
        Me.btSelectRenderer.UseVisualStyleBackColor = True
        '
        'rbConvertASCtoImg
        '
        Me.rbConvertASCtoImg.AutoSize = True
        Me.rbConvertASCtoImg.Location = New System.Drawing.Point(569, 25)
        Me.rbConvertASCtoImg.Name = "rbConvertASCtoImg"
        Me.rbConvertASCtoImg.Size = New System.Drawing.Size(161, 16)
        Me.rbConvertASCtoImg.TabIndex = 20
        Me.rbConvertASCtoImg.Text = "Convert ASCII to images"
        Me.rbConvertASCtoImg.UseVisualStyleBackColor = True
        '
        'rbResample
        '
        Me.rbResample.AutoSize = True
        Me.rbResample.Location = New System.Drawing.Point(256, 54)
        Me.rbResample.Name = "rbResample"
        Me.rbResample.Size = New System.Drawing.Size(80, 16)
        Me.rbResample.TabIndex = 8
        Me.rbResample.Text = "Resample"
        Me.rbResample.UseVisualStyleBackColor = True
        '
        'rbClipAndResample
        '
        Me.rbClipAndResample.AutoSize = True
        Me.rbClipAndResample.Location = New System.Drawing.Point(119, 55)
        Me.rbClipAndResample.Name = "rbClipAndResample"
        Me.rbClipAndResample.Size = New System.Drawing.Size(104, 16)
        Me.rbClipAndResample.TabIndex = 7
        Me.rbClipAndResample.Text = "Clip/resample"
        Me.rbClipAndResample.UseVisualStyleBackColor = True
        '
        'rbConvertGTiffToASCii
        '
        Me.rbConvertGTiffToASCii.AutoSize = True
        Me.rbConvertGTiffToASCii.Checked = True
        Me.rbConvertGTiffToASCii.Location = New System.Drawing.Point(119, 25)
        Me.rbConvertGTiffToASCii.Name = "rbConvertGTiffToASCii"
        Me.rbConvertGTiffToASCii.Size = New System.Drawing.Size(106, 16)
        Me.rbConvertGTiffToASCii.TabIndex = 4
        Me.rbConvertGTiffToASCii.TabStop = True
        Me.rbConvertGTiffToASCii.Text = "GTIFF to ASCII"
        Me.rbConvertGTiffToASCii.UseVisualStyleBackColor = True
        '
        'rbConvertASCiiToGTiff
        '
        Me.rbConvertASCiiToGTiff.AutoSize = True
        Me.rbConvertASCiiToGTiff.Location = New System.Drawing.Point(427, 25)
        Me.rbConvertASCiiToGTiff.Name = "rbConvertASCiiToGTiff"
        Me.rbConvertASCiiToGTiff.Size = New System.Drawing.Size(98, 16)
        Me.rbConvertASCiiToGTiff.TabIndex = 4
        Me.rbConvertASCiiToGTiff.Text = "ASCII to GTiff"
        Me.rbConvertASCiiToGTiff.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(537, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 12)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Resampling method :"
        '
        'cbResamplingMethod
        '
        Me.cbResamplingMethod.FormattingEnabled = True
        Me.cbResamplingMethod.Location = New System.Drawing.Point(667, 49)
        Me.cbResamplingMethod.Name = "cbResamplingMethod"
        Me.cbResamplingMethod.Size = New System.Drawing.Size(148, 20)
        Me.cbResamplingMethod.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvFileList)
        Me.GroupBox4.Controls.Add(Me.btRemoveAll)
        Me.GroupBox4.Controls.Add(Me.btRemoveSelected)
        Me.GroupBox4.Location = New System.Drawing.Point(448, 153)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(411, 304)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Selected source files"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkDecimalLength)
        Me.GroupBox5.Controls.Add(Me.tbDecimalPartN)
        Me.GroupBox5.Controls.Add(Me.tbBandN)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.btSelectBaseRasterFile)
        Me.GroupBox5.Controls.Add(Me.tbBaseGridFile)
        Me.GroupBox5.Controls.Add(Me.cbResamplingMethod)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.cbODataType)
        Me.GroupBox5.Controls.Add(Me.chkBaseGrid)
        Me.GroupBox5.Controls.Add(Me.txtResampleCellSize)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.chkResampleSize)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 470)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(847, 106)
        Me.GroupBox5.TabIndex = 210
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Conditions"
        '
        'chkDecimalLength
        '
        Me.chkDecimalLength.AutoSize = True
        Me.chkDecimalLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDecimalLength.Location = New System.Drawing.Point(517, 77)
        Me.chkDecimalLength.Name = "chkDecimalLength"
        Me.chkDecimalLength.Size = New System.Drawing.Size(146, 16)
        Me.chkDecimalLength.TabIndex = 221
        Me.chkDecimalLength.Text = "Decimal part length   :"
        Me.chkDecimalLength.UseVisualStyleBackColor = True
        '
        'tbDecimalPartN
        '
        Me.tbDecimalPartN.Enabled = False
        Me.tbDecimalPartN.Location = New System.Drawing.Point(667, 74)
        Me.tbDecimalPartN.Name = "tbDecimalPartN"
        Me.tbDecimalPartN.Size = New System.Drawing.Size(51, 21)
        Me.tbDecimalPartN.TabIndex = 220
        '
        'tbBandN
        '
        Me.tbBandN.Location = New System.Drawing.Point(158, 48)
        Me.tbBandN.Name = "tbBandN"
        Me.tbBandN.Size = New System.Drawing.Size(51, 21)
        Me.tbBandN.TabIndex = 218
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(54, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 12)
        Me.Label12.TabIndex = 219
        Me.Label12.Text = "Band to convert :"
        '
        'btSelectBaseRasterFile
        '
        Me.btSelectBaseRasterFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSelectBaseRasterFile.Location = New System.Drawing.Point(427, 23)
        Me.btSelectBaseRasterFile.Name = "btSelectBaseRasterFile"
        Me.btSelectBaseRasterFile.Size = New System.Drawing.Size(27, 21)
        Me.btSelectBaseRasterFile.TabIndex = 217
        Me.btSelectBaseRasterFile.Text = "..."
        Me.btSelectBaseRasterFile.UseVisualStyleBackColor = True
        '
        'tbBaseGridFile
        '
        Me.tbBaseGridFile.Location = New System.Drawing.Point(158, 22)
        Me.tbBaseGridFile.Name = "tbBaseGridFile"
        Me.tbBaseGridFile.Size = New System.Drawing.Size(263, 21)
        Me.tbBaseGridFile.TabIndex = 216
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 12)
        Me.Label11.TabIndex = 215
        Me.Label11.Text = "Output file data type :"
        '
        'cbODataType
        '
        Me.cbODataType.FormattingEnabled = True
        Me.cbODataType.Location = New System.Drawing.Point(158, 75)
        Me.cbODataType.Name = "cbODataType"
        Me.cbODataType.Size = New System.Drawing.Size(111, 20)
        Me.cbODataType.TabIndex = 210
        '
        'chkBaseGrid
        '
        Me.chkBaseGrid.AutoSize = True
        Me.chkBaseGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBaseGrid.Location = New System.Drawing.Point(14, 24)
        Me.chkBaseGrid.Name = "chkBaseGrid"
        Me.chkBaseGrid.Size = New System.Drawing.Size(141, 16)
        Me.chkBaseGrid.TabIndex = 211
        Me.chkBaseGrid.Text = "Base extent grid file :"
        Me.chkBaseGrid.UseVisualStyleBackColor = True
        '
        'txtResampleCellSize
        '
        Me.txtResampleCellSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResampleCellSize.Enabled = False
        Me.txtResampleCellSize.Location = New System.Drawing.Point(667, 22)
        Me.txtResampleCellSize.Name = "txtResampleCellSize"
        Me.txtResampleCellSize.Size = New System.Drawing.Size(48, 21)
        Me.txtResampleCellSize.TabIndex = 213
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(719, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 12)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "[m]"
        '
        'chkResampleSize
        '
        Me.chkResampleSize.AutoSize = True
        Me.chkResampleSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkResampleSize.Location = New System.Drawing.Point(517, 25)
        Me.chkResampleSize.Name = "chkResampleSize"
        Me.chkResampleSize.Size = New System.Drawing.Size(148, 16)
        Me.chkResampleSize.TabIndex = 212
        Me.chkResampleSize.Text = "Resampling cell size :"
        Me.chkResampleSize.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 12)
        Me.Label2.TabIndex = 211
        Me.Label2.Text = "** Korean is not allowed in the file path and name."
        '
        'fRasterFileConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 686)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btStartProcess)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(890, 725)
        Me.MinimumSize = New System.Drawing.Size(890, 725)
        Me.Name = "fRasterFileConverter"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Raster file converter"
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvFileList As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btAddAllFiles As System.Windows.Forms.Button
    Friend WithEvents btAddSelectedFile As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDestinationFolderPath As System.Windows.Forms.TextBox
    Friend WithEvents btOpenDestinationFolder As System.Windows.Forms.Button
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents btStartProcess As System.Windows.Forms.Button
    Friend WithEvents btRemoveSelected As System.Windows.Forms.Button
    Friend WithEvents btRemoveAll As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbResample As System.Windows.Forms.RadioButton
    Friend WithEvents rbClipAndResample As System.Windows.Forms.RadioButton
    Friend WithEvents rbConvertASCiiToGTiff As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbConvertGTiffToASCii As System.Windows.Forms.RadioButton
    Friend WithEvents rbConvertASCtoImg As System.Windows.Forms.RadioButton
    Friend WithEvents btSelectRenderer As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstFiles As System.Windows.Forms.ListBox
    Friend WithEvents txtFolderPathSource As System.Windows.Forms.TextBox
    Friend WithEvents btOpenRfFolder As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbResamplingMethod As System.Windows.Forms.ComboBox
    Friend WithEvents tbExtensionFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btSelectBaseRasterFile As Button
    Friend WithEvents tbBaseGridFile As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbODataType As ComboBox
    Friend WithEvents chkBaseGrid As CheckBox
    Friend WithEvents txtResampleCellSize As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkResampleSize As CheckBox
    Friend WithEvents txtResultFileTag As TextBox
    Friend WithEvents txtResultFilePrefix As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbFileNameFilter As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbBandN As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents rbConvertGribToASCii As RadioButton
    Friend WithEvents rbGdalinfo As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents chkDecimalLength As CheckBox
    Friend WithEvents tbDecimalPartN As TextBox
End Class
