using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace otelv3
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class FrmAdminGiris : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            label3 = new Label();
            BtnGirisYap = new Button();
            TxtSifre = new TextBox();
            TxtKullaniciAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8f, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(163, 67);
            label3.Name = "label3";
            label3.Size = new Size(246, 29);
            label3.TabIndex = 11;
            label3.Text = "Lütfen Giriş Yapınız.";
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGirisYap.Location = new Point(221, 283);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(128, 39);
            BtnGirisYap.TabIndex = 10;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = true;
            // 
            // TxtSifre
            // 
            TxtSifre.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 162);
            TxtSifre.Location = new Point(277, 203);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(143, 27);
            TxtSifre.TabIndex = 9;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // TxtKullaniciAdi
            // 
            TxtKullaniciAdi.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 162);
            TxtKullaniciAdi.Location = new Point(277, 153);
            TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            TxtKullaniciAdi.Size = new Size(143, 27);
            TxtKullaniciAdi.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(159, 205);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 7;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(127, 155);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adı :";
            // 
            // FrmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(614, 388);
            Controls.Add(label3);
            Controls.Add(BtnGirisYap);
            Controls.Add(TxtSifre);
            Controls.Add(TxtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAdminGiris";
            Text = "Giriş";
            ResumeLayout(false);
            PerformLayout();

        }

        private Label label3;
        private Button BtnGirisYap;
        private TextBox TxtSifre;
        private TextBox TxtKullaniciAdi;
        private Label label2;
        private Label label1;
    }
}