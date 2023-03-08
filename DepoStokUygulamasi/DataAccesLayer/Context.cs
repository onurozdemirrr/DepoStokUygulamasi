using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class Context:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Employee> Employees { get; set; }





        // Singleton dizaynda amaç her istenildiğinde nesne üretmenin önüne geçmektir. İstenilen nesneden bir tane üretilir. Daha sonra ihtiyaç duyulduğunda bu nesne tekrar tekrar gönderilir. Bu Clas'tan yeni bir nesne üretmenin önüne geçmek için Constructor/Yapıcı metodu private olarak işaretliyorum. Bu durumda Context Class'ından bir nesne üretilemeyecek.
        private Context()
        {
        }

        private static Context context;

        public static Context ContextVer()
        {
            if (context == null)
            {
                context = new Context();
            }
            return context;
        }

    }
}
