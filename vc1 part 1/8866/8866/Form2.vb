Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Format(15000, "C")
        TextBox2.Text = Format(&HD, "D")
        TextBox3.Text = Format(1234567, "E")
        TextBox4.Text = Format(35000, "F")
        TextBox5.Text = Format(50000, "G")
        TextBox6.Text = Format(35000.75, "N")
        TextBox7.Text = Format(0.15, "P")
        TextBox8.Text = Format(1.999, "R")
        TextBox9.Text = Format(15, "X")

    End Sub
End Class