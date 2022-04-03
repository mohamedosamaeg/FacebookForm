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
        
        }

       
}
    