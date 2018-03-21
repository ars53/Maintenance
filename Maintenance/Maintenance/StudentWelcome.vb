Imports System.Data.SqlClient
Public Class frmStudentWelcome
    Protected db As New db
    Protected stud As Integer
    Public Sub New(ByVal user As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        stud = user
    End Sub


    Private Sub frmStudentWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function getSID()
        'This function will return the user's name, the sql needs changing once the students info table is created 
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("SELECT * FROM Logins l JOIN  g on g.username = l.username where l.username = @user AND l.password = @pass AND g.studentid is not null", connection)
        command.Parameters.Add("@user", SqlDbType.VarChar).Value = stud


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Return table.Rows(0).Item(4)
    End Function

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        Dim enroll As New frmEnroll(stud)
        enroll.Show()
        Me.Close()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim view As New frmStudentViewRec(stud)
        view.Show()
        Me.Close()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmLogin.Show()
        Me.Close()

    End Sub
End Class