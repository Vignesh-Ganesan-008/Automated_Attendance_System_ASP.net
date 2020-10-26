Imports MySql.Data.MySqlClient
Public Class Form1

    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertstring As String

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        textBox1.Text = ""
        textBox2.Text = ""
        comboBox1.Text = "--Select--"
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        conn = New MySqlConnection
        Dim reader As MySqlDataReader
        conn.ConnectionString = "server=127.0.0.1;userid=root;password=;database=vb;"
        Try
            conn.Open()
            'MessageBox.Show("Welcome")
            Dim query As String
            If comboBox1.SelectedIndex = "0" Then
                If textBox1.Text = "Admin" And textBox2.Text = "12345" Then
                    Home.Show()
                End If
            ElseIf comboBox1.SelectedIndex = "1" Then
                query = "select * from vb.login where uname='" & textBox1.Text & "' and pass='" & textBox2.Text & "'"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count = 1 Then
                    MessageBox.Show("Welcome")
                    Me.Hide()
                    HomeTeacher.Show()
                ElseIf count > 1 Then
                    MessageBox.Show("USERNAME and PASSWORD are incorrect")
                Else
                    MessageBox.Show("USERNAME and PASSWORD are incorrect")
                End If
                'conn.Close()
            ElseIf comboBox1.SelectedIndex = "2" Then
                query = "select * from vb.studentlogin where sid='" & textBox1.Text & "' and pass='" & textBox2.Text & "'"
                command = New MySqlCommand(query, conn)
                reader = command.ExecuteReader
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count = 1 Then
                    MessageBox.Show("username and password are correct")
                    Me.Hide()
                    HomeStudent.Show()
                ElseIf count > 1 Then
                    MessageBox.Show("username and password are incorrect")
                Else
                    MessageBox.Show("username and password are incorrect")
                End If
                'conn.Close()
            End If
            conn.Close()

        Catch ex As mySqlException


        Finally

        End Try

    End Sub
End Class
