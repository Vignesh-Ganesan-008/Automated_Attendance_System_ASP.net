Public Class Home
    Private Sub addTeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addTeacherToolStripMenuItem.Click
        AddTeacher.ShowDialog()
    End Sub

    Private Sub addStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addStudentToolStripMenuItem.Click
        AddStudent.ShowDialog()
    End Sub

    Private Sub viewTeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewTeacherToolStripMenuItem.Click
        ViewTeacher.ShowDialog()
    End Sub

    Private Sub viewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewStudentToolStripMenuItem.Click
        ViewStudent.ShowDialog()
    End Sub

    Private Sub viewAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewAttendanceToolStripMenuItem.Click
        TeacherAttendance.ShowDialog()
    End Sub

    Private Sub logoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logoutToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class