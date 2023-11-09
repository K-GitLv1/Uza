Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer = 20
        Dim y As Integer = 10
        If x = 20 AndAlso y = 10 Then
            MessageBox.Show("เงื่อนไขไม่เป็นจริง", "ผลการตรวจสอบเงื่อนไข")
        Else
            MessageBox.Show("เงื่อนไขไม่เป็นจริง", "ผลการตรวจสอบเงื่อนไข")
        End If
    End Sub
End Class