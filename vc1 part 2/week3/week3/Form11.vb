Option Explicit On
Option Strict On
Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = ""
        Dim i As Integer = 6
        Do
            str = str & i.ToString & Environment.NewLine
            i = i + 1
        Loop While i < 5
        MessageBox.Show(str, "ผลการวนลูป")
    End Sub
End Class