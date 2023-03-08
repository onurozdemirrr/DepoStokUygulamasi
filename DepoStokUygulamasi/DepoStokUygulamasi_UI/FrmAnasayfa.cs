using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoStokUygulamasi_UI
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void tsbtnUrunIslemleri_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct();
            frmProduct.MdiParent = this;
            FormGetir(frmProduct);
        }

        private void FormGetir(Form form)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void tsbtnFirmaIslemleri_Click(object sender, EventArgs e)
        {
            FrmFirmalar frmFirmalar = new FrmFirmalar();
            frmFirmalar.MdiParent = this;
            FormGetir(frmFirmalar);
        }

        private void tsbtnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            frmpersoneller frmPersoneller = new frmpersoneller();
            frmPersoneller.MdiParent = this;
            FormGetir(frmPersoneller);
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = statusStrip1.Text + " " + "Admin";
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
