using ProductAppApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppApi.DataAccess.Abstract
{
    public interface IProductRepository
    {
        Product GetProductById(string sBarkod);
    }
}
