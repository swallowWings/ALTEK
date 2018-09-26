Public Class fProgressBar
    Public Event StopProcess(ByVal sender As fProgressBar)

    Private Sub btStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStop.Click
        RaiseEvent StopProcess(Me)
    End Sub

End Class