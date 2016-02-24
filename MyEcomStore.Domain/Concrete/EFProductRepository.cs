using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEcomStore.Domain.Abstract;

namespace MyEcomStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Entities.Product> Products
        {
            get { return context.Products ; }
        }
    }
}
