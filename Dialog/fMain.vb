Public Class fMain
    Private Sub fMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btStartFileProcessing_Click(sender As Object, e As EventArgs) Handles btStartFileProcessing.Click
        Dim fFP As New fRasterFileConverter
        fFP.Show()
    End Sub


    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Me.Close()
    End Sub

    Private Sub btTextFileEdit_Click(sender As Object, e As EventArgs) Handles btTextFileEdit.Click
        Dim fFP As New fFileEdit
        fFP.Show()
    End Sub

    Private Sub btExtractText_Click(sender As Object, e As EventArgs) Handles btExtractText.Click
        Dim fFP As New fExtractValue
        fFP.Show()
    End Sub

    Private Sub btChangeFileName_Click(sender As Object, e As EventArgs) Handles btChangeFileName.Click
        Dim fFP As New fFileName
        fFP.Show()
    End Sub

    Private Sub btASCcalculator_Click(sender As Object, e As EventArgs) Handles btASCcalculator.Click
        Dim fFP As New fCalculator
        fFP.Show()
    End Sub

    Private Sub btConvertCoordSystem_Click(sender As Object, e As EventArgs) Handles btConvertCoordSystem.Click
        Dim fFP As New fConvertCoordiSystem
        fFP.Show()
    End Sub
End Class
