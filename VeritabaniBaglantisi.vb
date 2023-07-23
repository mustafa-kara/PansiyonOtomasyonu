Imports System.Data.SqlClient
Public Class VeritabaniBaglantisi
    Public Shared Function BaglantiGetir() As SqlConnection
        Dim baglanti As SqlConnection = New SqlConnection("Data Source=MUSTAFA\SQLEXPRESS;Initial Catalog=KaranfilOtel;Integrated Security=True")
        Return baglanti
    End Function
End Class
