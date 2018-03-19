<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEnroll
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
        Me.dgvEnroll = New System.Windows.Forms.DataGridView()
        Me.btnEnroll = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.lblNoClass = New System.Windows.Forms.Label()
        Me.btnAdvising = New System.Windows.Forms.Button()
        CType(Me.dgvEnroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEnroll
        '
        Me.dgvEnroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnroll.Location = New System.Drawing.Point(0, 2)
        Me.dgvEnroll.Name = "dgvEnroll"
        Me.dgvEnroll.Size = New System.Drawing.Size(434, 225)
        Me.dgvEnroll.TabIndex = 0
        '
        'btnEnroll
        '
        Me.btnEnroll.Location = New System.Drawing.Point(285, 277)
        Me.btnEnroll.Name = "btnEnroll"
        Me.btnEnroll.Size = New System.Drawing.Size(101, 23)
        Me.btnEnroll.TabIndex = 1
        Me.btnEnroll.Text = "Enroll In Class"
        Me.btnEnroll.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(52, 277)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 2
        Me.btnDel.Text = "Delete Class"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'lblNoClass
        '
        Me.lblNoClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoClass.Location = New System.Drawing.Point(39, 53)
        Me.lblNoClass.Name = "lblNoClass"
        Me.lblNoClass.Size = New System.Drawing.Size(347, 119)
        Me.lblNoClass.TabIndex = 3
        Me.lblNoClass.Text = "Not registered for classes, click enroll to begin"
        Me.lblNoClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdvising
        '
        Me.btnAdvising.Location = New System.Drawing.Point(133, 277)
        Me.btnAdvising.Name = "btnAdvising"
        Me.btnAdvising.Size = New System.Drawing.Size(146, 23)
        Me.btnAdvising.TabIndex = 4
        Me.btnAdvising.Text = "Add Classes from Advising"
        Me.btnAdvising.UseVisualStyleBackColor = True
        '
        'frmEnroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 323)
        Me.Controls.Add(Me.btnAdvising)
        Me.Controls.Add(Me.lblNoClass)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnEnroll)
        Me.Controls.Add(Me.dgvEnroll)
        Me.Name = "frmEnroll"
        Me.Text = "Enroll"
        CType(Me.dgvEnroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvEnroll As DataGridView
    Friend WithEvents btnEnroll As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents lblNoClass As Label
    Friend WithEvents btnAdvising As Button
End Class
