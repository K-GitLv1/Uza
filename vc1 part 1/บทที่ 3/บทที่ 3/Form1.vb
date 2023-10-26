Public Class Form1
    Dim a, b, c, d, e1, f1, g, h As Integer
    Dim num As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        d = TextBox4.Text
        e1 = TextBox5.Text
        f1 = TextBox6.Text
        g = TextBox7.Text
        h = TextBox8.Text

        num = a + b - c - d - e1 - f1 - g - h
        TextBox9.Text = num
    End Sub
End Class
