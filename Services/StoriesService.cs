using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using facebook.Models;
using facebook.Repository;

namespace facebook.Services
{
    public class StoriesService : IStoriesRepository
    {
        FacebookDbContext dbContext = new FacebookDbContext();
        public void Add(Stories entity)
        {
            if (!IsExist(entity))
            {
                entity.CreatedDate = DateTime.Now;
                dbContext.Story.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            if (IsExistById(Id))
            {
                dbContext.Story.Remove(Get(Id));
                dbContext.SaveChanges();
            }
        }

        public Stories Get(int id)
        {
            if (IsExistById(id))
            {
                return dbContext.Story.Where(x => x.Id == id).SingleOrDefault();
            }
            return null;
        }

        public List<Stories> Get()
        {
            return dbContext.Story.ToList();
        }

        public bool IsExist(Stories entity)
        {
            if (!IsExistById(entity.Id))
            {
                return dbContext.Story.Any(x => x.Name == entity.Name);
            }
            else
            {
                return true;
            }
        }

        public bool IsExistById(int Id)
        {
            return dbContext.Story.Any(x => x.Id == Id);
        }

        public void Update(Stories entity)
        {
            throw new NotImplementedException();
        }
    }
}
