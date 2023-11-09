Option Explicit On
Option Strict On
Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arrLanguage = New String() {"VB", "C#", "ASP", "JAVA"}
        Dim str As String = ""
        For Each item In arrLanguage
            str = str & item & Environment.NewLine
        Next
        MessageBox.Show(str, "ผลการอ่านค่าอาร์เรย์")
    End Sub
End Class