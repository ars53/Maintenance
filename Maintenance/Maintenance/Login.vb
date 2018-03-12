Imports System.Data.SqlClient
Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=arshephe; Trusted_Connection=yes"}
        Dim command As New SqlCommand("Select * FROM Logins_maint where USERNAME = @username AND Password = @password", connection)
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUser.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Wrong password")
        Else
            Welcome.Show()
            Me.Dispose()
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
End Class