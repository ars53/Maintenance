Public Class frmAdvisingEnroll
    Protected adv As Date
    Protected id As Integer
    Protected db As New db
    Public Sub New(ByVal i As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        id = i
    End Sub

    Private Sub frmAdvisingEnroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.sql = "SELECT a.ClassName, a.Section, a.semy FROM adv_cls_asc a join advising b on a.advisingid = b.advisingid WHERE b.advisingid = (SELECT MAX(advisingID) FROM Advising where studentid = @sid)"
        db.bind("@sid", id)
        db.fill(dgvAdEnroll)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim rows As Integer
        rows = dgvAdEnroll.Rows.Count - 2
        For i As Integer = 0 To rows Step 1
            db.sql = "INSERT INTO Enrollment (Classname, studentid, section, semy) values (@cname, @sid, @sec, @semy)"
            db.bind("@cname", dgvAdEnroll.Item(0, i).Value)
            db.bind("@sid", id)
            db.bind("@sec", dgvAdEnroll.Item(1, i).Value)
            db.bind("@semy", dgvAdEnroll.Item(2, i).Value)
            db.execute()
            
        Next
        Me.Close()

    End Sub
End Class