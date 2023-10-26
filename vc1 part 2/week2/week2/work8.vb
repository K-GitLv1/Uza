Public Class work8
    Private Sub work8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As DateTime = Nothing
        d = Convert.ToDateTime("7/7/2023 12:00:00 AM")
        MessageBox.Show(d.ToString("D"), "วันที่แบบยาว")
    End Sub
End Class