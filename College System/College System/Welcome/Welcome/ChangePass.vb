Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class ChangePass
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ..\..\Resources\Computers.accdb;Persist Security Info=True")
    Dim Adapter As New OleDbDataAdapter
    Dim dscomp As DataSet = New DataSet
    Private Sub ChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtnew.Text <> txtconfirm.Text Then
            MessageBox.Show("Passwords does not match ! Check Your Credential")

        ElseIf txtNew.Text = txtConfirm.Text Then
            Dim update = New OleDbCommand("UPDATE [Teacher] SET [Password] = '" & txtconfirm.Text & "' where [Password] = '" & txtold.Text & "'", conn)
            update.ExecuteNonQuery()
            MessageBox.Show("Password is updated ")
            conn.Close()
        End If
        txtconfirm.Clear()
        txtnew.Clear()
        txtold.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub
End Class