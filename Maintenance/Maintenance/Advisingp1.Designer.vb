<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdvisingp1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.txtIDNum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.frmSemy = New System.Windows.Forms.Label()
        Me.txtSemy = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSemy)
        Me.GroupBox1.Controls.Add(Me.frmSemy)
        Me.GroupBox1.Controls.Add(Me.txtMName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMajor)
        Me.GroupBox1.Controls.Add(Me.txtIDNum)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 155)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Info:"
        '
        'txtMName
        '
        Me.txtMName.Location = New System.Drawing.Point(100, 40)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(114, 20)
        Me.txtMName.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name"
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(289, 12)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(136, 20)
        Me.txtMajor.TabIndex = 15
        '
        'txtIDNum
        '
        Me.txtIDNum.Location = New System.Drawing.Point(100, 92)
        Me.txtIDNum.Name = "txtIDNum"
        Me.txtIDNum.Size = New System.Drawing.Size(114, 20)
        Me.txtIDNum.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ID Number"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(100, 66)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(114, 20)
        Me.txtLName.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(239, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Major"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(100, 15)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(114, 20)
        Me.txtFName.TabIndex = 9
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(329, 171)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(108, 40)
        Me.btnCreate.TabIndex = 25
        Me.btnCreate.Text = "Start new Advising Session"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(46, 173)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(147, 37)
        Me.btnChange.TabIndex = 26
        Me.btnChange.Text = "Change previous advising session"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'frmSemy
        '
        Me.frmSemy.AutoSize = True
        Me.frmSemy.Location = New System.Drawing.Point(286, 47)
        Me.frmSemy.Name = "frmSemy"
        Me.frmSemy.Size = New System.Drawing.Size(144, 13)
        Me.frmSemy.TabIndex = 16
        Me.frmSemy.Text = "Semester and year (i.e SP18)"
        '
        'txtSemy
        '
        Me.txtSemy.Location = New System.Drawing.Point(289, 69)
        Me.txtSemy.MaxLength = 4
        Me.txtSemy.Name = "txtSemy"
        Me.txtSemy.Size = New System.Drawing.Size(109, 20)
        Me.txtSemy.TabIndex = 17
        '
        'frmAdvisingp1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 229)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAdvisingp1"
        Me.Text = "Advisingp1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMajor As TextBox
    Friend WithEvents txtIDNum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnChange As Button
    Friend WithEvents txtSemy As TextBox
    Friend WithEvents frmSemy As Label
End Class
