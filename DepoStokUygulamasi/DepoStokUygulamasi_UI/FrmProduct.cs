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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }
        ProductManager manager = new ProductManager();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.CategoryId = Convert.ToInt32(cbxKategoriId.SelectedValue);
            product.Adi = tbxUrunAdi.Text;
            product.BarkodKodu = tbxBarkodKodu.Text;
            product.StokMiktari = Convert.ToInt32(tbxStokMiktari.Text);
            product.UnitId = Convert.ToInt32(cbxBirimId.SelectedValue);
            product.BirimFiyat = Convert.ToDouble(tbxBirimFiyati.Text);
            product.WarehouseId = Convert.ToInt32(cbxDepoId.SelectedValue);
            product.RafNo = tbxRaf.Text;
            product.MinStok = Convert.ToInt32(tbxMinStok.Text);
            product.MaxStok = Convert.ToInt32(tbxMaxStok.Text);

            manager.ProductAddBL(product);
            FormTemizle();
            ProductListele();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'depoStokUygulamasiDataSet2.Warehouses' table. You can move, or remove it, as needed.
            this.warehousesTableAdapter.Fill(this.depoStokUygulamasiDataSet2.Warehouses);
            // TODO: This line of code loads data into the 'depoStokUygulamasiDataSet1.Units' table. You can move, or remove it, as needed.
            this.unitsTableAdapter.Fill(this.depoStokUygulamasiDataSet1.Units);
            // TODO: This line of code loads data into the 'depoStokUygulamasiDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.depoStokUygulamasiDataSet.Categories);

            ProductListele();
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
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
                if (item.GetType().ToString() == "System.Windows.Forms.ComboBox")
                {
                    item.Text = "";
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.Id = Convert.ToInt32(tbxId.Text);
            product.CategoryId = Convert.ToInt32(cbxKategoriId.SelectedValue);
            product.Adi = tbxUrunAdi.Text;
            product.BarkodKodu = tbxBarkodKodu.Text;
            product.StokMiktari = Convert.ToInt32(tbxStokMiktari.Text);
            product.UnitId = Convert.ToInt32(cbxBirimId.SelectedValue);
            product.BirimFiyat = Convert.ToDouble(tbxBirimFiyati.Text);
            product.WarehouseId = Convert.ToInt32(cbxDepoId.SelectedValue);
            product.RafNo = tbxRaf.Text;
            product.MinStok = Convert.ToInt32(tbxMinStok.Text);
            product.MaxStok = Convert.ToInt32(tbxMaxStok.Text);

            manager.ProductUpdateBL(product);
            FormTemizle();
            ProductListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(tbxId.Text);
            manager.ProductDeleteBL(productId);
            FormTemizle();
            ProductListele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbxKategoriId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxUrunAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxBarkodKodu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxStokMiktari.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cbxBirimId.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxBirimFiyati.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cbxDepoId.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tbxRaf.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tbxMinStok.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            tbxMaxStok.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            ProductListele();
        }
        private void ProductListele()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }

        private void btnKategoriFormuAc_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.ShowDialog();
        }

        private void btnBirimFormAc_Click(object sender, EventArgs e)
        {
            FrmBirim frmBirim = new FrmBirim();
            frmBirim.ShowDialog();
        }

        private void btnDepoFormAc_Click(object sender, EventArgs e)
        {
            FrmWarehouse frmWarehouse = new FrmWarehouse();
            frmWarehouse.ShowDialog();
        }

        private void cbxKategoriId_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter.Fill(this.depoStokUygulamasiDataSet.Categories);
        }

        private void cbxBirimId_Click(object sender, EventArgs e)
        {
            this.unitsTableAdapter.Fill(this.depoStokUygulamasiDataSet1.Units);
        }

        private void cbxDepoId_Click(object sender, EventArgs e)
        {
            this.warehousesTableAdapter.Fill(this.depoStokUygulamasiDataSet2.Warehouses);
        }
    }
}
