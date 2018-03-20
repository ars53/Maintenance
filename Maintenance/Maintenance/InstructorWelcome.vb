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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub btnAdvising_Click(sender As Object, e As EventArgs) Handles btnAdvising.Click
        Dim advise As New frmAdvisingp1(facID)
        advise.Show()
        Me.Close()

    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim accept As New frmAcceptDecline(facID)
        accept.ShowDialog()

    End Sub
End Class