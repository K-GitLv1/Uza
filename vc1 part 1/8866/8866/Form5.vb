Public Class Form5
    Dim p1, p2, p3, p4, p5, p6, p7, p8, p9 As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus

        p1 = TextBox1.Text
        TextBox1.Text = Format(p1, "#,##0.00")
    End Sub


    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles TextBox3.LostFocus
        p3 = TextBox3.Text
        TextBox3.Text = Format(p3, "#,##0.00")
    End Sub
    Private Sub TextBox4_LostFocus(sender As Object, e As EventArgs) Handles TextBox4.LostFocus
        p4 = TextBox4.Text
        TextBox4.Text = Format(p4, "#,##0.00")
    End Sub
    Private Sub TextBox5_LostFocus(sender As Object, e As EventArgs) Handles TextBox5.LostFocus
        p5 = TextBox5.Text
        TextBox5.Text = Format(p5, "#,##0.00")
    End Sub

    Private Sub TextBox7_LostFocus(sender As Object, e As EventArgs) Handles TextBox7.LostFocus
        p7 = TextBox7.Text
        TextBox7.Text = Format(p7, "#,##0.00")
    End Sub
    Private Sub TextBox8_LostFocus(sender As Object, e As EventArgs) Handles TextBox8.LostFocus
        p8 = TextBox8.Text
        TextBox8.Text = Format(p8, "#,##0.00")
    End Sub
    Private Sub TextBox9_LostFocus(sender As Object, e As EventArgs) Handles TextBox9.LostFocus
        p9 = p1 - p2 - p3 - p4 - p5 - p6 - p7 - p8 - p9
        TextBox9.Text = Format(p9, "#,##0.00")
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        p2 = TextBox2.Text
        TextBox2.Text = Format(p2, "#,##0.00")
    End Sub

    Private Sub TextBox6_LostFocus(sender As Object, e As EventArgs) Handles TextBox6.LostFocus
        p6 = TextBox6.Text
        TextBox6.Text = Format(p6, "#,##0.00")
    End Sub
End Class