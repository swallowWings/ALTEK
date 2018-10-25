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
        Me.btExtractText = New System.Windows.Forms.Button()
        Me.btChangeFileName = New System.Windows.Forms.Button()
        Me.btASCcalculator = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btStartFileProcessing
        '
        Me.btStartFileProcessing.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btStartFileProcessing.Location = New System.Drawing.Point(43, 32)
        Me.btStartFileProcessing.Name = "btStartFileProcessing"
        Me.btStartFileProcessing.Size = New System.Drawing.Size(398, 40)
        Me.btStartFileProcessing.TabIndex = 0
        Me.btStartFileProcessing.Text = "Raster files converter"
        Me.btStartFileProcessing.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Location = New System.Drawing.Point(331, 291)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(110, 30)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btTextFileEdit
        '
        Me.btTextFileEdit.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btTextFileEdit.Location = New System.Drawing.Point(43, 188)
        Me.btTextFileEdit.Name = "btTextFileEdit"
        Me.btTextFileEdit.Size = New System.Drawing.Size(398, 40)
        Me.btTextFileEdit.TabIndex = 2
        Me.btTextFileEdit.Text = "Text files editor"
        Me.btTextFileEdit.UseVisualStyleBackColor = True
        '
        'btExtractText
        '
        Me.btExtractText.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btExtractText.Location = New System.Drawing.Point(43, 137)
        Me.btExtractText.Name = "btExtractText"
        Me.btExtractText.Size = New System.Drawing.Size(398, 40)
        Me.btExtractText.TabIndex = 1
        Me.btExtractText.Text = "Values extractor from text files"
        Me.btExtractText.UseVisualStyleBackColor = True
        '
        'btChangeFileName
        '
        Me.btChangeFileName.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btChangeFileName.Location = New System.Drawing.Point(43, 239)
        Me.btChangeFileName.Name = "btChangeFileName"
        Me.btChangeFileName.Size = New System.Drawing.Size(398, 40)
        Me.btChangeFileName.TabIndex = 3
        Me.btChangeFileName.Text = "File name processor"
        Me.btChangeFileName.UseVisualStyleBackColor = True
        '
        'btASCcalculator
        '
        Me.btASCcalculator.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btASCcalculator.Location = New System.Drawing.Point(43, 83)
        Me.btASCcalculator.Name = "btASCcalculator"
        Me.btASCcalculator.Size = New System.Drawing.Size(398, 43)
        Me.btASCcalculator.TabIndex = 4
        Me.btASCcalculator.Text = "ASCII raster calculator"
        Me.btASCcalculator.UseVisualStyleBackColor = True
        '
        'fMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 332)
        Me.Controls.Add(Me.btASCcalculator)
        Me.Controls.Add(Me.btChangeFileName)
        Me.Controls.Add(Me.btExtractText)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btTextFileEdit)
        Me.Controls.Add(Me.btStartFileProcessing)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(503, 371)
        Me.MinimumSize = New System.Drawing.Size(503, 371)
        Me.Name = "fMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Tok - Text file? It's OK!  v.2018.10.25"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btStartFileProcessing As Button
    Friend WithEvents btClose As Button
    Friend WithEvents btTextFileEdit As Button
    Friend WithEvents btExtractText As Button
    Friend WithEvents btChangeFileName As Button
    Friend WithEvents btASCcalculator As Button
End Class
