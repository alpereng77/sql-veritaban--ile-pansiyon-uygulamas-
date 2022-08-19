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

namespace gundogdupansiyon
{
    public partial class YeniMusteri : Form
    {
        public YeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-C52QN13;Initial Catalog=GundogduPansiyon;Integrated Security=True");
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
                    }

        private void button5_Click(object sender, EventArgs e)
        {
            txtOda.Text = "104";
            baglanti.Open();
            SqlCommand komut=new SqlCommand("insert into Oda104 (adi,soyadi) values('"+txtAd.Text+"','"+txtSoyad.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOda.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101 (adi,soyadi) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOda.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102 (adi,soyadi) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOda.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103 (adi,soyadi) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOda.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105 (adi,soyadi) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOda.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106 (adi,soyadi) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOda.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107 (adi,soyadi) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOda.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108 (adi,soyadi) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOda.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109 (adi,soyadi) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MüsteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + txtAd.Text + "','" + txtSoyad.Text +"','" + comboBox1.Text + "','"+txtTel.Text+"','"+txtMail.Text+"','"+txtTc.Text+"','"+txtOda.Text+"','"+textBox1.Text+"','"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"','"+dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Yapıldı");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dateTimePicker2.Text);

            TimeSpan sonuc;
            sonuc =BuyukTarih - KucukTarih;
            label11.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text)*50;
            textBox1.Text = ucret.ToString();
     


        }

        private void YeniMusteri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select *From Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                btnOda101.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda101.Text != "101")
            {
                btnOda101.BackColor = Color.Red;
                btnOda101.Enabled = false;
            }






            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select *From Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btnOda102.Text = oku2["adi"].ToString() + " " + oku2["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda102.Text != "102")
            {
                btnOda102.BackColor = Color.Red;
                btnOda102.Enabled = false;
            }








            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select *From Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btnOda103.Text = oku3["adi"].ToString() + " " + oku3["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda103.Text != "103")
            {
                btnOda103.BackColor = Color.Red;
                btnOda103.Enabled = false;
            }





            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select *From Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btnOda104.Text = oku4["adi"].ToString() + " " + oku4["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda104.Text != "104")
            {
                btnOda104.BackColor = Color.Red;
                btnOda104.Enabled = false;
            }




            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select *From Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btnOda105.Text = oku5["adi"].ToString() + " " + oku5["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda105.Text != "105")
            {
                btnOda105.BackColor = Color.Red;
                btnOda105.Enabled = false;
            }




            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select *From Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btnOda106.Text = oku6["adi"].ToString() + " " + oku6["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda106.Text != "106")
            {
                btnOda106.BackColor = Color.Red;
                btnOda106.Enabled = false;
            }





            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select *From Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                btnOda107.Text = oku7["adi"].ToString() + " " + oku7["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda107.Text != "107")
            {
                btnOda107.BackColor = Color.Red;
                btnOda107.Enabled = false;
            }



            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select *From Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btnOda108.Text = oku8["adi"].ToString() + " " + oku8["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda108.Text != "108")
            {
                btnOda108.BackColor = Color.Red;
                btnOda108.Enabled = false;
            }




            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select *From Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                btnOda109.Text = oku9["adi"].ToString() + " " + oku9["soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda109.Text != "109")
            {
                btnOda109.BackColor = Color.Red;
                btnOda109.Enabled = false;
            }
        }
    }
}
//Data Source=DESKTOP-C52QN13;Initial Catalog=GundogduPansiyon;Integrated Security=True