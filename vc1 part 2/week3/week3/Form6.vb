Option Explicit On
Option Strict On
Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userInput As String = "B"
        Dim str As String = ""
        Select Case userInput
            Case "A"
                str = "ดีเยี่ยม"
            Case "B"
                str = "ดีเด่น"
            Case "C"
                str = "ดีจัง"
            Case "D"
                str = "ดิดี"
            Case Else
                str = "ไม่ตรงสักอย่าง"
        End Select
        MessageBox.Show(str, "ผลการตรวจสอบ")
    End Sub
End Class