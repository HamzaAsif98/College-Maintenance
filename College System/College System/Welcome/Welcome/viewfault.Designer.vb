<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewfault
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewfault))
        Me.fault = New System.Windows.Forms.DataGridView()
        Me.resolve = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.fault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.resolve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fault
        '
        Me.fault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.fault.Location = New System.Drawing.Point(12, 63)
        Me.fault.Name = "fault"
        Me.fault.Size = New System.Drawing.Size(314, 264)
        Me.fault.TabIndex = 0
        '
        'resolve
        '
        Me.resolve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.resolve.Location = New System.Drawing.Point(332, 63)
        Me.resolve.Name = "resolve"
        Me.resolve.Size = New System.Drawing.Size(317, 264)
        Me.resolve.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FAULTS LOGBOOK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(367, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "RESOLVED LOGBOOK"
        '
        'viewfault
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(663, 336)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.resolve)
        Me.Controls.Add(Me.fault)
        Me.Name = "viewfault"
        Me.Text = "viewfault"
        CType(Me.fault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.resolve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fault As DataGridView
    Friend WithEvents resolve As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
