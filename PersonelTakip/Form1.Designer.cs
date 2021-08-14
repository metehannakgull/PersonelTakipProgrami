
namespace PersonelTakip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblYetki = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.radioBtnYonetici = new System.Windows.Forms.RadioButton();
            this.radioBtnKullanici = new System.Windows.Forms.RadioButton();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblGirisHakki = new System.Windows.Forms.Label();
            this.lblGirisHakki2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(32, 42);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(97, 16);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParola.Location = new System.Drawing.Point(32, 70);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(58, 16);
            this.lblParola.TabIndex = 0;
            this.lblParola.Text = "Parola:";
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetki.Location = new System.Drawing.Point(32, 98);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(47, 16);
            this.lblYetki.TabIndex = 0;
            this.lblYetki.Text = "Yetki:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(165, 42);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(144, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(165, 68);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(144, 20);
            this.txtParola.TabIndex = 1;
            // 
            // radioBtnYonetici
            // 
            this.radioBtnYonetici.AutoSize = true;
            this.radioBtnYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnYonetici.Location = new System.Drawing.Point(165, 94);
            this.radioBtnYonetici.Name = "radioBtnYonetici";
            this.radioBtnYonetici.Size = new System.Drawing.Size(71, 17);
            this.radioBtnYonetici.TabIndex = 2;
            this.radioBtnYonetici.TabStop = true;
            this.radioBtnYonetici.Text = "Yönetici";
            this.radioBtnYonetici.UseVisualStyleBackColor = true;
            // 
            // radioBtnKullanici
            // 
            this.radioBtnKullanici.AutoSize = true;
            this.radioBtnKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnKullanici.Location = new System.Drawing.Point(245, 94);
            this.radioBtnKullanici.Name = "radioBtnKullanici";
            this.radioBtnKullanici.Size = new System.Drawing.Size(73, 17);
            this.radioBtnKullanici.TabIndex = 3;
            this.radioBtnKullanici.TabStop = true;
            this.radioBtnKullanici.Text = "Kullanıcı";
            this.radioBtnKullanici.UseVisualStyleBackColor = true;
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(153, 121);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 33);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(234, 121);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 33);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // lblGirisHakki
            // 
            this.lblGirisHakki.AutoSize = true;
            this.lblGirisHakki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisHakki.Location = new System.Drawing.Point(32, 185);
            this.lblGirisHakki.Name = "lblGirisHakki";
            this.lblGirisHakki.Size = new System.Drawing.Size(88, 16);
            this.lblGirisHakki.TabIndex = 6;
            this.lblGirisHakki.Text = "Giriş Hakkı:";
            // 
            // lblGirisHakki2
            // 
            this.lblGirisHakki2.AutoSize = true;
            this.lblGirisHakki2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisHakki2.ForeColor = System.Drawing.Color.Red;
            this.lblGirisHakki2.Location = new System.Drawing.Point(126, 185);
            this.lblGirisHakki2.Name = "lblGirisHakki2";
            this.lblGirisHakki2.Size = new System.Drawing.Size(16, 16);
            this.lblGirisHakki2.TabIndex = 7;
            this.lblGirisHakki2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 294);
            this.Controls.Add(this.lblGirisHakki2);
            this.Controls.Add(this.lblGirisHakki);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.radioBtnKullanici);
            this.Controls.Add(this.radioBtnYonetici);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Name = "Form1";
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.RadioButton radioBtnYonetici;
        private System.Windows.Forms.RadioButton radioBtnKullanici;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblGirisHakki;
        private System.Windows.Forms.Label lblGirisHakki2;
    }
}

