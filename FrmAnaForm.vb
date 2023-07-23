Imports System
Imports System.Windows.Forms

Public Class FrmAnaForm
    Inherits Form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim fr As New FrmAdminGiris()
        fr.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim fr As New FrmYeniMusteri()
        fr.Show()
    End Sub

    Private Sub BtnMusteriler_Click(sender As Object, e As EventArgs) Handles BtnMusteriler.Click
        Dim fr As New FrmMusteriler()
        fr.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        MessageBox.Show("Karanfil Otel Kayıt Uygulaması / 2023 - Bursa - Mustafa Kara")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim fr As New FrmOdalar()
        fr.Show()
    End Sub

    Private Sub BtnCikis_Click(sender As Object, e As EventArgs) Handles BtnCikis.Click
        Application.Exit()
    End Sub

    Private Sub FrmAnaForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
