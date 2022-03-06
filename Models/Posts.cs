﻿using facebook.Audits;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace facebook.Models
{
    public class Posts : Audit
    {
        public string PostsLink { get; set; }
        [ForeignKey("PostsLink")]
        public Posts Post { get; set; }
    }
}
