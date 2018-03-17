<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.radFaculty = New System.Windows.Forms.RadioButton()
        Me.radStudent = New System.Windows.Forms.RadioButton()
        Me.linkNewUser = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(17, 106)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(169, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(70, 17)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(116, 20)
        Me.txtUser.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(70, 50)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(116, 20)
        Me.txtPassword.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'btnClear
        '
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(17, 135)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(169, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'radFaculty
        '
        Me.radFaculty.AutoSize = True
        Me.radFaculty.ForeColor = System.Drawing.Color.Black
        Me.radFaculty.Location = New System.Drawing.Point(17, 83)
        Me.radFaculty.Name = "radFaculty"
        Me.radFaculty.Size = New System.Drawing.Size(59, 17)
        Me.radFaculty.TabIndex = 6
        Me.radFaculty.TabStop = True
        Me.radFaculty.Text = "Faculty"
        Me.radFaculty.UseVisualStyleBackColor = True
        '
        'radStudent
        '
        Me.radStudent.AutoSize = True
        Me.radStudent.ForeColor = System.Drawing.Color.Black
        Me.radStudent.Location = New System.Drawing.Point(124, 83)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(62, 17)
        Me.radStudent.TabIndex = 7
        Me.radStudent.TabStop = True
        Me.radStudent.Text = "Student"
        Me.radStudent.UseVisualStyleBackColor = True
        '
        'linkNewUser
        '
        Me.linkNewUser.AutoSize = True
        Me.linkNewUser.Location = New System.Drawing.Point(157, 176)
        Me.linkNewUser.Name = "linkNewUser"
        Me.linkNewUser.Size = New System.Drawing.Size(31, 13)
        Me.linkNewUser.TabIndex = 8
        Me.linkNewUser.TabStop = True
        Me.linkNewUser.Text = "here."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "New User? Apply for access"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(11, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "_____________________________"
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 204)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.linkNewUser)
        Me.Controls.Add(Me.radStudent)
        Me.Controls.Add(Me.radFaculty)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnLogin)
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents radFaculty As RadioButton
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents linkNewUser As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
