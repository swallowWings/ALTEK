<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fCalculator))
        Me.btSelectAscFileA = New System.Windows.Forms.Button()
        Me.tbInFileA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btSelectAscFileB = New System.Windows.Forms.Button()
        Me.tbInFileB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btSelectAscFileC = New System.Windows.Forms.Button()
        Me.tbInFileC = New System.Windows.Forms.TextBox()
        Me.tbEq = New System.Windows.Forms.TextBox()
        Me.btStartCalc = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btResultFPN = New System.Windows.Forms.Button()
        Me.tbResultFPN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btHeip = New System.Windows.Forms.Button()
        Me.chkNodataToZeroASC1 = New System.Windows.Forms.CheckBox()
        Me.chkNodataToZeroASC2 = New System.Windows.Forms.CheckBox()
        Me.chkNodataToZeroASC3 = New System.Windows.Forms.CheckBox()
        Me.tbDecimalPartN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkMultiFiles = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btSelectAscFileA
        '
        Me.btSelectAscFileA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSelectAscFileA.Location = New System.Drawing.Point(549, 34)
        Me.btSelectAscFileA.Name = "btSelectAscFileA"
        Me.btSelectAscFileA.Size = New System.Drawing.Size(94, 21)
        Me.btSelectAscFileA.TabIndex = 221
        Me.btSelectAscFileA.Text = "Select a file"
        Me.btSelectAscFileA.UseVisualStyleBackColor = True
        '
        'tbInFileA
        '
        Me.tbInFileA.Location = New System.Drawing.Point(42, 34)
        Me.tbInFileA.Name = "tbInFileA"
        Me.tbInFileA.Size = New System.Drawing.Size(411, 21)
        Me.tbInFileA.TabIndex = 220
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 12)
        Me.Label1.TabIndex = 222
        Me.Label1.Text = "A :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 12)
        Me.Label2.TabIndex = 225
        Me.Label2.Text = "B :"
        '
        'btSelectAscFileB
        '
        Me.btSelectAscFileB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSelectAscFileB.Location = New System.Drawing.Point(549, 61)
        Me.btSelectAscFileB.Name = "btSelectAscFileB"
        Me.btSelectAscFileB.Size = New System.Drawing.Size(94, 21)
        Me.btSelectAscFileB.TabIndex = 224
        Me.btSelectAscFileB.Text = "Select a file"
        Me.btSelectAscFileB.UseVisualStyleBackColor = True
        '
        'tbInFileB
        '
        Me.tbInFileB.Location = New System.Drawing.Point(42, 61)
        Me.tbInFileB.Name = "tbInFileB"
        Me.tbInFileB.Size = New System.Drawing.Size(501, 21)
        Me.tbInFileB.TabIndex = 223
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 12)
        Me.Label3.TabIndex = 228
        Me.Label3.Text = "C :"
        '
        'btSelectAscFileC
        '
        Me.btSelectAscFileC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSelectAscFileC.Location = New System.Drawing.Point(549, 88)
        Me.btSelectAscFileC.Name = "btSelectAscFileC"
        Me.btSelectAscFileC.Size = New System.Drawing.Size(94, 21)
        Me.btSelectAscFileC.TabIndex = 227
        Me.btSelectAscFileC.Text = "Select a file"
        Me.btSelectAscFileC.UseVisualStyleBackColor = True
        '
        'tbInFileC
        '
        Me.tbInFileC.Location = New System.Drawing.Point(42, 88)
        Me.tbInFileC.Name = "tbInFileC"
        Me.tbInFileC.Size = New System.Drawing.Size(501, 21)
        Me.tbInFileC.TabIndex = 226
        '
        'tbEq
        '
        Me.tbEq.Location = New System.Drawing.Point(138, 123)
        Me.tbEq.Name = "tbEq"
        Me.tbEq.Size = New System.Drawing.Size(405, 21)
        Me.tbEq.TabIndex = 229
        '
        'btStartCalc
        '
        Me.btStartCalc.Location = New System.Drawing.Point(334, 465)
        Me.btStartCalc.Name = "btStartCalc"
        Me.btStartCalc.Size = New System.Drawing.Size(324, 33)
        Me.btStartCalc.TabIndex = 230
        Me.btStartCalc.Text = "Start calculation"
        Me.btStartCalc.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Location = New System.Drawing.Point(668, 465)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(132, 33)
        Me.btClose.TabIndex = 231
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btResultFPN
        '
        Me.btResultFPN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btResultFPN.Location = New System.Drawing.Point(19, 436)
        Me.btResultFPN.Name = "btResultFPN"
        Me.btResultFPN.Size = New System.Drawing.Size(139, 21)
        Me.btResultFPN.TabIndex = 233
        Me.btResultFPN.Text = "Result file"
        Me.btResultFPN.UseVisualStyleBackColor = True
        '
        'tbResultFPN
        '
        Me.tbResultFPN.Location = New System.Drawing.Point(164, 436)
        Me.tbResultFPN.Name = "tbResultFPN"
        Me.tbResultFPN.Size = New System.Drawing.Size(636, 21)
        Me.tbResultFPN.TabIndex = 232
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 12)
        Me.Label4.TabIndex = 228
        Me.Label4.Text = "Math. expression : "
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(19, 150)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(781, 273)
        Me.TextBox1.TabIndex = 235
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'btHeip
        '
        Me.btHeip.Location = New System.Drawing.Point(18, 465)
        Me.btHeip.Name = "btHeip"
        Me.btHeip.Size = New System.Drawing.Size(111, 33)
        Me.btHeip.TabIndex = 236
        Me.btHeip.Text = "Help"
        Me.btHeip.UseVisualStyleBackColor = True
        '
        'chkNodataToZeroASC1
        '
        Me.chkNodataToZeroASC1.AutoSize = True
        Me.chkNodataToZeroASC1.Location = New System.Drawing.Point(653, 38)
        Me.chkNodataToZeroASC1.Name = "chkNodataToZeroASC1"
        Me.chkNodataToZeroASC1.Size = New System.Drawing.Size(147, 16)
        Me.chkNodataToZeroASC1.TabIndex = 237
        Me.chkNodataToZeroASC1.Text = "Calculate nodata as 0"
        Me.chkNodataToZeroASC1.UseVisualStyleBackColor = True
        '
        'chkNodataToZeroASC2
        '
        Me.chkNodataToZeroASC2.AutoSize = True
        Me.chkNodataToZeroASC2.Location = New System.Drawing.Point(653, 65)
        Me.chkNodataToZeroASC2.Name = "chkNodataToZeroASC2"
        Me.chkNodataToZeroASC2.Size = New System.Drawing.Size(147, 16)
        Me.chkNodataToZeroASC2.TabIndex = 238
        Me.chkNodataToZeroASC2.Text = "Calculate nodata as 0"
        Me.chkNodataToZeroASC2.UseVisualStyleBackColor = True
        '
        'chkNodataToZeroASC3
        '
        Me.chkNodataToZeroASC3.AutoSize = True
        Me.chkNodataToZeroASC3.Location = New System.Drawing.Point(653, 92)
        Me.chkNodataToZeroASC3.Name = "chkNodataToZeroASC3"
        Me.chkNodataToZeroASC3.Size = New System.Drawing.Size(147, 16)
        Me.chkNodataToZeroASC3.TabIndex = 239
        Me.chkNodataToZeroASC3.Text = "Calculate nodata as 0"
        Me.chkNodataToZeroASC3.UseVisualStyleBackColor = True
        '
        'tbDecimalPartN
        '
        Me.tbDecimalPartN.Location = New System.Drawing.Point(684, 123)
        Me.tbDecimalPartN.Name = "tbDecimalPartN"
        Me.tbDecimalPartN.Size = New System.Drawing.Size(40, 21)
        Me.tbDecimalPartN.TabIndex = 240
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(560, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 12)
        Me.Label5.TabIndex = 241
        Me.Label5.Text = "Decimal part num. : "
        '
        'chkMultiFiles
        '
        Me.chkMultiFiles.AutoSize = True
        Me.chkMultiFiles.Location = New System.Drawing.Point(459, 36)
        Me.chkMultiFiles.Name = "chkMultiFiles"
        Me.chkMultiFiles.Size = New System.Drawing.Size(82, 16)
        Me.chkMultiFiles.TabIndex = 242
        Me.chkMultiFiles.Text = "Multi. files"
        Me.chkMultiFiles.UseVisualStyleBackColor = True
        '
        'fCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 510)
        Me.Controls.Add(Me.chkMultiFiles)
        Me.Controls.Add(Me.tbDecimalPartN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkNodataToZeroASC3)
        Me.Controls.Add(Me.chkNodataToZeroASC2)
        Me.Controls.Add(Me.chkNodataToZeroASC1)
        Me.Controls.Add(Me.btHeip)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btResultFPN)
        Me.Controls.Add(Me.tbResultFPN)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btStartCalc)
        Me.Controls.Add(Me.tbEq)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btSelectAscFileC)
        Me.Controls.Add(Me.tbInFileC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btSelectAscFileB)
        Me.Controls.Add(Me.tbInFileB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btSelectAscFileA)
        Me.Controls.Add(Me.tbInFileA)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(834, 532)
        Me.Name = "fCalculator"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "ASCII raster file calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btSelectAscFileA As Button
    Friend WithEvents tbInFileA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btSelectAscFileB As Button
    Friend WithEvents tbInFileB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btSelectAscFileC As Button
    Friend WithEvents tbInFileC As TextBox
    Friend WithEvents tbEq As TextBox
    Friend WithEvents btStartCalc As Button
    Friend WithEvents btClose As Button
    Friend WithEvents btResultFPN As Button
    Friend WithEvents tbResultFPN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btHeip As Button
    Friend WithEvents chkNodataToZeroASC1 As CheckBox
    Friend WithEvents chkNodataToZeroASC2 As CheckBox
    Friend WithEvents chkNodataToZeroASC3 As CheckBox
    Friend WithEvents tbDecimalPartN As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkMultiFiles As CheckBox
End Class
