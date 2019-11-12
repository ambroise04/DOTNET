using System;
using System.Collections.Generic;

namespace Repository
{
    public interface IRepository<T, U>
    {
        void Delete(T entityToDelete);
        void Delete(U id);
        IEnumerable<T> Get();
        T GetByID(U id);
        void Insert(T entity);
        void Update(T entitytToUpdate);
    }
}
