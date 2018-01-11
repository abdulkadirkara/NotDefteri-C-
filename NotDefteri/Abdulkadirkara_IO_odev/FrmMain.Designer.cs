namespace NotDefteri
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAc = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmYazdir = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmKes = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmYapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmSil = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmTumunuSec = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmSaatTarih = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmYaziTipi = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmSozcukKaydir = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmYardim = new System.Windows.Forms.ToolStripMenuItem();
            this.OpnDosya = new System.Windows.Forms.OpenFileDialog();
            this.TxtYazi = new System.Windows.Forms.TextBox();
            this.SvDosya = new System.Windows.Forms.SaveFileDialog();
            this.PrintDosya = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.yazıTipiToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(390, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmYeni,
            this.TsmAc,
            this.TsmKaydet,
            this.TsmYazdir,
            this.TsmCikis});
            this.menüToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menüToolStripMenuItem.Image")));
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // TsmYeni
            // 
            this.TsmYeni.Name = "TsmYeni";
            this.TsmYeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TsmYeni.Size = new System.Drawing.Size(150, 22);
            this.TsmYeni.Text = "Yeni";
            this.TsmYeni.Click += new System.EventHandler(this.TsmYeni_Click);
            // 
            // TsmAc
            // 
            this.TsmAc.Name = "TsmAc";
            this.TsmAc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TsmAc.Size = new System.Drawing.Size(150, 22);
            this.TsmAc.Text = "Aç";
            this.TsmAc.Click += new System.EventHandler(this.TsmAc_Click);
            // 
            // TsmKaydet
            // 
            this.TsmKaydet.Name = "TsmKaydet";
            this.TsmKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TsmKaydet.Size = new System.Drawing.Size(150, 22);
            this.TsmKaydet.Text = "Kaydet";
            this.TsmKaydet.Click += new System.EventHandler(this.TsmKaydet_Click);
            // 
            // TsmYazdir
            // 
            this.TsmYazdir.Name = "TsmYazdir";
            this.TsmYazdir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.TsmYazdir.Size = new System.Drawing.Size(150, 22);
            this.TsmYazdir.Text = "Yazdır";
            this.TsmYazdir.Click += new System.EventHandler(this.TsmYazdir_Click);
            // 
            // TsmCikis
            // 
            this.TsmCikis.Name = "TsmCikis";
            this.TsmCikis.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.TsmCikis.Size = new System.Drawing.Size(150, 22);
            this.TsmCikis.Text = "Çıkış";
            this.TsmCikis.Click += new System.EventHandler(this.TsmCikis_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmKes,
            this.TsmKopyala,
            this.TsmYapistir,
            this.TsmSil,
            this.TsmTumunuSec,
            this.TsmSaatTarih});
            this.düzenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("düzenToolStripMenuItem.Image")));
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // TsmKes
            // 
            this.TsmKes.Name = "TsmKes";
            this.TsmKes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.TsmKes.Size = new System.Drawing.Size(183, 22);
            this.TsmKes.Text = "Kes";
            this.TsmKes.Click += new System.EventHandler(this.TsmKes_Click);
            // 
            // TsmKopyala
            // 
            this.TsmKopyala.Name = "TsmKopyala";
            this.TsmKopyala.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.TsmKopyala.Size = new System.Drawing.Size(183, 22);
            this.TsmKopyala.Text = "Kopyala";
            this.TsmKopyala.Click += new System.EventHandler(this.TsmKopyala_Click);
            // 
            // TsmYapistir
            // 
            this.TsmYapistir.Name = "TsmYapistir";
            this.TsmYapistir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.TsmYapistir.Size = new System.Drawing.Size(183, 22);
            this.TsmYapistir.Text = "Yapıştır";
            this.TsmYapistir.Click += new System.EventHandler(this.TsmYapistir_Click);
            // 
            // TsmSil
            // 
            this.TsmSil.Name = "TsmSil";
            this.TsmSil.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.TsmSil.Size = new System.Drawing.Size(183, 22);
            this.TsmSil.Text = "Sil";
            this.TsmSil.Click += new System.EventHandler(this.TsmSil_Click);
            // 
            // TsmTumunuSec
            // 
            this.TsmTumunuSec.Name = "TsmTumunuSec";
            this.TsmTumunuSec.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.TsmTumunuSec.Size = new System.Drawing.Size(183, 22);
            this.TsmTumunuSec.Text = "Tümünü Seç";
            this.TsmTumunuSec.Click += new System.EventHandler(this.TsmTumunuSec_Click);
            // 
            // TsmSaatTarih
            // 
            this.TsmSaatTarih.Name = "TsmSaatTarih";
            this.TsmSaatTarih.Size = new System.Drawing.Size(183, 22);
            this.TsmSaatTarih.Text = "Saat/Tarih";
            this.TsmSaatTarih.Click += new System.EventHandler(this.TsmSaatTarih_Click);
            // 
            // yazıTipiToolStripMenuItem
            // 
            this.yazıTipiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmYaziTipi,
            this.TsmSozcukKaydir});
            this.yazıTipiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yazıTipiToolStripMenuItem.Image")));
            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.yazıTipiToolStripMenuItem.Text = "Biçim";
            // 
            // TsmYaziTipi
            // 
            this.TsmYaziTipi.Name = "TsmYaziTipi";
            this.TsmYaziTipi.Size = new System.Drawing.Size(147, 22);
            this.TsmYaziTipi.Text = "Yazı Tipi";
            this.TsmYaziTipi.Click += new System.EventHandler(this.TsmYaziTipi_Click);
            // 
            // TsmSozcukKaydir
            // 
            this.TsmSozcukKaydir.Name = "TsmSozcukKaydir";
            this.TsmSozcukKaydir.Size = new System.Drawing.Size(147, 22);
            this.TsmSozcukKaydir.Text = "Sözcük Kaydır";
            this.TsmSozcukKaydir.Click += new System.EventHandler(this.TsmSozcukKaydir_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmYardim});
            this.yardımToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yardımToolStripMenuItem.Image")));
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // TsmYardim
            // 
            this.TsmYardim.Name = "TsmYardim";
            this.TsmYardim.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.TsmYardim.Size = new System.Drawing.Size(130, 22);
            this.TsmYardim.Text = "Yardım";
            this.TsmYardim.Click += new System.EventHandler(this.TsmYardim_Click);
            // 
            // OpnDosya
            // 
            this.OpnDosya.FileName = "openFileDialog1";
            this.OpnDosya.FileOk += new System.ComponentModel.CancelEventHandler(this.OpnDosya_FileOk);
            // 
            // TxtYazi
            // 
            this.TxtYazi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtYazi.Location = new System.Drawing.Point(0, 24);
            this.TxtYazi.Multiline = true;
            this.TxtYazi.Name = "TxtYazi";
            this.TxtYazi.Size = new System.Drawing.Size(390, 237);
            this.TxtYazi.TabIndex = 1;
            // 
            // SvDosya
            // 
            this.SvDosya.FileOk += new System.ComponentModel.CancelEventHandler(this.SvDosya_FileOk);
            // 
            // PrintDosya
            // 
            this.PrintDosya.UseEXDialog = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 261);
            this.Controls.Add(this.TxtYazi);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Defteri";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmYeni;
        private System.Windows.Forms.ToolStripMenuItem TsmAc;
        private System.Windows.Forms.ToolStripMenuItem TsmKaydet;
        private System.Windows.Forms.ToolStripMenuItem TsmYazdir;
        private System.Windows.Forms.ToolStripMenuItem TsmCikis;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmKes;
        private System.Windows.Forms.ToolStripMenuItem TsmKopyala;
        private System.Windows.Forms.ToolStripMenuItem TsmYapistir;
        private System.Windows.Forms.ToolStripMenuItem TsmSil;
        private System.Windows.Forms.ToolStripMenuItem TsmTumunuSec;
        private System.Windows.Forms.ToolStripMenuItem TsmSaatTarih;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmYaziTipi;
        private System.Windows.Forms.ToolStripMenuItem TsmSozcukKaydir;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmYardim;
        private System.Windows.Forms.OpenFileDialog OpnDosya;
        private System.Windows.Forms.TextBox TxtYazi;
        private System.Windows.Forms.SaveFileDialog SvDosya;
        private System.Windows.Forms.PrintDialog PrintDosya;
    }
}

