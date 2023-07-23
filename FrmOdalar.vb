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


Public Class FrmOdalar
    Dim baglanti As SqlConnection = VeritabaniBaglantisi.BaglantiGetir()

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
    Private Sub BtnOda101_Click(sender As Object, e As EventArgs) Handles BtnOda101.Click

    End Sub

    Private Sub BtnOda102_Click(sender As Object, e As EventArgs) Handles BtnOda102.Click

    End Sub

    Private Sub BtnOda103_Click(sender As Object, e As EventArgs) Handles BtnOda103.Click

    End Sub

    Private Sub BtnOda104_Click(sender As Object, e As EventArgs) Handles BtnOda104.Click

    End Sub

    Private Sub BtnOda105_Click(sender As Object, e As EventArgs) Handles BtnOda105.Click

    End Sub

    Private Sub BtnOda106_Click(sender As Object, e As EventArgs) Handles BtnOda106.Click

    End Sub

    Private Sub BtnOda107_Click(sender As Object, e As EventArgs) Handles BtnOda107.Click

    End Sub

    Private Sub BtnOda108_Click(sender As Object, e As EventArgs) Handles BtnOda108.Click

    End Sub

    Private Sub BtnOda109_Click(sender As Object, e As EventArgs) Handles BtnOda109.Click

    End Sub

    Private Sub FrmOdalar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class