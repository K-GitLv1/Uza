Public Class work9
    Private Sub work9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As DateTime = Nothing
        d = Convert.ToDateTime("1/1/2023 12:00:00 AM")
        Dim newdate As DateTime = d.AddYears(5)
        MessageBox.Show(newdate.ToString("D"), "บวกเพิ่มอีก5ปี")
    End Sub
End Class