using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otelv3
{

    public partial class FrmAdminGiris : Form
    {

        private SqlConnection baglanti = new SqlConnection(@"Data Source=MUSTAFA\SQLEXPRESS;Initial Catalog=KaranfilOtel;Integrated Security=True");

        public FrmAdminGiris()
        {
            InitializeComponent();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where kullanici =@Kullaniciadi AND Sifre=@Sifresi";
                var prm1 = new SqlParameter("Kullaniciadi", TxtKullaniciAdi.Text.Trim());
                var prm2 = new SqlParameter("Sifresi", TxtSifre.Text.Trim());
                var komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                var dt = new DataTable();
                var da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    var fr = new otelv3.FrmAnaForm();
                    fr.Show();
                    Hide();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
                baglanti.Close();
            }

        }
    }
}