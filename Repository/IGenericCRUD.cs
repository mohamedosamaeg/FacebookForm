using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Repository
{
    public interface IGenericCRUD<M> where M : class
    {
        void Add(M entity);
        void Update(M entity);
        void Delete(int Id);
        M Get(int id);
        List<M> Get();
    }
}
