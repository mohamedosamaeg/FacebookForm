using facebook.Audits;
using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Models
{
    public class UserRole:Audit
    {
        public string Name { get; set; }
    }

}
