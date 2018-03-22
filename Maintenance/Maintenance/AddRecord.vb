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

        command.Parameters.Add("@StudID", SqlDbType.Int).Value = txtStudentID.Text
        command.Parameters.Add("@first", SqlDbType.VarChar).Value = txtFirstName.Text
        command.Parameters.Add("@middle", SqlDbType.VarChar).Value = txtMiddleName.Text
        command.Parameters.Add("@last", SqlDbType.VarChar).Value = txtLastName.Text
        command.Parameters.Add("@SSN", SqlDbType.VarChar).Value = txtSSN.Text
        'local address in form = Mailing address
        command.Parameters.Add("@LocalAdd1", SqlDbType.VarChar).Value = txtLAddress.Text
        'no second address line added to form to fit DB
        command.Parameters.Add("@LocalAdd2", SqlDbType.VarChar).Value = txtLocalLine2
        command.Parameters.Add("@LocalCity", SqlDbType.VarChar).Value = txtLCity.Text
        'for the sake of this, province = county
        'had to add county field for each address
        command.Parameters.Add("@LocalStateProvince", SqlDbType.VarChar).Value = txtLocalCounty.Text
        command.Parameters.Add("@LocalZip", SqlDbType.Int).Value = txtLZipCode.Text
        command.Parameters.Add("@LocalHomePhone", SqlDbType.Int).Value = txtCurrentPhone.Text
        command.Parameters.Add("@PermAdd1", SqlDbType.VarChar).Value = txtPAddress.Text
        command.Parameters.Add("@PermAdd2", SqlDbType.VarChar).Value = txtPermLine2
        command.Parameters.Add("@PermCity", SqlDbType.VarChar).Value = txtPCity.Text
        command.Parameters.Add("@PermStateProvince", SqlDbType.VarChar).Value = txtPermCounty
        command.Parameters.Add("@PermZip", SqlDbType.Int).Value = txtPZipCode.Text
        command.Parameters.Add("@PermHomePhone", SqlDbType.Int).Value = txtPPhone.Text
        command.Parameters.Add("@Email1", SqlDbType.VarChar).Value = txtEmail.Text
        'no second email field originally, has been added to form to fit DB
        command.Parameters.Add("@Email2", SqlDbType.VarChar).Value = txtEmail2.Text
        command.Parameters.Add("@birthday", SqlDbType.DateTime).Value = txtBirthday1.Text
        'why is this set to a 1 number int variable? will selected index work?
        command.Parameters.Add("@ethnicity", SqlDbType.Int).Value = cbxEthnic.SelectedIndex
        command.Parameters.Add("@gender", SqlDbType.Char).Value = cbxGender.SelectedText
        command.Parameters.Add("@origin", SqlDbType.VarChar).Value = cbxOrigin.SelectedText
        command.Parameters.Add("@preferred", SqlDbType.VarChar).Value = txtPreferred.Text
        '---------------------NOTES-------------------------------
        'data types vaerified and accurate 

        'exists on the form without a DB place...
        'command.Parameters.Add("@citizenship", SqlDbType.VarChar).Value = cbxCitizenship.SelectedText


    End Sub

    Private Sub cbxCitizenship_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCitizenship.SelectedIndexChanged

    End Sub

    Private Sub btnConfirm2_Click(sender As Object, e As EventArgs) Handles btnConfirm2.Click
        Dim con As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        'below connection needs proper table name to insert into
        'Dim command As New SqlCommand("INSERT  INTO Student_", con)

        'need to fix the data types!
        'need name of coulms in table to data entry
        'command.Parameters.Add("@year", SqlDbType.VarChar).Value = txtRequestYear.Text
        'command.Parameters.Add("@beforewhen", SqlDbType.VarChar).Value = txtBefore_when.Text
        'command.Parameters.Add("@enrolledwhen", SqlDbType.VarChar).Value = txtEnrolled_When.Text
        'command.Parameters.Add("@session", SqlDbType.VarChar).Value = cbxSession.SelectedText
        'command.Parameters.Add("@standing", SqlDbType.VarChar).Value = cbxStanding.SelectedText
    End Sub

    Private Sub btnConfirm3_Click(sender As Object, e As EventArgs) Handles btnConfirm3.Click
        Dim con As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        'below connection needs proper table name to insert into
        'Dim command As New SqlCommand("INSERT DateApplied = @dateapplied, DateAccepted = @dateaccepted, DateEnrolled = @dateenrolled, DateDeclined = @datedeclined, LOR1 = @, LOR2, = @, LOR3 = @, TranscriptsTN = @, ResumeYN = @, AssistantShip = @, GMATVerbal, = @GMATverbal, GMATQuant = @GMATquant, GMATTotal = @GMATtotal, GMATPercent = @, GRE = @, TOEFL = @, UndergradIns = @, UndergradGPA = @, UndergradMa = @, Degree = @, DegreeDate = @, SecondDegree = @,SecondDegree = @, SecondDegree = @, YearsWorkEx = @ @, DegreeSeeki = @, StatusFTPT = @, NondegreeS = @, StudentID = @  INTO StudentApp", con)

        'need to fix the data types!
        'need name of coulms in table to data entry
        'command.Parameters.Add("@GMATdate", SqlDbType.DateTime).Value = txtGMATDate.Text
        'command.Parameters.Add("@TOEFLdate", SqlDbType.DateTime).Value = txtTOEFLDate.Text
        'command.Parameters.Add("@TSEdate", SqlDbType.DateTime).Value = txtTSEDate.Text

        'command.Parameters.Add("@GMATverbal", SqlDbType.Int).Value = txtGMATVerbal.Text
        'command.Parameters.Add("@GMATquant", SqlDbType.Int).Value = txtGMATQuant.Text
        'command.Parameters.Add("@GMATtotal", SqlDbType.Int).Value = txtGMATTotal.Text
        'command.Parameters.Add("@underGPA", SqlDbType.Decimal).Value = txtUnderGPA.Text
        'command.Parameters.Add("@GPAsenior", SqlDbType.Decimal).Value = txtGPASenior.Text

        'command.Parameters.Add("@cname1", SqlDbType.VarChar).Value = txtCName1.Text
        'command.Parameters.Add("@CName2", SqlDbType.VarChar).Value = txtCName2.Text

        'command.Parameters.Add("@CTo1", SqlDbType.VarChar).Value = txtCTo1.Text
        'command.Parameters.Add("@CTo2", SqlDbType.VarChar).Value = txtCTo2.Text

        'command.Parameters.Add("@CFrom1", SqlDbType.VarChar).Value = txtCFrom1.Text
        'command.Parameters.Add("@CFrom2", SqlDbType.VarChar).Value = txtCFrom2.Text

        'command.Parameters.Add("@CGPA1", SqlDbType.Decimal).Value = txtCGPA1.Text
        'command.Parameters.Add("@CGPA2", SqlDbType.Decimal).Value = txtCGPA2.Text

        'command.Parameters.Add("@HoursEarned1", SqlDbType.VarChar).Value = txtHoursEarned1.Text
        'command.Parameters.Add("@HoursEarned2", SqlDbType.VarChar).Value = txtHoursEarned2.Text

        'command.Parameters.Add("@Degree1", SqlDbType.VarChar).Value = txtDegree1.Text
        'command.Parameters.Add("@Degree2", SqlDbType.VarChar).Value = txtDegree2.Text

        'command.Parameters.Add("@Major1", SqlDbType.VarChar).Value = txtMajor1.Text
        'command.Parameters.Add("@Major2", SqlDbType.VarChar).Value = txtMajor2.Text

        'command.Parameters.Add("@DegreeDate1", SqlDbType.VarChar).Value = txtDegreeDate1.Text
        'command.Parameters.Add("@DegreeDate2", SqlDbType.VarChar).Value = txtDegreeDate2.Text

        'command.Parameters.Add("@CurrentHours1", SqlDbType.VarChar).Value = txtCurrentHours1.Text
        'command.Parameters.Add("@CurrentHours2", SqlDbType.VarChar).Value = txtCurrentHours2.Text



    End Sub

    Private Sub tabCredentials_Click(sender As Object, e As EventArgs) Handles tabCredentials.Click

    End Sub

    Private Sub btnConfirm4_Click(sender As Object, e As EventArgs) Handles btnConfirm4.Click
        Dim con As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        'below connection needs proper table name to insert into
        'Dim command As New SqlCommand("INSERT DateApplied = @DateApplied, DateAccepted = @DateAccepted, DateEnrolled = @DEnrolled, DateDeclined = @DDate, ... INTO StudentApp", con)

        'need to fix the data types!
        'the data from this table is split onto another tab

        'command.Parameters.Add("@DateApplied", SqlDbType.DateTime).Value = txtDateApplied.Text
        'command.Parameters.Add("@DateAccepted", SqlDbType.DateTime).Value = txtDateAccepted.Text
        'command.Parameters.Add("@DEnrolled", SqlDbType.VarChar).Value = txtDEnrolled.Text
        'command.Parameters.Add("@DDate", SqlDbType.DateTime).Value = txtDDate.Text

        'command.Parameters.Add("@Status", SqlDbType.VarChar).Value = txtStatus.Text


        'command.Parameters.Add("@AStatus", SqlDbType.VarChar).Value = txtAStatus.Text
        'command.Parameters.Add("@FeePaid", SqlDbType.VarChar).Value = txtFeePaid.Text

        'command.Parameters.Add("@SEnrolled", SqlDbType.VarChar).Value = txtSEnrolled.Text



        'command.Parameters.Add("@Declined", SqlDbType.VarChar).Value = txtDeclined.Text


        'command.Parameters.Add("@AcceptedOffer", SqlDbType.VarChar).Value = txtAcceptedOffer.Text


    End Sub

    Private Sub tabPersonalInfo_Click(sender As Object, e As EventArgs) Handles tabPersonalInfo.Click

    End Sub
End Class