Public Class HomeStudent
    Private Sub myDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles myDetailsToolStripMenuItem.Click
        MyDetails.ShowDialog()
    End Sub

    Private Sub viewAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewAttendanceToolStripMenuItem.Click
        ViewAttendance.ShowDialog()
    End Sub

    Private Sub logoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logoutToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class