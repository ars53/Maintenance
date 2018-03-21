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
        db.sql = "SELECT * FROM Classes where classname not in (SELECT Classname from enrollment where studentid = @sid)"
        db.bind("@sid", sid)
        db.fill(dgvClasses)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        db.sql = "INSERT INTO Enrollment (Classname, studentid, section, semy) values (@name, @sid, @sec, @semy)"
        db.bind("@sid", sid)
        db.bind("@name", getClassID())
        db.bind("@sec", getClassValue("Section"))
        db.bind("@semy", getClassValue("SemY"))
        db.execute()
        Me.Close()


    End Sub
    Public Sub FillClass()
    End Sub
    Public Function getClassID() As String
        Return getClassValue("ClassName")
    End Function
    Public Function getClassValue(ByVal column As String)
        Return dgvClasses.Item(column, dgvClasses.CurrentRow.Index).Value
    End Function
End Class