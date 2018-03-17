<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentWelcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentWelcome))
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnEnroll = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvStud = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(183, 268)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(107, 23)
        Me.btnView.TabIndex = 9
        Me.btnView.Text = "View My Records"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnEnroll
        '
        Me.btnEnroll.Location = New System.Drawing.Point(62, 268)
        Me.btnEnroll.Name = "btnEnroll"
        Me.btnEnroll.Size = New System.Drawing.Size(107, 23)
        Me.btnEnroll.TabIndex = 8
        Me.btnEnroll.Text = "Enroll"
        Me.btnEnroll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 40)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Masters in Information Systems" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Student and Alumni Records"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 187)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'dgvStud
        '
        Me.dgvStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStud.Location = New System.Drawing.Point(71, 363)
        Me.dgvStud.Name = "dgvStud"
        Me.dgvStud.Size = New System.Drawing.Size(240, 150)
        Me.dgvStud.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(20, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(319, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "____________________________________________________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(20, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "____________________________________________________"
        '
        'frmStudentWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 302)
        Me.Controls.Add(Me.dgvStud)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnEnroll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmStudentWelcome"
        Me.Text = "Welcome, Student!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnView As Button
    Friend WithEvents btnEnroll As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvStud As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
End Class
