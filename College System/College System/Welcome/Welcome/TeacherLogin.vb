Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class TeacherLogin
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ..\..\Resources\Computers.accdb;Persist Security Info=True")
    Dim Adapter As New OleDbDataAdapter
    Dim dslog As DataSet = New DataSet

    Private Sub TeacherLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim teacherName As String
        Dim teacherPassword As String
        teacherName = txtteacher.Text
        teacherPassword = txtteachpass.Text


        'the query:
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Teacher] WHERE [Username] = '" & txtteacher.Text & "' AND [Password] = '" & txtteachpass.Text & "'", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found 
        Dim Access As Boolean = False


        'if found:
        While dr.Read
            Access = True

        End While

        'checking the result
        If Access = True Then
            Teacher1.Show()
            txtteachpass.Clear()
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Credentials")
        End If
    End Sub
End Class
