using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public  class WarehouseManager
    {
        GenericRepository<Warehouse> repository = new GenericRepository<Warehouse>();

        public List<Warehouse> GetAllBL()
        {
            return repository.List();
        }

        public string WarehouseAddBL(Warehouse warehouse)
        {

            string durum = "Kaydetme işlemi başarılı";
            if (warehouse.DepoAdi != null && warehouse.DepoAdi != "")
            {
                repository.Insert(warehouse);
            }
            else
            {
                durum = "Depo Adi alanı boş geçilemez.";
            }
            return durum;
        }

        public void WarehouseUpdateBL(Warehouse warehouse)
        {
            if (warehouse.Id != 0 && warehouse.DepoAdi != "")
            {
                repository.Update(warehouse, warehouse.Id);
            }
        }
        public void WarehouseDeleteBL(int id)
        {
            if (id != 0)
            {
                repository.Delete(id);
            }
        }
    }
}
