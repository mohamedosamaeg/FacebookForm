using facebook.Models;
using facebook.Repository;
using System;
using System.Collections.Generic;
using System.Linq;



namespace facebook.Services
{

    public class PostsService : IGenericCRUD<Posts>, IValidation<Posts>
    {
        FacebookDbContext DbContext = new FacebookDbContext();
        public void Add(Posts entity)
        {
            if (!IsExist(entity))
            {
                entity.CreatedDate = DateTime.Now;
                DbContext.Story.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            if (IsExistById(Id))
            {
                DbContext.Post.Remove(Get(Id));
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

        public List<Posts> Get()
        {
            return dbContext.Story.ToList();
        }

        public bool IsExist(Posts entity)
        {
            if (!IsExistById(entity.Id))
            {
                return dbContext.Post.Any(x => x.Name == entity.Name);
            }
            else
            {
                return true;
            }
        }

        public bool IsExistById(int Id)
        {
            return dbContext.Post.Any(x => x.Id == Id);
        }

        public void Edite(Stories entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Posts entity)
        {
            throw new NotImplementedException();
        }

        Posts IGenericCRUD<Posts>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}

