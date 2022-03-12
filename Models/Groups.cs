using arageek.Common;
using facebook.Audits;
using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Models
{
    public class Groups :Audit
    {
        Posts post = new Posts();
        Stories stories = new Stories();
        public List<Posts> posts { get; set; }
        public List<Stories> Stories { get; set; }
        
      
    }
}
