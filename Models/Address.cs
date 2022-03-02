using facebook.Audits;
using facebook.Parent;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace facebook.Models
{
    public class Address :Audit
    {
        public int AddressId { get; set; }
       
        
    }
}
