Public Class frmInstructorWelcome
    Protected facID As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub New(ByVal fid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        facID = fid
    End Sub
    Private Sub btnLogOff_Click(sender As Object, e As EventArgs)
        frmLogin.Show()
        Me.Dispose()
    End Sub
End Class