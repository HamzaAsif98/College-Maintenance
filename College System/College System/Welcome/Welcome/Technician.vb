Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Technician
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ..\..\Resources\Computers.accdb;Persist Security Info=True")
    Dim compAdapter As New OleDbDataAdapter
    Dim dscomp As DataSet = New DataSet

    Private Sub Technician_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim sqlquery As String = "(SELECT * FROM [FaultInfo])"
            compAdapter.SelectCommand = New OleDbCommand(sqlquery, conn)
            compAdapter.Fill(dscomp, "allFaults")
            displayfaultgrid.DataSource = dscomp.Tables("allFaults")
            Dim sqlquery2 As String = "Select * From [Resolved]"
            compAdapter.SelectCommand = New OleDbCommand(sqlquery2, conn)
            compAdapter.Fill(dscomp, "allresolved")
            resolved.DataSource = dscomp.Tables("allresolved")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub searchfault_Click(sender As Object, e As EventArgs) Handles searchfault.Click
        displayfaultgrid.DataSource.clear()
        Dim RoomNo As Integer = txtroom.Text

        Try

            Dim sqlquery As String = "(SELECT * FROM [FaultInfo] WHERE [RoomNum] =  " & RoomNo & "  )"
            compAdapter.SelectCommand = New OleDbCommand(sqlquery, conn)
            compAdapter.Fill(dscomp, "allFaults")
            displayfaultgrid.DataSource = dscomp.Tables("allFaults")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        displayfaultgrid.Refresh()
        conn.Close()

    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        displayfaultgrid.DataSource.Clear()

    End Sub
    Private Sub updateDBTable()
        Dim SQLInsert As String
        SQLInsert = "Insert into [Resolved] Values (RoomNum,DateLogged,CompNumber,FaultDesc,UsersName,TechnicianComment')"
        Dim insertCommand As New OleDbCommand(SQLInsert, conn)
        insertCommand.ExecuteNonQuery()
        MessageBox.Show("Resolved")

    End Sub
    Private Sub btnresolve_Click(sender As Object, e As EventArgs) Handles btnresolve.Click
        Dim comment As String = txtcomment.Text
        Try

            Dim query As String = "INSERT INTO Resolved (RoomNum,DateLogged,CompNumber,FaultDesc,UsersName,TechnicianComment) VALUES ( RoomNum,DateLogged,CompNumber,FaultDesc,UsersName, from FaultInfo)"

            compAdapter.InsertCommand = New OleDbCommand(query, conn)
            compAdapter.Fill(dscomp, "allResolved")
            resolved.DataSource = dscomp.Tables("allResolved")
            If Me.displayfaultgrid.Rows.Count > 0 Then
                If Me.displayfaultgrid.SelectedRows.Count > 0 Then
                    Dim intStdID As Integer = Me.displayfaultgrid.SelectedRows(0).Cells("RoomNum").Value
                    'open connection
                    If Not conn.State = ConnectionState.Open Then
                        conn.Open()
                    End If

                    'delete data
                    Dim cmd As New SqlCommand
                    cmd.CommandText = "DELETE FROM FaultInfo WHERE RoomNo=" & intStdID
                    Dim res As DialogResult
                    res = MsgBox("Are you sure you want to DELETE the selected Row?", MessageBoxButtons.YesNo)
                    If res = Windows.Forms.DialogResult.Yes Then
                        cmd.ExecuteNonQuery()
                    Else : Exit Sub
                    End If

                End If
            End If
            displayfaultgrid.DataSource.refresh
            resolved.DataSource.refresh
        Catch ex As Exception
        End Try



    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Hide()

    End Sub
End Class