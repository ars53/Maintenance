<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentViewRec
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNameFD = New System.Windows.Forms.Label()
        Me.lblMND = New System.Windows.Forms.Label()
        Me.lblLND = New System.Windows.Forms.Label()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.lblSSND = New System.Windows.Forms.Label()
        Me.grpLocal = New System.Windows.Forms.GroupBox()
        Me.lblZipLocal = New System.Windows.Forms.Label()
        Me.lblZipI = New System.Windows.Forms.Label()
        Me.lblStateI = New System.Windows.Forms.Label()
        Me.lblLocalState = New System.Windows.Forms.Label()
        Me.lblCityDL = New System.Windows.Forms.Label()
        Me.lblCityLocalL = New System.Windows.Forms.Label()
        Me.lblLocalADR2D = New System.Windows.Forms.Label()
        Me.lblLocalADR2 = New System.Windows.Forms.Label()
        Me.ldlLocalAdr = New System.Windows.Forms.Label()
        Me.lblLocalADRL = New System.Windows.Forms.Label()
        Me.grpPermAdr = New System.Windows.Forms.GroupBox()
        Me.lblPermZip = New System.Windows.Forms.Label()
        Me.lblPCountry = New System.Windows.Forms.Label()
        Me.lblPermCountry = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPermState = New System.Windows.Forms.Label()
        Me.lblPState = New System.Windows.Forms.Label()
        Me.lblPermCity = New System.Windows.Forms.Label()
        Me.lblPCity = New System.Windows.Forms.Label()
        Me.lblPermAdr2 = New System.Windows.Forms.Label()
        Me.lblPAdr2 = New System.Windows.Forms.Label()
        Me.lblPermADR1 = New System.Windows.Forms.Label()
        Me.lblPA1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.grpLocal.SuspendLayout()
        Me.grpPermAdr.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblNameFD
        '
        Me.lblNameFD.AutoSize = True
        Me.lblNameFD.Location = New System.Drawing.Point(53, 21)
        Me.lblNameFD.Name = "lblNameFD"
        Me.lblNameFD.Size = New System.Drawing.Size(24, 13)
        Me.lblNameFD.TabIndex = 1
        Me.lblNameFD.Text = "text"
        '
        'lblMND
        '
        Me.lblMND.AutoSize = True
        Me.lblMND.Location = New System.Drawing.Point(53, 39)
        Me.lblMND.Name = "lblMND"
        Me.lblMND.Size = New System.Drawing.Size(24, 13)
        Me.lblMND.TabIndex = 2
        Me.lblMND.Text = "text"
        '
        'lblLND
        '
        Me.lblLND.AutoSize = True
        Me.lblLND.Location = New System.Drawing.Point(53, 57)
        Me.lblLND.Name = "lblLND"
        Me.lblLND.Size = New System.Drawing.Size(24, 13)
        Me.lblLND.TabIndex = 3
        Me.lblLND.Text = "text"
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Location = New System.Drawing.Point(130, 21)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(107, 13)
        Me.lblSSN.TabIndex = 4
        Me.lblSSN.Text = "SSN (###-##-####)"
        '
        'lblSSND
        '
        Me.lblSSND.AutoSize = True
        Me.lblSSND.Location = New System.Drawing.Point(133, 38)
        Me.lblSSND.Name = "lblSSND"
        Me.lblSSND.Size = New System.Drawing.Size(24, 13)
        Me.lblSSND.TabIndex = 5
        Me.lblSSND.Text = "text"
        '
        'grpLocal
        '
        Me.grpLocal.Controls.Add(Me.lblZipLocal)
        Me.grpLocal.Controls.Add(Me.lblZipI)
        Me.grpLocal.Controls.Add(Me.lblStateI)
        Me.grpLocal.Controls.Add(Me.lblLocalState)
        Me.grpLocal.Controls.Add(Me.lblCityDL)
        Me.grpLocal.Controls.Add(Me.lblCityLocalL)
        Me.grpLocal.Controls.Add(Me.lblLocalADR2D)
        Me.grpLocal.Controls.Add(Me.lblLocalADR2)
        Me.grpLocal.Controls.Add(Me.ldlLocalAdr)
        Me.grpLocal.Controls.Add(Me.lblLocalADRL)
        Me.grpLocal.Location = New System.Drawing.Point(15, 96)
        Me.grpLocal.Name = "grpLocal"
        Me.grpLocal.Size = New System.Drawing.Size(222, 183)
        Me.grpLocal.TabIndex = 6
        Me.grpLocal.TabStop = False
        Me.grpLocal.Text = "Local Address"
        '
        'lblZipLocal
        '
        Me.lblZipLocal.AutoSize = True
        Me.lblZipLocal.Location = New System.Drawing.Point(91, 84)
        Me.lblZipLocal.Name = "lblZipLocal"
        Me.lblZipLocal.Size = New System.Drawing.Size(24, 13)
        Me.lblZipLocal.TabIndex = 9
        Me.lblZipLocal.Text = "text"
        '
        'lblZipI
        '
        Me.lblZipI.AutoSize = True
        Me.lblZipI.Location = New System.Drawing.Point(6, 84)
        Me.lblZipI.Name = "lblZipI"
        Me.lblZipI.Size = New System.Drawing.Size(46, 13)
        Me.lblZipI.TabIndex = 8
        Me.lblZipI.Text = "Zipcode"
        '
        'lblStateI
        '
        Me.lblStateI.AutoSize = True
        Me.lblStateI.Location = New System.Drawing.Point(91, 67)
        Me.lblStateI.Name = "lblStateI"
        Me.lblStateI.Size = New System.Drawing.Size(24, 13)
        Me.lblStateI.TabIndex = 7
        Me.lblStateI.Text = "text"
        '
        'lblLocalState
        '
        Me.lblLocalState.AutoSize = True
        Me.lblLocalState.Location = New System.Drawing.Point(4, 67)
        Me.lblLocalState.Name = "lblLocalState"
        Me.lblLocalState.Size = New System.Drawing.Size(79, 13)
        Me.lblLocalState.TabIndex = 6
        Me.lblLocalState.Text = "State/Province"
        '
        'lblCityDL
        '
        Me.lblCityDL.AutoSize = True
        Me.lblCityDL.Location = New System.Drawing.Point(91, 50)
        Me.lblCityDL.Name = "lblCityDL"
        Me.lblCityDL.Size = New System.Drawing.Size(24, 13)
        Me.lblCityDL.TabIndex = 5
        Me.lblCityDL.Text = "text"
        '
        'lblCityLocalL
        '
        Me.lblCityLocalL.AutoSize = True
        Me.lblCityLocalL.Location = New System.Drawing.Point(6, 50)
        Me.lblCityLocalL.Name = "lblCityLocalL"
        Me.lblCityLocalL.Size = New System.Drawing.Size(53, 13)
        Me.lblCityLocalL.TabIndex = 4
        Me.lblCityLocalL.Text = "Local City"
        '
        'lblLocalADR2D
        '
        Me.lblLocalADR2D.AutoSize = True
        Me.lblLocalADR2D.Location = New System.Drawing.Point(91, 33)
        Me.lblLocalADR2D.Name = "lblLocalADR2D"
        Me.lblLocalADR2D.Size = New System.Drawing.Size(24, 13)
        Me.lblLocalADR2D.TabIndex = 3
        Me.lblLocalADR2D.Text = "text"
        '
        'lblLocalADR2
        '
        Me.lblLocalADR2.AutoSize = True
        Me.lblLocalADR2.Location = New System.Drawing.Point(6, 33)
        Me.lblLocalADR2.Name = "lblLocalADR2"
        Me.lblLocalADR2.Size = New System.Drawing.Size(77, 13)
        Me.lblLocalADR2.TabIndex = 2
        Me.lblLocalADR2.Text = "Address Line 2"
        '
        'ldlLocalAdr
        '
        Me.ldlLocalAdr.AutoSize = True
        Me.ldlLocalAdr.Location = New System.Drawing.Point(91, 16)
        Me.ldlLocalAdr.Name = "ldlLocalAdr"
        Me.ldlLocalAdr.Size = New System.Drawing.Size(24, 13)
        Me.ldlLocalAdr.TabIndex = 1
        Me.ldlLocalAdr.Text = "text"
        '
        'lblLocalADRL
        '
        Me.lblLocalADRL.AutoSize = True
        Me.lblLocalADRL.Location = New System.Drawing.Point(6, 16)
        Me.lblLocalADRL.Name = "lblLocalADRL"
        Me.lblLocalADRL.Size = New System.Drawing.Size(77, 13)
        Me.lblLocalADRL.TabIndex = 0
        Me.lblLocalADRL.Text = "Address Line 1"
        '
        'grpPermAdr
        '
        Me.grpPermAdr.Controls.Add(Me.lblPermZip)
        Me.grpPermAdr.Controls.Add(Me.lblPCountry)
        Me.grpPermAdr.Controls.Add(Me.lblPermCountry)
        Me.grpPermAdr.Controls.Add(Me.Label2)
        Me.grpPermAdr.Controls.Add(Me.lblPermState)
        Me.grpPermAdr.Controls.Add(Me.lblPState)
        Me.grpPermAdr.Controls.Add(Me.lblPermCity)
        Me.grpPermAdr.Controls.Add(Me.lblPCity)
        Me.grpPermAdr.Controls.Add(Me.lblPermAdr2)
        Me.grpPermAdr.Controls.Add(Me.lblPAdr2)
        Me.grpPermAdr.Controls.Add(Me.lblPermADR1)
        Me.grpPermAdr.Controls.Add(Me.lblPA1)
        Me.grpPermAdr.Location = New System.Drawing.Point(254, 96)
        Me.grpPermAdr.Name = "grpPermAdr"
        Me.grpPermAdr.Size = New System.Drawing.Size(222, 183)
        Me.grpPermAdr.TabIndex = 7
        Me.grpPermAdr.TabStop = False
        Me.grpPermAdr.Text = "Permanant Address"
        '
        'lblPermZip
        '
        Me.lblPermZip.AutoSize = True
        Me.lblPermZip.Location = New System.Drawing.Point(94, 107)
        Me.lblPermZip.Name = "lblPermZip"
        Me.lblPermZip.Size = New System.Drawing.Size(24, 13)
        Me.lblPermZip.TabIndex = 11
        Me.lblPermZip.Text = "text"
        '
        'lblPCountry
        '
        Me.lblPCountry.AutoSize = True
        Me.lblPCountry.Location = New System.Drawing.Point(6, 84)
        Me.lblPCountry.Name = "lblPCountry"
        Me.lblPCountry.Size = New System.Drawing.Size(43, 13)
        Me.lblPCountry.TabIndex = 10
        Me.lblPCountry.Text = "Country"
        '
        'lblPermCountry
        '
        Me.lblPermCountry.AutoSize = True
        Me.lblPermCountry.Location = New System.Drawing.Point(91, 84)
        Me.lblPermCountry.Name = "lblPermCountry"
        Me.lblPermCountry.Size = New System.Drawing.Size(24, 13)
        Me.lblPermCountry.TabIndex = 9
        Me.lblPermCountry.Text = "text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Zipcode"
        '
        'lblPermState
        '
        Me.lblPermState.AutoSize = True
        Me.lblPermState.Location = New System.Drawing.Point(91, 67)
        Me.lblPermState.Name = "lblPermState"
        Me.lblPermState.Size = New System.Drawing.Size(24, 13)
        Me.lblPermState.TabIndex = 7
        Me.lblPermState.Text = "text"
        '
        'lblPState
        '
        Me.lblPState.AutoSize = True
        Me.lblPState.Location = New System.Drawing.Point(4, 67)
        Me.lblPState.Name = "lblPState"
        Me.lblPState.Size = New System.Drawing.Size(79, 13)
        Me.lblPState.TabIndex = 6
        Me.lblPState.Text = "State/Province"
        '
        'lblPermCity
        '
        Me.lblPermCity.AutoSize = True
        Me.lblPermCity.Location = New System.Drawing.Point(91, 50)
        Me.lblPermCity.Name = "lblPermCity"
        Me.lblPermCity.Size = New System.Drawing.Size(24, 13)
        Me.lblPermCity.TabIndex = 5
        Me.lblPermCity.Text = "text"
        '
        'lblPCity
        '
        Me.lblPCity.AutoSize = True
        Me.lblPCity.Location = New System.Drawing.Point(6, 50)
        Me.lblPCity.Name = "lblPCity"
        Me.lblPCity.Size = New System.Drawing.Size(53, 13)
        Me.lblPCity.TabIndex = 4
        Me.lblPCity.Text = "Local City"
        '
        'lblPermAdr2
        '
        Me.lblPermAdr2.AutoSize = True
        Me.lblPermAdr2.Location = New System.Drawing.Point(91, 33)
        Me.lblPermAdr2.Name = "lblPermAdr2"
        Me.lblPermAdr2.Size = New System.Drawing.Size(24, 13)
        Me.lblPermAdr2.TabIndex = 3
        Me.lblPermAdr2.Text = "text"
        '
        'lblPAdr2
        '
        Me.lblPAdr2.AutoSize = True
        Me.lblPAdr2.Location = New System.Drawing.Point(6, 33)
        Me.lblPAdr2.Name = "lblPAdr2"
        Me.lblPAdr2.Size = New System.Drawing.Size(77, 13)
        Me.lblPAdr2.TabIndex = 2
        Me.lblPAdr2.Text = "Address Line 2"
        '
        'lblPermADR1
        '
        Me.lblPermADR1.AutoSize = True
        Me.lblPermADR1.Location = New System.Drawing.Point(91, 16)
        Me.lblPermADR1.Name = "lblPermADR1"
        Me.lblPermADR1.Size = New System.Drawing.Size(24, 13)
        Me.lblPermADR1.TabIndex = 1
        Me.lblPermADR1.Text = "text"
        '
        'lblPA1
        '
        Me.lblPA1.AutoSize = True
        Me.lblPA1.Location = New System.Drawing.Point(6, 16)
        Me.lblPA1.Name = "lblPA1"
        Me.lblPA1.Size = New System.Drawing.Size(77, 13)
        Me.lblPA1.TabIndex = 0
        Me.lblPA1.Text = "Address Line 1"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(13, 417)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmStudentViewRec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 452)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.grpPermAdr)
        Me.Controls.Add(Me.grpLocal)
        Me.Controls.Add(Me.lblSSND)
        Me.Controls.Add(Me.lblSSN)
        Me.Controls.Add(Me.lblLND)
        Me.Controls.Add(Me.lblMND)
        Me.Controls.Add(Me.lblNameFD)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmStudentViewRec"
        Me.Text = "StudentViewRec"
        Me.grpLocal.ResumeLayout(False)
        Me.grpLocal.PerformLayout()
        Me.grpPermAdr.ResumeLayout(False)
        Me.grpPermAdr.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblNameFD As Label
    Friend WithEvents lblMND As Label
    Friend WithEvents lblLND As Label
    Friend WithEvents lblSSN As Label
    Friend WithEvents lblSSND As Label
    Friend WithEvents grpLocal As GroupBox
    Friend WithEvents lblZipLocal As Label
    Friend WithEvents lblZipI As Label
    Friend WithEvents lblStateI As Label
    Friend WithEvents lblLocalState As Label
    Friend WithEvents lblCityDL As Label
    Friend WithEvents lblCityLocalL As Label
    Friend WithEvents lblLocalADR2D As Label
    Friend WithEvents lblLocalADR2 As Label
    Friend WithEvents ldlLocalAdr As Label
    Friend WithEvents lblLocalADRL As Label
    Friend WithEvents grpPermAdr As GroupBox
    Friend WithEvents lblPermZip As Label
    Friend WithEvents lblPCountry As Label
    Friend WithEvents lblPermCountry As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPermState As Label
    Friend WithEvents lblPState As Label
    Friend WithEvents lblPermCity As Label
    Friend WithEvents lblPCity As Label
    Friend WithEvents lblPermAdr2 As Label
    Friend WithEvents lblPAdr2 As Label
    Friend WithEvents lblPermADR1 As Label
    Friend WithEvents lblPA1 As Label
    Friend WithEvents btnBack As Button
End Class
