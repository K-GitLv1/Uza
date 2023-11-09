Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr As Integer() = New Integer(2) {}
        For i = 0 To 3 - 1
            arr(i) = i * 500
        Next
        For j = 0 To 3 - 1
            MessageBox.Show(arr(j).ToString(), "อ่านค่าตัวแปรอาร์เรย์")
        Next
    End Sub
End Class