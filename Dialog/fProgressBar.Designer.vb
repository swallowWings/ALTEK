<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fProgressBar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fProgressBar))
        Me.GRMToolsPrograssBar = New System.Windows.Forms.ProgressBar()
        Me.labGRMToolsPrograssBar = New System.Windows.Forms.Label()
        Me.btStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GRMToolsPrograssBar
        '
        Me.GRMToolsPrograssBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GRMToolsPrograssBar.Location = New System.Drawing.Point(22, 32)
        Me.GRMToolsPrograssBar.Name = "GRMToolsPrograssBar"
        Me.GRMToolsPrograssBar.Size = New System.Drawing.Size(421, 23)
        Me.GRMToolsPrograssBar.TabIndex = 0
        '
        'labGRMToolsPrograssBar
        '
        Me.labGRMToolsPrograssBar.AutoSize = True
        Me.labGRMToolsPrograssBar.Location = New System.Drawing.Point(20, 9)
        Me.labGRMToolsPrograssBar.Name = "labGRMToolsPrograssBar"
        Me.labGRMToolsPrograssBar.Size = New System.Drawing.Size(42, 12)
        Me.labGRMToolsPrograssBar.TabIndex = 1
        Me.labGRMToolsPrograssBar.Text = "Label1"
        '
        'btStop
        '
        Me.btStop.Location = New System.Drawing.Point(368, 3)
        Me.btStop.Name = "btStop"
        Me.btStop.Size = New System.Drawing.Size(75, 23)
        Me.btStop.TabIndex = 2
        Me.btStop.Text = "Stop"
        Me.btStop.UseVisualStyleBackColor = True
        '
        'fProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 67)
        Me.Controls.Add(Me.btStop)
        Me.Controls.Add(Me.labGRMToolsPrograssBar)
        Me.Controls.Add(Me.GRMToolsPrograssBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(482, 105)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(482, 105)
        Me.Name = "fProgressBar"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GRMToolsPrograssBar As System.Windows.Forms.ProgressBar
    Friend WithEvents labGRMToolsPrograssBar As System.Windows.Forms.Label
    Friend WithEvents btStop As System.Windows.Forms.Button
End Class
