Public Class frmAdd

    Private Sub ckLocalNone_CheckedChanged(sender As Object, e As EventArgs) Handles ckLocalNone.CheckedChanged

        If ckLocalNone.Checked = True Then
            txtCurrentPhone.Text = "None"
            txtCurrentPhone.Enabled = False
        End If

    End Sub

    Private Sub ckWorkNone_CheckedChanged(sender As Object, e As EventArgs) Handles ckWorkNone.CheckedChanged

        If ckWorkNone.Checked = True Then
            txtWorkPhone.Text = "None"
            txtWorkPhone.Enabled = False
        End If

    End Sub

    Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim First As String
        First = txtFirstName.Text

        Dim Last As String
        Last = txtLastName.Text
        lblStudentName.Text = First + Last

        Dim StudId As Integer
        StudId = txtStudentID.Text
        lblStudentID.Text = StudId

        txtDEnrolled.Enabled = False
        txtDDate.Enabled = False
        txtDateAccepted.Enabled = False

    End Sub

    Private Sub txtSEnrolled_TextChanged(sender As Object, e As EventArgs) Handles txtSEnrolled.TextChanged

    End Sub
End Class