using facebook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Repository
{
    public interface IStoriesRepository : IGenericCRUD<Stories>
    {
        void Active(int stories);
    }
}
