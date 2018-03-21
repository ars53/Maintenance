<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcceptDecline
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
        Me.dgvAccept = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        CType(Me.dgvAccept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAccept
        '
        Me.dgvAccept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccept.Location = New System.Drawing.Point(2, 0)
        Me.dgvAccept.Name = "dgvAccept"
        Me.dgvAccept.Size = New System.Drawing.Size(448, 297)
        Me.dgvAccept.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 325)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 50)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Decline All Low GMAT Candidates"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(244, 325)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(113, 50)
        Me.btnAccept.TabIndex = 3
        Me.btnAccept.Text = "Accept Selected Candidate"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'frmAcceptDecline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 400)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvAccept)
        Me.Name = "frmAcceptDecline"
        Me.Text = "AcceptDecline"
        CType(Me.dgvAccept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAccept As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAccept As Button
End Class
