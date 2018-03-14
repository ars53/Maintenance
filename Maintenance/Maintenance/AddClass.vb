Public Class frmAddClass
    Protected db As New db
    Protected sid As Integer
    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sid = id
    End Sub
    Private Sub AddClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.sql = "SELECT * FROM Classes"
        db.fill(dgvClasses)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        db.sql = "INSERT INTO Enrollment values (@sid, @classname)"
        db.bind("@sid", sid)
        db.bind("@classname", getClassID())
        db.execute()
        Me.Close()
    End Sub
    Public Function getClassID() As String
        Return getClassValue("Name")
    End Function
    Public Function getClassValue(ByVal column As String)
        Return dgvClasses.Item(column, dgvClasses.CurrentRow.Index).Value
    End Function
End Class