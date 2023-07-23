Imports System.Data.SqlClient


Public Class FrmAdminGiris
    Dim baglanti As SqlConnection = VeritabaniBaglantisi.BaglantiGetir()

    Private Sub BtnGirisYap_Click(sender As Object, e As EventArgs) Handles BtnGirisYap.Click
        Try
            baglanti.Open()
            Dim sql As String = "select * from AdminGiris where kullanici =@Kullaniciadi AND Sifre=@Sifresi"
            Dim prm1 As SqlParameter = New SqlParameter("Kullaniciadi", TxtKullaniciAdi.Text.Trim())
            Dim prm2 As SqlParameter = New SqlParameter("Sifresi", TxtSifre.Text.Trim())
            Dim komut As SqlCommand = New SqlCommand(sql, baglanti)
            komut.Parameters.Add(prm1)
            komut.Parameters.Add(prm2)
            Dim dt As DataTable = New DataTable()
            Dim da As SqlDataAdapter = New SqlDataAdapter(komut)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim fr As FrmAnaForm = New FrmAnaForm()
                fr.Show()
                Me.Hide()
            End If

        Catch __unusedException1__ As Exception
            MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış")
            baglanti.Close()
        End Try

    End Sub
End Class