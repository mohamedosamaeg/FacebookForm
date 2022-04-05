using System;
using System.Collections.Generic;
using System.Text;

using facebook.Models;

namespace facebook.Repository
{
    public class IwarningRepository : IGenericCRUD<Warning>, IValidation<Warning>
    {
        public void Add(Warning entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Warning Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Warning> Get()
        {
            throw new NotImplementedException();
        }

        public bool IsExist(Warning entity)
        {
            throw new NotImplementedException();
        }

        public bool IsExistById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Warning entity)
        {
            throw new NotImplementedException();
        }
    }
}
