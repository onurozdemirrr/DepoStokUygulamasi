using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EmployeeManager
    {
        GenericRepository<Employee> repository = new GenericRepository<Employee>();

        public List<Employee> GetAllBL()
        {
            return repository.List();
        }

        public string EmployeeAddBL(Employee employee)
        {

            string durum = "Kaydetme işlemi başarılı";
            if (employee.Adi != "" && employee.Soyadi != "")
            {
                repository.Insert(employee);
            }
            else
            {
                durum = "personel Adı ya da Soyadı  alanı boş geçilemez.";
            }
            return durum;
        }

        public void EmployeeUpdateBL(Employee employee)
        {
            if (employee.Id != 0 && employee.Adi != ""&& employee.Soyadi != "")
            {
                repository.Update(employee, employee.Id);
            }
        }
        public void EmployeeDeleteBL(int id)
        {
            if (id != 0)
            {
                repository.Delete(id);
            }
        }

        public string GetEmployee(string kullaniciAdi, string sifre)
        {
            string durum = "Giriş başarılı";
             var result = repository.Get(x => x.KullaniciAdi == kullaniciAdi && x.Sifre==sifre && x.AktifMi==true);
            if (result == null)
            {
                durum = "Kullanıcı adı ya da şifre yanlış.";
            }
            return durum;
        }
    }
}
