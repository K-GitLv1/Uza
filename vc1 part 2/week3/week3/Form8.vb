Option Explicit On
Option Strict On
Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = ""
        For i As Integer = 1 To 5 Step 2
            str = str & i.ToString() & Environment.NewLine
        Next
        MessageBox.Show(str, "ผลการวนลูป")
    End Sub
End Class