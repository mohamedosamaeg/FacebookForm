using facebook.Audits;
using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Models
{
    public class UserRole:Audit
    {
        
        public List<User> users { get; set; }
    }

    
}
