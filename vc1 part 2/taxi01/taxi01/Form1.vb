Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Double

        TextBox1.Focus()

        a = TextBox1.Text * 5
        b = TextBox2.Text * 2
        c = a + b

        TextBox3.Text = 35 + c
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub
End Class
