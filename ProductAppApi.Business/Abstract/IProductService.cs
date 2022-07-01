using ProductAppApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppApi.Business.Abstract
{
    public interface IProductService
    {
        Product GetProductByBarcode(string sBarkod);
    }
}
