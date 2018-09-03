using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private ProductUnitDatabaseEntities dbContext;
        public UserRepository(ProductUnitDatabaseEntities _dbContext)
        {
            this.dbContext = _dbContext;
        }
        public void Delete(int Id)
        {
            User user = dbContext.Users.Find(Id);

            dbContext.Users.Remove(user);

            Save();
        }

     

        public IEnumerable<User> GetList()
        {
            return dbContext.Users.ToList();
        }

        public void Insert(User entity)
        {
            dbContext.Users.Add(entity);

            Save();
        }


        public void Save()
        {
            // throw new NotImplementedException();
            dbContext.SaveChanges();
        }

       
        public void Update(User entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;

            Save();
        }

        User GetByID(int Id)
        {
            return dbContext.Users.Find(Id);
        }

        User IRepository<User>.GetByID(int Id)
        {
            return dbContext.Users.Find(Id);
        }
    }
}
