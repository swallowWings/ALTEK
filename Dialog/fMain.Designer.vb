<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMain
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
        Me.btStartFileProcessing = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btTextFileEdit = New System.Windows.Forms.Button()
        Me.btGetText = New System.Windows.Forms.Button()
        Me.btChangeFileName = New System.Windows.Forms.Button()
        Me.btASCcalculator = New System.Windows.Forms.Button()
        Me.btConvertCoordSystem = New System.Windows.Forms.Button()
        Me.btAppendFiles = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btStartFileProcessing
        '
        Me.btStartFileProcessing.BackColor = System.Drawing.Color.Khaki
        Me.btStartFileProcessing.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.btStartFileProcessing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btStartFileProcessing.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btStartFileProcessing.Location = New System.Drawing.Point(32, 29)
        Me.btStartFileProcessing.Name = "btStartFileProcessing"
        Me.btStartFileProcessing.Size = New System.Drawing.Size(273, 40)
        Me.btStartFileProcessing.TabIndex = 0
        Me.btStartFileProcessing.Text = "Raster files converter"
        Me.btStartFileProcessing.UseVisualStyleBackColor = False
        '
        'btClose
        '
        Me.btClose.BackColor = System.Drawing.Color.BurlyWood
        Me.btClose.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood
        Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btClose.Location = New System.Drawing.Point(195, 393)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(110, 30)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = False
        '
        'btTextFileEdit
        '
        Me.btTextFileEdit.BackColor = System.Drawing.Color.Khaki
        Me.btTextFileEdit.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.btTextFileEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTextFileEdit.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btTextFileEdit.Location = New System.Drawing.Point(32, 234)
        Me.btTextFileEdit.Name = "btTextFileEdit"
        Me.btTextFileEdit.Size = New System.Drawing.Size(273, 40)
        Me.btTextFileEdit.TabIndex = 2
        Me.btTextFileEdit.Text = "Text files editor"
        Me.btTextFileEdit.UseVisualStyleBackColor = False
        '
        'btGetText
        '
        Me.btGetText.BackColor = System.Drawing.Color.Khaki
        Me.btGetText.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.btGetText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGetText.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btGetText.Location = New System.Drawing.Point(32, 185)
        Me.btGetText.Name = "btGetText"
        Me.btGetText.Size = New System.Drawing.Size(273, 40)
        Me.btGetText.TabIndex = 1
        Me.btGetText.Text = "Get values from text files"
        Me.btGetText.UseVisualStyleBackColor = False
        '
        'btChangeFileName
        '
        Me.btChangeFileName.BackColor = System.Drawing.Color.Khaki
        Me.btChangeFileName.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.btChangeFileName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btChangeFileName.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btChangeFileName.Location = New System.Drawing.Point(32, 334)
        Me.btChangeFileName.Name = "btChangeFileName"
        Me.btChangeFileName.Size = New System.Drawing.Size(273, 40)
        Me.btChangeFileName.TabIndex = 3
        Me.btChangeFileName.Text = "File name processor"
        Me.btChangeFileName.UseVisualStyleBackColor = False
        '
        'btASCcalculator
        '
        Me.btASCcalculator.BackColor = System.Drawing.Color.Khaki
        Me.btASCcalculator.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.btASCcalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btASCcalculator.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btASCcalculator.Location = New System.Drawing.Point(32, 80)
        Me.btASCcalculator.Name = "btASCcalculator"
        Me.btASCcalculator.Size = New System.Drawing.Size(273, 43)
        Me.btASCcalculator.TabIndex = 4
        Me.btASCcalculator.Text = "ASCII raster calculator"
        Me.btASCcalculator.UseVisualStyleBackColor = False
        '
        'btConvertCoordSystem
        '
        Me.btConvertCoordSystem.BackColor = System.Drawing.Color.Khaki
        Me.btConvertCoordSystem.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.btConvertCoordSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConvertCoordSystem.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btConvertCoordSystem.Location = New System.Drawing.Point(32, 133)
        Me.btConvertCoordSystem.Name = "btConvertCoordSystem"
        Me.btConvertCoordSystem.Size = New System.Drawing.Size(273, 43)
        Me.btConvertCoordSystem.TabIndex = 5
        Me.btConvertCoordSystem.Text = "Coordinate system converter"
        Me.btConvertCoordSystem.UseVisualStyleBackColor = False
        '
        'btAppendFiles
        '
        Me.btAppendFiles.BackColor = System.Drawing.Color.Khaki
        Me.btAppendFiles.FlatAppearance.BorderColor = System.Drawing.Color.Khaki
        Me.btAppendFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAppendFiles.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btAppendFiles.Location = New System.Drawing.Point(32, 284)
        Me.btAppendFiles.Name = "btAppendFiles"
        Me.btAppendFiles.Size = New System.Drawing.Size(273, 40)
        Me.btAppendFiles.TabIndex = 6
        Me.btAppendFiles.Text = "Append text files"
        Me.btAppendFiles.UseVisualStyleBackColor = False
        '
        'fMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(334, 435)
        Me.Controls.Add(Me.btAppendFiles)
        Me.Controls.Add(Me.btConvertCoordSystem)
        Me.Controls.Add(Me.btASCcalculator)
        Me.Controls.Add(Me.btChangeFileName)
        Me.Controls.Add(Me.btGetText)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btTextFileEdit)
        Me.Controls.Add(Me.btStartFileProcessing)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(350, 474)
        Me.MinimumSize = New System.Drawing.Size(350, 474)
        Me.Name = "fMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "ALTEK - v.2020.04.09"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btStartFileProcessing As Button
    Friend WithEvents btClose As Button
    Friend WithEvents btTextFileEdit As Button
    Friend WithEvents btGetText As Button
    Friend WithEvents btChangeFileName As Button
    Friend WithEvents btASCcalculator As Button
    Friend WithEvents btConvertCoordSystem As Button
    Friend WithEvents btAppendFiles As Button
End Class
