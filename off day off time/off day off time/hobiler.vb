Public Class hobiler
    Dim i = 0, k = 0, j As Integer = 0
    Dim left = 0, top As Integer = 0

    Private Sub textboxolustur()

        i = i + 1
        Dim textbox As New TextBox()

        textbox.Top = 20 + top

        textbox.Left = 255

        textbox.Width = 100

        textbox.Text = ""
        textbox.Name = "textbox" & i
        Me.Controls.Add(textbox)
        top = top + 25




    End Sub
    Private Sub labelolustur(ByVal soru As String)

        j = j + 1
        Dim label As New Label()

        label.Top = 20 + top

        label.Left = 250

        label.Width = 150


        label.Text = soru
        label.Name = "label" & j
        Me.Controls.Add(label)
        top = top + 30




    End Sub
    Private Sub checkboxolustur(ByVal soru As String)

        k = k + 1
        Dim check As New CheckBox()

        check.Top = 20 + top

        check.Left = 250



        check.Text = soru
        check.Name = "check" & k
        Me.Controls.Add(check)
        top = top + 25



    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Select Case ComboBox1.SelectedItem
            Case "SANAT"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("Müzik")
                ComboBox2.Items.Add("Edebiyat")
                ComboBox2.Items.Add("Sinema")
                ComboBox2.Items.Add("Tiyatro")
            Case "SAĞLIK"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("Spor")
                ComboBox2.Items.Add("Beslenme")
            Case "BİLİM"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("Teknoloji")
                ComboBox2.Items.Add("Pozitif Bilimler")
            Case "YAŞAM"
                ComboBox2.Items.Clear()
                ComboBox2.Items.Add("Gezi")
                ComboBox2.Items.Add("Doğa")

        End Select

    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox2.SelectionChangeCommitted

        Select Case ComboBox2.SelectedItem
            Case "Müzik"
                labelolustur("Sevdiğiniz müzik türü nedir?")
                textboxolustur()
                labelolustur("Ne tür müzik dinlersiniz?")
                textboxolustur()
            Case "Edebiyat"
                labelolustur("Kitap okur musunuz?")
                checkboxolustur("Evet")
                checkboxolustur("Hayır")

                labelolustur("Ne tür kitap okursunuz?")
                    textboxolustur()

            Case "Sinema"
                labelolustur("Sevdiğiniz müzik türü nedir?")
                textboxolustur()
                labelolustur("Ne tür müzik dinlersiniz?")
                textboxolustur()
            Case "Tiyatro"
                labelolustur("Sevdiğiniz müzik türü nedir?")
                textboxolustur()
                labelolustur("Ne tür müzik dinlersiniz?")
                textboxolustur()
            Case "Spor"
                labelolustur("Sevdiğiniz müzik türü nedir?")
                textboxolustur()
                labelolustur("Ne tür müzik dinlersiniz?")
                textboxolustur()
            Case "Beslenme"
                labelolustur("Sevdiğiniz müzik türü nedir?")
                textboxolustur()
                labelolustur("Ne tür müzik dinlersiniz?")
                textboxolustur()
            Case "Teknoloji"
                labelolustur("Sevdiğiniz müzik türü nedir?")
                textboxolustur()
                labelolustur("Ne tür müzik dinlersiniz?")
                textboxolustur()
            Case "Pozitif Bilimler"
                labelolustur("Sevdiğiniz müzik türü nedir?")
                textboxolustur()
                labelolustur("Ne tür müzik dinlersiniz?")
                textboxolustur()
            Case "Gezi"
                labelolustur("Sevdiğiniz müzik türü nedir?")
                textboxolustur()
                labelolustur("Ne tür müzik dinlersiniz?")
                textboxolustur()
            Case "Doğa"
                labelolustur("Sevdiğiniz müzik türü nedir?")
                textboxolustur()
                labelolustur("Ne tür müzik dinlersiniz?")
                textboxolustur()
        End Select



    End Sub

    Private Sub hobiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
End Class