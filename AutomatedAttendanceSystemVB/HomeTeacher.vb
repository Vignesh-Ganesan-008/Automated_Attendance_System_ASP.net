Public Class HomeTeacher
    Private Sub takeAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles takeAttendanceToolStripMenuItem.Click
        TakeAttendance.ShowDialog()
    End Sub

    Private Sub viewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewStudentToolStripMenuItem.Click
        ViewStudent.ShowDialog()
    End Sub

    Private Sub viewAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewAttendanceToolStripMenuItem.Click
        TeacherAttendance.ShowDialog()
    End Sub

    Private Sub logoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logoutToolStripMenuItem.Click
        Form1.Show()
        Hide()
    End Sub
End Class