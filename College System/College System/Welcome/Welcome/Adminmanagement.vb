Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Adminmanagement
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ..\..\Resources\Computers.accdb;Persist Security Info=True")
    Dim compAdapter As New OleDbDataAdapter
    Dim dscomp As DataSet = New DataSet
    Dim SerialNum, RoomNumber, CompNumber As Int64
    Dim Model, Manufacturer As String
    Dim RoomName, NumberOfComputers As String
    Dim username, password As String

    Private Sub Adminmanagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim query3 As String = "Select * From [Resolved]"
            compAdapter.SelectCommand = New OleDbCommand(query3, conn)
            compAdapter.Fill(dscomp, "allresolved")
            Resolved.DataSource = dscomp.Tables("allresolved")
            Dim query2 As String = "Select * From [FaultInfo]"
            compAdapter.SelectCommand = New OleDbCommand(query2, conn)
            compAdapter.Fill(dscomp, "allFaultLog")
            faultlog.DataSource = dscomp.Tables("allfaultlog")
            Dim sqlquery As String = "Select * From [ComputerInfo]"
            compAdapter.SelectCommand = New OleDbCommand(sqlquery, conn)
            compAdapter.Fill(dscomp, "allCompInfo")
            computergrid.DataSource = dscomp.Tables("allCompInfo")
            Dim query As String = "Select * From [Rooms]"
            compAdapter.SelectCommand = New OleDbCommand(query, conn)
            compAdapter.Fill(dscomp, "allRooms")
            display.DataSource = dscomp.Tables("allRooms")
            Dim query1 As String = "Select * From [Teacher]"
            compAdapter.SelectCommand = New OleDbCommand(query1, conn)
            compAdapter.Fill(dscomp, "allTeacher")
            usergrid.DataSource = dscomp.Tables("allTeacher")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'conn.Close()

        End Try


    End Sub
    Private Sub btnDeleteRoom_Click(sender As Object, e As EventArgs) Handles btnDeleteRoom.Click

        ' Delete from the datasource.
        dscomp.Tables("allRooms").Rows(0).Delete()


        'Delete from the underlying database table.

        Dim deleteCommand As String

        Dim toDelete As String = txtRoomName.Text


        deleteCommand = "Delete"

        deleteCommand = "Delete From [Rooms] where RoomName = '" & toDelete & "'"
        Dim SQLDelete As New OleDbCommand(deleteCommand, conn)
        SQLDelete.ExecuteNonQuery()
        MessageBox.Show("Room Deleted")
        display.Refresh()
        '   conn.Close()

    End Sub

    Private Sub btnUpdateRoom_Click(sender As Object, e As EventArgs) Handles btnUpdateRoom.Click
        'Updating Room 
        Dim update As String = ("UPDATE [Rooms] SET [NumberOfComputers] = '" & NumberOfComputers & "' where [RoomName] = '" & RoomName & "'")
        Dim updateCommand As New OleDbCommand(update, conn)
        updateCommand.ExecuteNonQuery()
        RoomName = txtRoomName.Text
        NumberOfComputers = txtNumberOfComputers.Text
        MessageBox.Show("Room Updated")
        display.Refresh()

        'conn.Close()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        'Adding Room To Room Table
        Dim SQLInsert As String


        SQLInsert = "Insert into [Rooms] Values ('" & RoomName & "','" & NumberOfComputers & "')"
        Dim insertCommand As New OleDbCommand(SQLInsert, conn)
        insertCommand.ExecuteNonQuery()
        MessageBox.Show("Room Added")
        RoomName = txtRoomName.Text



        RoomName = txtRoomName.Text
        NumberOfComputers = txtNumberOfComputers.Text
        Dim userRow As DataRow

        userRow = dscomp.Tables("allRooms").NewRow()

        userRow.Item("RoomName") = RoomName
        userRow.Item("NumberOfComputers") = NumberOfComputers


        dscomp.Tables("allRooms").Rows.Add(userRow)
        display.Refresh()
        'conn.Close()

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Hide()

    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        MessageBox.Show("Room With Most Faults : 113")

        MessageBox.Show("Total Computer : 4")
    End Sub

    Private Sub updateDBTable()
        'updating Computer Tables
        Dim SQLInsert As String


        SQLInsert = "Insert into [ComputerInfo] Values ('" & SerialNum & "','" & RoomNumber & "','" & CompNumber & "','" & Model & "','" & Manufacturer & "')"
        Dim insertCommand As New OleDbCommand(SQLInsert, conn)
        insertCommand.ExecuteNonQuery()
        MessageBox.Show("Computer Added")
        'conn.Close()
    End Sub
    Private Sub updateTeacherTable()
        'updating teacher tables
        Dim SQLInsert As String

        SQLInsert = "Insert into [Teacher] Values ('" & username & "','" & password & "')"
        Dim insertCommand As New OleDbCommand(SQLInsert, conn)
        insertCommand.ExecuteNonQuery()
        MessageBox.Show("User Added")

    End Sub
    'Adding Computer To Computers Table
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        SerialNum = txtSerial.Text
        RoomNumber = txtRoomNum.Text
        CompNumber = txtComp.Text
        Model = txtModel.Text
        Manufacturer = txtManuf.Text
        Dim compRow As DataRow
        compRow = dscomp.Tables("allCompInfo").NewRow()




        compRow.Item("SerialNumber") = SerialNum
        compRow.Item("RoomNumber") = RoomNumber
        compRow.Item("CompName") = CompNumber
        compRow.Item("Model") = Model
        compRow.Item("Manufacturer") = Manufacturer

        dscomp.Tables("allCompInfo").Rows.Add(compRow)
        If dscomp.Tables.Count = 0 Then Exit Sub
        updateDBTable()
        ' conn.Close()
    End Sub
    'Adding User From Teachers Table
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        username = txtUser.Text



        'the query:
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Teacher] WHERE [Username] = '" & txtUser.Text & "'", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found 
        Dim userFound As Boolean = False


        'if found:
        While dr.Read
            userFound = True

        End While

        'checking the result
        If userFound = True Then
            MsgBox("Username already exists", MsgBoxStyle.OkOnly, "Error")


        Else

            username = txtUser.Text
            password = TxtPass.Text
            Dim userRow As DataRow

            userRow = dscomp.Tables("allTeacher").NewRow()

            userRow.Item("Username") = username
            userRow.Item("Password") = password


            dscomp.Tables("allTeacher").Rows.Add(userRow)

            updateTeacherTable()
            usergrid.Refresh()
        End If
    End Sub
    'Deleting User From Teachers Table
    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        ' Delete from the datasource.
        dscomp.Tables("allTeacher").Rows(0).Delete()


        'Delete from the underlying database table.

        Dim deleteCommand As String

        Dim toDelete As String = txtUser.Text


        deleteCommand = "Delete"

        deleteCommand = "Delete From [Teacher] where Username = '" & toDelete & "'"
        Dim SQLDelete As New OleDbCommand(deleteCommand, conn)
        SQLDelete.ExecuteNonQuery()
        MessageBox.Show("User Deleted")
        usergrid.Refresh()
    End Sub

End Class