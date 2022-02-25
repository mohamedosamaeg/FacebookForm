using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Repository
{
    public interface IGenericCRUD<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int Id);
        T Get(int id);
        List<T> Get();
    }
}
