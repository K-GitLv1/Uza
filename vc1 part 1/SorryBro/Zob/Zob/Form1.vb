Public Class Form1

    Dim b1, b2, b3, b4, b5, b6, b7, b8 As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim t1 As Integer = 0

        b5 = 50
        b6 = 80
        b7 = 60
        b8 = 89

        b1 = bb1.Text * b5
        b2 = bb2.Text * b6
        b3 = bb3.Text * b7
        b4 = bb4.Text * b8

        If cb1.Checked = True Then
            t1 += b1
        End If
        If cb2.Checked = True Then
            t1 += b2
        End If
        If cb3.Checked = True Then
            t1 += b3
        End If
        If cb4.Checked = True Then
            t1 += b4
        End If
        TextBox1.Text = t1.ToString()
    End Sub

    Private Sub cb4_CheckedChanged(sender As Object, e As EventArgs) Handles cb4.CheckedChanged
        If cb4.Checked = True Then
            bb4.Enabled = True
        ElseIf cb4.Checked = False Then
            bb4.Enabled = False
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox6.Text = TextBox5.Text - TextBox1.Text
    End Sub
    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked = True Then
            bb2.Enabled = True
        ElseIf cb2.Checked = False Then
            bb4.Enabled = False
        End If
    End Sub
    Private Sub cb3_CheckedChanged(sender As Object, e As EventArgs) Handles cb3.CheckedChanged
        If cb3.Checked = True Then
            bb3.Enabled = True
        ElseIf cb3.Checked = False Then
            bb4.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bb1.Clear()
        bb4.Clear()
        bb3.Clear()
        bb2.Clear()
        TextBox1.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        bb1.Focus()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked = True Then
            bb1.Enabled = True
        ElseIf cb1.Checked = False Then
            bb1.Enabled = False
        End If
    End Sub
End Class
