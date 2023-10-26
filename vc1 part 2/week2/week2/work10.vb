Public Class work10
    Private Sub work10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As DateTime = Nothing
        d = Convert.ToDateTime("7/7/2023 12:00:00 AM")
        Dim newdate As DateTime = d.AddMonths(3)
        MessageBox.Show(newdate.ToString("D"), "บวกเพิ่มอีก3เดือน")
    End Sub
End Class