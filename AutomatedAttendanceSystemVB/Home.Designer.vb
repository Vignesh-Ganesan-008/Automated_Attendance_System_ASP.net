<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.addTeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewTeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addTeacherToolStripMenuItem, Me.addStudentToolStripMenuItem, Me.viewTeacherToolStripMenuItem, Me.viewStudentToolStripMenuItem, Me.viewAttendanceToolStripMenuItem, Me.logoutToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(606, 24)
        Me.menuStrip1.TabIndex = 1
        Me.menuStrip1.Text = "menuStrip1"
        '
        'addTeacherToolStripMenuItem
        '
        Me.addTeacherToolStripMenuItem.Name = "addTeacherToolStripMenuItem"
        Me.addTeacherToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.addTeacherToolStripMenuItem.Text = "Add Teacher"
        '
        'addStudentToolStripMenuItem
        '
        Me.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem"
        Me.addStudentToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.addStudentToolStripMenuItem.Text = "Add Student"
        '
        'viewTeacherToolStripMenuItem
        '
        Me.viewTeacherToolStripMenuItem.Name = "viewTeacherToolStripMenuItem"
        Me.viewTeacherToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.viewTeacherToolStripMenuItem.Text = "View Teacher"
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
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(606, 462)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "Home"
        Me.Text = "`"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents addTeacherToolStripMenuItem As ToolStripMenuItem
    Private WithEvents addStudentToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewTeacherToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewStudentToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewAttendanceToolStripMenuItem As ToolStripMenuItem
    Private WithEvents logoutToolStripMenuItem As ToolStripMenuItem
End Class
