 
Public Class gaktivite

    Const gün As Double = 24.0
    Private this As Object

    Public Function hesapla(ByVal toplam As Integer) As Double
        Dim ksaat As Double = 0
        ksaat = gün - toplam
        ksaat = (ksaat * 1 / 3)
        ksaat = Math.Round(Convert.ToDouble(ksaat), 0)
        Return ksaat
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim uyuma As Double
        Dim is_okul As Double
        Dim kzaman As Double
        Dim sonuc As Double
        Try
            Dim iDate As String = comm
            Dim oDate As DateTime = Convert.ToDateTime(iDate)
            MsgBox(oDate.Day & " " & oDate.Month & "  " & oDate.Year)
            uyuma = Convert.ToDate(ComboBox1.Text)
            is_okul = itxt.Text
            kzaman = ktxt.Text
            sonuc = uyuma + is_okul + kzaman
            sonuc = hesapla(sonuc)
            MessageBox.Show("Aktiviteleriniz için ayrılan zaman:" & sonuc)
            Dim gkalan As Double
            gkalan = gün - (sonuc + uyuma + is_okul + kzaman)
            Dim g As Graphics = CreateGraphics()
            Dim rect As Rectangle = New Rectangle(300, 50, 200, 200)
            uyuma = ((uyuma / 24) * 360)
            is_okul = ((is_okul / 24) * 360)
            kzaman = ((kzaman / 24) * 360)
            sonuc = ((sonuc / 24) * 360)
            gkalan = ((gkalan / 24) * 360)
            g.FillPie(Brushes.Green, rect, 0, uyuma)
            g.FillPie(Brushes.Red, rect, uyuma, is_okul)
            g.FillPie(Brushes.Blue, rect, is_okul + uyuma, kzaman)
            g.FillPie(Brushes.Orange, rect, is_okul + uyuma + kzaman, sonuc)
            g.FillPie(Brushes.Yellow, rect, is_okul + uyuma + kzaman + sonuc, gkalan)
            g.Dispose()
            GroupBox1.Visible = True
        Catch ex As Exception
            MessageBox.Show("lütfen boş bırakma")


        End Try


    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub gaktivite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class