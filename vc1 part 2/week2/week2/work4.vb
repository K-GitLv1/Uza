Public Class work4
    Private Sub work4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "การใช้งาน Visual studio 2019"
        Dim result As String = ""
        result = str.Replace("studio", "Basic")
        MessageBox.Show(result.ToString(), "ผลการแทนที่")
    End Sub
End Class