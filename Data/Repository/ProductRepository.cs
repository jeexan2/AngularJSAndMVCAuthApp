using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ProductUnitDatabaseEntities dbContext;
        public ProductRepository(ProductUnitDatabaseEntities _dbContext)
        {
            this.dbContext = _dbContext;
        }
        public void Delete(int Id)
        {
            Product product = dbContext.Products.Find(Id);

            dbContext.Products.Remove(product);

            Save();
        }

        public Product GetByID(int Id)
        {
            return dbContext.Products.Find(Id);
        }

        public IEnumerable<Product> GetList()
        {
            return dbContext.Products.ToList();
        }

        public void Insert(Product entity)
        {
            dbContext.Products.Add(entity);

            Save();
        }

        public void Save()
        {
            // throw new NotImplementedException();
            dbContext.SaveChanges();
        }

        public void Update(Product entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;

            Save();
        }
    }
}
