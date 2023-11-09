Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim al As New ArrayList
        al.Add("C#")
        al.Add("VB")
        al.Add("PHP")
        al.Add("JAVA")
        Dim str As String = ""
        For Each item In al
            str = str & item & Environment.NewLine
        Next
        MessageBox.Show(str, "ผลการอ่านค่าอาร์เรย์")
    End Sub
End Class