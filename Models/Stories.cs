﻿using arageek.Common;
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
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Groups group { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User user { get; set; }

    }
}
