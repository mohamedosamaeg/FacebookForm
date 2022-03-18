using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Repository
{
    public interface IValidation<M> where M : class
    {
        bool IsExist(M entity);
        bool IsExistById(int Id);
    }
}

