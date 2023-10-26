Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mDate As Date = Date.Now
        TextBox1.Text = mDate
        TextBox2.Text = mDate.Date
        TextBox3.Text = mDate.Day
        TextBox4.Text = mDate.DayOfWeek
        TextBox5.Text = mDate.Month
        TextBox6.Text = mDate.Year
        TextBox7.Text = mDate.Year + 543
        TextBox8.Text = TimeOfDay
        TextBox9.Text = mDate.Hour
        TextBox10.Text = mDate.Minute
        TextBox11.Text = mDate.Second
    End Sub
End Class