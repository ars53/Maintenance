<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadvisingp2
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
        Me.dgvAdviseclasses = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        CType(Me.dgvAdviseclasses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAdviseclasses
        '
        Me.dgvAdviseclasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdviseclasses.Location = New System.Drawing.Point(-1, -1)
        Me.dgvAdviseclasses.Name = "dgvAdviseclasses"
        Me.dgvAdviseclasses.Size = New System.Drawing.Size(551, 242)
        Me.dgvAdviseclasses.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(238, 415)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(117, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add Courses"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(12, 270)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(528, 137)
        Me.txtComments.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(361, 415)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(136, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Finish Advising"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Location = New System.Drawing.Point(13, 248)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(59, 13)
        Me.lblComments.TabIndex = 4
        Me.lblComments.Text = "Comments:"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(44, 413)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove Class"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'frmadvisingp2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 450)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvAdviseclasses)
        Me.Name = "frmadvisingp2"
        Me.Text = "advisingp2"
        CType(Me.dgvAdviseclasses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAdviseclasses As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtComments As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblComments As Label
    Friend WithEvents btnRemove As Button
End Class
