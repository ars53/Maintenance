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
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("SELECT StudentID, First_name, middle_name, last_name FROM Student_Header WHERE studentid = @sid", connection)
        command.Parameters.Add("@sid", SqlDbType.VarChar).Value = txtIDNum.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("This student ID is not registered")
        ElseIf table.Rows(0).Item(1) <> txtFName.Text Then
            MsgBox("The entered first name is not registered to this student ID")
        ElseIf table.Rows(0).Item(2) <> txtMName.Text Then
            MsgBox("The entered middle name is not registered to this student ID")
        ElseIf table.Rows(0).Item(3) <> txtLName.Text Then
            MsgBox("The entered last name is not registered to this student id")

        Else



            db.sql = "INSERT INto advising (First_Name, Middle_Name, Last_Name, StudentID, Major, advisorid, semy) values (@first, @middle, @last, @sid, @major, @FID, @semy)"
            db.bind("@first", txtFName.Text)
            db.bind("@middle", txtMName.Text)
            db.bind("@last", txtLName.Text)
            db.bind("@sid", txtIDNum.Text)
            db.bind("@major", txtMajor.Text)
            db.bind("@fid", FID)
            db.bind("@semy", txtSemy.Text)
            db.execute()

            Dim connection1 As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
            Dim command1 As New SqlCommand("SELECT Max(advisingid) FROM Advising", connection)
            Dim adapter1 As New SqlDataAdapter(command1)
            Dim table1 As New DataTable()
            adapter1.Fill(table1)
            If table1.Rows.Count() <= 0 Then
                'MsgBox("Wrong password")
            Else
                Dim adviseid = (table1.Rows(0).Item(0))
                Dim advisesession As New frmadvisingp2(adviseid)
                advisesession.ShowDialog()

                'advisesession.ShowDialog()
            End If
        End If



    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim sessionID = InputBox("Input the session you wish to make changes to")
        If sessionID = "" Or sessionID = 0 Then
            MsgBox("Please Enter a session ID")
        Else
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
        End If

    End Sub
End Class