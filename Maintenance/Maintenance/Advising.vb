Imports System.Data.SqlClient
Public Class frmAdvising
    Private Sub frmAdvising_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim Char_Term As String
        Char_Term = ""

        Dim intIDNum As Integer
        'intIDNum = Convert.ToInt(txtIDNum.Text)
        If IsNumeric(txtIDNum.Text) = True Then
            intIDNum = txtIDNum.Text
        Else
            MsgBox("ID num is not numeric")
        End If


        If lstTerm.SelectedIndex = 0 Then
            Char_Term = "S1"
        ElseIf lstTerm.SelectedIndex = 1 Then
            Char_Term = "S2"
        ElseIf lstTerm.SelectedIndex = 2 Then
            Char_Term = "S3"
        ElseIf lstTerm.SelectedIndex = 3 Then
            Char_Term = "FL"
        ElseIf lstTerm.SelectedIndex = 4 Then
            Char_Term = "SP"
        Else messagebox.Show("Please Select A Term")
        End If


        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=ISYS4283F1759; Trusted_Connection=yes"}
        'Dim command As New SqlCommand("Select * FROM Logins_maint where USERNAME = @username AND Password = @password AND instructor = 1", connection)
        Dim command As New SqlCommand("Insert Into advising values ( @FirstName, @MiddleName, @LastName, @IDNumber, @Major, @Term, @Year, @Classes, @Section, @Time, @Comments )", connection)

        command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = txtFName.Text
        command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = txtLName.Text
        command.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = txtMName.Text
        command.Parameters.Add("@IDNumber", SqlDbType.Int).Value = intIDNum
        command.Parameters.Add("@Major", SqlDbType.VarChar).Value = txtMajor.Text
        command.Parameters.Add("@Term", SqlDbType.Char).Value = Char_Term
        command.Parameters.Add("@Year", SqlDbType.VarChar).Value = txtTermYear.Text
        command.Parameters.Add("@Classes", SqlDbType.VarChar).Value = "test"
        command.Parameters.Add("@Section", SqlDbType.Int).Value = 1
        command.Parameters.Add("@Time", SqlDbType.VarChar).Value = "1111"
        command.Parameters.Add("@Comments", SqlDbType.VarChar).Value = txtComments.Text

        'Need trycatch
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()


        'Dim adapter As New SqlDataAdapter(command)
        'Dim table As New DataTable()
        'adapter.Fill(table)
        'If table.Rows.Count() <= 0 Then
        '    MsgBox("Wrong password")

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtFName.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClass0.Clear()
        txtClass1.Clear()
        txtClass2.Clear()
        txtClass3.Clear()
        txtClass4.Clear()
        txtClass5.Clear()
        txtClass6.Clear()
        txtComments.Clear()
        txtFName.Clear()
        txtIDNum.Clear()
        txtLName.Clear()
        txtMajor.Clear()
        txtMName.Clear()
        txtSection0.Clear()
        txtSection1.Clear()
        txtSection2.Clear()
        txtSection3.Clear()
        txtSection4.Clear()
        txtSection5.Clear()
        txtSection6.Clear()
        txtTermYear.Clear()
        txtTime0.Clear()
        txtTime1.Clear()
        txtTime2.Clear()
        txtTime3.Clear()
        txtTime4.Clear()
        txtTime5.Clear()
        txtTime6.Clear()
        lstTerm.SelectedIndex = -1
    End Sub
End Class