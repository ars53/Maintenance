Imports System.Data.SqlClient
Public Class frmEnroll
    Protected db As New db
    Protected sid As Integer
    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sid = id
    End Sub
    Private Sub frmEnroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = sid
    End Sub
End Class