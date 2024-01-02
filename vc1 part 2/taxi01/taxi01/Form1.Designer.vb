<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Noto Sans Thai", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(30, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ค่า Taxi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Noto Sans Thai", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(169, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ค่าโดยสารเริ่มต้นที่่ 35 บาท"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Noto Sans Thai", 24.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(71, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 48)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Taxi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Noto Sans Thai", 18.0!)
        Me.Label4.Location = New System.Drawing.Point(26, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(335, 36)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ราคาค่าโดยสาร กิโลเมตรละ 5 บาท"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Noto Sans Thai", 18.0!)
        Me.Label5.Location = New System.Drawing.Point(438, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(311, 36)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ราคาค่าโดยสาร ชั่วโมงละ 2 บาท"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Noto Sans Thai", 15.75!)
        Me.TextBox1.Location = New System.Drawing.Point(32, 159)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 43)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Noto Sans Thai", 18.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(262, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 36)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "กิโลเมตร"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Noto Sans Thai", 15.75!)
        Me.TextBox2.Location = New System.Drawing.Point(444, 159)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(213, 43)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Noto Sans Thai", 18.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(674, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 36)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ชั่วโมง"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Noto Sans Thai", 20.25!)
        Me.Button1.Location = New System.Drawing.Point(32, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 194)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "คิดค่าโดยสาร"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Noto Sans Thai", 18.0!)
        Me.Label8.Location = New System.Drawing.Point(330, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 36)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "รวมเป็นเงิน :"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Noto Sans Thai", 83.99999!)
        Me.TextBox3.ForeColor = System.Drawing.Color.Lime
        Me.TextBox3.Location = New System.Drawing.Point(336, 284)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(321, 155)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Noto Sans Thai", 18.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(663, 412)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 36)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "บาท"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 476)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Noto Sans Thai", 8.249999!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
End Class
