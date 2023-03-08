using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager
    {
        GenericRepository<Product> repository = new GenericRepository<Product>();

        public List<Product> GetAllBL()
        {
            return repository.List();
        }

        public string ProductAddBL(Product product)
        {

            string durum = "Kaydetme işlemi başarılı";
            if (product.Adi != null && product.Adi != "")
            {
                repository.Insert(product);
            }
            else
            {
                durum = "Category Name alanı boş geçilemez.";
            }
            return durum;
        }

        public void ProductUpdateBL(Product product)
        {
            if (product.Id != 0 && product.Adi != "")
            {
                repository.Update(product, product.Id);
            }
        }
        public void ProductDeleteBL(int id)
        {
            if (id != 0)
            {
                repository.Delete(id);
            }
        }
    }
}
