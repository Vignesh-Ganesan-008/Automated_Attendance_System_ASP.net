Imports MySql.Data.MySqlClient
Imports System.Data

Public Class ViewTeacher
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=127.0.0.1;userid=root;password=;database=vb;Convert Zero Datetime=True"
        Try

            conn.Open()
        Catch myerror As MySqlException
            MessageBox.Show("Error Connecting to Database: " & myerror.Message)

        End Try

        Dim myAdapter As New MySqlDataAdapter
        Dim myCommand As New MySqlCommand()
        myCommand.Connection = conn
        myCommand.CommandText = "SELECT * FROM login WHERE uname='" & textBox1.Text & "' LIMIT 1"

        myAdapter.SelectCommand = myCommand

        Dim dt As New DataTable()
        dt.Load(myCommand.ExecuteReader())
        DataGridView1.DataSource = dt

        conn.Close()
    End Sub


End Class