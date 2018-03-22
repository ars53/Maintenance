Imports System.Data.SqlClient
Public Class frmAdd
    Protected db As New db
    Protected h As String = "N"
    Protected eth As String = "white"
    Protected gen As String = "M"
    Protected before As String = "N"
    Protected attend As String = "N"
    Protected Sess As String = ""
    Protected previousStatus As String = ""
    Protected requestAssist As String = "N"
    Protected sid As Integer
    Private Sub ckLocalNone_CheckedChanged(sender As Object, e As EventArgs) Handles ckLocalNone.CheckedChanged

        If ckLocalNone.Checked = True Then
            txtCurrentPhone.Text = "None"
            txtCurrentPhone.Enabled = False
        End If

    End Sub

    Private Sub ckWorkNone_CheckedChanged(sender As Object, e As EventArgs) Handles ckWorkNone.CheckedChanged

        If ckWorkNone.Checked = True Then
            txtpPhone.Text = "None"
            txtpPhone.Enabled = False
        End If

    End Sub

    Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim First As String
        First = txtFirstName.Text

        Dim Last As String
        Last = txtLastName.Text
        lblStudentName.Text = First + Last

        Dim StudId As Integer
        'StudId = txtStudentID.Text
        lblStudentID.Text = StudId

        txtDEnrolled.Enabled = False
        txtDDate.Enabled = False
        txtDateAccepted.Enabled = False

    End Sub

    Private Sub txtSEnrolled_TextChanged(sender As Object, e As EventArgs) Handles txtSEnrolled.TextChanged

    End Sub
    Private Sub chkHispanic_CheckedChanged(sender As Object, e As EventArgs) Handles chkHispanic.CheckedChanged
        If chkHispanic.Checked = True Then
            h = "Y"
        ElseIf chkHispanic.Checked = False Then
            h = "N"
        End If
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim lphone As Integer
        Dim pPhone As Integer
        db.sql = "INSERT INTO Student_Header (First_Name, Middle_Name, Last_Name, SSN, LocalAddress1, LocalAddress2, Local_City, LocalStateProvince, LocalZip, LocalHomePhone, PermAddress, PermAddress2, Perm_City, PermStateProvince, PermZip, PermHomePhone, email1, Email2, Birthdate, hispanic, Ethnicity, Gender, OriginCountry, Preferred_name) values  (@first,@middle, @last, @ssn, @la1, @la2, @lcity, @lstate, @lzip, @lphone, @pa1, @pa2, @pcity, @pstate, @pzip, @pphone, @email1, @email2, @birth, @hispanic, @ethnicity, @gender, @oCountry, @cell)"
        db.bind("@first", txtFirstName.Text)
        db.bind("@middle", txtMiddleName.Text)
        db.bind("@last", txtLastName.Text)
        db.bind("@ssn", txtSSN.Text)
        db.bind("@la1", txtLAddress.Text)
        db.bind("@la2", txtLADR2.Text)
        db.bind("@lcity", txtLCity.Text)
        db.bind("@lstate", cbxLState.Text)
        db.bind("@lzip", txtLZipCode.Text)
        db.bind("@lphone", Int16.TryParse(txtLphone.Text, lphone))
        db.bind("@pa1", txtPAddress.Text)
        db.bind("@pa2", txtpadr2.Text)
        db.bind("@pcity", txtPCity.Text)
        db.bind("@pstate", cbxPState.Text)
        db.bind("@pzip", txtPZipCode.Text)
        db.bind("@pphone", Int16.TryParse(txtpPhone.Text, pPhone))
        db.bind("@email1", txtEmail.Text)
        db.bind("@email2", txtEmail2.Text)
        db.bind("@birth", txtBirthday1.Text)
        db.bind("@hispanic", h)
        db.bind("@ethnicity", eth)
        db.bind("@gender", gen)
        db.bind("@oCountry", txtOCountry.Text)
        db.bind("@cell", txtCellPhone.Text)
        db.execute()
        getstudentID()

        db.sql = "INSERT INTO Studentapp (studentid) values (@sid)"
        db.bind("@sid", sid)
        db.execute()

        db.sql = "INSERT INTO Status (studentID) Values (@sid)"
        db.bind("@sid", sid)
        db.execute()
        'creates a username for the new user
        Dim username As String = txtFirstName.Text.Substring(0, 3) & txtLastName.Text.Substring(0, 2)
        db.sql = "INSERT INTO Usernames (username, studentID) values (@user, @sid)"
        db.bind("@user", username)
        db.bind("@sid", sid)
        db.execute()
        'creates a login
        Dim password As String = "password"
        db.sql = "INSERT INTO Logins (username, password) Values (@user, @pass)"
        db.bind("@user", username)
        db.bind("@pass", password)
        db.execute()
        MsgBox("Your user name is" & username & "and your password is " & password)



    End Sub

    Private Sub getstudentID()
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("SELECT MAX(StudentID) FROM Student_Header", connection)

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then

        Else
            sid = table.Rows(0).Item(0)
        End If
    End Sub

    Private Sub btnConfirm2_Click(sender As Object, e As EventArgs) Handles btnConfirm2.Click

        getstudentID()

        db.sql = "UPDATE StudentApp SET yearrequest = @year , session = @sess, previousapp = @previousapp, prevappdate = @prevappdate, enrolled = @enrolled, enrolleddate = @enrolleddate, ifenrolled = @ifenrolled, AssistantShipRequested = @assistant WHERE StudentID = @sid"
        db.bind("@year", txtRequestYear.Text)
        db.bind("@sess", Sess)
        db.bind("@previousapp", before)
        db.bind("@prevappdate", txtBefore_when.Text)
        db.bind("@enrolled", attend)
        db.bind("@enrolleddate", txtEnrolled_When.Text)
        db.bind("@ifenrolled", previousStatus)
        db.bind("@assistant", requestAssist)
        db.bind("@sid", sid)
        db.execute()

    End Sub

    Private Sub btnConfirm3_Click(sender As Object, e As EventArgs) Handles btnConfirm3.Click
        db.sql = "UPDATE StudentApp set GMATVerbal = @gmatVerbal, GMATQuant = @gmatQ, GMATTotal = @gmatT, Gre = @gre, TOEFL = @toefl, UndergradInst = @UGI, UndergradGPA = @UGGPA, UndergradMajor = @UGMajor, Degree = @degree1, DegreeDate = @degree1Date, SecondDegree = @degree2, SecondDegreDate = @degree2date, SecondDegreeInst = @degree2Ins, GMATDate = @gmatdate, TOEFLDate = @toeflDate, GREDate = @gredate WHERE StudentID = @sid"
        db.bind("@gmatVerbal", txtGMATVerbal.Text)
        db.bind("@gmatQ", txtGMATQuant.Text)
        db.bind("@gmatT", txtGMATTotal.Text)
        db.bind("@gre", txtGRETotal.Text)
        db.bind("@toefl", txtTOEFLTotal.Text)
        db.bind("@UGI", txtCName1.Text)
        db.bind("@UGGPA", txtUnderGPA.Text)
        db.bind("@UGMajor", txtMajor1.Text)
        db.bind("@degree1", txtDegree1.Text)
        db.bind("@degree1Date", txtDegreeDate1.Text)
        db.bind("@degree2", txtDegree2.Text)
        db.bind("@degree2Date", txtDegreeDate2.Text)
        db.bind("@degree2Ins", txtCName2.Text)
        db.bind("@gmatdate", txtGMATDate.Text)
        db.bind("@gredate", txtGREDate.Text)
        db.bind("@toefldate", txtTOEFLDate.Text)
        getstudentID()

        db.bind("@sid", sid)
        db.execute()






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

    Private Sub cbxEthnic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEthnic.SelectedIndexChanged
        If cbxEthnic.SelectedIndex = 0 Then
            eth = "Alaskan Native/Am Indian"
        ElseIf cbxEthnic.SelectedIndex = 1 Then
            eth = "Black/African American"
        ElseIf cbxEthnic.SelectedIndex = 2 Then
            eth = "Asian/Pacific Islander"
        ElseIf cbxEthnic.SelectedIndex = 3 Then
            eth = "White"
        End If
    End Sub

    Private Sub cbxGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGender.SelectedIndexChanged
        If cbxGender.SelectedIndex = 0 Then
            gen = "M"
        ElseIf cbxGender.SelectedIndex = 1 Then
            gen = "F"
        ElseIf cbxGender.SelectedIndex = 2 Then
            gen = "O"
        End If
    End Sub

    Private Sub chkBefore_CheckedChanged(sender As Object, e As EventArgs) Handles chkBefore.CheckedChanged
        If chkBefore.Checked = True Then
            before = "Y"
        ElseIf chkBefore.Checked = False Then
            before = "N"
        End If
    End Sub

    Private Sub chkEnrolled_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnrolled.CheckedChanged
        If chkEnrolled.Checked = True Then
            attend = "Y"
        ElseIf chkEnrolled.Checked = False Then
            attend = "N"
        End If
    End Sub

    Private Sub cbxSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSession.SelectedIndexChanged
        If cbxSession.SelectedIndex = 0 Then
            sess = "SP"
        ElseIf cbxSession.SelectedIndex = 1 Then
            sess = "FA"
        End If
    End Sub

    Private Sub cbxStanding_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStanding.SelectedIndexChanged
        If cbxStanding.SelectedIndex = 0 Then
            previousStatus = "Graduate"
        ElseIf cbxStanding.SelectedIndex = 1 Then
            previousStatus = "Undergrad"
        ElseIf cbxStanding.SelectedIndex = 2 Then
            previousStatus = "Other"
        End If
    End Sub

    Private Sub chkRequested_CheckedChanged(sender As Object, e As EventArgs) Handles chkRequested.CheckedChanged
        If chkRequested.Checked = True Then
            requestAssist = "Y"
        ElseIf chkRequested.Checked = False Then
            requestAssist = "N"
        End If
    End Sub
End Class