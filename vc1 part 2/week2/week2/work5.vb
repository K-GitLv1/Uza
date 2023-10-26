Public Class work5
    Private Sub work5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "การใช้งาน Visual Studio 2019"
        Dim result As String() = str.Split(" "c)
        MessageBox.Show(result(0) +
            Environment.NewLine + result(1) +
            Environment.NewLine + result(2) +
            Environment.NewLine + result(3), "ผลการแบ่งข้อความ")
    End Sub
End Class