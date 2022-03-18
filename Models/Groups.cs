using arageek.Common;
using facebook.Audits;
using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Models
{
    public class Groups :Audit
    {
        public List<Post> posts { get; set; }
        public List<Stories> Stories { get; set; }
        public List<User> users  { get; set; }
    }
}
