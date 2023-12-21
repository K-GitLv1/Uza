Imports System.Data.OleDb

Public Class Form2
    Dim Conn As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Users\IT-542\Documents\Pinit 020\Week 7\Week 7\db_Test.mdb")
    Dim CMD As OleDbCommand
    Dim dr As OleDbDataReader
    Dim SQL As String
    Sub Load()

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class