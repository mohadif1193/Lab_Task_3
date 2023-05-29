Public Class Loading
    Private Sub timerLoad_Tick(sender As Object, e As EventArgs) Handles timerLoad.Tick

        pbLoading.Value += 1
        If pbLoading.Value = 100 Then
            timerLoad.Dispose()
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class