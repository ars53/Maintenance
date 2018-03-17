Imports System.Data.SqlClient
Public Class frmAdd

    Private Sub ckLocalNone_CheckedChanged(sender As Object, e As EventArgs) Handles ckLocalNone.CheckedChanged

        If ckLocalNone.Checked = True Then
            txtCurrentPhone.Text = "None"
            txtCurrentPhone.Enabled = False
        End If

    End Sub

    Private Sub ckWorkNone_CheckedChanged(sender As Object, e As EventArgs) Handles ckWorkNone.CheckedChanged

        If ckWorkNone.Checked = True Then
            txtWorkPhone.Text = "None"
            txtWorkPhone.Enabled = False
        End If

    End Sub

    Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim First As String
        First = txtFirstName.Text

        Dim Last As String
        Last = txtLastName.Text
        lblStudentName.Text = First + Last

        Dim StudId As Integer
        StudId = txtStudentID.Text
        lblStudentID.Text = StudId

        txtDEnrolled.Enabled = False
        txtDDate.Enabled = False
        txtDateAccepted.Enabled = False

    End Sub

    Private Sub txtSEnrolled_TextChanged(sender As Object, e As EventArgs) Handles txtSEnrolled.TextChanged

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim con As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}

        Dim command As New SqlCommand("INSERT StudentID = @StudID,First_Name = @first,Middle_Name = @middle,Last_Name = @last,SSN = @SSN,LocalAddress1 = @LocalAdd1,LocalAddress2 = @LocalAdd2,Local_City = @LocalCity,LocalStateProvince = @LocalStateProvince,LocalZip = @LocalZip,LocalHomePhone = @LocalHomePhone,PermAddress = @PermAdd1,PermAddress2 = @PermAdd2,Perm_City = @PermCity,PermStateProvince = @PermStateProvince,PermZip = @PermZip,PermHomePhone = @PermHomePhone,Email1 = @Email1,Email2 = @Email2,Birthdate = @birthday,Ethnicity = @ethnicity,Gender = @gender,OriginCountry = @origin,Preferred_name = @preferred INTO Student_Header", con)

        'need to fix the data types!
        'command.Parameters.Add("@StudID", SqlDbType.VarChar).Value = txtStudentID.Text
        command.Parameters.Add("@first", SqlDbType.VarChar).Value = txtFirstName.Text
        command.Parameters.Add("@middle", SqlDbType.VarChar).Value = txtMiddleName.Text
        command.Parameters.Add("@last", SqlDbType.VarChar).Value = txtLastName.Text
        'command.Parameters.Add("@SSN", SqlDbType.VarChar).Value = txtSSN.Text
        'local address in form = former address OR Mailing address???????
        'command.Parameters.Add("@LocalAdd1", SqlDbType.VarChar).Value = 
        'command.Parameters.Add("@LocalAdd2", SqlDbType.VarChar).Value = 
        'command.Parameters.Add("@LocalCity", SqlDbType.VarChar).Value = 

        'what is the province? a county???
        'command.Parameters.Add("@LocalStateProvince", SqlDbType.VarChar).Value = 

        'command.Parameters.Add("@LocalZip", SqlDbType.VarChar).Value = 
        'command.Parameters.Add("@LocalHomePhone", SqlDbType.VarChar).Value = txtCurrentPhone.Text
        'permanent address in form = perm
        command.Parameters.Add("@PermAdd1", SqlDbType.VarChar).Value = txtPAddress.Text
        'command.Parameters.Add("@PermAdd2", SqlDbType.VarChar).Value = 
        command.Parameters.Add("@PermCity", SqlDbType.VarChar).Value = txtPCity.Text

        'another province...?
        'command.Parameters.Add("@PermStateProvince", SqlDbType.VarChar).Value = 

        'command.Parameters.Add("@PermZip", SqlDbType.VarChar).Value = txtPZipCode.Text
        'command.Parameters.Add("@PermHomePhone", SqlDbType.VarChar).Value = txtPPhone.Text
        command.Parameters.Add("@Email1", SqlDbType.VarChar).Value = txtEmail.Text

        'no second email field..
        'command.Parameters.Add("@Email2", SqlDbType.VarChar).Value = 

        'command.Parameters.Add("@birthday", SqlDbType.VarChar).Value = txtBirthday1.Text
        'command.Parameters.Add("@ethnicity", SqlDbType.VarChar).Value = cbxEthnic.SelectedText
        command.Parameters.Add("@gender", SqlDbType.VarChar).Value = cbxGender.SelectedText
        'command.Parameters.Add("@origin", SqlDbType.VarChar).Value = cbxOrigin.SelectedText
        command.Parameters.Add("@preferred", SqlDbType.VarChar).Value = txtPreferred.Text

        'so where does this info go???
        'command.Parameters.Add("@citizenship", SqlDbType.VarChar).Value = cbxCitizenship.SelectedText


    End Sub

    Private Sub cbxCitizenship_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCitizenship.SelectedIndexChanged

    End Sub
End Class