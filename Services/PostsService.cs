using facebook.Models;
using facebook.Repository;
using System;
using System.Collections.Generic;
using System.Linq;



namespace facebook.Services
{

    public class PostsService : IPostsRepository
    {
        FacebookDbContext DbContext = new FacebookDbContext();
        public void Add(Post entity)
        {
            if (!IsExist(entity))
            {
                entity.CreatedDate = DateTime.Now;
                DbContext.Post.Add(entity);
                DbContext.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            if (IsExistById(Id))
            {
                DbContext.Post.Remove(Get(Id));
                DbContext.SaveChanges();
            }
        }

        public Post Get(int id)
        {
            if (IsExistById(id))
            {
                return DbContext.Post.Where(x => x.Id == id).SingleOrDefault();
            }
            return null;
        }

        public List<Post> Get()
        {
            return DbContext.Post.ToList();
        }

        public bool IsExist(Post entity)
        {
            if (!IsExistById(entity.Id))
            {
                return DbContext.Post.Any(x => x.Name == entity.Name);
            }
            else
            {
                return true;
            }
        }

        public bool IsExistById(int Id)
        {
            return DbContext.Post.Any(x => x.Id == Id);
        }

        public void Update(Post entity)//complete 
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

