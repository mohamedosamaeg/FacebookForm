using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Repository
{
    public interface IValidation<T> where T : class
    {
       
        bool IsExist(T entity);
        bool IsExistById(int Id);
    }
}

