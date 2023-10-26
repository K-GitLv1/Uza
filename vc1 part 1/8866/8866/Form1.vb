Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txtInput As String
        txtInput = TextBox1.Text
        TextBox2.Text = txtInput.Length()
        TextBox3.Text = txtInput.ToUpper()
        TextBox4.Text = txtInput.ToLower()
        TextBox5.Text = txtInput.Trim()
        TextBox6.Text = txtInput.Insert(0, "ข้าคือ ")
        TextBox7.Text = txtInput.Remove(0, 4)
        TextBox8.Text = txtInput.Substring(1, 2)
        TextBox9.Text = txtInput.IndexOf("a")
        If TextBox9.Text = "-1" Then
            TextBox9.Text = "Not found"
        End If
        If IsNumeric(txtInput) = False Then
            TextBox10.Text = "Error in  number"
        Else
            TextBox10.Text = "This value is number"
        End If
        TextBox11.Text = txtInput.Replace("u", "v")
    End Sub
End Class