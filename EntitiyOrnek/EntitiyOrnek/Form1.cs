using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EntitiyOrnek
{
    public partial class Form1 : Form
    {
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOgrenciListele_Click(object sender, EventArgs e) //btnOgrenciListele
        {
            dataGridView1.DataSource = db.TBLOGRENCI.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            //EF kullanmadan 
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-CFJ1BO9\MSSQLSERVER1;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
            SqlCommand komut = new SqlCommand("Select * From TBLDERSLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void BtnNotListesi_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLNOTLAR
                        select new
                        {
                            item.NOTID,
                            item.TBLOGRENCI.AD,
                            item.TBLDERSLER.DERSAD,
                            item.SINAV1,
                            item.SINAV2,
                            item.SINAV3,
                            item.ORTALAMA,
                            item.DURUM
                        };
            dataGridView1.DataSource = query.ToList();
            //dataGridView1.DataSource = db.TBLNOTLAR.ToList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.TextLength > 0)
            {
                TBLOGRENCI t = new TBLOGRENCI();
                t.AD = txtAd.Text;
                t.SOYAD = txtSoyad.Text;
                db.TBLOGRENCI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Öğrenci listeye eklenmiştir.");
            }
            if (txtDersAd.TextLength > 0)
            {
                TBLDERSLER d = new TBLDERSLER();
                d.DERSAD = txtDersAd.Text;
                db.TBLDERSLER.Add(d);
                db.SaveChanges();
                MessageBox.Show("Ders adı listeye eklenmiştir.");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var x = Convert.ToInt32(txtOgrenciID.Text);
            var y = db.TBLOGRENCI.Find(x);

            db.TBLOGRENCI.Remove(y);
            db.SaveChanges();
            MessageBox.Show("Öğrenci başarılı bir şekilde silinmiştir.");

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrenciID.Text);
            var x = db.TBLOGRENCI.Find(id);
            x.AD = txtAd.Text;
            x.SOYAD = txtSoyad.Text;
            x.FOTOGRAF = txtFoto.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Bilgileri Başarı ile güncellendi.");
        }

        private void btnProsedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NOTLISTESI();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLOGRENCI.Where(x => x.AD == txtAd.Text | x.SOYAD == txtSoyad.Text).ToList();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAd.Text;
            var degerler = from item in db.TBLOGRENCI
                           where item.AD.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void BtnLinqEntity_Click(object sender, EventArgs e)
        {
            //Ascending
            if (radioButton1.Checked == true)
            {
                List<TBLOGRENCI> liste1 = db.TBLOGRENCI.OrderBy(p => p.AD).ToList();
                dataGridView1.DataSource = liste1;
            }
            //Descending
            if (radioButton2.Checked == true)
            {
                List<TBLOGRENCI> liste2 = db.TBLOGRENCI.OrderByDescending(p => p.AD).ToList();
                dataGridView1.DataSource = liste2;
            }
            //İlk 3 Kayıt
            if (radioButton3.Checked == true)
            {
                List<TBLOGRENCI> liste3 = db.TBLOGRENCI.OrderBy(p => p.AD).Take(3).ToList();
                dataGridView1.DataSource = liste3;
            }
            //ID'ye göre veri getir
            if (radioButton4.Checked == true)
            {
                if (txtOgrenciID.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen Öğrenci ID giriniz.");
                }
                else
                {
                    var id = Convert.ToInt32(txtOgrenciID.Text);
                    List<TBLOGRENCI> liste4 = db.TBLOGRENCI.Where(p => p.ID == id).ToList();
                    dataGridView1.DataSource = liste4;
                }
            }
            //Adı A ile başlayanlar
            if (radioButton5.Checked == true)
            {
                List<TBLOGRENCI> liste5 = db.TBLOGRENCI.Where(p => p.AD.StartsWith("A")).ToList();
                dataGridView1.DataSource = liste5;
            }
            //Adı A ile bitenler
            if (radioButton6.Checked == true)
            {
                List<TBLOGRENCI> liste6 = db.TBLOGRENCI.Where(p => p.AD.EndsWith("A")).ToList();
                dataGridView1.DataSource = liste6;
            }
            //Deger var mı?
            if (radioButton7.Checked == true)
            {
                bool degerler = db.TBLKULUPLER.Any();
                MessageBox.Show(degerler.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Deger var mı?
            if (radioButton8.Checked == true)
            {
                int toplam = db.TBLOGRENCI.Count();
                MessageBox.Show(("Toplam Öğrenci Sayısı: " + toplam.ToString()), "Toplam Öğrenci Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Sınav 1 Toplam puan
            if (radioButton9.Checked == true)
            {
                int? toplam = db.TBLNOTLAR.Sum(p => p.SINAV1);
                MessageBox.Show("Toplam Sınav1: " + toplam);
            }
            if (radioButton10.Checked == true)
            {
                double? ort = db.TBLNOTLAR.Average(p => p.SINAV1);
                MessageBox.Show("Ortalama Sınav1 Puan: " + ort.ToString());
            }
            if (radioButton11.Checked == true)
            {
                var ortalama = db.TBLNOTLAR.Average(p => p.SINAV1);
                var list = (from item in db.TBLNOTLAR
                            where item.SINAV1 > ortalama & item.TBLDERSLER.DERSID == 1
                            select new
                            {
                                item.NOTID,
                                OGRENCI = item.TBLOGRENCI.AD + " " + item.TBLOGRENCI.SOYAD,
                                item.TBLDERSLER.DERSAD,
                                item.SINAV1,
                                item.SINAV2,
                                item.SINAV3,
                                item.ORTALAMA,
                                item.DURUM
                            });
                dataGridView1.DataSource = list.ToList();
            }
            if (radioButton12.Checked == true)
            {
                var enYuksek = db.TBLNOTLAR.Max(p => p.SINAV1);
                var list = (from x in db.TBLNOTLAR
                            where x.SINAV1 == enYuksek
                            select new
                            {
                                x.NOTID,
                                x.SINAV1,
                                x.TBLDERSLER.DERSAD,
                                OGRENCI = x.TBLOGRENCI.AD + " " + x.TBLOGRENCI.SOYAD
                            });
                dataGridView1.DataSource = list.ToList();
                //2.Yol prosedür ile
                //dataGridView1.DataSource = db.NOTLISTESI().Where(p => p.SINAV1 == enYuksek).ToList();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.TBLNOTLAR
                        join d2 in db.TBLOGRENCI
                        on d1.OGR equals d2.ID
                        join d3 in db.TBLDERSLER
                        on d1.DERS equals d3.DERSID
                        select new
                        {
                            ÖĞRENCİ = d2.AD + " " + d2.SOYAD,
                            DERS = d3.DERSAD,
                            SINAV1 = d1.SINAV1,
                            SINAV2 = d1.SINAV2,
                            SINAV3 = d1.SINAV3,
                            ORTALAMA = d1.ORTALAMA
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void txtOgrenciID_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
