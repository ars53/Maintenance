Public Class frmWelcome
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogOff_Click(sender As Object, e As EventArgs)
        frmLogin.Show()
        Me.Dispose()
    End Sub

    Private Sub btnAdvising_Click(sender As Object, e As EventArgs) Handles btnAdvising.Click
        frmAdvising.Show()
        Me.Dispose()

    End Sub
End Class