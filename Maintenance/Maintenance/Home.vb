Public Class Home
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        'code below to comit chnages to the DB  vvvvvvvv

        '----------------------------------
        MessageBox.Show("Data entry saved.")
    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        Me.Hide()


    End Sub

    Private Sub btnEditRecord_Click(sender As Object, e As EventArgs) Handles btnEditRecord.Click
        Me.Hide()
        'frmRecEdit.Show()

    End Sub

    Private Sub btnDeleteRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteRecord.Click
        '------------------------------------------------------------------
        MessageBox.Show("You are not authorized to remove student records.")
    End Sub

    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged

    End Sub
End Class
