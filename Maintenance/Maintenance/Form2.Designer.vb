<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnSpringFall = New System.Windows.Forms.Button()
        Me.btnSummer12 = New System.Windows.Forms.Button()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.btnSpringInter = New System.Windows.Forms.Button()
        Me.btnFallInter = New System.Windows.Forms.Button()
        Me.grpFull = New System.Windows.Forms.GroupBox()
        Me.grpPart = New System.Windows.Forms.GroupBox()
        Me.grpFull.SuspendLayout()
        Me.grpPart.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSpringFall
        '
        Me.btnSpringFall.Location = New System.Drawing.Point(111, 26)
        Me.btnSpringFall.Name = "btnSpringFall"
        Me.btnSpringFall.Size = New System.Drawing.Size(75, 23)
        Me.btnSpringFall.TabIndex = 0
        Me.btnSpringFall.Text = "Spring/Fall"
        Me.btnSpringFall.UseVisualStyleBackColor = True
        '
        'btnSummer12
        '
        Me.btnSummer12.Location = New System.Drawing.Point(111, 55)
        Me.btnSummer12.Name = "btnSummer12"
        Me.btnSummer12.Size = New System.Drawing.Size(75, 23)
        Me.btnSummer12.TabIndex = 1
        Me.btnSummer12.Text = "Summer "
        Me.btnSummer12.UseVisualStyleBackColor = True
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(111, 21)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(126, 18)
        Me.lblAdd.TabIndex = 4
        Me.lblAdd.Text = "Select Session:"
        '
        'btnSpringInter
        '
        Me.btnSpringInter.Location = New System.Drawing.Point(88, 26)
        Me.btnSpringInter.Name = "btnSpringInter"
        Me.btnSpringInter.Size = New System.Drawing.Size(119, 23)
        Me.btnSpringInter.TabIndex = 2
        Me.btnSpringInter.Text = "Spring Intercession"
        Me.btnSpringInter.UseVisualStyleBackColor = True
        '
        'btnFallInter
        '
        Me.btnFallInter.Location = New System.Drawing.Point(88, 55)
        Me.btnFallInter.Name = "btnFallInter"
        Me.btnFallInter.Size = New System.Drawing.Size(119, 23)
        Me.btnFallInter.TabIndex = 5
        Me.btnFallInter.Text = "Fall Intercession"
        Me.btnFallInter.UseVisualStyleBackColor = True
        '
        'grpFull
        '
        Me.grpFull.Controls.Add(Me.btnSpringFall)
        Me.grpFull.Controls.Add(Me.btnSummer12)
        Me.grpFull.Location = New System.Drawing.Point(17, 51)
        Me.grpFull.Name = "grpFull"
        Me.grpFull.Size = New System.Drawing.Size(300, 100)
        Me.grpFull.TabIndex = 6
        Me.grpFull.TabStop = False
        Me.grpFull.Text = "13 Week:"
        '
        'grpPart
        '
        Me.grpPart.Controls.Add(Me.btnSpringInter)
        Me.grpPart.Controls.Add(Me.btnFallInter)
        Me.grpPart.Location = New System.Drawing.Point(17, 157)
        Me.grpPart.Name = "grpPart"
        Me.grpPart.Size = New System.Drawing.Size(300, 100)
        Me.grpPart.TabIndex = 7
        Me.grpPart.TabStop = False
        Me.grpPart.Text = "2 Week:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 477)
        Me.Controls.Add(Me.grpPart)
        Me.Controls.Add(Me.grpFull)
        Me.Controls.Add(Me.lblAdd)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.grpFull.ResumeLayout(False)
        Me.grpPart.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSpringFall As Button
    Friend WithEvents btnSummer12 As Button
    Friend WithEvents lblAdd As Label
    Friend WithEvents btnSpringInter As Button
    Friend WithEvents btnFallInter As Button
    Friend WithEvents grpFull As GroupBox
    Friend WithEvents grpPart As GroupBox
End Class
