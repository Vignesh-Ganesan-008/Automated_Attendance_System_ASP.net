Imports MySql.Data.MySqlClient
Public Class TakeAttendance

    Dim Mysqlconn As MySqlConnection
    Dim command As MySqlCommand
    Dim gender As String
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click


        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=127.0.0.1;userid=root;password=;database=vb;"
        Dim READER As MySqlDataReader
        Try
            Mysqlconn.Open()
            Dim Query As String
            Query = "insert into vb.atten (class,date,`1`,`2`,`3`,`4`,`5`,`6`,`7`,`8`,`9`,`10`) values ('" & comboBox1.Text & "','" & DateTimePicker1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & ComboBox5.Text & "','" & ComboBox6.Text & "','" & ComboBox7.Text & "','" & ComboBox8.Text & "','" & ComboBox9.Text & "','" & ComboBox10.Text & "','" & ComboBox11.Text & "')"
            command = New MySqlCommand(Query, Mysqlconn)
            READER = command.ExecuteReader
            MessageBox.Show("Data Saved")
            Mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()

        End Try
    End Sub

' Author : Vignesh Ganesan

    Private Sub TakeAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.MaxDate = Date.Now
    End Sub
End Class