Imports System.Data.SqlClient
Public Class frmStudentWelcome
    Protected db As New db
    Protected stud As String
    Public Sub New(ByVal user As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        stud = user
    End Sub

    Private Sub frmStudentWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.sql = "SELECT * FROM Students where username = @usr"
        db.bind("@usr", stud)
        db.fill(dgvStud)
    End Sub
    Public Function getStudentID() As Integer
        Return getStudentValue("ID")
    End Function
    Public Function getStudentValue(ByVal column As String)
        Return dgvStud.Item(column, dgvStud.CurrentRow.Index).Value
    End Function

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        Dim enroll As New frmEnroll(getStudentID())
        enroll.ShowDialog()
    End Sub
End Class