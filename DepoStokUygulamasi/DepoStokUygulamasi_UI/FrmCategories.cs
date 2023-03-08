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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        CategoryManager manager = new CategoryManager();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = manager.GetAllBL();
            //dataGridView1.Rows[3].Visible = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = tbxCategoryName.Text;
            category.Description = tbxDescription.Text;
            string sonuc = manager.CategoryAddBL(category);
            MessageBox.Show(sonuc);
            FormuTemizle();
        }

        public void FormuTemizle()
        {
            tbxCategoryId.Clear();
            tbxDescription.Clear();
            tbxCategoryName.Clear();            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Id = Convert.ToInt32(tbxCategoryId.Text);
            category.Name = tbxCategoryName.Text;
            category.Description = tbxDescription.Text;
            manager.CategoryUpdateBL(category);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormuDoldur();

        }

        private void FormuDoldur()
        {
            tbxCategoryId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxCategoryName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value != null)
            {
                tbxDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(tbxCategoryId.Text);
            
            manager.CategoryDeleteBL(categoryId);
        }

        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }
    }
}


// https://codeshare.io/N3MO3J