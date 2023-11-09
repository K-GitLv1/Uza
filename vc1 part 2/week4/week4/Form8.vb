Option Explicit On
Option Strict On
Public Class Form8
    Dim arr As Integer() = {10, 100, 20, 200, 3, 40, 5, 50}
    Dim str As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        str = ""
        For i As Integer = 0 To arr.Length - 1
            str = str & arr(i) & " "
        Next
        str = str & Environment.NewLine & "------------------------------------------" &
            Environment.NewLine
        Dim max As Integer = arr(0)
        For j As Integer = 1 To arr.Length - 1
            If max < arr(j) Then
                max = arr(j)
            End If
        Next
        str = str & max.ToString()
        MessageBox.Show(str, "ค่ามากที่สุด")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        str = ""
        For i As Integer = 0 To arr.Length - 1
            str = str & arr(i) & " "
        Next
        str = str & Environment.NewLine & "---------------------------" & Environment.NewLine
        Dim min As Integer = arr(0)
        For j As Integer = 1 To arr.Length - 1
            If min > arr(j) Then
                min = arr(j)
            End If
        Next
        str = str & min.ToString()
        MessageBox.Show(str, "ค่าน้อยที่สุด")
    End Sub
End Class