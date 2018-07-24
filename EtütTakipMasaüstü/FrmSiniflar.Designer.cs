namespace EtütTakipMasaüstü
{
    partial class FrmSiniflar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiniflar));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnSinifEkle = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSinif = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSinifSil = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSilinecek = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSinif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSilinecek.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnSinifEkle);
            this.groupControl1.Controls.Add(this.TxtSinif);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(475, 551);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Yeni Sınıf Ekleme";
            // 
            // BtnSinifEkle
            // 
            this.BtnSinifEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSinifEkle.Appearance.Options.UseFont = true;
            this.BtnSinifEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSinifEkle.ImageOptions.Image")));
            this.BtnSinifEkle.Location = new System.Drawing.Point(131, 307);
            this.BtnSinifEkle.Name = "BtnSinifEkle";
            this.BtnSinifEkle.Size = new System.Drawing.Size(207, 71);
            this.BtnSinifEkle.TabIndex = 2;
            this.BtnSinifEkle.Text = "Sınıf Ekle";
            this.BtnSinifEkle.Click += new System.EventHandler(this.BtnSinifEkle_Click);
            // 
            // TxtSinif
            // 
            this.TxtSinif.Location = new System.Drawing.Point(27, 213);
            this.TxtSinif.Name = "TxtSinif";
            this.TxtSinif.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSinif.Properties.Appearance.Options.UseFont = true;
            this.TxtSinif.Size = new System.Drawing.Size(419, 40);
            this.TxtSinif.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(125, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eklenecek Sınıf :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dataGridView1);
            this.groupControl2.Location = new System.Drawing.Point(543, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(645, 551);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Sistemde Kayıtlı Sınıflar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(635, 518);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.label4);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.BtnSinifSil);
            this.groupControl3.Controls.Add(this.TxtSilinecek);
            this.groupControl3.Controls.Add(this.label2);
            this.groupControl3.Location = new System.Drawing.Point(1241, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(475, 551);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Sınıf Silme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(55, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numarayı Kutuya Yazarak Silebilirsiniz...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Silmek İstediğiniz Sınıfın Yanında Yer Alan ";
            // 
            // BtnSinifSil
            // 
            this.BtnSinifSil.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSinifSil.Appearance.Options.UseFont = true;
            this.BtnSinifSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSinifSil.ImageOptions.Image")));
            this.BtnSinifSil.Location = new System.Drawing.Point(131, 307);
            this.BtnSinifSil.Name = "BtnSinifSil";
            this.BtnSinifSil.Size = new System.Drawing.Size(207, 71);
            this.BtnSinifSil.TabIndex = 4;
            this.BtnSinifSil.Text = "Sınıf Sil";
            this.BtnSinifSil.Click += new System.EventHandler(this.BtnSinifSil_Click);
            // 
            // TxtSilinecek
            // 
            this.TxtSilinecek.Location = new System.Drawing.Point(27, 213);
            this.TxtSilinecek.Name = "TxtSilinecek";
            this.TxtSilinecek.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSilinecek.Properties.Appearance.Options.UseFont = true;
            this.TxtSilinecek.Size = new System.Drawing.Size(419, 40);
            this.TxtSilinecek.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(125, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Silinecek Sınıf :";
            // 
            // FrmSiniflar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 751);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmSiniflar";
            this.Text = "Sınıflar Sayfası";
            this.Load += new System.EventHandler(this.FrmSiniflar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSinif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSilinecek.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnSinifEkle;
        private DevExpress.XtraEditors.TextEdit TxtSinif;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton BtnSinifSil;
        private DevExpress.XtraEditors.TextEdit TxtSilinecek;
        private System.Windows.Forms.Label label2;
    }
}