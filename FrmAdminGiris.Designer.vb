<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdminGiris
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdminGiris))
        Me.label3 = New System.Windows.Forms.Label()
        Me.BtnGirisYap = New System.Windows.Forms.Button()
        Me.TxtSifre = New System.Windows.Forms.TextBox()
        Me.TxtKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.Location = New System.Drawing.Point(170, 170)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(246, 29)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Lütfen Giriş Yapınız."
        '
        'BtnGirisYap
        '
        Me.BtnGirisYap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnGirisYap.Location = New System.Drawing.Point(209, 308)
        Me.BtnGirisYap.Name = "BtnGirisYap"
        Me.BtnGirisYap.Size = New System.Drawing.Size(128, 39)
        Me.BtnGirisYap.TabIndex = 10
        Me.BtnGirisYap.Text = "Giriş Yap"
        Me.BtnGirisYap.UseVisualStyleBackColor = True
        '
        'TxtSifre
        '
        Me.TxtSifre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtSifre.Location = New System.Drawing.Point(273, 252)
        Me.TxtSifre.Name = "TxtSifre"
        Me.TxtSifre.Size = New System.Drawing.Size(143, 27)
        Me.TxtSifre.TabIndex = 9
        Me.TxtSifre.UseSystemPasswordChar = True
        '
        'TxtKullaniciAdi
        '
        Me.TxtKullaniciAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtKullaniciAdi.Location = New System.Drawing.Point(273, 202)
        Me.TxtKullaniciAdi.Name = "TxtKullaniciAdi"
        Me.TxtKullaniciAdi.Size = New System.Drawing.Size(143, 27)
        Me.TxtKullaniciAdi.TabIndex = 8
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.Location = New System.Drawing.Point(155, 254)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(70, 25)
        Me.label2.TabIndex = 7
        Me.label2.Text = "Şifre :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label1.Location = New System.Drawing.Point(123, 204)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(145, 25)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Kullanıcı Adı :"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(260, 67)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(77, 88)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.otelv3.My.Resources.Resources.carnation__2_
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(203, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 32)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Karanfil Otel"
        '
        'FrmAdminGiris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(614, 388)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.BtnGirisYap)
        Me.Controls.Add(Me.TxtSifre)
        Me.Controls.Add(Me.TxtKullaniciAdi)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdminGiris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Giriş"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label3 As Label
    Private WithEvents BtnGirisYap As Button
    Private WithEvents TxtSifre As TextBox
    Private WithEvents TxtKullaniciAdi As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Private WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
