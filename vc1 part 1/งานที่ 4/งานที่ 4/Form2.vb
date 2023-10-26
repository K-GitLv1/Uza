Public Class Form2
    Dim c1, c2, c3 As Integer
    Dim p1, p2, p3 As Double
    Dim t1, t2, t3, sum, money, change As Double
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        c1 = TextBox4.Text
        p1 = TextBox7.Text
        t1 = c1 * p1
        TextBox10.Text = t1

        c2 = TextBox5.Text
        p2 = TextBox8.Text
        t2 = c2 * p2
        TextBox11.Text = t2

        c3 = TextBox6.Text
        p3 = TextBox9.Text
        t3 = c3 * p3
        TextBox12.Text = t3

        sum = t1 + t2 + t3
        Label6.Text = sum






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        money = TextBox13.Text
        change = money - sum
        Label8.Text = change
    End Sub
End Class