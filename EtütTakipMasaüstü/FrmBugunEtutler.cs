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
    public partial class FrmBugunEtutler : Form
    {
        public FrmBugunEtutler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmBugunEtutler_Load(object sender, EventArgs e)
        {
            LblTarih.Text = DateTime.Now.ToShortDateString();

            BugunEtut();
        }

        void BugunEtut()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select ID,DERSADI as 'Ders Adı',TBL_OGRETMEN.ADSOYAD as 'Öğretmen Adı',TBL_OGRENCI.ADSOYAD as 'Öğrenci Adı',TARIH,SAAT From TBL_ETUT inner join TBL_DERSLER on TBL_ETUT.DERSID = TBL_DERSLER.DERSID inner join TBL_OGRETMEN on TBL_ETUT.OGRETMENID = TBL_OGRETMEN.OGRETMENID inner join TBL_OGRENCI on TBL_ETUT.OGRENCIID = TBL_OGRENCI.OGRENCIID where TARIH=@p1 order by ID desc", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", LblTarih.Text);
                gridControl1.DataSource = komut.ExecuteReader();
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
