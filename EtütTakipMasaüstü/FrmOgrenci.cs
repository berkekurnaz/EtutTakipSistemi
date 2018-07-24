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

namespace EtütTakipMasaüstü
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            Listele();
            SinifListele();
        }

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select OGRENCIID,ADSOYAD,TELEFON,MAIL,SINIFADI From TBL_OGRENCI inner join TBL_SINIFLAR on TBL_OGRENCI.SINIFID = TBL_SINIFLAR.SINIFID", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void SinifListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_SINIFLAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            TxtSinif.ValueMember = "SINIFID";
            TxtSinif.DisplayMember = "SINIFADI";
            TxtSinif.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show(TxtAdSoyad.Text + " Adlı Öğrenciyi Kaydetmek İstiyor Musun ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (TxtAdSoyad.Text == "")
                {
                    MessageBox.Show("Boş Alanı Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        SqlCommand komut = new SqlCommand("insert into TBL_OGRENCI(ADSOYAD,TELEFON,MAIL,SINIFID) values (@P1,@P2,@P3,@P4)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@P1", TxtAdSoyad.Text);
                        komut.Parameters.AddWithValue("@P2", TxtTelefon.Text);
                        komut.Parameters.AddWithValue("@P3", TxtMail.Text);
                        komut.Parameters.AddWithValue("@P4", TxtSinif.SelectedValue);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Öğrenci Sisteme Başarıyla Eklendi...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                        TxtAdSoyad.Text = "";
                        TxtMail.Text = "";
                        TxtId.Text = "";
                        TxtTelefon.Text = "";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                Listele();
            }
        }

        private void BtnDüzenle_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show(TxtAdSoyad.Text + " Adlı Öğrenciyi Düzenlemek İstiyor Musun ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (TxtAdSoyad.Text == "")
                {
                    MessageBox.Show("Boş Alanı Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        SqlCommand komut = new SqlCommand("Update TBL_OGRENCI set ADSOYAD=@P1,TELEFON=@P2,MAIL=@P3,SINIFID=@P4 where OGRENCIID=@P5", bgl.baglanti());
                        komut.Parameters.AddWithValue("@P1", TxtAdSoyad.Text);
                        komut.Parameters.AddWithValue("@P2", TxtTelefon.Text);
                        komut.Parameters.AddWithValue("@P3", TxtMail.Text);
                        komut.Parameters.AddWithValue("@P4", TxtSinif.SelectedValue);
                        komut.Parameters.AddWithValue("@P5", TxtId.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Öğrenci Başarıyla Güncellendi...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                Listele();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show(TxtAdSoyad.Text + " Adlı Öğrenciyi Silmek İstiyor Musun ?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (TxtAdSoyad.Text == "")
                {
                    MessageBox.Show("Boş Alanı Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        SqlCommand komut = new SqlCommand("Delete From TBL_OGRENCI where OGRENCIID=@P1", bgl.baglanti());
                        komut.Parameters.AddWithValue("@P1", TxtId.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        TxtId.Text = "";
                        TxtAdSoyad.Text = "";
                        TxtMail.Text = "";
                        TxtTelefon.Text = "";
                        MessageBox.Show("Öğrenci Başarıyla Silindi...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                Listele();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int number = dataGridView1.SelectedCells[0].RowIndex;

            try
            {
                TxtId.Text = dataGridView1.Rows[number].Cells[0].Value.ToString();
                TxtAdSoyad.Text = dataGridView1.Rows[number].Cells[1].Value.ToString();
                TxtTelefon.Text = dataGridView1.Rows[number].Cells[2].Value.ToString();
                TxtMail.Text = dataGridView1.Rows[number].Cells[3].Value.ToString();
                TxtSinif.Text = dataGridView1.Rows[number].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
