using facebook.Audits;
using System.Collections.Generic;

namespace facebook.Models
{
    public class ProfileSettings : Audit
    {
        public List<ProfileSettings> Settings { get; set; }
    }
}