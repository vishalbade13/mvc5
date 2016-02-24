using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEcomStore.Domain.Entities;

namespace MyEcomStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
