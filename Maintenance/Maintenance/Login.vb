Imports System.Data.SqlClient
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If radFaculty.Checked = True Then
            Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
            Dim command As New SqlCommand("SELECT * FROM Logins l JOIN usernames g on g.username = l.username where l.username = @user AND l.password = @pass AND g.instructorid is not null", connection)
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUser.Text
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count() <= 0 Then
                MsgBox("Wrong password")
            Else
                Dim teachid = (table.Rows(0).Item(4))
                Dim adminwelcome As New frmInstructorWelcome(teachid)
                adminwelcome.Show()
                Me.Dispose()
                Me.Close()
            End If
        ElseIf radStudent.Checked = True Then
            Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
            Dim command As New SqlCommand("SELECT * FROM Logins l JOIN Usernames g on g.username = l.username where l.username = @user AND l.password = @pass AND g.studentid is not null", connection)
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUser.Text
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count() <= 0 Then
                MsgBox("Wrong password")
            Else
                Dim studentid = (table.Rows(0).Item(3))
                Dim welcome As New frmStudentWelcome(studentid)
                welcome.Show()
                'Me.Dispose()
                Me.Close()
            End If
        ElseIf (radFaculty.Checked = False And radStudent.Checked = False) Or (txtUser.Text.Length = 0 Or txtPassword.Text.Length = 0) Then
            If txtUser.Text.Length = 0 Then
                MsgBox("Please enter a username")
            ElseIf txtPassword.Text.Length = 0 Then
                MsgBox("Please enter a password")
            Else
                MsgBox("Please select either faculty or student option")
            End If
        ElseIf txtPassword.Text.Length = 0 Or txtUser.Text.Length = 0 Then

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPassword.Clear()
        txtUser.Clear()
        txtUser.Focus()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Focus()
        txtPassword.Clear()
        txtUser.Clear()
    End Sub


    Private Sub linkNewUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkNewUser.LinkClicked
        frmAdd.Show()
        Me.Dispose()
        Me.Close()

    End Sub
End Class