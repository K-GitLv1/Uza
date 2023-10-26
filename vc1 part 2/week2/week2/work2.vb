Public Class work2
    Private Sub work2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name As String = "USA"
        Dim lastname As String = "Jiraphat Nurach"
        Dim fullname As String = name & " " & lastname
        MessageBox.Show(fullname, "ผลการต่อ")
    End Sub
End Class