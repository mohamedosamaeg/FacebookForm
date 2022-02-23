using arageek.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Models
{
    public class story: Base
    {
        public DateTime ExpiredTime { get; set; }
        public String StoryReply { get; set; }
    }
}
