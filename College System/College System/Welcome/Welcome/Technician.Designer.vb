<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Technician
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Technician))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtroom = New System.Windows.Forms.TextBox()
        Me.displayfaultgrid = New System.Windows.Forms.DataGridView()
        Me.searchfault = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.resolved = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcomment = New System.Windows.Forms.TextBox()
        Me.btnresolve = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        CType(Me.displayfaultgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.resolved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room No"
        '
        'txtroom
        '
        Me.txtroom.Location = New System.Drawing.Point(103, 93)
        Me.txtroom.Name = "txtroom"
        Me.txtroom.Size = New System.Drawing.Size(100, 20)
        Me.txtroom.TabIndex = 1
        '
        'displayfaultgrid
        '
        Me.displayfaultgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.displayfaultgrid.Location = New System.Drawing.Point(234, 65)
        Me.displayfaultgrid.Name = "displayfaultgrid"
        Me.displayfaultgrid.Size = New System.Drawing.Size(240, 150)
        Me.displayfaultgrid.TabIndex = 2
        '
        'searchfault
        '
        Me.searchfault.Location = New System.Drawing.Point(47, 135)
        Me.searchfault.Name = "searchfault"
        Me.searchfault.Size = New System.Drawing.Size(156, 23)
        Me.searchfault.TabIndex = 3
        Me.searchfault.Text = "Search From Faults Log"
        Me.searchfault.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(78, 164)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "Clear Grid"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(114, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Technician Check Log"
        '
        'resolved
        '
        Me.resolved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.resolved.Location = New System.Drawing.Point(234, 270)
        Me.resolved.Name = "resolved"
        Me.resolved.Size = New System.Drawing.Size(240, 160)
        Me.resolved.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Technician Comment"
        '
        'txtcomment
        '
        Me.txtcomment.Location = New System.Drawing.Point(116, 297)
        Me.txtcomment.Name = "txtcomment"
        Me.txtcomment.Size = New System.Drawing.Size(100, 20)
        Me.txtcomment.TabIndex = 8
        '
        'btnresolve
        '
        Me.btnresolve.Location = New System.Drawing.Point(76, 339)
        Me.btnresolve.Name = "btnresolve"
        Me.btnresolve.Size = New System.Drawing.Size(75, 23)
        Me.btnresolve.TabIndex = 9
        Me.btnresolve.Text = "Resolved"
        Me.btnresolve.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(12, 442)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 10
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Technician
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(528, 477)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnresolve)
        Me.Controls.Add(Me.txtcomment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.resolved)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.searchfault)
        Me.Controls.Add(Me.displayfaultgrid)
        Me.Controls.Add(Me.txtroom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Technician"
        Me.Text = "Technician"
        CType(Me.displayfaultgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.resolved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtroom As TextBox
    Friend WithEvents displayfaultgrid As DataGridView
    Friend WithEvents searchfault As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents resolved As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcomment As TextBox
    Friend WithEvents btnresolve As Button
    Friend WithEvents btncancel As Button
End Class
