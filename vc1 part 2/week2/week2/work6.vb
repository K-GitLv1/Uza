Public Class work6
    Private Sub work6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num1 As Double = 2.75
        Dim num2 As Double = 3.14756
        Dim answer As Double = num1 / num2
        MessageBox.Show(answer.ToString(), "คำตอบแบบที่ยังไม่จัดรูปแบบ")
        Dim answer2 As String = ""
        'answer2 = string.Fomat("{0:n3}",answer)
        answer2 = answer.ToString("#,##0.00")
        MessageBox.Show(answer2.ToString(), "คำตอบที่จัดรูปแบบแล้ว")
    End Sub
End Class