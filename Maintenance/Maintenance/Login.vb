Imports System.Data.SqlClient
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If radFaculty.Checked = True Then
            Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=arshephe; Trusted_Connection=yes"}
            Dim command As New SqlCommand("Select * FROM Logins_maint where USERNAME = @username AND Password = @password AND instructor = 1", connection)
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUser.Text
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count() <= 0 Then
                MsgBox("Wrong password")
            Else
                frmAdvising.Show()
                Me.Dispose()
            End If
        ElseIf radStudent.Checked = True Then
            Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=arshephe; Trusted_Connection=yes"}
            Dim command As New SqlCommand("Select * FROM Logins_maint where USERNAME = @username AND Password = @password AND student = 1 ", connection)
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUser.Text
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count() <= 0 Then
                MsgBox("Wrong password")
            Else
                Dim welcome As New frmStudentWelcome(txtUser.Text.ToString)
                welcome.Show()
                Me.Dispose()
                Me.Close()
            End If

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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub linkNewUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkNewUser.LinkClicked
        frmAdd.Show()
        Me.Dispose()
        Me.Close()

    End Sub
End Class