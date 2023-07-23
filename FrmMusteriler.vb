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

Public Class FrmMusteriler
    Dim baglanti As SqlConnection = VeritabaniBaglantisi.BaglantiGetir()
    Private Sub verilergoster()
        listView1.Items.Clear()
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand("Select * from MusteriEkle", baglanti)
        Dim oku As SqlDataReader = komut.ExecuteReader()

        While oku.Read()
            Dim ekle As ListViewItem = New ListViewItem()
            ekle.Text = oku("Musteriid").ToString()
            ekle.SubItems.Add(oku("Adi").ToString())
            ekle.SubItems.Add(oku("Soyadi").ToString())
            ekle.SubItems.Add(oku("Cinsiyet").ToString())
            ekle.SubItems.Add(oku("Telefon").ToString())
            ekle.SubItems.Add(oku("Mail").ToString())
            ekle.SubItems.Add(oku("TC").ToString())
            ekle.SubItems.Add(oku("OdaNo").ToString())
            ekle.SubItems.Add(oku("Ucret").ToString())
            ekle.SubItems.Add(oku("GirisTarihi").ToString())
            ekle.SubItems.Add(oku("CikisTarihi").ToString())
            listView1.Items.Add(ekle)
        End While

        baglanti.Close()
    End Sub
    Private Sub BtnVerileriGoster_Click(sender As Object, e As EventArgs) Handles BtnVerileriGoster.Click
        verilergoster()
    End Sub
    Dim id As Integer = 0
    Private eskiOdaNo As String
    Private Sub listView1_DoubleClick(sender As Object, e As EventArgs) Handles listView1.DoubleClick
        id = Integer.Parse(listView1.SelectedItems(0).SubItems(0).Text)
        TxtAdi.Text = listView1.SelectedItems(0).SubItems(1).Text
        TxtSoyadi.Text = listView1.SelectedItems(0).SubItems(2).Text
        comboBox1.Text = listView1.SelectedItems(0).SubItems(3).Text
        MskTxtTelefon.Text = listView1.SelectedItems(0).SubItems(4).Text
        TxtMail.Text = listView1.SelectedItems(0).SubItems(5).Text
        TxtKimlikNo.Text = listView1.SelectedItems(0).SubItems(6).Text
        TxtOdaNo.Text = listView1.SelectedItems(0).SubItems(7).Text
        TxtUcret.Text = listView1.SelectedItems(0).SubItems(8).Text
        DtpGirisTarihi.Text = listView1.SelectedItems(0).SubItems(9).Text
        DtpCikisTarihi.Text = listView1.SelectedItems(0).SubItems(10).Text
        eskiOdaNo = TxtOdaNo.Text
    End Sub


    Private Sub BtnSil_Click(sender As Object, e As EventArgs) Handles BtnSil.Click
        Try
            baglanti.Open()
            Dim komut As SqlCommand = New SqlCommand("update Odalar set Durum='Boş', Adi='', Soyadi='' where OdaNo='" & TxtOdaNo.Text & "'", baglanti)
            komut.ExecuteNonQuery()
            baglanti.Close()



            MessageBox.Show("Çıkış yapıldı. Oda boşaltıldı.")
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub


    Private Sub BtnTemizle_Click(sender As Object, e As EventArgs) Handles BtnTemizle.Click
        Try
            TxtAdi.Clear()
            TxtSoyadi.Clear()
            comboBox1.Text = ""
            MskTxtTelefon.Clear()
            TxtMail.Clear()
            TxtKimlikNo.Clear()
            TxtOdaNo.Clear()
            TxtUcret.Clear()
            DtpGirisTarihi.Text = ""
            DtpCikisTarihi.Text = ""
        Catch __unusedException1__ As Exception
            MessageBox.Show("Temizleme Butonu Hatalı. ")
        End Try
    End Sub

    Private Sub BtnGuncelle_Click(sender As Object, e As EventArgs) Handles BtnGuncelle.Click
        Try
            baglanti.Open()

            ' Eski odanın durumunu boşa çıkarın
            If eskiOdaNo <> TxtOdaNo.Text Then
                Dim komutEski As New SqlCommand("update Odalar set Durum='Boş', Adi=NULL, Soyadi=NULL where OdaNo='" & eskiOdaNo & "'", baglanti)
                komutEski.ExecuteNonQuery()
            End If

            ' Müşterinin bilgilerini güncelleyin
            Dim komut As New SqlCommand("update MusteriEkle set Adi='" & TxtAdi.Text & "',Soyadi='" & TxtSoyadi.Text & "',Cinsiyet='" & comboBox1.Text & "',Telefon='" & MskTxtTelefon.Text & "',Mail='" & TxtMail.Text & "',TC='" & TxtKimlikNo.Text & "',OdaNo='" & TxtOdaNo.Text & "',Ucret='" & TxtUcret.Text & "',GirisTarihi ='" & DtpGirisTarihi.Value.ToString("yyyy-MM-dd") & "',CikisTarihi='" & DtpCikisTarihi.Value.ToString("yyyy-MM-dd") & "' where Musteriid=" & id & "", baglanti)
            komut.ExecuteNonQuery()

            ' Yeni odanın durumunu dolu yapın
            If eskiOdaNo <> TxtOdaNo.Text Then
                Dim komutYeni As New SqlCommand("update Odalar set Durum='Dolu', Adi='" & TxtAdi.Text & "', Soyadi='" & TxtSoyadi.Text & "' where OdaNo='" & TxtOdaNo.Text & "'", baglanti)
                komutYeni.ExecuteNonQuery()
            End If

            MessageBox.Show("Müşteri Bilgileri Güncellendi.")

            baglanti.Close()
            verilergoster()

        Catch __unusedException1__ As Exception
            MessageBox.Show("Güncelleme Butonu Hatalı.")
        End Try
    End Sub



    Private Sub BtnAra_Click(sender As Object, e As EventArgs) Handles BtnAra.Click
        listView1.Items.Clear()
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand("Select * from MusteriEkle where adi like '%" & textBox1.Text & "%'", baglanti)
        Dim oku As SqlDataReader = komut.ExecuteReader()

        While oku.Read()
            Dim ekle As ListViewItem = New ListViewItem()
            ekle.Text = oku("Musteriid").ToString()
            ekle.SubItems.Add(oku("Adi").ToString())
            ekle.SubItems.Add(oku("Soyadi").ToString())
            ekle.SubItems.Add(oku("Cinsiyet").ToString())
            ekle.SubItems.Add(oku("Telefon").ToString())
            ekle.SubItems.Add(oku("Mail").ToString())
            ekle.SubItems.Add(oku("TC").ToString())
            ekle.SubItems.Add(oku("OdaNo").ToString())
            ekle.SubItems.Add(oku("Ucret").ToString())
            ekle.SubItems.Add(oku("GirisTarihi").ToString())
            ekle.SubItems.Add(oku("CikisTarihi").ToString())
            listView1.Items.Add(ekle)
        End While
        baglanti.Close()
    End Sub

    Private Sub BtnMusteriSil_Click(sender As Object, e As EventArgs) Handles BtnMusteriSil.Click
        Try
            baglanti.Open()
            Dim komut As SqlCommand = New SqlCommand("delete from MusteriEkle where Musteriid = (" & id & ")", baglanti)
            komut.ExecuteNonQuery()
            baglanti.Close()
            MessageBox.Show("Müşteri Silindi")
            verilergoster()
        Catch __unusedException1__ As Exception
            MessageBox.Show("Müşteri Sil Butonu Hatalı. ")
        End Try
    End Sub
End Class