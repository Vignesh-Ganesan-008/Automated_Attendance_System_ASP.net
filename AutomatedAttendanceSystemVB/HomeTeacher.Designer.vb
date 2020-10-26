<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeTeacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeTeacher))
        Me.menuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.takeAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip2
        '
        Me.menuStrip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.takeAttendanceToolStripMenuItem, Me.viewStudentToolStripMenuItem, Me.viewAttendanceToolStripMenuItem, Me.logoutToolStripMenuItem})
        Me.menuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip2.Name = "menuStrip2"
        Me.menuStrip2.Size = New System.Drawing.Size(595, 24)
        Me.menuStrip2.TabIndex = 3
        Me.menuStrip2.Text = "menuStrip2"
        '
        'takeAttendanceToolStripMenuItem
        '
        Me.takeAttendanceToolStripMenuItem.Name = "takeAttendanceToolStripMenuItem"
        Me.takeAttendanceToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.takeAttendanceToolStripMenuItem.Text = "Take Attendance"
        '
        'viewStudentToolStripMenuItem
        '
        Me.viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem"
        Me.viewStudentToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.viewStudentToolStripMenuItem.Text = "View Student"
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
        'HomeTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(595, 468)
        Me.Controls.Add(Me.menuStrip2)
        Me.Name = "HomeTeacher"
        Me.Text = "HomeTeacher"
        Me.menuStrip2.ResumeLayout(False)
        Me.menuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip2 As MenuStrip
    Private WithEvents takeAttendanceToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewStudentToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewAttendanceToolStripMenuItem As ToolStripMenuItem
    Private WithEvents logoutToolStripMenuItem As ToolStripMenuItem
End Class
