using facebook.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using facebook.Models;

namespace facebook.Services
{
    public class UserRoleService : IUserRole
    {
        FacebookDbContext dbContext = new FacebookDbContext();
        public void Add(IUserRoleRepository entity)
        {
            if (!IsExist(entity))
            {
                dbContext.IUserRole.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IUserRole Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserRole> Get()
        {
            throw new NotImplementedException();
        }

        public bool IsExist(IUserRole entity)
        {
            return dbContext.UserRole.Any(x => x.Id == entity.Id || x.Name == entity.Name);
        }

        public bool IsExistById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(IUserRole entity)
        {
            throw new NotImplementedException();
        }
    }
}


