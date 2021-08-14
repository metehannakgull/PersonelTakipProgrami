using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text.RegularExpressions; //regex
using System.IO;


namespace PersonelTakip
{
    public partial class FormYonetici : Form
    {
        public FormYonetici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CVANAKGUL;Initial Catalog=PersonelTakip;Integrated Security=True");

        private void kullanicilariGoster()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter komut = new SqlDataAdapter("select TcNo AS[TC KİMLİK NO],Ad AS[ADI],Soyad AS[SOYADI]," +
                    "Yetki AS[YETKİ],KullaniciAdi AS[KULLANICI ADI], Parola AS[PAROLA] from Table_Kullanicilar Order By Ad ASC",baglanti);
                DataSet dsHafiza = new DataSet(); //bellekte alan oluşturduk
                komut.Fill(dsHafiza); //sorgudan gelenlerle doldurduk
                dataGridView1.DataSource = dsHafiza.Tables[0];
                baglanti.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();

               // throw;
            }
        }
        private void personelleriGoster()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter komut = new SqlDataAdapter("select TcNo AS[TC KİMLİK NO],Ad AS[ADI],Soyad AS[SOYADI]," +
                    "Cinsiyet AS[CİNSİYET],Mezuniyet AS[MEZUNİYET], DogumTarihi AS[DOGUM TARİHİ], Gorev AS[GOREV],GorevYeri AS[GOREV YERİ]" +
                    ",Maas AS[MAAŞ] from Table_Personeller Order By Ad ASC", baglanti);
                DataSet dsHafiza = new DataSet(); //bellekte alan oluşturduk
                komut.Fill(dsHafiza); //sorgudan gelenlerle doldurduk
                dataGridView2.DataSource = dsHafiza.Tables[0];
                baglanti.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();

                // throw;
            }
        }

        private void FormYonetici_Load(object sender, EventArgs e)
        {
            // kullanicilariGoster();
            //  personelleriGoster();
            //********************FormYonetici Ayarları*********************//
            pictureBox1.Height = 150;
            pictureBox1.Width = 150;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\kullaniciResim\\" + Form1.tcno + ".jpg"); //Form1de giriş yapılan kişinin TcNo su ne ise onun resmi gelecek
               //üst satıdaki kod çok önemli. Form1 deki "tcno" değişkenimizi kullarak TC'ye göre resmi getirdik.
            }
            catch 
            {

                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\kullaniciResim\\defaultResim.jpg");
                // eğer resim yoksa varsayılan resmi getirecek
            }
            ////*******************Kullanıcı İşlemleri Ayarları****************//
            this.Text = "YÖNETİCİ İŞLEMLERİ";
            lblAktifKullanici2.ForeColor = Color.DarkRed;
            lblAktifKullanici2.Text = Form1.adi + " " + Form1.soyadi;
            txtTC.MaxLength = 11;
            txtKullaniciAdi.MaxLength = 8;
            toolTip1.SetToolTip(this.txtTC, "Tc kimlik numarası 11 karakter olamlı!"); //mouse ile üzerine gelince bu bilgiyi verecek
            radioBtnYonetici.Checked = true;
            txtAd.CharacterCasing = CharacterCasing.Upper;
            txtSoyad.CharacterCasing = CharacterCasing.Upper;
            txtParola.MaxLength = 10;
            txtParolaTekrar.MaxLength = 10;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
           
            kullanicilariGoster();
            ////*********Personel İşlemleri Ayarları*********//
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Width = 100;
            pictureBox2.Height = 100;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;

            maskedTextBoxTC_P.Mask = "00000000000"; //0 zorunlu rakam girişi demektir. Buraya 11 haneli sayı girilmesini zorunlu kılmış olduk.
            maskedTextBoxAd_P.Mask = "LL??????????????????????"; // 22 haneli isim girilebilir dedik. 2 tane kesin harf olmalı dedik.
            maskedTextBoxSoyad_P.Mask= "LL??????????????????????";
            maskedTextBoxMaas_P.Mask = "0000";// zorunlu 4 haneli sayı girilmeli dedik.
            maskedTextBoxMaas_P.Text = "0";
            maskedTextBoxAd_P.Text.ToUpper();
            maskedTextBoxSoyad_P.Text.ToUpper();

            comboBoxMezuniyet_P.Items.Add("İlköğretim");
            comboBoxMezuniyet_P.Items.Add("Ortaöğretim");
            comboBoxMezuniyet_P.Items.Add("Lise");
            comboBoxMezuniyet_P.Items.Add("Üniversite");

            comboBoxGorevi_P7.Items.Add("Yönetici");
            comboBoxGorevi_P7.Items.Add("Memur");
            comboBoxGorevi_P7.Items.Add("Şoför");
            comboBoxGorevi_P7.Items.Add("İşçi");

            comboBoxGorevYeri_P.Items.Add("Arge");
            comboBoxGorevYeri_P.Items.Add("Bilgi İşlem");
            comboBoxGorevYeri_P.Items.Add("Muhasebe");
            comboBoxGorevYeri_P.Items.Add("Üretim");
            comboBoxGorevYeri_P.Items.Add("Paketleme");
            comboBoxGorevYeri_P.Items.Add("Nakliye");

            DateTime zaman = DateTime.Now;
            int yil = int.Parse(zaman.ToString("yyyy"));// şuanki tarihin "yil"ini aldık.
            int ay = int.Parse(zaman.ToString("MM")); //ay
            int gun = int.Parse(zaman.ToString("dd"));//gün
            dateTimePicker1.MinDate = new DateTime(1960, 1, 1); //çalışanımız 50 yaş üstü olamsın
            dateTimePicker1.MaxDate = new DateTime(yil - 18, ay, gun); //18 yaşından küçükler çalışamaz.
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            radioBtnBay_P.Checked = true;
            personelleriGoster();
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text.Length < 11)
            {
                errorProvider1.SetError(txtTC, "TC kimlik numarası 11 haneli olmalı!");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)//klavyeden her tuşa basıldığında çalışcak
            //harf karakterini vs engelleyeceğim. Tc bölümüne sadece rakam girilmesini istiyorum.
        {
            if(((int)e.KeyChar>=48 && (int)e.KeyChar <= 57) ||(int)e.KeyChar==8)//asci table 48-57 arası rakamlar. 8: backspace tuşu

            {
                e.Handled = false; //if koşulundaki tuşların basılmasına izin veriyoruz
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar)==true || char.IsControl(e.KeyChar)==true || char.IsSeparator(e.KeyChar) == true)
            { //harfler,boşul tuşu ve backspace tuşu aktif. Geri kalanları engelledim.
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
            { //harfler,boşul tuşu ve backspace tuşu aktif. Geri kalanları engelledim.
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text.Length != 8)
            {
                errorProvider1.SetError(txtKullaniciAdi, "Kullanıcı Adı 8 karakter olmalı!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar)==true || char.IsControl(e.KeyChar)==true || char.IsDigit(e.KeyChar) == true)
            { //harf, rakam ve backspace'e izin verdik
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        int parolaSkoru = 0;
        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            string parolaSeviyesi = "";
            int kucukHarfSkoru = 0, buyukHarfSkoru = 0, rakamSkoru = 0, sembolSkoru = 0;
            string sifre = txtParola.Text;
            //*************Regex kütüphanesi ingilizce karakterleri kullanır. Türkçe karakterleri ingilizce karakterlere değişeceğiz*****//
            string düzeltilmisSifre = "";
            düzeltilmisSifre = sifre;
            düzeltilmisSifre = düzeltilmisSifre.Replace('İ', 'I');
            düzeltilmisSifre = düzeltilmisSifre.Replace('ı', 'i');
            düzeltilmisSifre = düzeltilmisSifre.Replace('Ç', 'C');
            düzeltilmisSifre = düzeltilmisSifre.Replace('ç', 'c');
            düzeltilmisSifre = düzeltilmisSifre.Replace('Ş', 'S');
            düzeltilmisSifre = düzeltilmisSifre.Replace('ş', 's');
            düzeltilmisSifre = düzeltilmisSifre.Replace('Ğ', 'G');
            düzeltilmisSifre = düzeltilmisSifre.Replace('ğ', 'g');
            düzeltilmisSifre = düzeltilmisSifre.Replace('Ü', 'U');
            düzeltilmisSifre = düzeltilmisSifre.Replace('ü', 'u');
            düzeltilmisSifre = düzeltilmisSifre.Replace('Ö', 'O');
            düzeltilmisSifre = düzeltilmisSifre.Replace('ö', 'o');

            if (sifre != düzeltilmisSifre)
            {
                sifre = düzeltilmisSifre;
                txtParola.Text = sifre;
                MessageBox.Show("Paroladaki türkçe karakter İngilizce karakterlere dönüştürülmüştür.");
            }
            //1 küçük harf 10 puan, 2 ve üzeri 20 puan olacak.
            int azKarakterSayisi = sifre.Length - Regex.Replace(sifre, "[a-z]", "").Length; //Şifrenin tamamından, "küçük harf içermeyenleri" çıkardık. Böylece küçük harf sayısını elde ettik.
            kucukHarfSkoru = Math.Min(2, azKarakterSayisi) * 10;//2 mi daha küçük, yoksa küçük harf sayısı mı daha küçük
                                                                //hangisi daha küçükse onu 10 puan ile çarpıyoruz.

            //1 büyük harf 10 puan, 2 ve üzeri 20 puan olacak.
            int AZKarakterSayisi = sifre.Length - Regex.Replace(sifre, "[A-Z]", "").Length; //Şifrenin tamamından, "büyük harf içermeyenleri" çıkardık. Böylece büyük harf sayısını elde ettik.
            buyukHarfSkoru = Math.Min(2, AZKarakterSayisi) * 10;//2 mi daha küçük, yoksa büyük harf sayısı mı daha küçük
                                                                //hangisi daha küçükse onu 10 puan ile çarpıyoruz.

            //1 rakam  10 puan, 2 ve üzeri 20 puan olacak.
            int rakamSayisi = sifre.Length - Regex.Replace(sifre, "[0-9]", "").Length; //Şifrenin tamamından, "rakam içermeyenleri" çıkardık. Böylece rakam sayısını elde ettik.
            rakamSkoru = Math.Min(2, rakamSayisi) * 10;//2 mi daha küçük, yoksa rakam sayısı mı daha küçük
                                                       //hangisi daha küçükse onu 10 puan ile çarpıyoruz.

            //1 sembol 10 puan, 2 ve üzeri 20 puan olacak.
            int sembolSayisi = sifre.Length - (azKarakterSayisi + AZKarakterSayisi + rakamSayisi); //Şifrenin tamamından, "küçük harf sayısını,büyük harf sayısını ve rakam sayısını" çıkardık. Böylece sembol sayısını elde ettik.
            sembolSkoru = Math.Min(2, sembolSayisi) * 10;//2 mi daha küçük, yoksa sembol sayısı mı daha küçük
            //hangisi daha küçükse onu 10 puan ile çarpıyoruz.

            parolaSkoru = kucukHarfSkoru + buyukHarfSkoru + rakamSkoru + sembolSkoru;
            if (sifre.Length == 9)
            {
                parolaSkoru = parolaSkoru + 10;
            }
            else if(sifre.Length==10){
                parolaSkoru = parolaSkoru + 20;
            }
            if (kucukHarfSkoru == 0 || buyukHarfSkoru == 0 || rakamSkoru == 0 || sembolSkoru == 0)
            {
                lblParolaKriteri2.Text = "Büyük harf,küçük harf, rakam ve sembol kullanmalısınız!.";
            }
            if(kucukHarfSkoru!=0 && buyukHarfSkoru!=0 && rakamSkoru!=0 && sembolSkoru != 0)
            {
                lblParolaKriteri2.Text = "";
            }
            if (parolaSkoru < 70)
            {
                parolaSeviyesi = "Kabul edilemez!";
            }
            else if(parolaSkoru==70 || parolaSkoru == 80)
            {
                parolaSeviyesi = "Güçlü";
            }
            else if (parolaSkoru == 90 || parolaSkoru == 100)
            {
                parolaSeviyesi = "Çok güçlü";
            }
            lblSkor.Text = "%" + parolaSkoru.ToString();
            lblSeviye.Text = parolaSeviyesi;
            progressBar1.Value = parolaSkoru;

        }

        private void txtParolaTekrar_TextChanged(object sender, EventArgs e)
        {
            if (txtParolaTekrar.Text != txtParola.Text)
            {
                errorProvider1.SetError(txtParolaTekrar, "Parola tekrarı eşleşmiyor.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void topPage1Temizle()//Kullanıcı işlemlerini temizleme metodumuz
        {
            txtTC.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtKullaniciAdi.Clear();
            txtParola.Clear();
            txtParolaTekrar.Clear();
        }
        private void topPage2Temizle() //Personel İşlemlerini temizleme metodumuz
        {
            pictureBox2.Image = null;
            maskedTextBoxTC_P.Clear();
            maskedTextBoxAd_P.Clear();
            maskedTextBoxSoyad_P.Clear();
            maskedTextBoxMaas_P.Clear();
            comboBoxMezuniyet_P.SelectedIndex = -1;
            comboBoxGorevi_P7.SelectedIndex = -1;
            comboBoxGorevYeri_P.SelectedIndex = -1;


        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string yetki = "";
            bool kayitKontrol = false;//başlangıç olarak kaydımız yok kabul edip "false" dedik
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Table_Kullanicilar where TcNo='"+txtTC.Text+"'",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                kayitKontrol = true;
                break;
            }
            baglanti.Close();

            if (kayitKontrol == false) //girilen TcNo veritabanımızda yoksa
            {
                //TC kimlik No kontrolü
                if(txtTC.Text.Length<11 || txtTC.Text== "")
                {
                    lblTC.ForeColor = Color.Red;
                }
                else
                {
                    lblTC.ForeColor = Color.Black;
                }
                //Ad kontolü
                if (txtAd.Text.Length < 2 || txtAd.Text == "")
                {
                    lblAd.ForeColor = Color.Red;
                }
                else
                {
                    lblAd.ForeColor = Color.Black;
                }
                //Soyad kontolü
                if (txtSoyad.Text.Length < 2 || txtSoyad.Text == "")
                {
                    lblSoyad.ForeColor = Color.Red;
                }
                else
                {
                    lblSoyad.ForeColor = Color.Black;
                }
                //KullanıcıAdı kontolü
                if (txtKullaniciAdi.Text.Length !=8 || txtKullaniciAdi.Text == "")
                {
                    lblKullaniciAdi.ForeColor = Color.Red;
                }
                else
                {
                    lblKullaniciAdi.ForeColor = Color.Black;
                }
                //Parola kontolü
                if (txtParola.Text=="" || parolaSkoru<70)
                {
                    lblParola.ForeColor = Color.Red;
                }
                else
                {
                    lblParola.ForeColor = Color.Black;
                }
                //ParolaTekrar kontolü
                if (txtParolaTekrar.Text == "" ||  txtParola.Text != txtParolaTekrar.Text)
                {
                    lblParolaTekrar.ForeColor = Color.Red;
                }
                else
                {
                    lblParolaTekrar.ForeColor = Color.Black;
                }

                //*******Hiçbir hata yoksa kayıt edilmesini istiyorum. Kontrolleri yazmaya devam*****//
                if(txtTC.Text.Length==11 && txtTC.Text != "" && txtAd.Text != "" && txtAd.Text.Length>1
                    && txtSoyad.Text != "" && txtSoyad.Text.Length>1 && txtKullaniciAdi.Text != "" &&
                    txtParola.Text != "" && txtParolaTekrar.Text != "" && txtParola.Text==txtParolaTekrar.Text 
                    && parolaSkoru > 70)
                {
                    if (radioBtnYonetici.Checked == true)
                    {
                        yetki = "Yönetici";
                    }
                    else if (radioBtnKullanici.Checked == true)
                    {
                        yetki = "Kullanıcı";
                    }
                    try
                    {
                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("insert into Table_Kullanicilar values ('"+txtTC.Text+ "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + yetki + "','" + txtKullaniciAdi.Text +
                            "','" + txtParola.Text +"')",baglanti);
                        komut2.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kullanıcı kaydı başarıyla oluşturuldu.","Personel Takip Programı",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        topPage1Temizle();
                        
                    }
                    catch (Exception e2)
                    {

                        MessageBox.Show(e2.Message);
                        baglanti.Close();
                    }
                }
                else //eğer bir şeyler yanlış gidiyorsa 
                {
                    MessageBox.Show("Yazı rengi kırmızı olanları yeniden gözden geçiriniz", "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                

            }
            else //Aynı kayıt var mı, varsa uyarı mesajı gönderdik.
            {
                MessageBox.Show("Girilen TC kimlik numarası kayıtlıdır.", "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bool kayitAramaDurumu = false;//başlangıçta böyle bir kayıt yok kabul ettik
            if (txtTC.Text.Length == 11)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from TAble_Kullanicilar where TcNo='"+
                    txtTC.Text+"'",baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    kayitAramaDurumu = true; //kayıt bulunduğu için "true" dedik
                    txtAd.Text = oku.GetValue(1).ToString(); //veritabanındaki "Ad" bölmesini "txtAd"a yazdırdık
                    txtSoyad.Text = oku.GetValue(2).ToString();
                    if (oku.GetValue(3).ToString() == "Yönetici")
                    {
                        radioBtnYonetici.Checked = true;
                    }
                    else
                    {
                        radioBtnKullanici.Checked = true;
                    }
                    txtKullaniciAdi.Text = oku.GetValue(4).ToString();
                    txtParola.Text = oku.GetValue(5).ToString();
                    txtParolaTekrar.Text = oku.GetValue(5).ToString();
                    break;
                }
                if (kayitAramaDurumu == false)
                {
                    MessageBox.Show("Aranan kayıt bulunamadı!", "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen 11 haneli TC kimlik numarası giriniz!", "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                topPage1Temizle();
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string yetki = "";
          
                //TC kimlik No kontrolü
                if (txtTC.Text.Length < 11 || txtTC.Text == "")
                {
                    lblTC.ForeColor = Color.Red;
                }
                else
                {
                    lblTC.ForeColor = Color.Black;
                }
                //Ad kontolü
                if (txtAd.Text.Length < 2 || txtAd.Text == "")
                {
                    lblAd.ForeColor = Color.Red;
                }
                else
                {
                    lblAd.ForeColor = Color.Black;
                }
                //Soyad kontolü
                if (txtSoyad.Text.Length < 2 || txtSoyad.Text == "")
                {
                    lblSoyad.ForeColor = Color.Red;
                }
                else
                {
                    lblSoyad.ForeColor = Color.Black;
                }
                //KullanıcıAdı kontolü
                if (txtKullaniciAdi.Text.Length != 8 || txtKullaniciAdi.Text == "")
                {
                    lblKullaniciAdi.ForeColor = Color.Red;
                }
                else
                {
                    lblKullaniciAdi.ForeColor = Color.Black;
                }
                //Parola kontolü
                if (txtParola.Text == "" || parolaSkoru < 70)
                {
                    lblParola.ForeColor = Color.Red;
                }
                else
                {
                    lblParola.ForeColor = Color.Black;
                }
                //ParolaTekrar kontolü
                if (txtParolaTekrar.Text == "" || txtParola.Text != txtParolaTekrar.Text)
                {
                    lblParolaTekrar.ForeColor = Color.Red;
                }
                else
                {
                    lblParolaTekrar.ForeColor = Color.Black;
                }

                //*******Hiçbir hata yoksa kayıt edilmesini istiyorum. Kontrolleri yazmaya devam*****//
                if (txtTC.Text.Length == 11 && txtTC.Text != "" && txtAd.Text != "" && txtAd.Text.Length > 1
                    && txtSoyad.Text != "" && txtSoyad.Text.Length > 1 && txtKullaniciAdi.Text != "" &&
                    txtParola.Text != "" && txtParolaTekrar.Text != "" && txtParola.Text == txtParolaTekrar.Text
                    && parolaSkoru > 70)
                {
                    if (radioBtnYonetici.Checked == true)
                    {
                        yetki = "Yönetici";
                    }
                    else if (radioBtnKullanici.Checked == true)
                    {
                        yetki = "Kullanıcı";
                    }
                    try
                    {
                        baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update Table_Kullanicilar set Ad='" + txtAd.Text + "',Soyad='" + txtSoyad.Text + "',Yetki='" + yetki + "',KullaniciAdi='" + txtKullaniciAdi.Text + "',Parola='" + txtParola.Text + "' where TcNo='"+txtTC.Text+"'", baglanti);
                        komut3.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kullanıcı kaydı başarıyla güncellendi..", "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    // topPage1Temizle();
                    kullanicilariGoster();

                    }
                    catch (Exception e2)
                    {

                        MessageBox.Show(e2.Message,"Personel Takip Programı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        baglanti.Close();
                    }
                }
                else //eğer bir şeyler yanlış gidiyorsa 
                {
                    MessageBox.Show("Yazı rengi kırmızı olanları yeniden gözden geçiriniz", "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtTC.Text.Length == 11)
            {
                bool kayitAramaDurumu = false;//başlangıçta "false" olsun
                baglanti.Open();
                 SqlCommand komut4 = new SqlCommand("select * from Table_Kullanicilar where TcNo='"+txtTC.Text+"'",baglanti);
                //öncelikle girilen tc kimlik numarası var mı onu kontrol edelim.
                SqlDataReader oku = komut4.ExecuteReader();
                string tc;
                while (oku.Read())
                {
                    kayitAramaDurumu = true; //kayıt okunuyorsa "true" deriz
                    tc = oku["TcNo"].ToString();
                    if (txtTC.Text == tc)
                    {
                        baglanti.Close();
                        baglanti.Open();
                        SqlCommand komut5 = new SqlCommand("delete from Table_Kullanicilar where TcNo='" + txtTC.Text + "'", baglanti);
                        komut5.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı kaydı silindi!", "PErsonel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        baglanti.Close();
                    }
                    baglanti.Close();
                    break;
                }
                baglanti.Close();


                kullanicilariGoster();
                topPage1Temizle();
               // //while çalışmadıysa
              //  
                    MessageBox.Show("Silinecek kayıt bulunamadı!", "PErsonel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  
                 
                

            }
            else
            {
                MessageBox.Show("Lütfen 11 karakterden oluşan TC kimlik Numarası giriniz!", "PErsonel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            topPage1Temizle();
        }

        private void btnGozat_P_Click(object sender, EventArgs e)
        {
            OpenFileDialog resimSec = new OpenFileDialog();
            resimSec.Title = "Personel resmi seçiniz";
            resimSec.Filter = "JPG Dosyalar (*.jpg) | *.jpg"; //sadece .jpg uzantılı dosyaları göreceğiz
            if (resimSec.ShowDialog()==DialogResult.OK)
            {
                this.pictureBox2.Image = new Bitmap(resimSec.OpenFile());

            }
        }

        private void btnKaydet_P_Click(object sender, EventArgs e)
        {
            //maskedtesxbox kullanıcının bizim istediğimiz veriyi girmesi için kullanırız.
            string cinsiyet = "";
            bool kayitKontrol = false; //veritabanında var mı kontrolü için
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Table_Personeller where TcNo='" + maskedTextBoxTC_P.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read()) //kaydedilmiş personel var mı ona baktık
            {
                kayitKontrol = true;
                break;
            }
            baglanti.Close();
            if (kayitKontrol == false)//girdiğimiz tcNo ile ilgili personel kaydı yoksa
            {
                if (pictureBox2.Image == null)
                {
                    btnGozat_P.ForeColor = Color.Red;
                }
                else
                {
                    btnGozat_P.ForeColor = Color.Black;
                }
                if (maskedTextBoxTC_P.MaskCompleted == false)//From load'da tanımladığımız "Mask" kuralına uyulmadıysa demektir.
                {
                    lblTC_P.ForeColor = Color.Red;
                }
                else
                {
                    lblTC_P.ForeColor = Color.Black;
                }
                if (maskedTextBoxAd_P.MaskCompleted == false)//From load'da tanımladığımız "Mask" kuralına uyulmadıysa demektir.
                {
                    lblAdi_P.ForeColor = Color.Red;
                }
                else
                {
                    lblAdi_P.ForeColor = Color.Black;
                }
                if (maskedTextBoxSoyad_P.MaskCompleted == false)//From load'da tanımladığımız "Mask" kuralına uyulmadıysa demektir.
                {
                    lblSoyad_P.ForeColor = Color.Red;
                }
                else
                {
                    lblSoyad_P.ForeColor = Color.Black;
                }
                if (comboBoxMezuniyet_P.Text == "")
                {
                    lblMezuniyet_P.ForeColor = Color.Red;
                }
                else
                {
                    lblMezuniyet_P.ForeColor = Color.Black;
                }
                if (comboBoxGorevi_P7.Text == "")
                {
                    lblGorevi_P.ForeColor = Color.Red;
                }
                else
                {
                    lblGorevi_P.ForeColor = Color.Black;
                }
                if (comboBoxGorevYeri_P.Text == "")
                {
                    lblGorevYeri_P.ForeColor = Color.Red;
                }
                else
                {
                    lblGorevYeri_P.ForeColor = Color.Black;
                }
                if (maskedTextBoxMaas_P.MaskCompleted == false)//From load'da tanımladığımız "Mask" kuralına uyulmadıysa demektir.
                {
                    lblMaas_P.ForeColor = Color.Red;
                }
                else
                {
                    lblMaas_P.ForeColor = Color.Black;
                }
                if (int.Parse(maskedTextBoxMaas_P.Text) < 1000)
                {
                    lblMaas_P.ForeColor = Color.Red;
                }
                else
                {
                    lblMaas_P.ForeColor = Color.Black;
                }
                if (pictureBox2.Image != null && maskedTextBoxTC_P.MaskCompleted!=false && maskedTextBoxAd_P.MaskCompleted!=false
                    && maskedTextBoxSoyad_P.MaskCompleted!=false && comboBoxMezuniyet_P.Text!="" &&
                    comboBoxGorevi_P7.Text!=""&& comboBoxGorevYeri_P.Text!=""&& maskedTextBoxMaas_P.MaskCompleted != false)
                {
                    if(radioBtnBay_P.Checked==true)
                    {
                        cinsiyet = "Bay";
                    }
                    else if(radioBtnBayan.Checked==true)
                    {
                        cinsiyet = "Bayan";
                    }
                    try
                    {
                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("insert into Table_Personeller values ('" + maskedTextBoxTC_P.Text + "','" + maskedTextBoxAd_P.Text + "','" + maskedTextBoxSoyad_P.Text + "','" + cinsiyet + "','" +
                            comboBoxMezuniyet_P.Text + "','"+dateTimePicker1.Text+"','" + comboBoxGorevi_P7.Text + "','" + comboBoxGorevYeri_P.Text + "','" + maskedTextBoxMaas_P.Text + "')", baglanti);
                        komut2.ExecuteNonQuery();
                        baglanti.Close();

                        if (!Directory.Exists(Application.StartupPath + "\\personelResim"))//Debug'da "personelResim" klasörü yoksa oluşturmak için
                        {
                            //Application.StartupPath: bin klasörü içerindeki "Debug" klasörünü ifade eder.
                            Directory.CreateDirectory(Application.StartupPath + "\\personelResim");
                        }
                        //"personelResim" klasrü var ise kullancağımız resmin bir kopyasını bu dosyamızda tutalım
                        
                        pictureBox2.Image.Save(Application.StartupPath + "\\personelResim\\" + maskedTextBoxTC_P.Text+".jpg");//resmi tcNo ile ismi vererek kaydettik
                             
                        
                        MessageBox.Show("Yeni personel kaydı oluşturuldu.", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        personelleriGoster();
                        topPage2Temizle();
                        maskedTextBoxMaas_P.Text = "0";
                    }
                    catch (Exception eee)
                    {

                        MessageBox.Show(eee.Message,"Personel Takip Sistemi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        baglanti.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Yazı rengi kırmızı olan alanları yeniden gözden geçiriniz!.", "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Girilen TC Kimlik Numarası kayıtlıdır!.", "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAra_P_Click(object sender, EventArgs e)
        {
            bool kayitAramaDurumu = false;
            if (maskedTextBoxTC_P.Text.Length == 11)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Table_Personeller where TcNo='"+maskedTextBoxTC_P.Text+"'",baglanti);
                SqlDataReader oku = komut.ExecuteReader();//RAmde oluşturan alana, sorgumdan gelenleri yazdırdım
                while (oku.Read()) //oku.Read()==true
                {
                    kayitAramaDurumu = true;//kayıt var tur yaptık
                    try
                    {
                        pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\personelResim\\" + oku.GetValue(0).ToString() + ".jpg");
                        //bulunan kaydın getValue(0) yani 0. alanı(TcNo) sunu al, stringe dönüştür.

                    }
                    catch //resim yoksa default olarak resim koyacağız.
                    {
                        pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\personelResim\\defaultResim.jpg");

                    }
                    maskedTextBoxAd_P.Text = oku.GetValue(1).ToString();
                    maskedTextBoxSoyad_P.Text = oku.GetValue(2).ToString();
                    if (oku.GetValue(3).ToString() == "Bay")
                    {
                        radioBtnBay_P.Checked = true;
                    }
                    else
                    {
                        radioBtnBayan.Checked = true;
                    }
                    comboBoxMezuniyet_P.Text = oku.GetValue(4).ToString();
                    dateTimePicker1.Text = oku.GetValue(5).ToString();
                    comboBoxGorevi_P7.Text = oku.GetValue(6).ToString();
                    comboBoxGorevYeri_P.Text = oku.GetValue(7).ToString();
                    maskedTextBoxMaas_P.Text = oku.GetValue(8).ToString();
                    baglanti.Close();
                    break;

                }
                if (kayitAramaDurumu == false)
                {
                    MessageBox.Show("Aranan kayıt bulunamadı", "Personel takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("11 Haneli TC no giriniz.", "Personel takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //topPage1Temizle();
            }
        }

        private void btnGuncelle_P_Click(object sender, EventArgs e)
        {
            string cinsiyet = "";
           
                if (pictureBox2.Image == null)
                {
                    btnGozat_P.ForeColor = Color.Red;
                }
                else
                {
                    btnGozat_P.ForeColor = Color.Black;
                }
                if (maskedTextBoxTC_P.MaskCompleted == false)//From load'da tanımladığımız "Mask" kuralına uyulmadıysa demektir.
                {
                    lblTC_P.ForeColor = Color.Red;
                }
                else
                {
                    lblTC_P.ForeColor = Color.Black;
                }
                if (maskedTextBoxAd_P.MaskCompleted == false)//From load'da tanımladığımız "Mask" kuralına uyulmadıysa demektir.
                {
                    lblAdi_P.ForeColor = Color.Red;
                }
                else
                {
                    lblAdi_P.ForeColor = Color.Black;
                }
                if (maskedTextBoxSoyad_P.MaskCompleted == false)//From load'da tanımladığımız "Mask" kuralına uyulmadıysa demektir.
                {
                    lblSoyad_P.ForeColor = Color.Red;
                }
                else
                {
                    lblSoyad_P.ForeColor = Color.Black;
                }
                if (comboBoxMezuniyet_P.Text == "")
                {
                    lblMezuniyet_P.ForeColor = Color.Red;
                }
                else
                {
                    lblMezuniyet_P.ForeColor = Color.Black;
                }
                if (comboBoxGorevi_P7.Text == "")
                {
                    lblGorevi_P.ForeColor = Color.Red;
                }
                else
                {
                    lblGorevi_P.ForeColor = Color.Black;
                }
                if (comboBoxGorevYeri_P.Text == "")
                {
                    lblGorevYeri_P.ForeColor = Color.Red;
                }
                else
                {
                    lblGorevYeri_P.ForeColor = Color.Black;
                }
                if (maskedTextBoxMaas_P.MaskCompleted == false)//From load'da tanımladığımız "Mask" kuralına uyulmadıysa demektir.
                {
                    lblMaas_P.ForeColor = Color.Red;
                }
                else
                {
                    lblMaas_P.ForeColor = Color.Black;
                }
                if (int.Parse(maskedTextBoxMaas_P.Text) < 1000)
                {
                    lblMaas_P.ForeColor = Color.Red;
                }
                else
                {
                    lblMaas_P.ForeColor = Color.Black;
                }
                if (pictureBox2.Image != null && maskedTextBoxTC_P.MaskCompleted != false && maskedTextBoxAd_P.MaskCompleted != false
                    && maskedTextBoxSoyad_P.MaskCompleted != false && comboBoxMezuniyet_P.Text != "" &&
                    comboBoxGorevi_P7.Text != "" && comboBoxGorevYeri_P.Text != "" && maskedTextBoxMaas_P.MaskCompleted != false)
                {
                    if (radioBtnBay_P.Checked == true)
                    {
                        cinsiyet = "Bay";
                    }
                    else if (radioBtnBayan.Checked == true)
                    {
                        cinsiyet = "Bayan";
                    }
                    try
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("update Table_Personeller set Ad='" + maskedTextBoxAd_P.Text + "', Soyad='" + maskedTextBoxSoyad_P.Text + "',Cinsiyet='" + cinsiyet + "',Mezuniyet='" +
                            comboBoxMezuniyet_P.Text + "',DogumTarihi='" + dateTimePicker1.Text + "',Gorev='" + comboBoxGorevi_P7.Text + "',GorevYeri='" + comboBoxGorevYeri_P.Text + "',Maas='" + maskedTextBoxMaas_P.Text + "'where TcNo='"+maskedTextBoxTC_P.Text+"'", baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        personelleriGoster();
                        topPage2Temizle();
                        maskedTextBoxMaas_P.Text = "0";
                    }
                    catch (Exception eee)
                    {

                        MessageBox.Show(eee.Message, "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        baglanti.Close();
                    }
                }
               

            
           
        }

        private void btnSil_P_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxTC_P.MaskCompleted == true)
            {
                bool kayitAramaDurumu = false;//kayıt yok diye farzedelim
                string tc;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Table_Personeller where TcNo='"+maskedTextBoxTC_P.Text+"'",baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    kayitAramaDurumu = true;//kayıt var
                    tc = oku["TcNo"].ToString();

                    if (tc == maskedTextBoxTC_P.Text)
                    {
                        baglanti.Close();
                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("delete from Table_Personeller where TcNo='" + maskedTextBoxTC_P.Text + "'", baglanti);
                        komut2.ExecuteNonQuery();
                        baglanti.Close();
                    }
                     
                    break;

                }
                if (kayitAramaDurumu == false)
                {
                    MessageBox.Show("Silinecek kayıt bulunamadı", "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
                personelleriGoster();

                topPage2Temizle();
                maskedTextBoxMaas_P.Text = "0";
            }
            else
            {
                MessageBox.Show("TC no 11 haneli olmalı", "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                topPage2Temizle();
                maskedTextBoxMaas_P.Text = "0";
            }
        }

        private void btnTemizle_P_Click(object sender, EventArgs e)
        {
            topPage2Temizle();
        }
    }
}
