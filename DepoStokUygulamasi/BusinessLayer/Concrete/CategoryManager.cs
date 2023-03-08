using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {

        GenericRepository<Category> repository = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return repository.List();
        }

        public string CategoryAddBL(Category category)
        {

            string durum = "Kaydetme işlemi başarılı";
            if (category.Name!= null && category.Name!="" )
            {
                repository.Insert(category);
            }
            else
            {
                durum = "Category Name alanı boş geçilemez.";
            }
            return durum;
        }

        public void CategoryUpdateBL(Category category)
        {
            if (category.Id != 0 && category.Name!="")
            {
                repository.Update(category, category.Id);
            }
        }
        public void CategoryDeleteBL(int id)
        {
            if (id !=0)
            {
                repository.Delete(id);
            }
        }
    }
}
