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

namespace PersonelTakip
{
    public partial class FormKullanici : Form
    {
        public FormKullanici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CVANAKGUL;Initial Catalog=PersonelTakip;Integrated Security=True");

        private void personelleriGoster()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter komut = new SqlDataAdapter("select TcNo AS[TC KİMLİK NO], Ad AS[ADI], Soyad[SOYADI], Cinsiyet AS[CİNSİYETİ]" +
                    ", Mezuniyet AS[MEZUNİYETİ], DogumTarihi AS[DOĞUM TARİHİ], Gorev AS[GÖREVİ], GorevYeri AS[GÖREV YERİ]" +
                    ",Maas AS[MAAŞI] from Table_Personeller Order By Ad ASC", baglanti);
                DataSet hafiza = new DataSet();
                komut.Fill(hafiza);
                dataGridView1.DataSource = hafiza.Tables[0];
                baglanti.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }
        private void FormKullanici_Load(object sender, EventArgs e)
        {
            personelleriGoster();
            this.Text = "KULLANICI İŞLEMLERİ";
            lblAktifKullanici2.Text = Form1.adi + " " +Form1.soyadi;
            pictureBox1.Height = 150;
            pictureBox1.Width = 150;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Height = 150;
            pictureBox2.Width = 150;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\kullaniciResim\\" + Form1.tcno + ".jpg");
            }
            catch 
            {
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\kullaniciResim\\defaultResim.jpg");


            }
            maskedTextBoxTC_K.Mask = "00000000000";

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bool kayiAramaDurumu = false;
            if (maskedTextBoxTC_K.Text.Length == 11)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Table_Personeller where TcNo='" + maskedTextBoxTC_K.Text + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    kayiAramaDurumu = true;
                    try
                    {
                        pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\personelResim\\" + oku.GetValue(0) + ".jpg");

                    }
                    catch 
                    {
                        pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\personelResim\\defaultResim.jpg");

                    }
                    lblAd2.Text = oku.GetValue(1).ToString();
                    lblSoyad2.Text = oku.GetValue(2).ToString();

                    if (oku.GetValue(3).ToString() == "Bay")
                    {
                        lblCinsiyet2.Text = "Bay";
                    }
                    else
                    {
                        lblCinsiyet2.Text = "Bayan";
                    }
                    lblMezuniyet2.Text = oku.GetValue(4).ToString();
                    lblDogumTarihi2.Text = oku.GetValue(5).ToString();
                    lblGorev2.Text = oku.GetValue(6).ToString();
                    lblGorevYeri2.Text = oku.GetValue(7).ToString();
                    lblMaas2.Text = oku.GetValue(8).ToString();
                    break;

                }
                if (kayiAramaDurumu == false)
                {
                    MessageBox.Show("Aranan kayıt bulunamadı");
                }
                baglanti.Close();

            }
            else
            {
                MessageBox.Show("11 haneli tc kimlik numarası giriniz.");
            }
        }
    }
}
