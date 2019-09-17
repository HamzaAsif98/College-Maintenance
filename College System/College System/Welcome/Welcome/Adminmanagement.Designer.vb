<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adminmanagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adminmanagement))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtRoomNum = New System.Windows.Forms.TextBox()
        Me.txtComp = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtManuf = New System.Windows.Forms.TextBox()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.lblManuf = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblCompName = New System.Windows.Forms.Label()
        Me.lblRoomNum = New System.Windows.Forms.Label()
        Me.lblSerial = New System.Windows.Forms.Label()
        Me.computergrid = New System.Windows.Forms.DataGridView()
        Me.display = New System.Windows.Forms.DataGridView()
        Me.btnUpdateRoom = New System.Windows.Forms.Button()
        Me.btnDeleteRoom = New System.Windows.Forms.Button()
        Me.btnAddRoom = New System.Windows.Forms.Button()
        Me.lblNumOfComputers = New System.Windows.Forms.Label()
        Me.lblRoomName = New System.Windows.Forms.Label()
        Me.txtNumberOfComputers = New System.Windows.Forms.TextBox()
        Me.txtRoomName = New System.Windows.Forms.TextBox()
        Me.usergrid = New System.Windows.Forms.DataGridView()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.faultlog = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Resolved = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.computergrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usergrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.faultlog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Resolved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(84, 253)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(56, 19)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtRoomNum
        '
        Me.txtRoomNum.Location = New System.Drawing.Point(138, 120)
        Me.txtRoomNum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRoomNum.Name = "txtRoomNum"
        Me.txtRoomNum.Size = New System.Drawing.Size(76, 20)
        Me.txtRoomNum.TabIndex = 20
        '
        'txtComp
        '
        Me.txtComp.Location = New System.Drawing.Point(138, 151)
        Me.txtComp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtComp.Name = "txtComp"
        Me.txtComp.Size = New System.Drawing.Size(76, 20)
        Me.txtComp.TabIndex = 19
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(138, 177)
        Me.txtModel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(76, 20)
        Me.txtModel.TabIndex = 18
        '
        'txtManuf
        '
        Me.txtManuf.Location = New System.Drawing.Point(138, 203)
        Me.txtManuf.Margin = New System.Windows.Forms.Padding(2)
        Me.txtManuf.Name = "txtManuf"
        Me.txtManuf.Size = New System.Drawing.Size(76, 20)
        Me.txtManuf.TabIndex = 17
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(138, 89)
        Me.txtSerial.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(76, 20)
        Me.txtSerial.TabIndex = 16
        '
        'lblManuf
        '
        Me.lblManuf.AutoSize = True
        Me.lblManuf.Location = New System.Drawing.Point(24, 207)
        Me.lblManuf.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblManuf.Name = "lblManuf"
        Me.lblManuf.Size = New System.Drawing.Size(70, 13)
        Me.lblManuf.TabIndex = 15
        Me.lblManuf.Text = "Manufacturer"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(24, 181)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(36, 13)
        Me.lblModel.TabIndex = 14
        Me.lblModel.Text = "Model"
        '
        'lblCompName
        '
        Me.lblCompName.AutoSize = True
        Me.lblCompName.Location = New System.Drawing.Point(24, 155)
        Me.lblCompName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCompName.Name = "lblCompName"
        Me.lblCompName.Size = New System.Drawing.Size(83, 13)
        Me.lblCompName.TabIndex = 13
        Me.lblCompName.Text = "Computer Name"
        '
        'lblRoomNum
        '
        Me.lblRoomNum.AutoSize = True
        Me.lblRoomNum.Location = New System.Drawing.Point(24, 123)
        Me.lblRoomNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRoomNum.Name = "lblRoomNum"
        Me.lblRoomNum.Size = New System.Drawing.Size(75, 13)
        Me.lblRoomNum.TabIndex = 12
        Me.lblRoomNum.Text = "Room Number"
        '
        'lblSerial
        '
        Me.lblSerial.AutoSize = True
        Me.lblSerial.Location = New System.Drawing.Point(24, 93)
        Me.lblSerial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(73, 13)
        Me.lblSerial.TabIndex = 11
        Me.lblSerial.Text = "Serial Number"
        '
        'computergrid
        '
        Me.computergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.computergrid.Location = New System.Drawing.Point(219, 89)
        Me.computergrid.Name = "computergrid"
        Me.computergrid.Size = New System.Drawing.Size(240, 150)
        Me.computergrid.TabIndex = 22
        '
        'display
        '
        Me.display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.display.Location = New System.Drawing.Point(721, 86)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(272, 153)
        Me.display.TabIndex = 23
        '
        'btnUpdateRoom
        '
        Me.btnUpdateRoom.Location = New System.Drawing.Point(549, 187)
        Me.btnUpdateRoom.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateRoom.Name = "btnUpdateRoom"
        Me.btnUpdateRoom.Size = New System.Drawing.Size(110, 28)
        Me.btnUpdateRoom.TabIndex = 30
        Me.btnUpdateRoom.Text = "Update Room"
        Me.btnUpdateRoom.UseVisualStyleBackColor = True
        '
        'btnDeleteRoom
        '
        Me.btnDeleteRoom.Location = New System.Drawing.Point(606, 155)
        Me.btnDeleteRoom.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteRoom.Name = "btnDeleteRoom"
        Me.btnDeleteRoom.Size = New System.Drawing.Size(110, 28)
        Me.btnDeleteRoom.TabIndex = 29
        Me.btnDeleteRoom.Text = "Delete Room"
        Me.btnDeleteRoom.UseVisualStyleBackColor = True
        '
        'btnAddRoom
        '
        Me.btnAddRoom.Location = New System.Drawing.Point(497, 155)
        Me.btnAddRoom.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(110, 28)
        Me.btnAddRoom.TabIndex = 28
        Me.btnAddRoom.Text = "Add Room"
        Me.btnAddRoom.UseVisualStyleBackColor = True
        '
        'lblNumOfComputers
        '
        Me.lblNumOfComputers.AutoSize = True
        Me.lblNumOfComputers.Location = New System.Drawing.Point(494, 124)
        Me.lblNumOfComputers.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumOfComputers.Name = "lblNumOfComputers"
        Me.lblNumOfComputers.Size = New System.Drawing.Size(111, 13)
        Me.lblNumOfComputers.TabIndex = 27
        Me.lblNumOfComputers.Text = "Number Of Computers"
        '
        'lblRoomName
        '
        Me.lblRoomName.AutoSize = True
        Me.lblRoomName.Location = New System.Drawing.Point(494, 94)
        Me.lblRoomName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRoomName.Name = "lblRoomName"
        Me.lblRoomName.Size = New System.Drawing.Size(66, 13)
        Me.lblRoomName.TabIndex = 26
        Me.lblRoomName.Text = "Room Name"
        '
        'txtNumberOfComputers
        '
        Me.txtNumberOfComputers.Location = New System.Drawing.Point(615, 116)
        Me.txtNumberOfComputers.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumberOfComputers.Name = "txtNumberOfComputers"
        Me.txtNumberOfComputers.Size = New System.Drawing.Size(76, 20)
        Me.txtNumberOfComputers.TabIndex = 25
        '
        'txtRoomName
        '
        Me.txtRoomName.Location = New System.Drawing.Point(615, 86)
        Me.txtRoomName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRoomName.Name = "txtRoomName"
        Me.txtRoomName.Size = New System.Drawing.Size(76, 20)
        Me.txtRoomName.TabIndex = 24
        '
        'usergrid
        '
        Me.usergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.usergrid.Location = New System.Drawing.Point(200, 363)
        Me.usergrid.Margin = New System.Windows.Forms.Padding(2)
        Me.usergrid.Name = "usergrid"
        Me.usergrid.RowTemplate.Height = 24
        Me.usergrid.Size = New System.Drawing.Size(277, 104)
        Me.usergrid.TabIndex = 37
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Location = New System.Drawing.Point(96, 443)
        Me.btnDeleteUser.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(79, 24)
        Me.btnDeleteUser.TabIndex = 36
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(13, 403)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(53, 13)
        Me.lblPass.TabIndex = 35
        Me.lblPass.Text = "Password"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(13, 369)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(60, 13)
        Me.lblUser.TabIndex = 34
        Me.lblUser.Text = "User Name"
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(84, 399)
        Me.TxtPass.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(76, 20)
        Me.TxtPass.TabIndex = 33
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(84, 365)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(76, 20)
        Me.txtUser.TabIndex = 32
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(13, 443)
        Me.btnAddUser.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(79, 24)
        Me.btnAddUser.TabIndex = 31
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 18)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Computer Management"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(637, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 18)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Room Management"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 18)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "User Management"
        '
        'btnreport
        '
        Me.btnreport.Location = New System.Drawing.Point(816, 582)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(75, 23)
        Me.btnreport.TabIndex = 43
        Me.btnreport.Text = "Report"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-3, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1010, 23)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "_________________________________________________________________________________" &
    "________________________________________________________________________________" &
    "______" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(897, 582)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 45
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'faultlog
        '
        Me.faultlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.faultlog.Location = New System.Drawing.Point(533, 363)
        Me.faultlog.Name = "faultlog"
        Me.faultlog.Size = New System.Drawing.Size(460, 104)
        Me.faultlog.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(677, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 26)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Fault LogBook" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Resolved
        '
        Me.Resolved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Resolved.Location = New System.Drawing.Point(289, 522)
        Me.Resolved.Name = "Resolved"
        Me.Resolved.Size = New System.Drawing.Size(402, 96)
        Me.Resolved.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(423, 482)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 26)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Resolved Log"
        '
        'Adminmanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1002, 630)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Resolved)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.faultlog)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.usergrid)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.btnUpdateRoom)
        Me.Controls.Add(Me.btnDeleteRoom)
        Me.Controls.Add(Me.btnAddRoom)
        Me.Controls.Add(Me.lblNumOfComputers)
        Me.Controls.Add(Me.lblRoomName)
        Me.Controls.Add(Me.txtNumberOfComputers)
        Me.Controls.Add(Me.txtRoomName)
        Me.Controls.Add(Me.display)
        Me.Controls.Add(Me.computergrid)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtRoomNum)
        Me.Controls.Add(Me.txtComp)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtManuf)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.lblManuf)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblCompName)
        Me.Controls.Add(Me.lblRoomNum)
        Me.Controls.Add(Me.lblSerial)
        Me.Name = "Adminmanagement"
        Me.Text = "Adminmanagement"
        CType(Me.computergrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usergrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.faultlog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Resolved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents txtRoomNum As TextBox
    Friend WithEvents txtComp As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtManuf As TextBox
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents lblManuf As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblCompName As Label
    Friend WithEvents lblRoomNum As Label
    Friend WithEvents lblSerial As Label
    Friend WithEvents computergrid As DataGridView
    Friend WithEvents display As DataGridView
    Friend WithEvents btnUpdateRoom As Button
    Friend WithEvents btnDeleteRoom As Button
    Friend WithEvents btnAddRoom As Button
    Friend WithEvents lblNumOfComputers As Label
    Friend WithEvents lblRoomName As Label
    Friend WithEvents txtNumberOfComputers As TextBox
    Friend WithEvents txtRoomName As TextBox
    Friend WithEvents usergrid As DataGridView
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents lblPass As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents btnAddUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnreport As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents faultlog As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Resolved As DataGridView
    Friend WithEvents Label6 As Label
End Class
