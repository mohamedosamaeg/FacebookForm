using facebook.Audits;
using facebook.Parent;
using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Models
{
    public class User :Human
    {
        internal readonly object userRole;

        public string UserName { get; set; }
        public string Password { get; set; }
        public object mobiles { get; internal set; }
    }
}

