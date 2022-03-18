using facebook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Repository
{
    public interface IPostsRepository : IGenericCRUD<Post>, IValidation<Post>
    {
        List<Post> GetByGroupId(int groupId);
        List<Post> GetByUserId(int userId);
    }
}
