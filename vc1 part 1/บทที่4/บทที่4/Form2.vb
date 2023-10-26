Public Class Form2
    Dim score, a, b, c, d As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click, Label17.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label18.Click, Label30.Click, Label29.Click, Label28.Click, Label27.Click, Label26.Click, Label25.Click, Label24.Click, Label23.Click, Label22.Click, Label21.Click, Label20.Click, Label19.Click

    End Sub

    Dim Grade As Char
    Dim gradev2 As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        d = TextBox4.Text
        TextBox5.Text = a + b + c + d
        score = TextBox5.Text

        If score >= 100 Then
            gradev2 = "SSSSSR"
        ElseIf score >= 80 Then
            Grade = "A"
        ElseIf score >= 70 Then
            Grade = "B"
        ElseIf score >= 60 Then
            Grade = "c"
        ElseIf score >= 50 Then
            Grade = "d"
        Else
            Grade = "f"

        End If
        TextBox6.Text = Grade
        TextBox6.Text = gradev2
    End Sub

End Class