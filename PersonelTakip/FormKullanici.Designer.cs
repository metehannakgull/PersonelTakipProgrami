
namespace PersonelTakip
{
    partial class FormKullanici
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
            this.lblGorev = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblMezuniyet = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblGorevYeri = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblAktifKullanici = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxTC_K = new System.Windows.Forms.MaskedTextBox();
            this.lblAd2 = new System.Windows.Forms.Label();
            this.lblMezuniyet2 = new System.Windows.Forms.Label();
            this.lblCinsiyet2 = new System.Windows.Forms.Label();
            this.lblSoyad2 = new System.Windows.Forms.Label();
            this.lblDogumTarihi2 = new System.Windows.Forms.Label();
            this.lblGorev2 = new System.Windows.Forms.Label();
            this.lblGorevYeri2 = new System.Windows.Forms.Label();
            this.lblMaas2 = new System.Windows.Forms.Label();
            this.lblAktifKullanici2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGorev
            // 
            this.lblGorev.AutoSize = true;
            this.lblGorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGorev.Location = new System.Drawing.Point(583, 49);
            this.lblGorev.Name = "lblGorev";
            this.lblGorev.Size = new System.Drawing.Size(48, 15);
            this.lblGorev.TabIndex = 20;
            this.lblGorev.Text = "Gorev:";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.Location = new System.Drawing.Point(533, 25);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(98, 15);
            this.lblDogumTarihi.TabIndex = 19;
            this.lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // lblMezuniyet
            // 
            this.lblMezuniyet.AutoSize = true;
            this.lblMezuniyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMezuniyet.Location = new System.Drawing.Point(203, 124);
            this.lblMezuniyet.Name = "lblMezuniyet";
            this.lblMezuniyet.Size = new System.Drawing.Size(76, 15);
            this.lblMezuniyet.TabIndex = 18;
            this.lblMezuniyet.Text = "Mezuniyet:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(218, 99);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(61, 15);
            this.lblCinsiyet.TabIndex = 17;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(229, 74);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(50, 15);
            this.lblSoyad.TabIndex = 16;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(189, 24);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(90, 15);
            this.lblTC.TabIndex = 15;
            this.lblTC.Text = "TC kimlik no:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 130);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(443, 20);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 30;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(252, 49);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(27, 15);
            this.lblAd.TabIndex = 31;
            this.lblAd.Text = "Ad:";
            // 
            // lblGorevYeri
            // 
            this.lblGorevYeri.AutoSize = true;
            this.lblGorevYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGorevYeri.Location = new System.Drawing.Point(554, 73);
            this.lblGorevYeri.Name = "lblGorevYeri";
            this.lblGorevYeri.Size = new System.Drawing.Size(77, 15);
            this.lblGorevYeri.TabIndex = 32;
            this.lblGorevYeri.Text = "Görev Yeri:";
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaas.Location = new System.Drawing.Point(585, 97);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(46, 15);
            this.lblMaas.TabIndex = 33;
            this.lblMaas.Text = "Maaş:";
            // 
            // lblAktifKullanici
            // 
            this.lblAktifKullanici.AutoSize = true;
            this.lblAktifKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktifKullanici.Location = new System.Drawing.Point(731, 25);
            this.lblAktifKullanici.Name = "lblAktifKullanici";
            this.lblAktifKullanici.Size = new System.Drawing.Size(98, 15);
            this.lblAktifKullanici.TabIndex = 34;
            this.lblAktifKullanici.Text = "Aktif Kullanıcı:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(734, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 130);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // maskedTextBoxTC_K
            // 
            this.maskedTextBoxTC_K.Location = new System.Drawing.Point(285, 24);
            this.maskedTextBoxTC_K.Name = "maskedTextBoxTC_K";
            this.maskedTextBoxTC_K.Size = new System.Drawing.Size(131, 20);
            this.maskedTextBoxTC_K.TabIndex = 36;
            // 
            // lblAd2
            // 
            this.lblAd2.AutoSize = true;
            this.lblAd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd2.Location = new System.Drawing.Point(296, 49);
            this.lblAd2.Name = "lblAd2";
            this.lblAd2.Size = new System.Drawing.Size(15, 15);
            this.lblAd2.TabIndex = 37;
            this.lblAd2.Text = "..";
            // 
            // lblMezuniyet2
            // 
            this.lblMezuniyet2.AutoSize = true;
            this.lblMezuniyet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMezuniyet2.Location = new System.Drawing.Point(296, 124);
            this.lblMezuniyet2.Name = "lblMezuniyet2";
            this.lblMezuniyet2.Size = new System.Drawing.Size(15, 15);
            this.lblMezuniyet2.TabIndex = 38;
            this.lblMezuniyet2.Text = "..";
            // 
            // lblCinsiyet2
            // 
            this.lblCinsiyet2.AutoSize = true;
            this.lblCinsiyet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet2.Location = new System.Drawing.Point(296, 99);
            this.lblCinsiyet2.Name = "lblCinsiyet2";
            this.lblCinsiyet2.Size = new System.Drawing.Size(15, 15);
            this.lblCinsiyet2.TabIndex = 39;
            this.lblCinsiyet2.Text = "..";
            // 
            // lblSoyad2
            // 
            this.lblSoyad2.AutoSize = true;
            this.lblSoyad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad2.Location = new System.Drawing.Point(296, 74);
            this.lblSoyad2.Name = "lblSoyad2";
            this.lblSoyad2.Size = new System.Drawing.Size(15, 15);
            this.lblSoyad2.TabIndex = 40;
            this.lblSoyad2.Text = "..";
            // 
            // lblDogumTarihi2
            // 
            this.lblDogumTarihi2.AutoSize = true;
            this.lblDogumTarihi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi2.Location = new System.Drawing.Point(637, 25);
            this.lblDogumTarihi2.Name = "lblDogumTarihi2";
            this.lblDogumTarihi2.Size = new System.Drawing.Size(15, 15);
            this.lblDogumTarihi2.TabIndex = 41;
            this.lblDogumTarihi2.Text = "..";
            // 
            // lblGorev2
            // 
            this.lblGorev2.AutoSize = true;
            this.lblGorev2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGorev2.Location = new System.Drawing.Point(637, 49);
            this.lblGorev2.Name = "lblGorev2";
            this.lblGorev2.Size = new System.Drawing.Size(15, 15);
            this.lblGorev2.TabIndex = 42;
            this.lblGorev2.Text = "..";
            // 
            // lblGorevYeri2
            // 
            this.lblGorevYeri2.AutoSize = true;
            this.lblGorevYeri2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGorevYeri2.Location = new System.Drawing.Point(637, 73);
            this.lblGorevYeri2.Name = "lblGorevYeri2";
            this.lblGorevYeri2.Size = new System.Drawing.Size(15, 15);
            this.lblGorevYeri2.TabIndex = 43;
            this.lblGorevYeri2.Text = "..";
            // 
            // lblMaas2
            // 
            this.lblMaas2.AutoSize = true;
            this.lblMaas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaas2.Location = new System.Drawing.Point(637, 99);
            this.lblMaas2.Name = "lblMaas2";
            this.lblMaas2.Size = new System.Drawing.Size(15, 15);
            this.lblMaas2.TabIndex = 44;
            this.lblMaas2.Text = "..";
            // 
            // lblAktifKullanici2
            // 
            this.lblAktifKullanici2.AutoSize = true;
            this.lblAktifKullanici2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktifKullanici2.ForeColor = System.Drawing.Color.Red;
            this.lblAktifKullanici2.Location = new System.Drawing.Point(835, 25);
            this.lblAktifKullanici2.Name = "lblAktifKullanici2";
            this.lblAktifKullanici2.Size = new System.Drawing.Size(15, 15);
            this.lblAktifKullanici2.TabIndex = 45;
            this.lblAktifKullanici2.Text = "..";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(885, 156);
            this.dataGridView1.TabIndex = 46;
            // 
            // FormKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 362);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAktifKullanici2);
            this.Controls.Add(this.lblMaas2);
            this.Controls.Add(this.lblGorevYeri2);
            this.Controls.Add(this.lblGorev2);
            this.Controls.Add(this.lblDogumTarihi2);
            this.Controls.Add(this.lblSoyad2);
            this.Controls.Add(this.lblCinsiyet2);
            this.Controls.Add(this.lblMezuniyet2);
            this.Controls.Add(this.lblAd2);
            this.Controls.Add(this.maskedTextBoxTC_K);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblAktifKullanici);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.lblGorevYeri);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGorev);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblMezuniyet);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblTC);
            this.Name = "FormKullanici";
            this.Text = "FormKullanici";
            this.Load += new System.EventHandler(this.FormKullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGorev;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblMezuniyet;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblGorevYeri;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblAktifKullanici;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTC_K;
        private System.Windows.Forms.Label lblAd2;
        private System.Windows.Forms.Label lblMezuniyet2;
        private System.Windows.Forms.Label lblCinsiyet2;
        private System.Windows.Forms.Label lblSoyad2;
        private System.Windows.Forms.Label lblDogumTarihi2;
        private System.Windows.Forms.Label lblGorev2;
        private System.Windows.Forms.Label lblGorevYeri2;
        private System.Windows.Forms.Label lblMaas2;
        private System.Windows.Forms.Label lblAktifKullanici2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}