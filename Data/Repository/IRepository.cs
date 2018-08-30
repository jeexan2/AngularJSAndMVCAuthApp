using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IRepository<T> where T :  class
    {
        void Insert(T entity); // Creation Purpose

        IEnumerable<T> GetList(); // Retrieve Lists Purpose

        T GetByID(int Id); // Retrieve Purpose

        void Update(T entity); //Update Purpose

        void Delete(int Id); //Deletion Purpose

        void Save();
    }
}
