Option Explicit On
Option Strict On
Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = ""
        Dim i As Integer = 1
        While i <= 10
            str = str & i.ToString & Environment.NewLine
            i = i + 1
        End While
        MessageBox.Show(str, "ผลการวนลูป")
    End Sub
End Class