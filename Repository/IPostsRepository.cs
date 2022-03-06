using facebook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Repository
{
    public interface IPostsRepository : IGenericCRUD<Posts>
    {
        void Likes(int Posts);
    }
}
