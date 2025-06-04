using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace SEO.Models
{
    public class ContactClient
    {
        public int Id { get; set; }

        public int ContactId { get; set; }


        [ForeignKey("Contact")]
        public virtual Contact? Contacts { get; set; }


        //[ForeignKey("Clients")]
        //public int ClientId { get; set; }

        //public virtual Client? Clients { get; set; }
    }
}
