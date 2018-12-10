<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tire
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
        Me.lblNo = New System.Windows.Forms.Label()
        Me.lblAd = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.btnMarka = New System.Windows.Forms.Button()
        Me.tabGrup = New System.Windows.Forms.TabControl()
        Me.tabMarka = New System.Windows.Forms.TabPage()
        Me.comboDesen = New System.Windows.Forms.ComboBox()
        Me.lblDesen = New System.Windows.Forms.Label()
        Me.tabUrun = New System.Windows.Forms.TabPage()
        Me.grupEbat = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTaban = New System.Windows.Forms.TextBox()
        Me.txtYanak = New System.Windows.Forms.TextBox()
        Me.txtYapi = New System.Windows.Forms.TextBox()
        Me.txtJant = New System.Windows.Forms.TextBox()
        Me.btnUrun = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFiyat = New System.Windows.Forms.TextBox()
        Me.txtSgrup = New System.Windows.Forms.TextBox()
        Me.txtUad = New System.Windows.Forms.TextBox()
        Me.txtUno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tabRecete = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tabStok = New System.Windows.Forms.TabPage()
        Me.grupGiris = New System.Windows.Forms.GroupBox()
        Me.cmbMarka = New System.Windows.Forms.ComboBox()
        Me.cmbDesen = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtIslemNo = New System.Windows.Forms.TextBox()
        Me.islemNo = New System.Windows.Forms.Label()
        Me.tabIslem = New System.Windows.Forms.TabPage()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTipi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIslem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabGrup.SuspendLayout()
        Me.tabMarka.SuspendLayout()
        Me.tabUrun.SuspendLayout()
        Me.grupEbat.SuspendLayout()
        Me.tabRecete.SuspendLayout()
        Me.tabStok.SuspendLayout()
        Me.grupGiris.SuspendLayout()
        Me.tabIslem.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.Location = New System.Drawing.Point(47, 44)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(69, 17)
        Me.lblNo.TabIndex = 0
        Me.lblNo.Text = "Marka No"
        '
        'lblAd
        '
        Me.lblAd.AutoSize = True
        Me.lblAd.Location = New System.Drawing.Point(47, 106)
        Me.lblAd.Name = "lblAd"
        Me.lblAd.Size = New System.Drawing.Size(71, 17)
        Me.lblAd.TabIndex = 1
        Me.lblAd.Text = "Marka Adı"
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(164, 44)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(100, 22)
        Me.txtNo.TabIndex = 2
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(164, 106)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(100, 22)
        Me.txtAd.TabIndex = 3
        '
        'btnMarka
        '
        Me.btnMarka.Location = New System.Drawing.Point(50, 240)
        Me.btnMarka.Name = "btnMarka"
        Me.btnMarka.Size = New System.Drawing.Size(75, 23)
        Me.btnMarka.TabIndex = 4
        Me.btnMarka.Text = "Kaydet"
        Me.btnMarka.UseVisualStyleBackColor = True
        '
        'tabGrup
        '
        Me.tabGrup.Controls.Add(Me.tabMarka)
        Me.tabGrup.Controls.Add(Me.tabUrun)
        Me.tabGrup.Controls.Add(Me.tabRecete)
        Me.tabGrup.Controls.Add(Me.tabStok)
        Me.tabGrup.Controls.Add(Me.tabIslem)
        Me.tabGrup.Location = New System.Drawing.Point(12, 12)
        Me.tabGrup.Name = "tabGrup"
        Me.tabGrup.SelectedIndex = 0
        Me.tabGrup.Size = New System.Drawing.Size(708, 668)
        Me.tabGrup.TabIndex = 5
        '
        'tabMarka
        '
        Me.tabMarka.Controls.Add(Me.comboDesen)
        Me.tabMarka.Controls.Add(Me.lblDesen)
        Me.tabMarka.Controls.Add(Me.lblNo)
        Me.tabMarka.Controls.Add(Me.btnMarka)
        Me.tabMarka.Controls.Add(Me.lblAd)
        Me.tabMarka.Controls.Add(Me.txtAd)
        Me.tabMarka.Controls.Add(Me.txtNo)
        Me.tabMarka.Location = New System.Drawing.Point(4, 25)
        Me.tabMarka.Name = "tabMarka"
        Me.tabMarka.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMarka.Size = New System.Drawing.Size(700, 639)
        Me.tabMarka.TabIndex = 0
        Me.tabMarka.Text = "Marka"
        Me.tabMarka.UseVisualStyleBackColor = True
        '
        'comboDesen
        '
        Me.comboDesen.FormattingEnabled = True
        Me.comboDesen.Location = New System.Drawing.Point(164, 172)
        Me.comboDesen.Name = "comboDesen"
        Me.comboDesen.Size = New System.Drawing.Size(121, 24)
        Me.comboDesen.TabIndex = 6
        '
        'lblDesen
        '
        Me.lblDesen.AutoSize = True
        Me.lblDesen.Location = New System.Drawing.Point(47, 172)
        Me.lblDesen.Name = "lblDesen"
        Me.lblDesen.Size = New System.Drawing.Size(95, 17)
        Me.lblDesen.TabIndex = 5
        Me.lblDesen.Text = "Marka Deseni"
        '
        'tabUrun
        '
        Me.tabUrun.Controls.Add(Me.grupEbat)
        Me.tabUrun.Controls.Add(Me.btnUrun)
        Me.tabUrun.Controls.Add(Me.Label9)
        Me.tabUrun.Controls.Add(Me.Label8)
        Me.tabUrun.Controls.Add(Me.txtFiyat)
        Me.tabUrun.Controls.Add(Me.txtSgrup)
        Me.tabUrun.Controls.Add(Me.txtUad)
        Me.tabUrun.Controls.Add(Me.txtUno)
        Me.tabUrun.Controls.Add(Me.Label10)
        Me.tabUrun.Controls.Add(Me.Label11)
        Me.tabUrun.Location = New System.Drawing.Point(4, 25)
        Me.tabUrun.Name = "tabUrun"
        Me.tabUrun.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUrun.Size = New System.Drawing.Size(700, 639)
        Me.tabUrun.TabIndex = 1
        Me.tabUrun.Text = "Ürün Tanımlama"
        Me.tabUrun.UseVisualStyleBackColor = True
        '
        'grupEbat
        '
        Me.grupEbat.Controls.Add(Me.Label4)
        Me.grupEbat.Controls.Add(Me.Label5)
        Me.grupEbat.Controls.Add(Me.Label6)
        Me.grupEbat.Controls.Add(Me.Label7)
        Me.grupEbat.Controls.Add(Me.txtTaban)
        Me.grupEbat.Controls.Add(Me.txtYanak)
        Me.grupEbat.Controls.Add(Me.txtYapi)
        Me.grupEbat.Controls.Add(Me.txtJant)
        Me.grupEbat.Location = New System.Drawing.Point(51, 147)
        Me.grupEbat.Name = "grupEbat"
        Me.grupEbat.Size = New System.Drawing.Size(226, 264)
        Me.grupEbat.TabIndex = 38
        Me.grupEbat.TabStop = False
        Me.grupEbat.Text = "Ebat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Taban"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Yanak"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Jant"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Yapı"
        '
        'txtTaban
        '
        Me.txtTaban.Location = New System.Drawing.Point(109, 32)
        Me.txtTaban.Name = "txtTaban"
        Me.txtTaban.Size = New System.Drawing.Size(100, 22)
        Me.txtTaban.TabIndex = 29
        '
        'txtYanak
        '
        Me.txtYanak.Location = New System.Drawing.Point(109, 93)
        Me.txtYanak.Name = "txtYanak"
        Me.txtYanak.Size = New System.Drawing.Size(100, 22)
        Me.txtYanak.TabIndex = 30
        '
        'txtYapi
        '
        Me.txtYapi.Location = New System.Drawing.Point(109, 211)
        Me.txtYapi.Name = "txtYapi"
        Me.txtYapi.Size = New System.Drawing.Size(100, 22)
        Me.txtYapi.TabIndex = 32
        '
        'txtJant
        '
        Me.txtJant.Location = New System.Drawing.Point(109, 150)
        Me.txtJant.Name = "txtJant"
        Me.txtJant.Size = New System.Drawing.Size(100, 22)
        Me.txtJant.TabIndex = 31
        '
        'btnUrun
        '
        Me.btnUrun.Location = New System.Drawing.Point(160, 558)
        Me.btnUrun.Name = "btnUrun"
        Me.btnUrun.Size = New System.Drawing.Size(75, 23)
        Me.btnUrun.TabIndex = 37
        Me.btnUrun.Text = "Kaydet"
        Me.btnUrun.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 489)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 17)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Fiyat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(57, 435)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 17)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Stok Grup"
        '
        'txtFiyat
        '
        Me.txtFiyat.Location = New System.Drawing.Point(160, 489)
        Me.txtFiyat.Name = "txtFiyat"
        Me.txtFiyat.Size = New System.Drawing.Size(100, 22)
        Me.txtFiyat.TabIndex = 34
        '
        'txtSgrup
        '
        Me.txtSgrup.Location = New System.Drawing.Point(160, 435)
        Me.txtSgrup.Name = "txtSgrup"
        Me.txtSgrup.Size = New System.Drawing.Size(100, 22)
        Me.txtSgrup.TabIndex = 33
        '
        'txtUad
        '
        Me.txtUad.Location = New System.Drawing.Point(160, 92)
        Me.txtUad.Name = "txtUad"
        Me.txtUad.Size = New System.Drawing.Size(100, 22)
        Me.txtUad.TabIndex = 27
        '
        'txtUno
        '
        Me.txtUno.Location = New System.Drawing.Point(160, 38)
        Me.txtUno.Name = "txtUno"
        Me.txtUno.Size = New System.Drawing.Size(100, 22)
        Me.txtUno.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(57, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Ürün Adı"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(57, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Ürün No"
        '
        'tabRecete
        '
        Me.tabRecete.Controls.Add(Me.Label12)
        Me.tabRecete.Controls.Add(Me.ComboBox1)
        Me.tabRecete.Location = New System.Drawing.Point(4, 25)
        Me.tabRecete.Name = "tabRecete"
        Me.tabRecete.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRecete.Size = New System.Drawing.Size(700, 639)
        Me.tabRecete.TabIndex = 2
        Me.tabRecete.Text = "Standart Recete"
        Me.tabRecete.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(57, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Kaplama Türü"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Soğuk Kaplama", "Sıcak Kaplama", "Ontort Kaplama", "Romux Kaplama"})
        Me.ComboBox1.Location = New System.Drawing.Point(160, 60)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'tabStok
        '
        Me.tabStok.Controls.Add(Me.grupGiris)
        Me.tabStok.Controls.Add(Me.txtIslemNo)
        Me.tabStok.Controls.Add(Me.islemNo)
        Me.tabStok.Location = New System.Drawing.Point(4, 25)
        Me.tabStok.Name = "tabStok"
        Me.tabStok.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStok.Size = New System.Drawing.Size(700, 639)
        Me.tabStok.TabIndex = 3
        Me.tabStok.Text = "Stok Hareket"
        Me.tabStok.UseVisualStyleBackColor = True
        '
        'grupGiris
        '
        Me.grupGiris.Controls.Add(Me.cmbMarka)
        Me.grupGiris.Controls.Add(Me.cmbDesen)
        Me.grupGiris.Controls.Add(Me.Label16)
        Me.grupGiris.Controls.Add(Me.Label15)
        Me.grupGiris.Controls.Add(Me.TextBox5)
        Me.grupGiris.Controls.Add(Me.Label14)
        Me.grupGiris.Location = New System.Drawing.Point(54, 72)
        Me.grupGiris.Name = "grupGiris"
        Me.grupGiris.Size = New System.Drawing.Size(406, 220)
        Me.grupGiris.TabIndex = 2
        Me.grupGiris.TabStop = False
        Me.grupGiris.Text = "Giriş"
        '
        'cmbMarka
        '
        Me.cmbMarka.FormattingEnabled = True
        Me.cmbMarka.Location = New System.Drawing.Point(168, 46)
        Me.cmbMarka.Name = "cmbMarka"
        Me.cmbMarka.Size = New System.Drawing.Size(121, 24)
        Me.cmbMarka.TabIndex = 7
        '
        'cmbDesen
        '
        Me.cmbDesen.FormattingEnabled = True
        Me.cmbDesen.Location = New System.Drawing.Point(168, 158)
        Me.cmbDesen.Name = "cmbDesen"
        Me.cmbDesen.Size = New System.Drawing.Size(121, 24)
        Me.cmbDesen.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(40, 161)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 17)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Desen"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(40, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 17)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Ürün Adeti"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(168, 102)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 22)
        Me.TextBox5.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(40, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Marka"
        '
        'txtIslemNo
        '
        Me.txtIslemNo.Location = New System.Drawing.Point(174, 44)
        Me.txtIslemNo.Name = "txtIslemNo"
        Me.txtIslemNo.Size = New System.Drawing.Size(100, 22)
        Me.txtIslemNo.TabIndex = 1
        '
        'islemNo
        '
        Me.islemNo.AutoSize = True
        Me.islemNo.Location = New System.Drawing.Point(51, 44)
        Me.islemNo.Name = "islemNo"
        Me.islemNo.Size = New System.Drawing.Size(104, 17)
        Me.islemNo.TabIndex = 0
        Me.islemNo.Text = "İşlem Numarası"
        '
        'tabIslem
        '
        Me.tabIslem.Controls.Add(Me.TextBox4)
        Me.tabIslem.Controls.Add(Me.TextBox3)
        Me.tabIslem.Controls.Add(Me.TextBox2)
        Me.tabIslem.Controls.Add(Me.TextBox1)
        Me.tabIslem.Controls.Add(Me.btnEkle)
        Me.tabIslem.Controls.Add(Me.Label13)
        Me.tabIslem.Controls.Add(Me.Label3)
        Me.tabIslem.Controls.Add(Me.txtTipi)
        Me.tabIslem.Controls.Add(Me.Label2)
        Me.tabIslem.Controls.Add(Me.txtIslem)
        Me.tabIslem.Controls.Add(Me.Label1)
        Me.tabIslem.Location = New System.Drawing.Point(4, 25)
        Me.tabIslem.Name = "tabIslem"
        Me.tabIslem.Padding = New System.Windows.Forms.Padding(3)
        Me.tabIslem.Size = New System.Drawing.Size(700, 639)
        Me.tabIslem.TabIndex = 4
        Me.tabIslem.Text = "İşlem"
        Me.tabIslem.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(54, 315)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(163, 22)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(244, 169)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(174, 22)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(177, 169)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(40, 22)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(54, 169)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 7
        '
        'btnEkle
        '
        Me.btnEkle.Location = New System.Drawing.Point(54, 409)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(75, 23)
        Me.btnEkle.TabIndex = 6
        Me.btnEkle.Text = "Ekle"
        Me.btnEkle.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(51, 281)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 17)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Üretimi Yapan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Üretilecek Ürün"
        '
        'txtTipi
        '
        Me.txtTipi.Location = New System.Drawing.Point(314, 46)
        Me.txtTipi.Name = "txtTipi"
        Me.txtTipi.Size = New System.Drawing.Size(104, 22)
        Me.txtTipi.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "İşlem Tipi"
        '
        'txtIslem
        '
        Me.txtIslem.Location = New System.Drawing.Point(119, 46)
        Me.txtIslem.Name = "txtIslem"
        Me.txtIslem.Size = New System.Drawing.Size(38, 22)
        Me.txtIslem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "İşlem No"
        '
        'tire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 720)
        Me.Controls.Add(Me.tabGrup)
        Me.Name = "tire"
        Me.Text = "Tire"
        Me.tabGrup.ResumeLayout(False)
        Me.tabMarka.ResumeLayout(False)
        Me.tabMarka.PerformLayout()
        Me.tabUrun.ResumeLayout(False)
        Me.tabUrun.PerformLayout()
        Me.grupEbat.ResumeLayout(False)
        Me.grupEbat.PerformLayout()
        Me.tabRecete.ResumeLayout(False)
        Me.tabRecete.PerformLayout()
        Me.tabStok.ResumeLayout(False)
        Me.tabStok.PerformLayout()
        Me.grupGiris.ResumeLayout(False)
        Me.grupGiris.PerformLayout()
        Me.tabIslem.ResumeLayout(False)
        Me.tabIslem.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNo As Label
    Friend WithEvents lblAd As Label
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtAd As TextBox
    Friend WithEvents btnMarka As Button
    Friend WithEvents tabGrup As TabControl
    Friend WithEvents tabMarka As TabPage
    Friend WithEvents tabUrun As TabPage
    Friend WithEvents tabRecete As TabPage
    Friend WithEvents btnUrun As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFiyat As TextBox
    Friend WithEvents txtSgrup As TextBox
    Friend WithEvents txtYapi As TextBox
    Friend WithEvents txtJant As TextBox
    Friend WithEvents txtYanak As TextBox
    Friend WithEvents txtTaban As TextBox
    Friend WithEvents txtUad As TextBox
    Friend WithEvents txtUno As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblDesen As Label
    Friend WithEvents grupEbat As GroupBox
    Friend WithEvents comboDesen As ComboBox
    Friend WithEvents tabStok As TabPage
    Friend WithEvents grupGiris As GroupBox
    Friend WithEvents txtIslemNo As TextBox
    Friend WithEvents islemNo As Label
    Friend WithEvents tabIslem As TabPage
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnEkle As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTipi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIslem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbMarka As ComboBox
    Friend WithEvents cmbDesen As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label14 As Label
End Class
