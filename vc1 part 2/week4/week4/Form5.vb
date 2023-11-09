Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr As String() = New String() {"1", "2", "3"}
        Dim length As Integer = arr.Length - 1
        Dim strReverse As String = ""

        While length >= 0
            strReverse = strReverse & arr(length) & Environment.NewLine
            length -= 1
        End While

        MessageBox.Show(strReverse, "ผลการ Reverse")
    End Sub
End Class