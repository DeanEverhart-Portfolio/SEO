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

        public string? Description { get; set; }

        public string? Type { get; set; }

        //public string Description { get; set; }

        //public string Type { get; set; }

        [ForeignKey("Clients")]
        public int ClientId { get; set; }

        public  Client? Clients { get; set; }

        // __________________________________________

        public ICollection<Hog>? Hogs { get; set; }

        public ICollection<Ahref>? Ahrefs { get; set; }

        // __________________________________________

    }
}
