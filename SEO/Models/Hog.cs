using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;


namespace SEO.Models
{
    public class Hog
    {
        public int Id { get; set; }

        // __________________________________ hog2 specific fields ____________________________________

        // _____ run _____

        [Display(Name = "Html")]
        public int? run { get; set; } // run

        [Display(Name = "Run")]
        public string? stringRun { get; set; } // run

        [Display(Name = "Rerun")]
        public bool? rerun { get; set; }

        [Display(Name = "Rerun")]
        public string? stringRerun { get; set; }

        [Display(Name = "Run")]
        public string? fullRun
        {
            get
            {
                return stringRun + " " + stringRerun;
            }
        }

        // _____________________ Color Coded Fields __________________________
        
        [Display(Name = "Run")]
        public int? IntField1 { get; set; }

        [Display(Name = "ReRun")]
        public string? StringField1 { get; set; }

        [Display(Name = "Checked")]
        public bool? BoolField1 { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Sent")]
        public DateTime? DateField1 { get; set; }

        [Display(Name = "Template")]
        public int? IntField2 { get; set; }

        [Display(Name = "Keyword")]
        public string? StringField2 { get; set; }

        [Display(Name = "CSV")]
        public bool? BoolField2 { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Received")]
        public DateTime? DateField2 { get; set; }

        [Display(Name = "Build")]
        public int? IntField3 { get; set; }

        [Display(Name = "Review")]
        public string? StringField3 { get; set; }

        [Display(Name = "Hero")]
        public bool? BoolField3 { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Export")]
        public DateTime? DateField3 { get; set; }

        // __________________ Color Coded Fields (end) __________________________


        // _____ template _____

        [Display(Name = "Template")]
        public int? template { get; set; } // template number

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateTemplate")]
        public DateTime? dateTemplate { get; set; }

        // _____ location _____

        [Display(Name = "Location")]
        public string? location { get; set; } // template location

        // ___________________

        [Display(Name = "Template / Location")]
        public string? fullTemplate
        {
            get
            {
                return template + " " + location;
            }
        }

        // _____ keyword _____

        [Display(Name = "CSV")]
        public bool? keyword { get; set; } // CSV & Keyword.com- Make CSV file for import and add town keywords to serpbook for master service

        [Display(Name = "Keyword")]
        public string? stringKeyword { get; set; } // master keyword - run relationshp?

        public string? stringKeyword1 { get; set; } // master keyword


        // _____ content _____

        [Display(Name = "Sent")]
        public bool? content { get; set; } // sent out for content

        [Display(Name = "Received")]
        public bool? content1 { get; set; } // received

        [Display(Name = "Checked")]
        public bool? content2 { get; set; } // checked


        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Sent")]
        public DateTime? dateContent { get; set; } // sent

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Writer")]
        public DateTime? dateContent1 { get; set; } // writer

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Received")]
        public DateTime? dateContent2 { get; set; } // received

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Checked")]
        public DateTime? dateContent3 { get; set; } // checked

        [Display(Name = "Writer")]
        public string? stringContent { get; set; } // writer - content given to

        [Display(Name = "Writer")]
        public string? fullWriter
        {
            get
            {
                return stringContent + " " + dateContent1;
            }
        }

        // ___ content (end) _____

        // _____ html _____

        [Display(Name = "Html")]
        public bool? html { get; set; } // converted word to html // HTML - converted word to html

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateHtml")]
        public DateTime? dateHtml { get; set; } // converted word to html // HTML - converted word to html

        // _____ meta _____

        [Display(Name = "Meta")]
        public bool? meta { get; set; } // Meta Descriptions made - Write it in https://wordcounter.net/ or the metamaker to count characters. Put name of person who wrote it in cell.

        [Display(Name = "Meta")]
        public string? stringMeta { get; set; } // Meta Descriptions made - Write it in https://wordcounter.net/ or the metamaker to count characters. Put name of person who wrote it in cell.

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateMeta")]
        public DateTime? dateMeta { get; set; } // Meta Descriptions made - Write it in https://wordcounter.net/ or the metamaker to count characters. Put name of person who wrote it in cell.

        [Display(Name = "Meta")]
        public string? fullMeta
        {
            get
            {
                return meta + " " + stringMeta;
            }
        }


        // _____ seo _____

        [Display(Name = "SEO")]
        public bool? seo { get; set; } // SEO completed on website

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateSeo")]
        public DateTime? dateSeo { get; set; } // SEO completed on website


        // _____ plugin _____

        [Display(Name = "Plugin")]
        public bool? plugin { get; set; } // Plugins - Damian - installed wp all import and seo plugin

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "datePlugin")]
        public DateTime? datePlugin { get; set; } // Plugins - Damian - installed wp all import and seo plugin

        // _____ hero _____

        [Display(Name = "Hero")]
        public bool? hero { get; set; } // Hero Slider(s)- make 1 Hero/homepage slider

        [Display(Name = "Hero")]
        public bool? hero1 { get; set; } // Review Slider - Make it

        [Display(Name = "Review")]
        public string? stringHero { get; set; } // Review Slider - Make it

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateHero")]
        public DateTime? dateHero { get; set; } // Review Slider - Make it

        // _____ backup _____

        [Display(Name = "Backup")]
        public bool? backup { get; set; }

        public string? stringBackup { get; set; } // Backups - Damian - Site Backup made - 2 of each site

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateBackup")]
        public DateTime? dateBackup { get; set; } // Backups - Damian - Site Backup made - 2 of each site

        // _____ build / export _____

        [Display(Name = "Build")]
        public bool? buildExport { get; set; } // Build & Export HOG

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Build")]
        public DateTime? dateBuildExport { get; set; } // Build & Export HOG

        [Display(Name = "Build")]
        public string? stringBuildExport { get; set; } // Build & Export HOG

        [Display(Name = "Build / Export")]
        public string? fullBuildExport
        {
            get
            {
                return buildExport + " " + dateBuildExport + " " + stringBuildExport;
            }
        }

        // _____ build / export (end) _____


        public bool? hog1 { get; set; } // Post-hog - disable comments on ALL pages, sitemap updated, robots checked, submitted to GSC and recrawled/re-indexed.Check Pages - 404's checked and fixed, cache flushed and re-made, at least 1 pages from EACH template is checked

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateHog")]
        public DateTime? dateHog { get; set; } // Post-hog - disable comments on ALL pages, sitemap updated, robots checked, submitted to GSC and recrawled/re-indexed.Check Pages - 404's checked and fixed, cache flushed and re-made, at least 1 pages from EACH template is checked

        public string? stringHog { get; set; } // Post-hog - disable comments on ALL pages, sitemap updated, robots checked, submitted to GSC and recrawled/re-indexed.Check Pages - 404's checked and fixed, cache flushed and re-made, at least 1 pages from EACH template is checked

        // _____ post _____

        [Display(Name = "Post")]
        public bool? post { get; set; }

        public string? stringPost { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "datePost")]
        public DateTime? datePost { get; set; }


        // _____ site _____

        [Display(Name = "Review")]
        public bool? site { get; set; } // Review - Was this site reviewed on Friday... Check design of HOG Slider and mobile.Mobile Responsiveness checker and Speed Test

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateSite")]
        public DateTime? dateSite { get; set; } // Review - Was this site reviewed on Friday... Check design of HOG Slider and mobile.Mobile Responsiveness checker and Speed Test

        public string? stringSite { get; set; } // Review - Was this site reviewed on Friday... Check design of HOG Slider an

        // _____ dev _____

        [Display(Name = "Dev")]
        public bool? dev { get; set; } //    dev website (empty)

        public int? hogOld { get; set; }


        // ________________________________ hog specific fields (end) _________________________________

        [ForeignKey("Domain")]
        public int DomainId { get; set; }

        public virtual Domain? Domain { get; set; }
    }
}