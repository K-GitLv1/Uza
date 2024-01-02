Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class home
    Dim cb As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ta, tan, ran, rab, rann, td As String
        Dim tfa, cb, tff, rb, total As Decimal
        Dim da As DateTime = DateTime.Now
        Dim ti As String = da.ToLongTimeString()

        tfa = Decimal.Parse(TextBox6.Text)
        ta = TextBox1.Text
        ran = TextBox3.Text
        rab = ComboBox1.SelectedItem.ToString()

        cb = TextBox2.Text
        rann = MaskedTextBox1.Text
        td = Date.Today
        tan = MaskedTextBox2.Text

        tff = If(ComboBox1.SelectedItem.ToString() = "กรุงเทพ", 0, 25)
        rb = cb - tfa - tff

        TextBox2.Text = cb.ToString("#,###.00")
        TextBox6.Text = tfa
        TextBox7.Text = tff

        Dim resultMessage As String =
        $"วันที่โอน: {td}" & vbCrLf &
        $"เวลา: {ti}" & vbCrLf &
        $"โอนเงินจาก:" & vbCrLf &
        $"    บัญชีผู้โอน: ธ.กรุงเทพ {rann}" & vbCrLf &
        $"    ชื่อบัญชี: {ta}" & vbCrLf &
        $"โอนเงินไป:" & vbCrLf &
        $"    บัญชีผู้รับ: {rab} {tan}" & vbCrLf &
        $"    ชื่อบัญชี: {ran}" & vbCrLf &
        $"ยอดเงินที่โอน: {tfa:N2} บาท" & vbCrLf &
        $"ค่าธรรมเนียม: {tff:N2} บาท"

        TextBox3.Text = rb

        MessageBox.Show("ธนาคารได้ทำการโอนเงินตามคำสั่งของท่านเรียบร้อยแล้ว" & vbCrLf + vbCrLf & resultMessage, "ยืนยันการโอนเงิน", MessageBoxButtons.OK)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb = 55000
        TextBox2.Text = cb.ToString("#,###.00")
        TextBox3.Text = cb.ToString("#,###.00")
        TextBox5.Text = Date.Today
    End Sub
End Class