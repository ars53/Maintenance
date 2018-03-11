Public Class SemSel
    Private Sub btnSpringInter_Click(sender As Object, e As EventArgs) Handles btnSpringInter.Click
        MessageBox.Show("Following forms are incomplete. Returning to previous Form.")
    End Sub

    Private Sub btnFallInter_Click(sender As Object, e As EventArgs) Handles btnFallInter.Click
        MessageBox.Show("Following forms are incomplete. Returning to previous Form.")
    End Sub

    Private Sub btnSpringFall_Click(sender As Object, e As EventArgs) Handles btnSpringFall.Click
        Me.Hide()
        SpFallAdvise.Show()
    End Sub

    Private Sub lblAdd_Click(sender As Object, e As EventArgs) Handles lblAdd.Click

    End Sub

    Private Sub btnSummer12_Click(sender As Object, e As EventArgs) Handles btnSummer12.Click
        Me.Hide()
        SummerAdvise.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        App1.Show()
    End Sub
End Class