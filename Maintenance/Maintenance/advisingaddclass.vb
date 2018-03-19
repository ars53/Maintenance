Public Class frmadvisingaddclass
    Protected db As New db
    Protected aid As Integer
    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        aid = id
    End Sub

    Private Sub frmadvisingaddclass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.sql = "SELECT * FROM Classes"
        db.fill(dgvClasses)
    End Sub
    Public Function getClassID() As String
        Return getClassValue("ClassName")
    End Function
    Public Function getClassValue(ByVal column As String)
        Return dgvClasses.Item(column, dgvClasses.CurrentRow.Index).Value
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        db.sql = "INSERT INTO adv_cls_asc (advisingID, classname, section, semy) values (@aid, @nam, @sec, @semy)"
        db.bind("@aid", aid)
        db.bind("@nam", getClassID())
        db.bind("@sec", getClassValue("section"))
        db.bind("@semy", getClassValue("SemY"))
        db.execute()
        Me.Close()

    End Sub
End Class