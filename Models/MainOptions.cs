using facebook.Audits;
using System.Collections.Generic;

namespace facebook.Models
{
    public class MainOptions :Audit
    {
        public List<MainOptions> Settings { get; set; }
    }
}