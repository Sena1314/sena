Imports System.Data.SqlClient

Public Class kullanici

    Private ad As String
    Private soyad As String
    Private dogum_tarihi As Date
    Private yas As String
    Private telefon As String
    Private sehir As String
    Private semt As String
    Private posta_kodu As String
    Private e_mail As String
    Private sifre As String
    Private sifre_tekrar As String
    Private meslek As String
    Public Sub verial(ByVal isim As String, ByVal soyisim As String, ByVal dog_tar As Date, ByVal tel As String, ByVal il As String, ByVal ilce As String, ByVal posta As String, ByVal email As String, ByVal sif1 As String, ByVal sif2 As String, ByVal job As String)
        ad = isim
        soyad = soyisim
        dogum_tarihi = dog_tar
        yas = (Year(DateTime.Now) - Year(dog_tar)).ToString()
        telefon = tel
        sehir = il
        semt = ilce
        posta_kodu = posta
        e_mail = email
        sifre = sif1
        sifre_tekrar = sif2
        meslek = job

    End Sub
    Public Sub New()
        ad = soyad = yas = telefon = sehir = semt = posta_kodu = e_mail = sifre = sifre_tekrar = meslek = vbNullString
        dogum_tarihi = vbNullString
    End Sub
    Public Sub Kaydet()
        Try
            Dim con As SqlConnection = New SqlConnection(" Source=MERT;Initial Catalog=off_day_off_time;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("insert into kullanici values(@ad,@soyad,@dogum_tarihi,@yas,@telefon,@sehir,@semt,@posta_kodu,@e_mail,@sifre,@sifre_tekrar,@meslek", con)
            cmd.Parameters.AddWithValue("@ad", ad)
            cmd.Parameters.AddWithValue("@soyad", soyad)
            cmd.Parameters.AddWithValue("@dogum_tarihi", dogum_tarihi)
            cmd.Parameters.AddWithValue("@yas", yas)
            cmd.Parameters.AddWithValue("@telefon", telefon)
            cmd.Parameters.AddWithValue("@sehir", sehir)
            cmd.Parameters.AddWithValue("@semt", semt)
            cmd.Parameters.AddWithValue("@posta_kodu", posta_kodu)
            cmd.Parameters.AddWithValue("@e_mail", e_mail)
            cmd.Parameters.AddWithValue("@sifre", sifre)
            cmd.Parameters.AddWithValue("@sifre_tekrar", sifre_tekrar)
            cmd.Parameters.AddWithValue("@meslek", meslek)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
