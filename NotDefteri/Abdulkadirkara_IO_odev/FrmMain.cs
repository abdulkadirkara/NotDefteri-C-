using System;
using NotDefteri;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefteri
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void TsmYeni_Click(object sender, EventArgs e)
        {
            TxtYazi.Text = "";
        }

        private void OpnDosya_FileOk(object sender, CancelEventArgs e)
        {
            string DosyaYolu = OpnDosya.FileName;
            TxtYazi.Text = File.ReadAllText(DosyaYolu);
        }

        private void TsmAc_Click(object sender, EventArgs e)
        {
            OpnDosya.ShowDialog();
        }

        private void TsmKaydet_Click(object sender, EventArgs e)
        {
            SvDosya.ShowDialog();
        }

        private void SvDosya_FileOk(object sender, CancelEventArgs e)
        {
            string KaydetYolu = SvDosya.FileName;
            File.WriteAllText(KaydetYolu, TxtYazi.Text);
        }

        private void TsmYazdir_Click(object sender, EventArgs e)
        {
            PrintDosya.ShowDialog();
        }

        private void TsmCikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        string Kes = "";
        private void TsmKes_Click(object sender, EventArgs e)
        {
            Kes = TxtYazi.SelectedText;
            TxtYazi.SelectedText = "";
        }

        private void TsmKopyala_Click(object sender, EventArgs e)
        {
            Kes = TxtYazi.Text;
        }

        private void TsmYapistir_Click(object sender, EventArgs e)
        {
            TxtYazi.Text += Kes;
        }

        private void TsmSil_Click(object sender, EventArgs e)
        {
            TxtYazi.SelectedText = "";
        }

        private void TsmTumunuSec_Click(object sender, EventArgs e)
        {
            TxtYazi.SelectAll();
        }

        private void TsmSaatTarih_Click(object sender, EventArgs e)
        {

            TxtYazi.Text = DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToLongTimeString();


        }

        private void TsmYaziTipi_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
            TxtYazi.Font = font.Font;
        }

        private void TsmSozcukKaydir_Click(object sender, EventArgs e)
        {
            if (TsmSozcukKaydir.Checked)
            {
                TxtYazi.WordWrap = true;
                TsmSozcukKaydir.Checked = false;
            }
            else
            {
                TxtYazi.WordWrap = false;
                TsmSozcukKaydir.Checked = true;
            }
        }
        YardimForm YF = new YardimForm();
        private void TsmYardim_Click(object sender, EventArgs e)
        {
            YF.Show();


        }
    }
}
