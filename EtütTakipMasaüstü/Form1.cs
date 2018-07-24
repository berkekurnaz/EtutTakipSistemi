using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtütTakipMasaüstü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmMainMenu frMainMenu = new FrmMainMenu();
            frMainMenu.MdiParent = this;
            frMainMenu.Show();
        }

        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMainMenu frMain = new FrmMainMenu();
            frMain.MdiParent = this;
            frMain.Show();
        }

        private void BtnEtutOlusturma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEtut frEtut = new FrmEtut();
            frEtut.MdiParent = this;
            frEtut.Show();
        }

        private void BtnDersOlusturma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDersler frDersler = new FrmDersler();
            frDersler.MdiParent = this;
            frDersler.Show();
        }

        private void BtnOgretmenEkleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOgretmenler frOgretmenler = new FrmOgretmenler();
            frOgretmenler.MdiParent = this;
            frOgretmenler.Show();
        }

        private void BtnOgrenciEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOgrenci frOgrenci = new FrmOgrenci();
            frOgrenci.MdiParent = this;
            frOgrenci.Show();
        }

        private void BtnSınıfOlusturma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSiniflar frSınıflar = new FrmSiniflar();
            frSınıflar.MdiParent = this;
            frSınıflar.Show();
        }

        private void BtnBugunEtutler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBugunEtutler frBugun = new FrmBugunEtutler();
            frBugun.MdiParent = this;
            frBugun.Show();
        }

        private void BtnButunEtutler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmButunEtutler frButun = new FrmButunEtutler();
            frButun.MdiParent = this;
            frButun.Show();
        }
    }
}
