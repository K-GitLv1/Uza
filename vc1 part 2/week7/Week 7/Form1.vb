Imports System.Data.OleDb

Public Class Form1
    Dim Conn As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db_Test.mdb")
    Dim CMD As OleDbCommand
    Dim dr As OleDbDataReader
    Dim SQL As String

    Sub LoadInfo()
        SQL = "SELECT * FROM stdData"
        CMD = New OleDbCommand(SQL, Conn)
        Try
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            dr = CMD.ExecuteReader
            DataGrid_Conn.Rows.Clear()
            While dr.Read
                DataGrid_Conn.Rows.Add(dr("std_id").ToString, dr("std_address").ToString, dr("std_name").ToString, dr("std_tel").ToString)
            End While
            Conn.Close()
            CMD.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnConn_Click(sender As Object, e As EventArgs) Handles btnConn.Click
        Call LoadInfo()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        DataGrid_Conn.Rows.Clear()
    End Sub
End Class