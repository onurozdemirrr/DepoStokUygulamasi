using BusinessLayer.Concrete;
using EntityLayer.Concrete;
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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        CompanyManager manager = new CompanyManager();
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            GetAllCompanies();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.FirmaAdi = tbxFirmaAdi.Text;
            company.FirmaTuru = tbxFirmaTuru.Text;
            company.Adres = tbxAdres.Text;
            company.Telefon = mtbxTelefon.Text;
            company.Email = tbxEmail.Text;
            company.YetkiliKisi = tbxYetkiliKisi.Text;
            company.Aciklama = tbxAciklama.Text;
            company.HesapNo = tbxHesapNo.Text;
            company.VergiNo = TbxVergiNo.Text;
            manager.CompanyAddBL(company);

            FormTemizle();
            GetAllCompanies();

        }

        public void FormTemizle()
        {
            tbxFirmaAdi.Clear();
            tbxFirmaTuru.Clear();
            tbxAdres.Clear();
            mtbxTelefon.Clear();
            tbxEmail.Clear();
            tbxYetkiliKisi.Clear();
            tbxAciklama.Clear();
            tbxHesapNo.Clear();
            TbxVergiNo.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int companyId = Convert.ToInt32(tbxId.Text);
            manager.CompanyDeleteBL(companyId);
            FormTemizle();
            GetAllCompanies();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Id = Convert.ToInt32(tbxId.Text);
            company.FirmaAdi = tbxFirmaAdi.Text;
            company.FirmaTuru = tbxFirmaTuru.Text;
            company.Adres = tbxAdres.Text;
            company.Telefon = mtbxTelefon.Text;
            company.Email = tbxEmail.Text;
            company.YetkiliKisi = tbxYetkiliKisi.Text;
            company.Aciklama = tbxAciklama.Text;
            company.HesapNo = tbxHesapNo.Text;
            company.VergiNo = TbxVergiNo.Text;
            manager.CompanyAddBL(company);
            FormTemizle();
            GetAllCompanies();
        }

        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void GetAllCompanies()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }
    }
}


