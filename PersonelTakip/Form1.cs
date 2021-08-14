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
{//Data Source=CVANAKGUL;Initial Catalog=PersonelTakip;Integrated Security=True
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CVANAKGUL;Initial Catalog=PersonelTakip;Integrated Security=True");

        public static string tcno, adi, soyadi, yetki; //Formlar arası veri aktarımında kullanılacak değişkenler

       

        int hak = 3;
        bool durum = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnGiris; //Enter'a basıldığında "btnGiris" butonu çalışacak.
            this.CancelButton = btnCikis;//ESC'ye basıldığında "btnCikis" butonu çalışacak.
            lblGirisHakki2.Text = hak.ToString();
            radioBtnYonetici.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen; //form ekranın merkezinde gelsin 
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow; // "tam ekran yapma" ve "simge durumunu küçültme" pasif ettim
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            if (hak != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Table_Kullanicilar",baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    if (radioBtnYonetici.Checked == true) //Yönetici girişi
                    {
                        if (oku["KullaniciAdi"].ToString()==txtKullaniciAdi.Text && 
                            oku["Parola"].ToString() == txtParola.Text &&
                            oku["Yetki"].ToString()=="Yönetici")
                        {
                            durum = true;//kullanıcı girişi "Yönetici" olarak başarı olduğu için "true" yaptım.
                            tcno = oku.GetValue(0).ToString(); //"GetValu(0)" 0. alan demektir. Sql'de 0. alanımızda "TcNo" sütunumuz vardır.
                            adi = oku.GetValue(1).ToString();
                            soyadi = oku.GetValue(2).ToString();
                            yetki = oku.GetValue(3).ToString();
                            this.Hide();//bu formumuzu gizledik

                            FormYonetici fr = new FormYonetici();//yönetici formumuzdan nesne oluşturduk. "GetValue" ile çektiklerimizi bu forma aktaracağınız
                            fr.Show(); //Yönetici formumuzu ekrana getirdik
                            break;//isteklerimizi aldığımız için "while döngüsünü" boşa çalıştırmamıza gerek yok.
                        }
                    }
                    if (radioBtnKullanici.Checked == true) //Kullanıcı girişi
                    {
                        if (oku["KullaniciAdi"].ToString() == txtKullaniciAdi.Text &&
                            oku["Parola"].ToString() == txtParola.Text &&
                            oku["Yetki"].ToString() == "Kullanıcı")
                        {
                            durum = true;//kullanıcı girişi "Kullanıcı" olarak başarı olduğu için "true" yaptım.
                            tcno = oku.GetValue(0).ToString(); //"GetValu(0)" 0. alan demektir. Sql'de 0. alanımızda "TcNo" sütunumuz vardır.
                            adi = oku.GetValue(1).ToString();
                            soyadi = oku.GetValue(2).ToString();
                            yetki = oku.GetValue(3).ToString();
                            this.Hide();//bu formumuzu gizledik

                            FormKullanici fr = new FormKullanici();//kullanıcı formumuzdan nesne oluşturduk. "GetValue" ile çektiklerimizi bu forma aktaracağınız
                            fr.Show(); //kullanıcı formumuzu ekrana getirdik
                            break;//isteklerimizi aldığımız için "while döngüsünü" boşa çalıştırmamıza gerek yok.
                        }
                    }
                }


                if (durum == false)
                {
                    hak--;
                }

                baglanti.Close();

            }
            lblGirisHakki2.Text = hak.ToString(); //kalan hakkımızı yazdırdık
            if (hak == 0)
            {
                btnGiris.Enabled = false;
                MessageBox.Show("Giriş hakkı kalmadı!","Personel Takip Programı",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();//formu kapadık
            }
        }
    }
}
