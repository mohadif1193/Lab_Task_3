Public Class Game
    Private Sub btAtk_Click(sender As Object, e As EventArgs) Handles btAtk.Click
        pbEnemy.Dispose()
        If pbEnemy.IsDisposed Then
            Loading.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btFlee_Click(sender As Object, e As EventArgs) Handles btFlee.Click
        pbPlayer.Dispose()
        If pbPlayer.IsDisposed Then
            Loading.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btBack_Click(sender As Object, e As EventArgs) Handles btBack.Click
        Loading.Show()
        Me.Hide()
    End Sub
End Class