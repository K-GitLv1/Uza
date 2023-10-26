Public Class work11
    Private Sub work11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As DateTime = Nothing
        d = Convert.ToDateTime("1/1/2023 12:00:00 AM")
        Dim newdate As DateTime = d.AddDays(10)
        MessageBox.Show(newdate.ToString("D"), "บวกเพิ่มอีก10วัน")
    End Sub
End Class