using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UnitManager
    {
        GenericRepository<Unit> repository = new GenericRepository<Unit>();

        public List<Unit> GetAllBL()
        {
            return repository.List();
        }

        public string UnitAddBL(Unit unit)
        {

            string durum = "Kaydetme işlemi başarılı";
            if (unit.BirimAdi != null && unit.BirimAdi != "")
            {
                repository.Insert(unit);
            }
            else
            {
                durum = "Birim Adi alanı boş geçilemez.";
            }
            return durum;
        }

        public void UnitUpdateBL(Unit unit)
        {
            if (unit.Id != 0 && unit.BirimAdi != "")
            {
                repository.Update(unit, unit.Id);
            }
        }
        public void UnitDeleteBL(int id)
        {
            if (id != 0)
            {
                repository.Delete(id);
            }
        }
    }
}
