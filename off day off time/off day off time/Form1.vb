Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms
Imports System.Reflection.Emit
Imports System.Data.SqlClient

Public Class bilgiler
    Private Sub HOBİLERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOBİLERToolStripMenuItem.Click
        HOBİLERToolStripMenuItem.Checked = True
        HOBİLERToolStripMenuItem.BackColor = Color.GreenYellow
        BİLGİLERToolStripMenuItem.Checked = False
        Dim hobi As hobiler = New hobiler()
        hobi.ShowDialog()
    End Sub

    Private Sub BİLGİLERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BİLGİLERToolStripMenuItem.Click
        If BİLGİLERToolStripMenuItem.Checked = True Then
            BİLGİLERToolStripMenuItem.BackColor = Color.Brown
            HOBİLERToolStripMenuItem.Checked = False
        End If
        Dim LB1 As System.Windows.Forms.Label = New System.Windows.Forms.Label()
        With LB1
            .TabIndex = 1
            .AutoSize = True
            .Location = New Point(12, 47)
            .Size = New Size(46, 13)
            .Text = $"ADINIZ:"
            Me.Controls.Add(LB1)
        End With
        Dim LB2 As System.Windows.Forms.Label = New System.Windows.Forms.Label()
        With LB2
            .TabIndex = 2
            .AutoSize = True
            .Location = New Point(12, 83)
            .Size = New Size(68, 13)
            .Text = $"SOYADINIZ:"
            Me.Controls.Add(LB2)
        End With
        Dim LB3 As System.Windows.Forms.Label = New System.Windows.Forms.Label()
        With LB3
            .AutoSize = True
            .Location = New System.Drawing.Point(12, 119)
            .Name = "LB3"
            .Size = New System.Drawing.Size(90, 13)
            .TabIndex = 4
            .Text = $"DOĞUM TARİHİ:"
            .Visible = True
            Me.Controls.Add(LB3)
        End With
        Dim LB4 As System.Windows.Forms.Label = New System.Windows.Forms.Label()
        With LB4
            LB4.AutoSize = True
            LB4.Location = New System.Drawing.Point(12, 151)
            LB4.Name = "LB4"
            LB4.Size = New System.Drawing.Size(119, 13)
            LB4.TabIndex = 5
            LB4.Text = $"TELEFON NUMARASI:"
            LB4.Visible = True
            Me.Controls.Add(LB4)
        End With
        Dim LB5 As System.Windows.Forms.Label = New System.Windows.Forms.Label()
        With LB5
            .AutoSize = True
            .Location = New System.Drawing.Point(12, 189)
            .Name = "LB5"
            .Size = New System.Drawing.Size(109, 13)
            .TabIndex = 6
            .Text = $"YAŞADIĞINIZ ÜLKE:"
            .Visible = True
            Me.Controls.Add(LB5)
        End With
        Dim LB6 As System.Windows.Forms.Label = New System.Windows.Forms.Label()
        With LB6
            .AutoSize = True
            .Location = New System.Drawing.Point(12, 228)
            .Name = "LB6"
            .Size = New System.Drawing.Size(114, 13)
            .TabIndex = 7
            .Text = $"YAŞADIĞINIZ ŞEHİR:"
            .Visible = True
            Me.Controls.Add(LB6)
        End With
        Dim LB7 As System.Windows.Forms.Label = New System.Windows.Forms.Label()
        With LB7
            .AutoSize = True
            .Location = New System.Drawing.Point(12, 266)
            .Name = "LB7"
            .Size = New System.Drawing.Size(104, 13)
            .TabIndex = 8
            .Text = $"YAŞADIĞINIZ İLÇE:"
            .Visible = True
            Me.Controls.Add(LB7)
        End With
        Dim LB8 As System.Windows.Forms.Label = New System.Windows.Forms.Label()
        With LB8
            .AutoSize = True
            .Location = New System.Drawing.Point(332, 83)
            .Name = "LB8"
            .Size = New System.Drawing.Size(80, 13)
            .TabIndex = 9
            .Text = $"POSTA KODU:"
            .Visible = True
            Me.Controls.Add(LB8)
        End With
        Dim LB9 As System.Windows.Forms.Label = New System.Windows.Forms.Label()
        With LB9
            .AutoSize = True
            .Location = New System.Drawing.Point(332, 119)
            .Name = "LB9"
            .Size = New System.Drawing.Size(106, 13)
            .TabIndex = 10
            .Text = $"KULLANICI(E-MAİL):"
            .Visible = True
            Me.Controls.Add(LB9)
        End With
        Dim LB10 As System.Windows.Forms.Label = New System.Windows.Forms.Label()
        With LB10
            .AutoSize = True
            .Location = New System.Drawing.Point(332, 155)
            .Name = "LB10"
            .Size = New System.Drawing.Size(99, 13)
            .TabIndex = 11
            .Text = $"KULLANICI ŞİFRE:"
            .Visible = True
            Me.Controls.Add(LB10)
        End With
        Dim LB11 As System.Windows.Forms.Label = New System.Windows.Forms.Label()
        With LB11
            .AutoSize = True
            .Location = New System.Drawing.Point(332, 187)
            .Name = "LB11"
            .Size = New System.Drawing.Size(88, 13)
            .TabIndex = 12
            .Text = $"ŞİFRE TEKRAR:"
            .Visible = True
            Me.Controls.Add(LB11)
        End With
        Dim LB12 As System.Windows.Forms.Label = New System.Windows.Forms.Label()
        With LB12
            .AutoSize = True
            .Location = New System.Drawing.Point(332, 225)
            .Name = "LB12"
            .Size = New System.Drawing.Size(75, 13)
            .TabIndex = 13
            .Text = $"MESLEĞİNİZ:"
            Me.Controls.Add(LB12)
        End With
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Visible = True
            End If
        Next
        For Each control As Control In Me.Controls
            If TypeOf control Is ComboBox Then
                control.Visible = True
            End If
        Next
        DateTimePicker1.Visible = True
        CheckBox1.Visible = True
        btn1.Visible = True
        PictureBox1.Visible = True
        Timer1.Interval = 60000
        Timer1.Start()

    End Sub

    Private Sub bilgiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Visible = False
            End If
        Next
        For Each control As Control In Me.Controls
            If TypeOf control Is ComboBox Then
                control.Visible = False
            End If
        Next
        DateTimePicker1.Visible = False
        CheckBox1.Visible = False
        btn1.Visible = False
        PictureBox1.Visible = False


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim karar As DialogResult = MessageBox.Show($"Bilgi Girişini tamamladınız mı?", $"BİLGİ GİRİŞİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If karar = DialogResult.Yes Then
            MsgBox("Sizi hobiler sayfasına yöneltiyorum")
            Timer1.Stop()
            BİLGİLERToolStripMenuItem.Checked = False
            HOBİLERToolStripMenuItem.Checked = True
            HOBİLERToolStripMenuItem.BackColor = Color.GreenYellow
            Dim hobi As hobiler = New hobiler()
            hobi.ShowDialog()
        ElseIf karar = DialogResult.No Then
            MessageBox.Show($"Ek süre veriliyor")
            Timer1.Interval = 90000
        End If

    End Sub

    Private Sub txt1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt3.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Dim resim_yolu As String

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim file As OpenFileDialog = New OpenFileDialog()
        file.Title = $"Resim Açma Penceresi"
        file.DefaultExt = $"jpg"
        file.InitialDirectory = $"C:\Desktop"
        file.Multiselect = False
        file.Filter = $"Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*"
        file.ShowDialog()
        resim_yolu = file.FileName
        PictureBox1.ImageLocation = resim_yolu
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim karakter As Char = Chr(0)
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = karakter
            TextBox3.PasswordChar = karakter
        Else
            karakter = Chr(42)
            TextBox2.PasswordChar = karakter
            TextBox3.PasswordChar = karakter
        End If


    End Sub
    Private Sub txt4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt4.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub KAYDETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KAYDETToolStripMenuItem.Click
        Try

            Dim hesap As kullanici = New kullanici()
            If TextBox2.Text = TextBox3.Text Then
                hesap.verial(txt1.Text, txt2.Text, DateTimePicker1.Value, txt3.Text, cmb2.Text, cmb3.Text, txt4.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text, cmb4.Text)
                hesap.Kaydet()
            Else
                MessageBox.Show($"Şifreler uyuşmamaktadır kontrol ediniz", $"şifre kontrol")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
