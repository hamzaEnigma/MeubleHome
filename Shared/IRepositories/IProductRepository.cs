using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.IRepositories
{
    public interface IProductRepository
    {
        void addProduct(ProductProduct _product);
        void deleteProduct(int id);
        IEnumerable<ProductProduct> getAllProducts();
        ProductProduct getProductById(string key);
        bool saveChanges();
        bool updateProduct(ProductProduct _product);
    }
}
