using Microsoft.EntityFrameworkCore;
using Proje_oop.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje_oop.ProjeContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-107QR8B;database=DbNewOopCore;" +
                "integrated security=true ");
        }
        public DbSet<Product> Products { get; set; } //c# ve sql tablosunda kullanacağım isimlendirme
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
