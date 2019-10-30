<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fGRMToolsCreateSoilGridLayer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fGRMToolsCreateSoilGridLayer))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btMakeSoilGrids = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.cmbSoilLayer = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btLoadSoilPhaseVAT = New System.Windows.Forms.Button()
        Me.txtSoilPhaseVATPathName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSoilPhaseField = New System.Windows.Forms.ComboBox()
        Me.btOpenDestinationFolder = New System.Windows.Forms.Button()
        Me.txtSoilTextureLayerName = New System.Windows.Forms.TextBox()
        Me.txtDestinationFolderPath = New System.Windows.Forms.TextBox()
        Me.labBaseExtentLayer = New System.Windows.Forms.Label()
        Me.cmbBaseGridLayer = New System.Windows.Forms.ComboBox()
        Me.chkCreateSoilTextureLayer = New System.Windows.Forms.CheckBox()
        Me.chkCreateSoilDepthLayer = New System.Windows.Forms.CheckBox()
        Me.txtSoilDepthLayerName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbUsingPolygonLayer = New System.Windows.Forms.RadioButton()
        Me.rbUsingGridLayer = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'btMakeSoilGrids
        '
        Me.btMakeSoilGrids.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btMakeSoilGrids.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btMakeSoilGrids.Location = New System.Drawing.Point(12, 402)
        Me.btMakeSoilGrids.Name = "btMakeSoilGrids"
        Me.btMakeSoilGrids.Size = New System.Drawing.Size(310, 26)
        Me.btMakeSoilGrids.TabIndex = 2
        Me.btMakeSoilGrids.Text = "Make grid layers"
        Me.btMakeSoilGrids.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btClose.Location = New System.Drawing.Point(328, 402)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(120, 26)
        Me.btClose.TabIndex = 3
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'cmbSoilLayer
        '
        Me.cmbSoilLayer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSoilLayer.FormattingEnabled = True
        Me.cmbSoilLayer.Location = New System.Drawing.Point(182, 22)
        Me.cmbSoilLayer.Name = "cmbSoilLayer"
        Me.cmbSoilLayer.Size = New System.Drawing.Size(241, 20)
        Me.cmbSoilLayer.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btLoadSoilPhaseVAT)
        Me.GroupBox1.Controls.Add(Me.txtSoilPhaseVATPathName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbSoilPhaseField)
        Me.GroupBox1.Controls.Add(Me.cmbSoilLayer)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 113)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source data"
        '
        'btLoadSoilPhaseVAT
        '
        Me.btLoadSoilPhaseVAT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btLoadSoilPhaseVAT.Location = New System.Drawing.Point(13, 75)
        Me.btLoadSoilPhaseVAT.Name = "btLoadSoilPhaseVAT"
        Me.btLoadSoilPhaseVAT.Size = New System.Drawing.Size(163, 21)
        Me.btLoadSoilPhaseVAT.TabIndex = 15
        Me.btLoadSoilPhaseVAT.Text = "Load soil phase VAT file"
        Me.btLoadSoilPhaseVAT.UseVisualStyleBackColor = True
        '
        'txtSoilPhaseVATPathName
        '
        Me.txtSoilPhaseVATPathName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSoilPhaseVATPathName.Location = New System.Drawing.Point(182, 75)
        Me.txtSoilPhaseVATPathName.Name = "txtSoilPhaseVATPathName"
        Me.txtSoilPhaseVATPathName.Size = New System.Drawing.Size(239, 21)
        Me.txtSoilPhaseVATPathName.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Soil phase field :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 12)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Soil layer :"
        '
        'cmbSoilPhaseField
        '
        Me.cmbSoilPhaseField.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSoilPhaseField.FormattingEnabled = True
        Me.cmbSoilPhaseField.Location = New System.Drawing.Point(182, 48)
        Me.cmbSoilPhaseField.Name = "cmbSoilPhaseField"
        Me.cmbSoilPhaseField.Size = New System.Drawing.Size(241, 20)
        Me.cmbSoilPhaseField.TabIndex = 12
        '
        'btOpenDestinationFolder
        '
        Me.btOpenDestinationFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btOpenDestinationFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btOpenDestinationFolder.Location = New System.Drawing.Point(13, 70)
        Me.btOpenDestinationFolder.Name = "btOpenDestinationFolder"
        Me.btOpenDestinationFolder.Size = New System.Drawing.Size(163, 21)
        Me.btOpenDestinationFolder.TabIndex = 19
        Me.btOpenDestinationFolder.Text = "Select destination folder"
        Me.btOpenDestinationFolder.UseVisualStyleBackColor = True
        '
        'txtSoilTextureLayerName
        '
        Me.txtSoilTextureLayerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSoilTextureLayerName.Location = New System.Drawing.Point(236, 102)
        Me.txtSoilTextureLayerName.Name = "txtSoilTextureLayerName"
        Me.txtSoilTextureLayerName.Size = New System.Drawing.Size(187, 21)
        Me.txtSoilTextureLayerName.TabIndex = 22
        '
        'txtDestinationFolderPath
        '
        Me.txtDestinationFolderPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDestinationFolderPath.Location = New System.Drawing.Point(182, 71)
        Me.txtDestinationFolderPath.Name = "txtDestinationFolderPath"
        Me.txtDestinationFolderPath.Size = New System.Drawing.Size(241, 21)
        Me.txtDestinationFolderPath.TabIndex = 20
        '
        'labBaseExtentLayer
        '
        Me.labBaseExtentLayer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labBaseExtentLayer.AutoSize = True
        Me.labBaseExtentLayer.Location = New System.Drawing.Point(47, 37)
        Me.labBaseExtentLayer.Name = "labBaseExtentLayer"
        Me.labBaseExtentLayer.Size = New System.Drawing.Size(133, 12)
        Me.labBaseExtentLayer.TabIndex = 198
        Me.labBaseExtentLayer.Text = "Base extent grid layer:"
        '
        'cmbBaseGridLayer
        '
        Me.cmbBaseGridLayer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBaseGridLayer.FormattingEnabled = True
        Me.cmbBaseGridLayer.Location = New System.Drawing.Point(182, 34)
        Me.cmbBaseGridLayer.Name = "cmbBaseGridLayer"
        Me.cmbBaseGridLayer.Size = New System.Drawing.Size(241, 20)
        Me.cmbBaseGridLayer.TabIndex = 18
        '
        'chkCreateSoilTextureLayer
        '
        Me.chkCreateSoilTextureLayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkCreateSoilTextureLayer.AutoSize = True
        Me.chkCreateSoilTextureLayer.Checked = True
        Me.chkCreateSoilTextureLayer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCreateSoilTextureLayer.Location = New System.Drawing.Point(13, 105)
        Me.chkCreateSoilTextureLayer.Name = "chkCreateSoilTextureLayer"
        Me.chkCreateSoilTextureLayer.Size = New System.Drawing.Size(221, 16)
        Me.chkCreateSoilTextureLayer.TabIndex = 21
        Me.chkCreateSoilTextureLayer.Text = "Create soil texture layer      Name:"
        Me.chkCreateSoilTextureLayer.UseVisualStyleBackColor = True
        '
        'chkCreateSoilDepthLayer
        '
        Me.chkCreateSoilDepthLayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkCreateSoilDepthLayer.AutoSize = True
        Me.chkCreateSoilDepthLayer.Checked = True
        Me.chkCreateSoilDepthLayer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCreateSoilDepthLayer.Location = New System.Drawing.Point(13, 134)
        Me.chkCreateSoilDepthLayer.Name = "chkCreateSoilDepthLayer"
        Me.chkCreateSoilDepthLayer.Size = New System.Drawing.Size(222, 16)
        Me.chkCreateSoilDepthLayer.TabIndex = 23
        Me.chkCreateSoilDepthLayer.Text = "Create soil depth layer        Name:"
        Me.chkCreateSoilDepthLayer.UseVisualStyleBackColor = True
        '
        'txtSoilDepthLayerName
        '
        Me.txtSoilDepthLayerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSoilDepthLayerName.Location = New System.Drawing.Point(236, 131)
        Me.txtSoilDepthLayerName.Name = "txtSoilDepthLayerName"
        Me.txtSoilDepthLayerName.Size = New System.Drawing.Size(187, 21)
        Me.txtSoilDepthLayerName.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtSoilDepthLayerName)
        Me.GroupBox2.Controls.Add(Me.chkCreateSoilDepthLayer)
        Me.GroupBox2.Controls.Add(Me.chkCreateSoilTextureLayer)
        Me.GroupBox2.Controls.Add(Me.cmbBaseGridLayer)
        Me.GroupBox2.Controls.Add(Me.labBaseExtentLayer)
        Me.GroupBox2.Controls.Add(Me.txtDestinationFolderPath)
        Me.GroupBox2.Controls.Add(Me.txtSoilTextureLayerName)
        Me.GroupBox2.Controls.Add(Me.btOpenDestinationFolder)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(436, 170)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Results"
        '
        'rbUsingPolygonLayer
        '
        Me.rbUsingPolygonLayer.AutoSize = True
        Me.rbUsingPolygonLayer.Checked = True
        Me.rbUsingPolygonLayer.Location = New System.Drawing.Point(12, 24)
        Me.rbUsingPolygonLayer.Name = "rbUsingPolygonLayer"
        Me.rbUsingPolygonLayer.Size = New System.Drawing.Size(160, 16)
        Me.rbUsingPolygonLayer.TabIndex = 8
        Me.rbUsingPolygonLayer.TabStop = True
        Me.rbUsingPolygonLayer.Text = "Using soil polygon layer"
        Me.rbUsingPolygonLayer.UseVisualStyleBackColor = True
        '
        'rbUsingGridLayer
        '
        Me.rbUsingGridLayer.AutoSize = True
        Me.rbUsingGridLayer.Location = New System.Drawing.Point(245, 24)
        Me.rbUsingGridLayer.Name = "rbUsingGridLayer"
        Me.rbUsingGridLayer.Size = New System.Drawing.Size(175, 16)
        Me.rbUsingGridLayer.TabIndex = 9
        Me.rbUsingGridLayer.Text = "Using soil phase grid layer"
        Me.rbUsingGridLayer.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.rbUsingGridLayer)
        Me.GroupBox3.Controls.Add(Me.rbUsingPolygonLayer)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(434, 52)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select source type"
        '
        'fGRMToolsCreateSoilGridLayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 446)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btMakeSoilGrids)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(464, 38)
        Me.Name = "fGRMToolsCreateSoilGridLayer"
        Me.Text = "Create soil texture and depth grid layers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btMakeSoilGrids As System.Windows.Forms.Button
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents cmbSoilLayer As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btOpenDestinationFolder As System.Windows.Forms.Button
    Friend WithEvents txtSoilTextureLayerName As System.Windows.Forms.TextBox
    Friend WithEvents txtDestinationFolderPath As System.Windows.Forms.TextBox
    Friend WithEvents labBaseExtentLayer As System.Windows.Forms.Label
    Friend WithEvents cmbBaseGridLayer As System.Windows.Forms.ComboBox
    Friend WithEvents chkCreateSoilTextureLayer As System.Windows.Forms.CheckBox
    Friend WithEvents chkCreateSoilDepthLayer As System.Windows.Forms.CheckBox
    Friend WithEvents txtSoilDepthLayerName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbUsingPolygonLayer As System.Windows.Forms.RadioButton
    Friend WithEvents rbUsingGridLayer As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btLoadSoilPhaseVAT As System.Windows.Forms.Button
    Friend WithEvents txtSoilPhaseVATPathName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSoilPhaseField As System.Windows.Forms.ComboBox
End Class
