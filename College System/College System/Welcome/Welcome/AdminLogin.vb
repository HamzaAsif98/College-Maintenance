Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class AdminLogin
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ..\..\Resources\Computers.accdb;Persist Security Info=True")
    Dim Adapter As New OleDbDataAdapter
    Dim dslog As DataSet = New DataSet

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()

    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        conn.Open()

        Dim adminName As String
        Dim adminPassword As String
        adminName = txtadmin.Text
        adminPassword = txtadminpass.Text


        'the query:
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Admin] WHERE [Username] = '" & txtadmin.Text & "' AND [Password] = '" & txtadminpass.Text & "'", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found 
        Dim Access As Boolean = False


        'if found:
        While dr.Read
            Access = True

        End While

        'checking the result
        If Access = True Then
            Adminmanagement.Show()
            Me.Close()
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Credentials")
        End If
        conn.Close()

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()

    End Sub
End Class
