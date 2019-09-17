<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Me.btnteacher = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnfault = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnteacher
        '
        Me.btnteacher.Location = New System.Drawing.Point(231, 12)
        Me.btnteacher.Name = "btnteacher"
        Me.btnteacher.Size = New System.Drawing.Size(75, 23)
        Me.btnteacher.TabIndex = 0
        Me.btnteacher.Text = "Teacher"
        Me.btnteacher.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Administrator"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 226)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Technician"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(201, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Created by Hamza"
        '
        'btnfault
        '
        Me.btnfault.Location = New System.Drawing.Point(231, 53)
        Me.btnfault.Name = "btnfault"
        Me.btnfault.Size = New System.Drawing.Size(75, 23)
        Me.btnfault.TabIndex = 4
        Me.btnfault.Text = "View Faults"
        Me.btnfault.UseVisualStyleBackColor = True
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Welcome.My.Resources.Resources.logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(332, 261)
        Me.Controls.Add(Me.btnfault)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnteacher)
        Me.DoubleBuffered = True
        Me.Name = "Welcome"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnteacher As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnfault As Button
End Class
