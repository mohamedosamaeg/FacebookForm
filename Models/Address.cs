using facebook.Audits;

namespace facebook.Models
{
    public class Address :Audit
    {
        public string AddressName { get; set; }
        public string AddressIP { get; set; }
    }
}
