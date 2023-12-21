Public Class Form2
    Dim strName As String
    Dim strType As String
    Public Property _strName() As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property
    Public Property _strType() As String
        Get
            Return strType
        End Get
        Set(ByVal value As String)
            strType = value
        End Set
    End Property
    Public Sub LoadInfo()
        Label3.Text = strName
        Label4.Text = strType
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadInfo()
    End Sub
End Class