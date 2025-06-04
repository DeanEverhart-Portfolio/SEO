using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace SEO.Models
{
    public class Domain
    {
        public int Id { get; set; }

        [Display(Name = "Domain Name")]
        public string Name { get; set; }

        public string? Website { get; set; }

        public string? Protocol { get; set; }

        public string? Subdomain { get; set; }

        public string? Topleveldomain { get; set; }

        public string? Description { get; set; }

        public string? Type { get; set; }

        //public string Description { get; set; }

        //public string Type { get; set; }

        

        [ForeignKey("Contact")]
        public int? ContactId { get; set; }

        public Contact? Contact { get; set; }

        // __________________________________________

        public ICollection<Hog>? Hogs { get; set; }

        public ICollection<Ahref>? Ahrefs { get; set; }

        // __________________________________________

    }
}
