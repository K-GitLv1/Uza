Public Class work7
    Private Sub work7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fullname As String = "จิรพัฒน์ หนูราช"
        Dim message As String = $"ชื่อ-สกุล : {fullname}"

        MessageBox.Show(message, "อ่านค่า")
    End Sub
End Class