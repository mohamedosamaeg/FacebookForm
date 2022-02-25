using facebook.Models;
using facebook.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace facebook.Services
{
    public class GroupsService : IGenericCRUD<GroupsService>, IValidation<GroupsService>
    {
        FacebookDbContext dbContext = new FacebookDbContext();

        public string Name { get; private set; }

        public void Add(FacebookDbContext entity)
        {
            if (!IsExist(entity))
            {
                entity.CreatedDate = DateTime.Now;
                dbContext.Group.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            if (IsExistById(Id))
            {
                

                dbContext.Group.Remove(Get(Id));
                dbContext.SaveChanges();
            }
        }

        public Groups Get(int id)
        {
            if (IsExistById(id))
            {
                return dbContext.Group.Where(x => x.Id == id).SingleOrDefault();
            }
            return null;
        }

        public List<GroupsService> Get()
        {
            return dbContext.Groups.ToList();
        }

        public bool IsExist(Groups entity)
        {
            if (!IsExistById(entity.Id))
            {
                return dbContext.Group.Any(x => x.Name == entity.Name);
            }
            else
            {
                return IsExistById(entity.Id);
            }
        }

        private bool IsExistById(object id)
        {
            throw new NotImplementedException();
        }

        public bool IsExistById(int Id)
        {
            return dbContext.Group.Any(x => x.Id == Id);
        }

        public void Update(GroupsService entity)
        {
            if (IsExist(entity))
            {
                Group Groups = Get(entity.Id);
                Groups.Name= entity.Name;
                dbContext.Group.Update(Group);
                dbContext.SaveChanges();
            }
        }

        private bool IsExist(GroupsService entity)
        {
            throw new NotImplementedException();
        }

        public void Add(GroupsService entity)
        {
            throw new NotImplementedException();
        }

        GroupsService IGenericCRUD<GroupsService>.Get(int id)
        {
            throw new NotImplementedException();
        }

        bool IValidation<GroupsService>.IsExist(GroupsService entity)
        {
            throw new NotImplementedException();
        }
    }
       
}

