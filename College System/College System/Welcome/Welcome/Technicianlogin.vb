Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Technicianlogin
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ..\..\Resources\Computers.accdb;Persist Security Info=True")
    Dim Adapter As New OleDbDataAdapter
    Dim dslog As DataSet = New DataSet

    Private Sub Technicianlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim techName As String
        Dim techPassword As String
        techName = txttech.Text
        techPassword = txttechpass.Text


        'the query:
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Technician] WHERE [Username] = '" & txttech.Text & "' AND [Password] = '" & txttechpass.Text & "'", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found 
        Dim Access As Boolean = False


        'Founding Data from table
        While dr.Read
            Access = True

        End While

        'checking the result of the query
        If Access = True Then
            Technician.Show()
            txttechpass.Clear()

        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Credentials")
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()

    End Sub
End Class
