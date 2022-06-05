using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.Extensions.Logging;
using Shared.IRepositories;

namespace Shared.Repositories
{


    public class ProductRepository :  IProductRepository
    {
        private readonly meuble_homeContext _context;
        private readonly ILogger _logger;

        public ProductRepository(meuble_homeContext context)
        {
            this._context = context;
        }

        public IEnumerable<ProductProduct> getAllProducts()
        {
            return _context.ProductProducts.ToList();
        }
        public ProductProduct getProductById(string key)
        {
            return _context.ProductProducts.Where(x => x.Reference == key).SingleOrDefault();
        }

        public void addProduct(ProductProduct _product)
        {
            _context.ProductProducts.Add(_product);
        }

        public bool updateProduct(ProductProduct _product)
        {
            var entityToUpdate = _context.ProductProducts.Where(x => x.Id == _product.Id).SingleOrDefault();
            if (entityToUpdate == null) return false;
            ProductProduct productUpdated = new ProductProduct()
            {
                Nom = _product.Nom,
                Prix = _product.Prix,
                Stock = _product.Stock,
                Description = _product.Description,
            };
            return true;
        }
        public void deleteProduct(int id)
        {
            var entityToRemove = _context.ProductProducts.Where(x => x.Id == id).SingleOrDefault();

            _context.ProductProducts.Remove(entityToRemove);
        }

        public bool saveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
