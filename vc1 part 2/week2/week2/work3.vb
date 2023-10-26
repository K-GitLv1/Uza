Public Class work3
    Private Sub work3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "586"
        Dim num1 As Integer = Integer.Parse(str)
        Dim num2 As Integer = 1200
        Dim sum As Integer
        sum = num1 + num2
        MessageBox.Show(sum, "ผลการคำนวณ")
    End Sub
End Class