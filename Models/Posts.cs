using facebook.Audits;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace facebook.Models
{
    public class Posts : Audit
    {
        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public Groups Groups { get; set; }

    }
}
    

