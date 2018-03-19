Imports System.Data.SqlClient
Public Class frmAdvisingp1
    Protected db As New db
    Protected FID As Integer
    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FID = id
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        db.sql = "INSERT INto advising (First_Name, Middle_Name, Last_Name, StudentID, Major, advisorid, semy) values (@first, @middle, @last, @sid, @major, @FID, @semy)"
        db.bind("@first", txtFName.Text)
        db.bind("@middle", txtMName.Text)
        db.bind("@last", txtLName.Text)
        db.bind("@sid", txtIDNum.Text)
        db.bind("@major", txtMajor.Text)
        db.bind("@fid", FID)
        db.bind("@semy", txtSemy.Text)
        db.execute()

        'Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        'Dim command As New SqlCommand("SELECT Max(advisingid) FROM Advising", connection)
        'Dim adapter As New SqlDataAdapter(command)
        'Dim table As New DataTable()
        'adapter.Fill(table)
        'If table.Rows.Count() <= 0 Then
        ' MsgBox("Wrong password")
        ' Else
        ' Dim adviseid = (table.Rows(0).Item(0))
        ' Dim advisesession As New frmadvisingp2(adviseid)
        ' advisesession.ShowDialog()

        '        End If
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim sessionID = InputBox("Input the session you wish to make changes to")
        Dim advisesession As New frmadvisingp2(sessionID)

        'advisesession.ShowDialog()
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("SELECT Max(advisingid) FROM Advising", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then

        ElseIf table.Rows(0).Item(0) < sessionID Then
            MsgBox("This is not a valid session")

        Else

            advisesession.ShowDialog()
        End If
    End Sub
End Class