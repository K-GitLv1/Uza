Option Explicit On
Option Strict On
Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer = 200
        Dim y As Integer = 200
        Dim resuit = IIf(x = y, "x มีค่าเท่ากับ y", "x ไม่เท่ากับ y")
        MessageBox.Show(resuit.ToString, "ผลการตรวจสอบ")
    End Sub
End Class