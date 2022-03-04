using facebook.Audits;
using facebook.Parent;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace facebook.Models
{
    public class User :Human
    {
        

        public string UserName { get; set; }
        public string Password  {get; set; }
        public int UserRoleId { get; set; }
        [ForeignKey("UserRoleId")]
        public  UserRole userRole  { get; set; }
        
        public string mobiles { get; set; }
    }
}

