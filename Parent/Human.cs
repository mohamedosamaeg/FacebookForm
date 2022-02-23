using facebook.Audits;
using System;
using System.Collections.Generic;
using System.Text;

namespace facebook.Parent
     {
    public abstract class Humen : Audit
    {
        public Humen()
        {
            FullName=$"{FirstName} {LastName}";
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public List<Address> addresses { get; set; }
        public string FullName;

    }

}
