Public Class work12
    Private Sub work12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As DateTime = DateTime.Now
        MessageBox.Show(d.ToString("D"), "วันที่ปัจจุบัน")
    End Sub
End Class