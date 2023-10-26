Public Class work1
    Private Sub work1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fullname As String = ""
        fullname = "อุสาห์ ทัศไนยเมธากุล"
        MessageBox.Show(fullname.Length.ToString(), "นับจำนวนตัวอักษร")
    End Sub
End Class