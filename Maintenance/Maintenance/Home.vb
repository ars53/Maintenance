Public Class Home
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click

    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        Me.Hide()


    End Sub

    Private Sub btnEditRecord_Click(sender As Object, e As EventArgs) Handles btnEditRecord.Click
        Me.Hide()
        RecEdit.Show()

    End Sub
End Class
