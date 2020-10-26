<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeStudent))
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.myDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.myDetailsToolStripMenuItem, Me.viewAttendanceToolStripMenuItem, Me.logoutToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(579, 24)
        Me.menuStrip1.TabIndex = 3
        Me.menuStrip1.Text = "menuStrip1"
        '
        'myDetailsToolStripMenuItem
        '
        Me.myDetailsToolStripMenuItem.Name = "myDetailsToolStripMenuItem"
        Me.myDetailsToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.myDetailsToolStripMenuItem.Text = "My Details"
        '
        'viewAttendanceToolStripMenuItem
        '
        Me.viewAttendanceToolStripMenuItem.Name = "viewAttendanceToolStripMenuItem"
        Me.viewAttendanceToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.viewAttendanceToolStripMenuItem.Text = "View Attendance"
        '
        'logoutToolStripMenuItem
        '
        Me.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem"
        Me.logoutToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.logoutToolStripMenuItem.Text = "Logout"
        '
        'HomeStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(579, 474)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "HomeStudent"
        Me.Text = "HomeStudent"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents myDetailsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewAttendanceToolStripMenuItem As ToolStripMenuItem
    Private WithEvents logoutToolStripMenuItem As ToolStripMenuItem
End Class
