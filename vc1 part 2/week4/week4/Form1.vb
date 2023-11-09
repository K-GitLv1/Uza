Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr As Integer() = {100, 200, 300, 400}
        MessageBox.Show(arr(0).ToString(), "แสดงข้อมูลสมาชิก")
    End Sub
End Class
