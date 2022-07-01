using ProductAppApi.Business.Abstract;
using ProductAppApi.DataAccess.Abstract;
using ProductAppApi.DataAccess.Concreate;
using ProductAppApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppApi.Business.Concreate
{
    public class ProductManager : IProductService
    {   
        private IProductRepository _productRepository;

        public ProductManager()
        {
            _productRepository = new ProductRepository();
        }

        public Product GetProductByBarcode(string sBarkod)
        {
            return _productRepository.GetProductById(sBarkod);
        }
    }
}
