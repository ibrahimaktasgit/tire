<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "İşlem No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "İşlem Tipi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Üretilecek Ürün"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(47, 101)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(175, 101)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(47, 226)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(175, 226)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(36, 22)
        Me.TextBox4.TabIndex = 6
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(237, 226)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(164, 22)
        Me.TextBox5.TabIndex = 7
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(47, 354)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(164, 22)
        Me.TextBox6.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Üretimi Yapan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(47, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Bitir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 609)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "İşlem Formu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
