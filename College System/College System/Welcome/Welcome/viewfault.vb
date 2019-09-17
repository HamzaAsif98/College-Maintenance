Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class viewfault
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ..\..\Resources\Computers.accdb;Persist Security Info=True")
    Dim compAdapter As New OleDbDataAdapter
    Dim dscomp As DataSet = New DataSet
    Private Sub viewfault_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim query3 As String = "Select * From [Resolved]"
            compAdapter.SelectCommand = New OleDbCommand(query3, conn)
            compAdapter.Fill(dscomp, "allresolved")
            resolve.DataSource = dscomp.Tables("allresolved")
            Dim query2 As String = "Select * From [FaultInfo]"
            compAdapter.SelectCommand = New OleDbCommand(query2, conn)
            compAdapter.Fill(dscomp, "allFaultLog")
            fault.DataSource = dscomp.Tables("allfaultlog")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class