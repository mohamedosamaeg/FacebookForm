using arageek.Common;
using facebook.Audits;
using System;
using System.Collections.Generic;
using System.Text;


namespace facebook.Models
{
    public class Stories : Audit
    { 
        public int Id { get; set; }
        public DateTime ExpiredTime { get; set; }
        public String StoryReply { get; set; }
        public object Name { get; internal set; }
    }
}
