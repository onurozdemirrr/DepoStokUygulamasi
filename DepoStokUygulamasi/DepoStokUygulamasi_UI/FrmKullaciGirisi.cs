using BusinessLayer.Concrete;
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
    public partial class FrmKullaciGirisi : Form
    {
        public FrmKullaciGirisi()
        {
            InitializeComponent();
        }
        EmployeeManager manager = new EmployeeManager();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //string durum = manager.GetEmployee(tbxKullaniciAdi.Text, tbxSifre.Text);
            //MessageBox.Show(durum);
            FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
            frmAnasayfa.Show();
            this.Hide();
        }
    }
}
