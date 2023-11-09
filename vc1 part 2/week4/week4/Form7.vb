Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr As Integer() = {1, 2, 3, 4, 4, 5, 5, 6, 6}
        Dim str As String = ""
        For i As Integer = 0 To arr.Length - 1
            str = str & arr(i) & " "
        Next
        str = str + Environment.NewLine & "--------------------" + Environment.NewLine
        Dim arrDis As Integer() = arr.Distinct().ToArray()
        For i As Integer = 0 To arrDis.Length - 1
            str = str & arrDis(i) & " "
        Next
        MessageBox.Show(str, "ผลการทำงาน")
    End Sub
End Class