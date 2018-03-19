Public Class frmAdvisingEnroll
    Protected adv As Date
    Protected id As Integer
    Protected db As New db
    Public Sub New(ByVal d As Date, i As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        adv = d
        id = i
    End Sub

    Private Sub frmAdvisingEnroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.sql = "SELECT"
    End Sub
End Class