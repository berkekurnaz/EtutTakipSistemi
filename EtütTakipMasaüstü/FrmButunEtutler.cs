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
    public partial class FrmButunEtutler : Form
    {
        public FrmButunEtutler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        TimeSpan fark;
        double farkGun;

        private void FrmGelecekEtutler_Load(object sender, EventArgs e)
        {
            LblTarih.Text = DateTime.Now.ToShortDateString();

            BugunEtut();

            Renklendir();
        }

        void Renklendir()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                fark = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString()) - Convert.ToDateTime(DateTime.Now.ToShortDateString());
                farkGun = fark.TotalDays;
                if (farkGun <= 0)
                {
                    dataGridView1.Rows[i].Cells[6].Value = true;
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }

            }
        }

        void BugunEtut()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select ID,DERSADI as 'Ders Adı',TBL_OGRETMEN.ADSOYAD as 'Öğretmen Adı',TBL_OGRENCI.ADSOYAD as 'Öğrenci Adı',TARIH,SAAT,DURUM From TBL_ETUT inner join TBL_DERSLER on TBL_ETUT.DERSID = TBL_DERSLER.DERSID inner join TBL_OGRETMEN on TBL_ETUT.OGRETMENID = TBL_OGRETMEN.OGRETMENID inner join TBL_OGRENCI on TBL_ETUT.OGRENCIID = TBL_OGRENCI.OGRENCIID order by ID desc", bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
