Public Class Form3
    Dim room, EL1, EL2, EL3, wt1, wt2, wt3 As Integer
    Dim Elbill, wtbill, total As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        room = TextBox1.Text
        EL1 = TextBox2.Text
        EL2 = TextBox4.Text
        EL3 = EL2 - EL1
        TextBox6.Text = EL3

        wt1 = TextBox3.Text
        wt2 = TextBox5.Text
        wt3 = wt2 - wt1
        TextBox7.Text = wt3

        Elbill = EL3 * 7
        TextBox8.Text = Elbill

        wtbill = wt3 * 19
        TextBox9.Text = wtbill

        total = room + Elbill + wtbill
        TextBox10.Text = total



    End Sub
End Class