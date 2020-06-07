using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitest.Business.Exception;
using Unitest.Data;

namespace Unitest.Business
{
    public class ProductManager
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            this._productDal = productDal;
        }

        public Product InsertProduct(Product newProduct)
        {
            var product = _productDal.Get(newProduct.ProductName);
            if (product != null)
            {
                throw new ProductAlreadyExist();
            }

            return _productDal.Insert(newProduct);
        }
    }
}
