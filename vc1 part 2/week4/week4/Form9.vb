Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arrs As Integer(,) = {{1, 2, 3}, {111, 222, 333}}
        Dim str As String = ""
        For Each item As Integer In arrs
            str = str & item & Environment.NewLine
        Next
        MessageBox.Show(str, "ผลการอ่านค่า")
    End Sub
End Class