Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Teacher1
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ..\..\Resources\Computers.accdb;Persist Security Info=True")
    Dim compAdapter As New OleDbDataAdapter
    Dim dscomp As DataSet = New DataSet
    Dim RoomNum, CompNumber As Int64
    Dim DateLogged As Date
    Dim FaultDesc, UsersName As String
    Private Sub Teacher1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim sqlquery As String = "Select * From [FaultInfo]"
            compAdapter.SelectCommand = New OleDbCommand(sqlquery, conn)
            compAdapter.Fill(dscomp, "Computers")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub updateDBTable()
        Dim SQLInsert As String
        SQLInsert = "Insert into [FaultInfo] Values ('" & RoomNum & "','" & DateLogged & "','" & CompNumber & "','" & FaultDesc & "','" & UsersName & "')"
        Dim insertCommand As New OleDbCommand(SQLInsert, conn)
        insertCommand.ExecuteNonQuery()
        MessageBox.Show("Fault Logged")

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Hide()

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [FaultInfo] WHERE [CompNumber] = " & txtcompno.Text & "", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        Dim compFound As Boolean = False


        While dr.Read
            compFound = True

        End While

        If compFound = True Then
            MsgBox("Error, Fault Already Logged", MsgBoxStyle.OkOnly, "Error")


        Else
            RoomNum = txtroomno.Text
        DateLogged = Date.Now()
        CompNumber = txtcompno.Text
        FaultDesc = txtfault.Text
        UsersName = TeacherLogin.txtteacher.Text
        Dim comp As DataRow
        comp = dscomp.Tables("Computers").NewRow()




        comp.Item("RoomNum") = RoomNum
        comp.Item("DateLogged") = DateLogged
        comp.Item("CompNumber") = CompNumber
        comp.Item("FaultDesc") = FaultDesc
        comp.Item("UsersName") = UsersName

        dscomp.Tables("Computers").Rows.Add(comp)
        If dscomp.Tables.Count = 0 Then Exit Sub
        updateDBTable()
        faultgrid.DataSource = dscomp.Tables("Computers")
        txtcompno.Clear()
        txtfault.Clear()
        txtroomno.Clear()
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ChangePass.Show()

    End Sub
End Class