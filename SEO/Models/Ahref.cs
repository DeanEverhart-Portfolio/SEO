using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SEO.Models
{
    public class Ahref
    {
        public int Id { get; set; }

        // __________________________________ ahref specific fields ____________________________________

        public string domain { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Week Ending")]
        public DateTime? date { get; set; }

        [Required]
        [DisplayFormat(NullDisplayText = "Value")]
        public int? value { get; set; }

        public string? stringValue { get; set; }

        // _______________________________ ahref specific fields (end) __________________________________

        [ForeignKey("Domain")]
        public int? DomainId { get; set; }

        public virtual Domain? Domain { get; set; }

    }
}
