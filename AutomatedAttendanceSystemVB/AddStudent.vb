Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
' Author : Vignesh Ganesan
Public Class AddStudent
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
            Query = "insert into vb.studentlogin (sid,sname,gen,contact,email,addr,dob,class,pass,cteach) values ('" & textBox1.Text & "','" & textBox2.Text & "','" & gender & "','" & textBox3.Text & "','" & textBox4.Text & "','" & textBox6.Text & "','" & textBox5.Text & "','" & textBox7.Text & "','" & textBox9.Text & "','" & textBox8.Text & "')"
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

    Private Sub radioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radioButton1.CheckedChanged
        'Dim gender As String
        gender = "Male"
    End Sub

    Private Sub radioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles radioButton2.CheckedChanged
        ' Dim gender As String
        gender = "Female"
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=127.0.0.1;userid=root;password=;database=vb;"
        Dim READER As MySqlDataReader
        Try
            Mysqlconn.Open()
            Dim Query As String
            Query = "delete from studentlogin where sid='" & textBox1.Text & "'"
            command = New MySqlCommand(Query, Mysqlconn)
            READER = command.ExecuteReader
            MessageBox.Show("Data Deleted")
            Mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()

        End Try
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=127.0.0.1;userid=root;password=;database=vb;"
        Dim READER As MySqlDataReader
        Try
            Mysqlconn.Open()
            Dim Query As String
            Query = "UPDATE studentlogin SET `sname`='" & textBox2.Text & "',`gen`='" & gender & "',`contact`='" & textBox3.Text & "',`email`='" & textBox4.Text & "',`addr`='" & textBox6.Text & "',`dob`='" & textBox5.Text & "',`class`='" & textBox7.Text & "',`pass`='" & textBox9.Text & "',`cteach`='" & textBox8.Text & "' WHERE sid='" & textBox1.Text & "'"
            command = New MySqlCommand(Query, Mysqlconn)
            READER = command.ExecuteReader
            MessageBox.Show("Data Updated")
            Mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()

        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        textBox1.Clear()
        textBox2.Clear()
        textBox3.Clear()
        textBox4.Clear()
        textBox5.Clear()
        textBox6.Clear()
        textBox7.Clear()
        textBox8.Clear()
        textBox9.Clear()
    End Sub

    Private Sub AddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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
        myCommand.CommandText = "SELECT * FROM studentlogin "

        myAdapter.SelectCommand = myCommand

        Dim dt As New DataTable()
        dt.Load(myCommand.ExecuteReader())
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub textBox3_TextChanged(sender As Object, e As EventArgs) Handles textBox3.LostFocus
        If Not IsNumeric(textBox3.Text) Then
            MsgBox("Enter a valid phone number")
            textBox3.Clear()
        End If
    End Sub

    Private Sub textBox2_TextChanged(sender As Object, e As EventArgs) Handles textBox2.LostFocus
        If Not Char.IsLetter(textBox2.Text) Then
            MsgBox("Enter a valid name")
            textBox2.Clear()
        End If
    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged
        If Not IsNumeric(textBox1.Text) Then
            MsgBox("Enter a valid phone number")
            textBox1.Clear()
        End If
    End Sub
End Class
' Author : Vignesh Ganesan