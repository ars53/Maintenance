Public Class frmWelcome
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogOff_Click(sender As Object, e As EventArgs) Handles btnLogOff.Click
        frmLogin.Show()
        Me.Dispose()
    End Sub
End Class