Public Class Form2
    Private Sub btnSpringInter_Click(sender As Object, e As EventArgs) Handles btnSpringInter.Click
        MessageBox.Show("Following forms are incomplete. Returning to previous Form.")
    End Sub

    Private Sub btnFallInter_Click(sender As Object, e As EventArgs) Handles btnFallInter.Click
        MessageBox.Show("Following forms are incomplete. Returning to previous Form.")
    End Sub

    Private Sub btnSpringFall_Click(sender As Object, e As EventArgs) Handles btnSpringFall.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub lblAdd_Click(sender As Object, e As EventArgs) Handles lblAdd.Click

    End Sub

    Private Sub btnSummer12_Click(sender As Object, e As EventArgs) Handles btnSummer12.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class