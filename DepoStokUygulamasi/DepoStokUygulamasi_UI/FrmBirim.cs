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
    public partial class FrmBirim : Form
    {
        public FrmBirim()
        {
            InitializeComponent();
        }
        UnitManager manager = new UnitManager();
        private void button1_Click(object sender, EventArgs e)
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
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tbxBirimAdi.Text!="")
            {
                Unit unit = new Unit();
                unit.BirimAdi = tbxBirimAdi.Text;
                unit.Aciklama = tbxAciklama.Text;
                manager.UnitAddBL(unit);
                FormTemizle();
                BirimListele();
                MessageBox.Show("Birim kaydedildi.");
            }
            else
            {
                MessageBox.Show("Birim Adı girmelisiniz.");
            }
        }

        private void BirimListele()
        {
            dataGridView1.DataSource = manager.GetAllBL();
            dataGridView1.Columns[3].Visible=false;
        }

        private void FormuDoldur()
        {
            tbxBirimId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxBirimAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxAciklama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormuDoldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxBirimAdi.Text != "")
            {
                Unit unit = new Unit();
                unit.Id = Convert.ToInt32(tbxBirimId.Text);
                unit.BirimAdi = tbxBirimAdi.Text;
                unit.Aciklama = tbxAciklama.Text;
                manager.UnitUpdateBL(unit);
                FormTemizle();
                BirimListele();
                MessageBox.Show("Birim güncellendi.");
            }
            else
            {
                MessageBox.Show("Birim Adı boş geçilemez.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tbxBirimId.Text !="")
            {
                manager.UnitDeleteBL(Convert.ToInt32(tbxBirimId.Text));
                FormTemizle();
                BirimListele();
            }
            else
            {
                MessageBox.Show("Silmek için bir kayıt seçin");
            }
        }

        private void FrmBirim_Load(object sender, EventArgs e)
        {
            BirimListele();
        }
    }
}
