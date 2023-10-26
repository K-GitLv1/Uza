Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        num = TextBox1.Text
        If (num Mod 2) = 0 Then
            MessageBox.Show("ค่าที่กรอกเป็นเลขคู่")
        Else
            MessageBox.Show("ค่าที่กรอกเป็นเลขคี่")

        End If
    End Sub
End Class
