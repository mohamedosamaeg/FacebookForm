using arageek.Common;
using facebook.Audits;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace facebook.Models
{
    public class Stories : Audit
    { 
        
        public int StoryId { get; set; }
        public DateTime ExpiredTime { get; set; }
        public String StoryReply { get; set; }
        [ForeignKey("StoryId")]
        public Groups Groups { get;  set; }

        public string StoryOwner { get;  set; }
        public string Isplay { get;  set; }
    }
}
