<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePass))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtold = New System.Windows.Forms.TextBox()
        Me.txtnew = New System.Windows.Forms.TextBox()
        Me.txtconfirm = New System.Windows.Forms.TextBox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Confirm Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "New Password"
        '
        'txtold
        '
        Me.txtold.Location = New System.Drawing.Point(135, 58)
        Me.txtold.Name = "txtold"
        Me.txtold.Size = New System.Drawing.Size(100, 20)
        Me.txtold.TabIndex = 3
        '
        'txtnew
        '
        Me.txtnew.Location = New System.Drawing.Point(135, 92)
        Me.txtnew.Name = "txtnew"
        Me.txtnew.Size = New System.Drawing.Size(100, 20)
        Me.txtnew.TabIndex = 4
        '
        'txtconfirm
        '
        Me.txtconfirm.Location = New System.Drawing.Point(135, 123)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.Size = New System.Drawing.Size(100, 20)
        Me.txtconfirm.TabIndex = 5
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(41, 157)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 6
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Change Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(135, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(256, 192)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.txtconfirm)
        Me.Controls.Add(Me.txtnew)
        Me.Controls.Add(Me.txtold)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ChangePass"
        Me.Text = "ChangePass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtold As TextBox
    Friend WithEvents txtnew As TextBox
    Friend WithEvents txtconfirm As TextBox
    Friend WithEvents btnupdate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
