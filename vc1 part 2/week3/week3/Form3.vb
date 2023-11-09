Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer = 20
        Dim y As Integer = 10
        If x = 5 OrElse y = 10 Then
            MessageBox.Show("เงื่อนไขเป็นจริง", "ผลการตรวจสอบเงื่อนไข")
        Else
            MessageBox.Show("เงื่อนไขเป็นจริง", "ผลการตรวจสอบเงื่อนไข")
        End If
    End Sub
End Class