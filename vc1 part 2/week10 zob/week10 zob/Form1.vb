Imports System.Data.OleDb
Public Class Form1
    Dim Conn As New OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data source=C:\k\work\vc1 part 2\week10 zob\week10 zob\bin\Debug\db\db34.mdb")
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Dim SQL As String
    Sub login()
        If TextBox1.Text = Nothing And TextBox2.Text = Nothing Then
            TextBox1.Focus()
            Exit Sub
        End If
        dt = New DataTable
        ds = New DataSet
        SQL = "SELECT * FROM UserLogin WHERE login_user='" & TextBox1.Text & "' AND login_pass='" & TextBox2.Text & "'"
        da = New OleDbDataAdapter(SQL, Conn)
        Try
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            ds.Tables.Add(dt)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim frm As New Form2
                frm._strName = dt.Rows(0)("login_name")
                frm._strType = dt.Rows(0)("login_type")
                frm.LoadInfo()
                frm.Show()
                Me.Hide()
            Else
                MessageBox.Show("UserName หรือ Password ผิด", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox1.Focus()
            End If
            Conn.Close()
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call login()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class