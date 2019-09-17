<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teacher1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtroomno = New System.Windows.Forms.TextBox()
        Me.txtcompno = New System.Windows.Forms.TextBox()
        Me.txtfault = New System.Windows.Forms.TextBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.faultgrid = New System.Windows.Forms.DataGridView()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.faultgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Computer No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fault"
        '
        'txtroomno
        '
        Me.txtroomno.Location = New System.Drawing.Point(126, 57)
        Me.txtroomno.Name = "txtroomno"
        Me.txtroomno.Size = New System.Drawing.Size(100, 20)
        Me.txtroomno.TabIndex = 3
        '
        'txtcompno
        '
        Me.txtcompno.Location = New System.Drawing.Point(126, 79)
        Me.txtcompno.Name = "txtcompno"
        Me.txtcompno.Size = New System.Drawing.Size(100, 20)
        Me.txtcompno.TabIndex = 4
        '
        'txtfault
        '
        Me.txtfault.Location = New System.Drawing.Point(126, 110)
        Me.txtfault.Multiline = True
        Me.txtfault.Name = "txtfault"
        Me.txtfault.Size = New System.Drawing.Size(156, 67)
        Me.txtfault.TabIndex = 5
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(19, 226)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 6
        Me.btnsubmit.Text = "&SUBMIT"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(126, 226)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 7
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'faultgrid
        '
        Me.faultgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.faultgrid.Location = New System.Drawing.Point(312, 55)
        Me.faultgrid.Name = "faultgrid"
        Me.faultgrid.Size = New System.Drawing.Size(240, 150)
        Me.faultgrid.TabIndex = 8
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(158, 192)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(93, 13)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Change Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(181, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "FAULT LOG"
        '
        'Teacher1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(567, 261)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.faultgrid)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtfault)
        Me.Controls.Add(Me.txtcompno)
        Me.Controls.Add(Me.txtroomno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Teacher1"
        Me.Text = "Teacher1"
        CType(Me.faultgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtroomno As TextBox
    Friend WithEvents txtcompno As TextBox
    Friend WithEvents txtfault As TextBox
    Friend WithEvents btnsubmit As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents faultgrid As DataGridView
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
End Class
