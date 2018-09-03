using Data;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductService : IProductService
    {
        private ProductRepository productRepository;
        private Product product;
        public ProductService()
        {
            productRepository = new ProductRepository();
            product = new Product();
        }
        public ProductService(ProductRepository _productRepository,Product _product)
        {
            this.productRepository = _productRepository;
            this.product = _product;
        }
        public void Insert()
        {
            productRepository.Insert(product);
        }
        public void Insert(Product _product)
        {
            productRepository.Insert(product);
        }
        public void Delete(int id)
        {
            productRepository.Delete(id);
        }

       
        public void Update(int id)
        {
            product = productRepository.GetByID(id);
            productRepository.Update(product);
        }
        public IEnumerable<Product> GetProductList()
        {
            return productRepository.GetList();
        }

        public void Update(Product product)
        {
            //throw new NotImplementedException();
            productRepository.Update(product);
        }
    }
}
