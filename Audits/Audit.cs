using arageek.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Audits
{
    public class Audit :Base
    {
            public DateTime CreatedDate { get; set; }
            public DateTime ModifiedDate { get; set; } = DateTime.Now;
       
    }
}
