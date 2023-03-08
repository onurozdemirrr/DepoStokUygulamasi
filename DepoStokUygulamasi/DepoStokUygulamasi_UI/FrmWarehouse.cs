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
    public partial class FrmWarehouse : Form
    {
        public FrmWarehouse()
        {
            InitializeComponent();
        }
        WarehouseManager manager = new WarehouseManager();
        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }
        private void FormTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    item.Text = "";
                }
                if (item.GetType().ToString() == "System.Windows.Forms.MaskedText")
                {
                    item.Text = "";
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tbxDepoAdi.Text != "")
            {
                Warehouse depo = new Warehouse();
                depo.DepoAdi=tbxDepoAdi.Text;
                depo.Aciklama = tbxAciklama.Text;
                depo.DepoYetkilisi = tbxYetkili.Text;
                depo.Telefon = mtbxTelefon.Text;
                manager.WarehouseAddBL(depo);
                DepoListele();
                FormTemizle();
                MessageBox.Show("Depo kaydeildi");
            }
            else
            {
                MessageBox.Show("Lütfen bir depo adı girin");
            }
        }

        private void DepoListele()
        {
            dataGridView1.DataSource = manager.GetAllBL();
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxDepoAdi.Text != "")
            {
                Warehouse depo = new Warehouse();
                depo.Id = Convert.ToInt32(tbxDepoId.Text);
                depo.DepoAdi = tbxDepoAdi.Text;
                depo.Aciklama = tbxAciklama.Text;
                depo.DepoYetkilisi = tbxYetkili.Text;
                depo.Telefon = mtbxTelefon.Text;
                manager.WarehouseUpdateBL(depo);
                DepoListele();
                FormTemizle();
                MessageBox.Show("Depo güncellendi");
            }
            else
            {
                MessageBox.Show("Lütfen bir depo adı girin");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tbxDepoId.Text != "")
            {
                manager.WarehouseDeleteBL(Convert.ToInt32(tbxDepoId.Text));
                DepoListele();
                FormTemizle();
            }
            else
            {
                MessageBox.Show("Silmek için lütfen bir kayıt seçin.");
            }
        }
    }
}

