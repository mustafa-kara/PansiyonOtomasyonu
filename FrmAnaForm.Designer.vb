<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnaForm))
        Me.BtnCikis = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.BtnMusteriler = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCikis
        '
        Me.BtnCikis.BackColor = System.Drawing.Color.Red
        Me.BtnCikis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnCikis.Location = New System.Drawing.Point(628, 349)
        Me.BtnCikis.Name = "BtnCikis"
        Me.BtnCikis.Size = New System.Drawing.Size(162, 101)
        Me.BtnCikis.TabIndex = 19
        Me.BtnCikis.Text = "Çıkış"
        Me.BtnCikis.UseVisualStyleBackColor = False
        '
        'button8
        '
        Me.button8.BackColor = System.Drawing.Color.DarkTurquoise
        Me.button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.button8.Location = New System.Drawing.Point(370, 349)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(162, 101)
        Me.button8.TabIndex = 16
        Me.button8.Text = "Hakkımızda"
        Me.button8.UseVisualStyleBackColor = False
        '
        'BtnMusteriler
        '
        Me.BtnMusteriler.BackColor = System.Drawing.Color.Violet
        Me.BtnMusteriler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnMusteriler.Location = New System.Drawing.Point(103, 349)
        Me.BtnMusteriler.Name = "BtnMusteriler"
        Me.BtnMusteriler.Size = New System.Drawing.Size(162, 101)
        Me.BtnMusteriler.TabIndex = 15
        Me.BtnMusteriler.Text = "Müşteriler"
        Me.BtnMusteriler.UseVisualStyleBackColor = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.PaleGreen
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button3.Location = New System.Drawing.Point(628, 97)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(162, 101)
        Me.button3.TabIndex = 14
        Me.button3.Text = "Odalar"
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.MediumPurple
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button2.Location = New System.Drawing.Point(370, 97)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(162, 101)
        Me.button2.TabIndex = 13
        Me.button2.Text = "Yeni Müşteri"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1.Location = New System.Drawing.Point(103, 97)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(162, 101)
        Me.button1.TabIndex = 12
        Me.button1.Text = "Admin Giriş"
        Me.button1.UseVisualStyleBackColor = False
        '
        'FrmAnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1046, 590)
        Me.Controls.Add(Me.BtnCikis)
        Me.Controls.Add(Me.button8)
        Me.Controls.Add(Me.BtnMusteriler)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAnaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAnaForm"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents BtnCikis As Button
    Private WithEvents button8 As Button
    Private WithEvents BtnMusteriler As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
End Class
