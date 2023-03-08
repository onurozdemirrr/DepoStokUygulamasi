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
    public partial class frmpersoneller : Form
    {
        EmployeeManager manager = new EmployeeManager();
        public frmpersoneller()
        {
            InitializeComponent();
        }

        private void btnformclear_Click(object sender, EventArgs e)
        {
            formtemizle();

        }
        private void formtemizle()
        {
            tbxId.Clear();
            tbxadi.Clear();
            tbxsoyadi.Clear();
            tbxgorevi.Clear();
            tbxkullaniciadi.Clear();
            tbxsifre.Clear();
            rbevet.Checked.ToString();
            rbhayir.Checked.ToString();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Adi=tbxadi.Text;
            employee.Soyadi=tbxsoyadi.Text;
            employee.Gorevi=tbxgorevi.Text;
            employee.KullaniciAdi=tbxkullaniciadi.Text;
            employee.Sifre=tbxsifre.Text;
           
            if(rbevet.Checked)
            {
                employee.AktifMi=true;
            }
            else
            {

            }


            MessageBox.Show("kaydedildi");
            manager.EmployeeAddBL(employee);           
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {            
            Employee employee = new Employee();
            employee.Id=Convert.ToInt32(tbxId.Text);
            employee.Adi=tbxadi.Text;
            employee.Soyadi=tbxsoyadi.Text;
            employee.Gorevi=tbxgorevi.Text;
            employee.KullaniciAdi=tbxkullaniciadi.Text;
            employee.Sifre=tbxsifre.Text;
            
             if(rbevet.Checked)
            {
                employee.AktifMi=true;
            }
            else
            {

            }

            MessageBox.Show("güncellendi");
            manager.EmployeeUpdateBL(employee);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int employeıd= Convert.ToInt32(tbxId.Text);
            manager.EmployeeDeleteBL(employeıd);
        }

        private void btnpersonellistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=manager.GetAllBL();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            formudoldur();
        }

        private void formudoldur()
        {
            tbxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxsoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxgorevi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxkullaniciadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxsifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            if((bool)dataGridView1.CurrentRow.Cells[6].Value)
            {
                rbevet.Checked=true;
            }
            else
            {
              rbhayir.Checked=true; 
            }
           


        }
    }
}
