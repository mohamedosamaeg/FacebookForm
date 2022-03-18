using facebook.Models;
using facebook.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace facebook.Services
{
    public class GroupsService : IGenericCRUD<Groups>, IValidation<Groups>
    {
        FacebookDbContext dbContext = new FacebookDbContext();

        public string Name { get; private set; }

        public void Add(Groups entity)
        {
            if (!IsExist(entity))
            {
                entity.CreatedDate = DateTime.Now;
                dbContext.groups.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            if (IsExistById(Id))
            {
                dbContext.groups.Remove(Get(Id));
                dbContext.SaveChanges();
            }
        }

        public Groups Get(int id)
        {
            if (IsExistById(id))
            {
                return dbContext.groups.Where(x => x.Id == id).SingleOrDefault();
            }
            return null;
        }

        public List<Groups> Get()
        {
            return dbContext.groups.ToList();
        }

        public bool IsExist(Groups entity)
        {
            if (!IsExistById(entity.Id))
            {
                return dbContext.groups.Any(x => x.Name == entity.Name);
            }
            else
            {
                return IsExistById(entity.Id);
            }
        }

  
        public bool IsExistById(int Id)
        {
            return dbContext.groups.Any(x => x.Id == Id);
        }

        public void Update(Groups entity)
        {
            if (IsExist(entity))
            {
                Groups Group = Get(entity.Id);
                Group.Name= entity.Name;
                dbContext.groups.Update(Group);
                dbContext.SaveChanges();
            }
        }

    }
       
}


