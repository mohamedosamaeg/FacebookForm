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
        Stories story = new Stories();
        [ForeignKey("StoryId")]
        public Groups Groups { get;  set; }

        public string UserId { get;  set; }
        
    }
}
