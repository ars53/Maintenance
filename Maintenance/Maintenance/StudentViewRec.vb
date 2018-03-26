Imports System.Data.SqlClient
Public Class frmStudentViewRec
    Protected db As New db
    Protected sid As Integer
    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sid = id
    End Sub
    Private Sub loadValues()
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("SELECT * FROM Student_header where studentid = @user", connection)
        command.Parameters.Add("@user", SqlDbType.VarChar).Value = sid

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then

        Else
            lblNameFD.Text = table.Rows(0).Item(1).ToString
            lblMND.Text = table.Rows(0).Item(2).ToString
            lblLND.Text = table.Rows(0).Item(3).ToString
            lblSSND.Text = table.Rows(0).Item(4).ToString
            ldlLocalAdr.Text = table.Rows(0).Item(5).ToString
            lblLocalADR2D.Text = table.Rows(0).Item(6).ToString
            lblCityDL.Text = table.Rows(0).Item(7).ToString
            lblStateI.Text = table.Rows(0).Item(8).ToString
            lblZipLocal.Text = table.Rows(0).Item(9).ToString
            lblPermADR1.Text = table.Rows(0).Item(11).ToString
            lblPermAdr2.Text = table.Rows(0).Item(12).ToString
            lblPermCity.Text = table.Rows(0).Item(13).ToString
            lblPermState.Text = table.Rows(0).Item(14).ToString
            lblPermZip.Text = table.Rows(0).Item(15).ToString
            lblPermCountry.Text = table.Rows(0).Item(22).ToString



        End If
    End Sub

    Private Sub frmStudentViewRec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadValues()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Show()
        Me.Close()
    End Sub
    'Public Function getEnrollID() As String
    ' Return getEnrollValue("ClassName")
    ' End Function
    ' Public Function getEnrollValue(ByVal column As String)
    'Return table.Item(column, dgvEnroll.CurrentRow.Index).Value
    'End Function
End Class