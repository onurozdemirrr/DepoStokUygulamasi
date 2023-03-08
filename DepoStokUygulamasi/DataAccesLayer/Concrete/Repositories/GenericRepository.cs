using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
        // Bizim buraya göndereceğimiz parametre Entity class'ları olacağı için T değerine "class" kısıtı uygulamış olduk.
    {
        // Bir önceki yapı normalde çalışır. Şu aşamada biz sadece 3 tabloyu temsil eden işlemler için bu yapıyı kurduk. FArklı tablolarımız için de benzer kodları tekrar tekrar yazmak zorunda kalacağız. Ve bir noktada yapılan bir değişiklik, birden çok Class'ı etkileyecek.Örneğimizde parametreli List() metodunda bunu gördük. Bu yapı yönetilebilir bir yapı değil ve yazılımcıının üzerinde çok fazla kod yükü oluşturacak. Yani çok fazla kod yazmak zorunda kalacak.
        // Bu yapı yerine GenericRepository isminde oluşturduum bu class ile bu kod yükünde kurtulacağız. Ve CategoryRepository, ProductRepository vb sınıfların yerine bu sınıf kullanılacak.
        // Genel olarak Database işlemleri hemen hemen bütün tablolar/Entity sınıflar için aynıdır. Bu kodları tekrar tekrar tekrar yazmak yerine Generic dediğimiz bu yapılar ile çözüyoruz.Yani Design Pattern'lardan Generic Repository Design Pattern'ı ile çözüyoruz.
        Context context = Context.ContextVer();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Delete(int id)
        {
            try
            {
                var result = _object.Find(id);
                _object.Remove(result);
                context.SaveChanges();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(" güncelleme hatası.." + Ex.Message);
            }
            //_object.Remove(p);            
            //context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.Find(filter);
        }

        public void Insert(T p)
        {
            _object.Add(p);
            context.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p, int id)
        {
            // Güncellenecek nesneyi buluyoruz.
            T guncellenecekNesne = _object.Find(id);
            // Bu nesneye ait bütün property'leri bir değişkene atıyoruz.
            var tumPropertyler = typeof(T).GetProperties();
            // Döngü ile ilgili property'lere parametrede gönderdiğimiz nesnenin içindeki değerleri atıyoruz. Id'yi bunun dışında tutuyoruz.
            foreach (var property in tumPropertyler)
            {
                if (property.Name != "Id")
                    property.SetValue(guncellenecekNesne, property.GetValue(p));
            }

            context.SaveChanges();
        }
    }
}
