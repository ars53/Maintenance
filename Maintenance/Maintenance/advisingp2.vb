Imports System.Data.SqlClient
Public Class frmadvisingp2
    Protected db As New db
    Protected aid As Integer
    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        aid = id
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("SELECT Comments FROM Advising WHERE advisingid = @aid", connection)
        command.Parameters.Add("@aid", SqlDbType.VarChar).Value = aid
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            ' MsgBox("Wrong password")
        Else
            Dim comment = (table.Rows(0).Item(0))
            txtComments.Text = comment.ToString

        End If

    End Sub
    Private Sub populateClasses()
        db.sql = "SELECT * From adv_cls_asc a JOIN Advising b on a.advisingid = b.advisingid WHERE b.advisingid = @aid"
        db.bind("@aid", aid)
        db.fill(dgvAdviseclasses)
    End Sub

    Private Sub frmadvisingp2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateClasses()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addCourse As New frmadvisingaddclass(aid)
        addCourse.ShowDialog()
        populateClasses()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        db.sql = "UPDATE Advising set comments = @comment WHERE advisingID = @aid"
        db.bind("@comment", txtComments.Text)
        db.bind("@aid", aid)
        db.execute()
        Me.Close()


    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        db.sql = "DELETE FROM Adv_cls_asc where Classname = @class AND advisingid = @aid AND SemY = @sem"
        db.bind("@class", getEnrollValue("Classname"))
        db.bind("@sem", getEnrollValue("semy"))
        db.bind("@aid", aid)
        db.execute()
        populateClasses()

    End Sub
    Public Function getEnrollID() As String
        Return getEnrollValue("ClassName")
    End Function
    Public Function getEnrollValue(ByVal column As String)
        Return dgvAdviseclasses.Item(column, dgvAdviseclasses.CurrentRow.Index).Value
    End Function
End Class