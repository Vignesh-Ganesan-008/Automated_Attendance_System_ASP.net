Imports MySql.Data.MySqlClient

Public Class MyDetails
    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs)
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        'textBox1.Text = Form1.textBox1.Text
        conn.ConnectionString = "server=127.0.0.1;userid=root;password=;database=vb;Convert Zero Datetime=True"
        Try

            conn.Open()
        Catch myerror As MySqlException
            MessageBox.Show("Error Connecting to Database: " & myerror.Message)

        End Try

        Dim myAdapter As New MySqlDataAdapter
        Dim myCommand As New MySqlCommand()
        myCommand.Connection = conn
        myCommand.CommandText = "SELECT * FROM studentlogin WHERE sid='" & Form1.textBox1.Text & "' LIMIT 1"
' Author : Vignesh Ganesan
        myAdapter.SelectCommand = myCommand

        Dim moddata As MySqlDataReader
        moddata = myCommand.ExecuteReader()

        Do While moddata.Read
            Label12.Text = moddata("sname").ToString
            Label22.Text = moddata("gen").ToString
            Label23.Text = moddata("contact").ToString
            Label24.Text = moddata("email").ToString
            Label25.Text = moddata("addr").ToString
            Label26.Text = moddata("dob").ToString
            Label27.Text = moddata("class").ToString
            Label28.Text = moddata("cteach").ToString
            Label29.Text = moddata("pass").ToString

        Loop

        conn.Close()
    End Sub

    Private Sub MyDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        Label30.Text = Form1.textBox1.Text
        conn.ConnectionString = "server=127.0.0.1;userid=root;password=;database=vb;Convert Zero Datetime=True"
        Try

            conn.Open()
        Catch myerror As MySqlException
            MessageBox.Show("Error Connecting to Database: " & myerror.Message)

        End Try

        Dim myAdapter As New MySqlDataAdapter
        Dim myCommand As New MySqlCommand()
        myCommand.Connection = conn
        myCommand.CommandText = "SELECT * FROM studentlogin WHERE sid='" & Label30.Text & "' LIMIT 1"

        myAdapter.SelectCommand = myCommand

        Dim moddata As MySqlDataReader
        moddata = myCommand.ExecuteReader()

        Do While moddata.Read
            Label12.Text = moddata("sname").ToString
            Label22.Text = moddata("gen").ToString
            Label23.Text = moddata("contact").ToString
            Label24.Text = moddata("email").ToString
            Label25.Text = moddata("addr").ToString
            Label26.Text = moddata("dob").ToString
            Label27.Text = moddata("class").ToString
            Label28.Text = moddata("cteach").ToString
            Label29.Text = moddata("pass").ToString

        Loop

        conn.Close()
    End Sub
End Class