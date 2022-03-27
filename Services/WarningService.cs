using facebook.Models;
using facebook.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Services
{
    public class WarningService :IwarningRepository
    {
        FacebookDbContext dbContext = new FacebookDbContext();
        public void Add(Warning entity)
        {
            if (!IsExist(entity))
            {
                entity.CreatedDate = DateTime.Now;
                DbContext.Warning.Add(entity);
                DbContext.SaveChanges();
            }
        }

        private bool IsExist(Warning entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            if (IsExistById(Id))
            {
                DbContext.Warning.Remove(Get(Id));
                DbContext.SaveChanges();
            }
        }

        public Post Get(int id)
        {
            if (IsExistById(id))
            {
                return DbContext.Warning.Where(x => x.Id == id).SingleOrDefault();
            }
            return null;
        }

        public List<Post> Get()
        {
            return DbContext.Warning.ToList();
        }

        public bool IsExist(Post entity)
        {
            if (!IsExistById(entity.Id))
            {
                return DbContext.Warning.Any(x => x.Name == entity.Name);
            }
            else
            {
                return true;
            }
        }

        public bool IsExistById(int Id)
        {
            return DbContext.Warning.Any(x => x.Id == Id);
        }

        public void Update(Post entity) 
        {
            throw new NotImplementedException();
        }

        public List<Post> GetByGroupId(int groupId)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
    