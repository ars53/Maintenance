Imports System.Data.SqlClient
Public Class frmAcceptDecline
    Protected db As New db
    Protected id As Integer
    Public Sub New(ByVal FID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        id = FID
    End Sub

    Private Sub frmAcceptDecline_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filldgv()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rowcount As Integer
        rowcount = dgvAccept.Rows.Count - 2

        For i As Integer = 0 To rowcount
            If dgvAccept.Item(4, i).Value < 490 Then
                db.sql = "UPDATE Status set admittedyn = @no, changedby = @fid WHERE studentid = @sid"
                db.bind("@no", "n")
                db.bind("@fid", id)
                db.bind("@sid", dgvAccept.Item(0, i).Value)
                db.execute()
            End If

        Next
        filldgv()

    End Sub
    Private Sub filldgv()
        db.sql = "SELECT s.StudentID, s.DateApplied, s.GMATVerbal, s.GMATQuant, s.GMATTotal, s.LOR1, s.LOR2, s.LOR3 FROM Studentapp s join status t on s.StudentID = t.StudentID Where t.AdmittedYN is null"
        db.fill(dgvAccept)
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        db.sql = "UPDATE Status set admittedyn = @yes, changedby = @fid where studentid = @sid"
        db.bind("@yes", "y")
        db.bind("@fid", id)
        db.bind("@sid", getStudentID())
        db.execute()
        filldgv()
        filldgv()


    End Sub
    Public Function getStudentID() As String
        Return getClassValue("StudentID")
    End Function
    Public Function getClassValue(ByVal column As String)
        Return dgvAccept.Item(column, dgvAccept.CurrentRow.Index).Value
    End Function
End Class