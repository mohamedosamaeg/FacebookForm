using facebook.Audits;
using System;
using System.Collections.Generic;
using System.Text;
using facebook.Models;

namespace facebook.Parent
     {
    public abstract class Human : Audit
    {
        public Human()
        {
            FullName=$"{FirstName} {LastName}";
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }  
        public DateTime BirthDay { get; set; }
        public List<Address> addresses { get; set; }
        public string FullName;

    }

}
