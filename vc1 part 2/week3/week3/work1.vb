Public Class work1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim price As Double
        Dim vat As Double
        Dim pricevat As Double
        price = TextBox1.Text
        TextBox2.Text = price
        If RadioButton1.Checked = True Then
            vat = price * (7 / 100)
            TextBox3.Text = vat
            TextBox4.Text = price + vat
        End If
        If RadioButton2.Checked = True Then
            vat = price * (7 / 107)
            pricevat = price - vat
            TextBox2.Text = pricevat.ToString("####.00")
            TextBox3.Text = vat.ToString("####.00")
            TextBox4.Text = price.ToString("####.00")
        End If
    End Sub
End Class