using facebook.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using facebook.Models;

namespace facebook.Services
{
    public class UserRoleService : IUserRoleRepository
    {
        FacebookDbContext dbContext = new FacebookDbContext();
        public void Add(UserRole entity)
        {
            if (!IsExist(entity))
            {
                dbContext.UserRole.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public UserRole Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserRole> Get()
        {
            throw new NotImplementedException();
        }

        public bool IsExist(UserRole entity)
        {
            return dbContext.UserRole.Any(x => x.Id == entity.Id || x.Name == entity.Name);
        }


        public bool IsExistById(int Id)
        {
            throw new NotImplementedException();
        }

    

        public void Update(UserRole entity)
        {
            throw new NotImplementedException();
        }

        UserRole IGenericCRUD<UserRole>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}


