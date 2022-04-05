using facebook.Models;
using facebook.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
                dbContext.Warning.Add(entity);
                dbContext.SaveChanges();
            }
        }
        public bool IsExist(Warning entity)
        {
            if (!IsExistById(entity.Id))
            {
                return dbContext.Warning.Any(x => x.Name == entity.Name);
            }
            else
            {
                return true;
            }
        }
        public bool IsExistById(int Id)
        {
            return dbContext.Warning.Any(x => x.Id == Id);
        }


    }
}
    