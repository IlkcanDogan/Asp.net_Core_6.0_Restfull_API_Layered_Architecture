using ProductAppApi.DataAccess.Abstract;
using ProductAppApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppApi.DataAccess.Concreate
{
    public class ProductRepository : IProductRepository
    {
        public Product GetProductById(string sBarkod)
        {
            using (var productDbContext = new ProductDbContext())
            {

                return productDbContext.tbBarkodokut.SingleOrDefault(table => table.sBarkod == sBarkod);
            }
        }
    }
}
