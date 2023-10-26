Public Class Form4
    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        Dim c As String
        c = TextBox1.Text
        If Val(Trim(Len(c)) <> 11) Then
            MessageBox.Show("รหัสต้องมี 11 ตัวนะแจ๊ะ")
            TextBox1.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Select Case Asc(e.KeyChar)
            Case 161 To 240 'ตรวจสอบ ก-ฮ สระวรรณยุกต์'
                e.Handled = False
            Case 8, 13, 32, 46 'อนุญาตให้ใช้ปุ่ม back,enter,del,space'
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกข้อมูลเป็นภาษาไทยเท่านั้นนะแจ๊ะ")
        End Select
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Select Case Asc(e.KeyChar)
            Case 65 To 90 'ตรวจสอบ a-z'
                e.Handled = False
            Case 97 To 122 'ตรวจสอบเลข a-z'
                e.Handled = False
            Case 8, 13, 32, 46 'อนุญาตให้ใช้ปุ่ม back,enter,del,space'
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกข้อมูลเป็นภาษาอังกฤษเท่านั้นนะแจ๊ะ")
        End Select
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'ตรวจสอบเลข 0-9'
                e.Handled = False
            Case 8, 13, 32, 46 'อนุญาตให้ใช้ปุ่ม back,enter,del,space'
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกข้อมูลเฉพาะตัวเลขเท่านั้นนะแจ๊ะ")
        End Select
    End Sub
End Class