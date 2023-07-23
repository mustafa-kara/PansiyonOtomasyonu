Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmYeniMusteri
    Dim baglanti As SqlConnection = VeritabaniBaglantisi.BaglantiGetir()
    Private Sub FrmYeniMusteri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OdaDurumunuGoster(BtnOda101, "101")
        OdaDurumunuGoster(BtnOda102, "102")
        OdaDurumunuGoster(BtnOda103, "103")
        OdaDurumunuGoster(BtnOda104, "104")
        OdaDurumunuGoster(BtnOda105, "105")
        OdaDurumunuGoster(BtnOda106, "106")
        OdaDurumunuGoster(BtnOda107, "107")
        OdaDurumunuGoster(BtnOda108, "108")
        OdaDurumunuGoster(BtnOda109, "109")
    End Sub
    Private Function TumBilgilerGirilmisMi() As Boolean
        If String.IsNullOrEmpty(TxtAdi.Text) OrElse String.IsNullOrEmpty(TxtSoyadi.Text) Then
            Return False
        End If

        If String.IsNullOrEmpty(comboBox1.Text) OrElse String.IsNullOrEmpty(MskTxtTelefon.Text) Then
            Return False
        End If

        If String.IsNullOrEmpty(TxtMail.Text) OrElse String.IsNullOrEmpty(TxtKimlikNo.Text) Then
            Return False
        End If

        If String.IsNullOrEmpty(TxtUcret.Text) Then
            Return False
        End If

        Return True
    End Function
    Private Sub TxtKimlikNo_TextChanged(sender As Object, e As EventArgs) Handles TxtKimlikNo.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TxtKimlikNo.Text, "[^0-9]") Then
            MessageBox.Show("Lütfen sadece sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            TxtKimlikNo.Text = TxtKimlikNo.Text.Remove(TxtKimlikNo.Text.Length - 1)
        End If
    End Sub

    Private Sub OdaDurumunuGoster(ByVal odaButton As Button, ByVal odaNumarasi As String)
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand("select * from Odalar where OdaNo='" & odaNumarasi & "' and Durum='Dolu'", baglanti)
        Dim oku As SqlDataReader = komut.ExecuteReader()

        Dim girişVar As Boolean = False

        While oku.Read()
            odaButton.Text = oku("Adi").ToString() & " " + oku("Soyadi").ToString()
            girişVar = True
        End While

        baglanti.Close()

        If girişVar Then
            odaButton.BackColor = Color.Red
            odaButton.Enabled = False
        Else
            odaButton.BackColor = Color.GreenYellow
            odaButton.Enabled = True
        End If
    End Sub



    Private Sub OdaEkle(ByVal odaNumarasi As String)
        If Not TumBilgilerGirilmisMi() Then
            MessageBox.Show("Lütfen tüm bilgileri doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        TxtOdaNo.Text = odaNumarasi
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand("update Odalar set Adi='" & TxtAdi.Text & "', Soyadi='" + TxtSoyadi.Text & "', Durum='Dolu' where OdaNo='" & odaNumarasi & "'", baglanti)
        komut.ExecuteNonQuery()
        baglanti.Close()
    End Sub


    Private Sub BtnOda101_Click(sender As Object, e As EventArgs) Handles BtnOda101.Click
        Try
            OdaEkle("101")
            OdaDurumunuGoster(BtnOda101, "101")
        Catch __unusedException1__ As Exception
            MessageBox.Show("oda 101 hata")
        End Try
    End Sub

    Private Sub BtnOda102_Click(sender As Object, e As EventArgs) Handles BtnOda102.Click
        Try
            OdaEkle("102")
            OdaDurumunuGoster(BtnOda102, "102")
        Catch __unusedException1__ As Exception
            MessageBox.Show("oda 102 hata")
        End Try
    End Sub

    Private Sub BtnOda103_Click(sender As Object, e As EventArgs) Handles BtnOda103.Click
        Try
            OdaEkle("103")
            OdaDurumunuGoster(BtnOda103, "103")
        Catch __unusedException1__ As Exception
            MessageBox.Show("oda 103 hata")
        End Try
    End Sub

    Private Sub BtnOda104_Click(sender As Object, e As EventArgs) Handles BtnOda104.Click
        Try
            OdaEkle("104")
            OdaDurumunuGoster(BtnOda104, "104")
        Catch __unusedException1__ As Exception
            MessageBox.Show("oda 104 hata")
        End Try
    End Sub

    Private Sub BtnOda105_Click(sender As Object, e As EventArgs) Handles BtnOda105.Click
        Try
            OdaEkle("105")
            OdaDurumunuGoster(BtnOda105, "105")
        Catch __unusedException1__ As Exception
            MessageBox.Show("oda 105 hata")
        End Try
    End Sub

    Private Sub BtnOda106_Click(sender As Object, e As EventArgs) Handles BtnOda106.Click
        Try
            OdaEkle("106")
            OdaDurumunuGoster(BtnOda106, "106")
        Catch __unusedException1__ As Exception
            MessageBox.Show("oda 106 hata")
        End Try
    End Sub

    Private Sub BtnOda107_Click(sender As Object, e As EventArgs) Handles BtnOda107.Click
        Try
            OdaEkle("107")
            OdaDurumunuGoster(BtnOda107, "107")
        Catch __unusedException1__ As Exception
            MessageBox.Show("oda 107 hata")
        End Try
    End Sub

    Private Sub BtnOda108_Click(sender As Object, e As EventArgs) Handles BtnOda108.Click
        Try
            OdaEkle("108")
            OdaDurumunuGoster(BtnOda108, "108")
        Catch __unusedException1__ As Exception
            MessageBox.Show("oda 108 hata")
        End Try
    End Sub

    Private Sub BtnOda109_Click(sender As Object, e As EventArgs) Handles BtnOda109.Click
        Try
            OdaEkle("109")
            OdaDurumunuGoster(BtnOda109, "109")
        Catch __unusedException1__ As Exception
            MessageBox.Show("oda 109 hata")
        End Try
    End Sub

    Private Sub BtnDoluOda_Click(sender As Object, e As EventArgs) Handles BtnDoluOda.Click
        MessageBox.Show("Kırmızı Renkli Kutular Dolu Odalar Gösterir.")
    End Sub

    Private Sub BtnBosOda_Click(sender As Object, e As EventArgs) Handles BtnBosOda.Click
        MessageBox.Show("Yeşil Renkli Kutular Boş Odaları Gösterir")
    End Sub

    Private Sub DtpCikisTarihi_ValueChanged(sender As Object, e As EventArgs) Handles DtpCikisTarihi.ValueChanged
        Dim Ucret As Integer
        Dim KucukTarih As DateTime = Convert.ToDateTime(DtpGirisTarihi.Text)
        Dim BuyukTarih As DateTime = Convert.ToDateTime(DtpCikisTarihi.Text)
        Dim Sonuc As TimeSpan = BuyukTarih - KucukTarih
        label11.Text = Sonuc.TotalDays.ToString()
        Ucret = Convert.ToInt32(label11.Text) * 100
        TxtUcret.Text = Ucret.ToString()

        Dim girisTarihi As DateTime = DtpGirisTarihi.Value
        Dim cikisTarihi As DateTime = DtpCikisTarihi.Value
        Dim bugun As DateTime = DateTime.Today

        If cikisTarihi <= girisTarihi OrElse cikisTarihi < bugun Then
            MessageBox.Show("Geçersiz tarih! Çıkış tarihi giriş tarihinden önce veya bugünden önce olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DtpCikisTarihi.Value = girisTarihi.AddDays(1)
        End If
    End Sub
    Dim isSaved As Boolean = False

    Private Sub BtnKaydet_Click(sender As Object, e As EventArgs) Handles BtnKaydet.Click
        Try
            If Not TumBilgilerGirilmisMi() Then
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            baglanti.Open()
            Dim komut As SqlCommand = New SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" & TxtAdi.Text & "', '" + TxtSoyadi.Text & "', '" + comboBox1.Text & "','" + MskTxtTelefon.Text & "','" + TxtMail.Text & "','" + TxtKimlikNo.Text & "','" + TxtOdaNo.Text & "','" + TxtUcret.Text & "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") & "','" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") & "')", baglanti)
            komut.ExecuteNonQuery()

            ' Oda durumunu 'Dolu' olarak güncelle
            Dim odaKomut As SqlCommand = New SqlCommand("update Odalar set Durum='Dolu' where OdaNo='" & TxtOdaNo.Text & "'", baglanti)
            odaKomut.ExecuteNonQuery()
            baglanti.Close()
            MessageBox.Show("Kayıt Yapıldı")
            isSaved = True
        Catch __unusedException1__ As Exception
            MessageBox.Show("Kaydet butonunda Hata")
        End Try
    End Sub

    Private Sub FrmYeniMusteri_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Kullanıcı bilgileri kaydedilmediyse ve baglanti hala aciksa
        If Not isSaved And baglanti.State = ConnectionState.Open Then
            ' Geri al komutunu çalıştır ve bağlantıyı kapat
            Dim komut As SqlCommand = New SqlCommand("ROLLBACK", baglanti)
            komut.ExecuteNonQuery()
            baglanti.Close()
        End If
    End Sub

    Private Sub DtpGirisTarihi_ValueChanged(sender As Object, e As EventArgs) Handles DtpGirisTarihi.ValueChanged
        Dim girisTarihi As DateTime = DtpGirisTarihi.Value
        Dim cikisTarihi As DateTime = DtpCikisTarihi.Value
        Dim bugun As DateTime = DateTime.Today

        If girisTarihi < bugun Then
            MessageBox.Show("Geçersiz tarih! Giriş tarihi bugünden önce olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DtpGirisTarihi.Value = bugun
        End If
    End Sub
End Class