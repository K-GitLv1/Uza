Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr As String() = New String() {"A", "BB", "CCC"}
        Dim str As String = ""
        For Each item As String In arr
            str = str & item & Environment.NewLine
        Next
        MessageBox.Show(str, "ผลการอ่านค่าอาร์เรย์")
    End Sub
End Class