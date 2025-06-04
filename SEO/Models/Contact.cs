using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SEO.Models
{
    public class Contact
    {
        public int ID { get; set; }

        // __________________________________ contact specific fields ____________________________________

        //[Required]
        [Display(Name = "First Name")]
        //[DisplayFormat(NullDisplayText = "First Name")]
        public string? FirstName { get; set; }

        //[Required]
        [Display(Name = "Last Name")]
        //[DisplayFormat(NullDisplayText = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Name")]
        public string? FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string? Company { get; set; }


        [Display(Name = "Company")]
        public string ContactPdm
        {
            get { return LastName + ", " + Company; }
        }

        public string? Department { get; set; }

        public string? JobTitle { get; set; }

        public string? Phone1 { get; set; }

        [Display(Name = "Phone 1")]
        public string? Phone1Full
        {
            get
            {
                return PhoneLabel + ": " + Phone1;
            }
        }

        public string? Phone2 { get; set; }

        [Display(Name = "Phone 2")]
        public string? Phone2Full
        {
            get
            {
                return Phone2Label + ": " + Phone2;
            }
        }

        public string? Phone3 { get; set; }

        [Display(Name = "Phone 3")]
        public string? Phone3Full
        {
            get
            {
                return Phone3Label + ": " + Phone3;
            }
        }

        // __________________________________

        public string? Company2 { get; set; }

        public string? Company3 { get; set; }

        public string? MiddleName { get; set; }

        public string? FirstNamePreference { get; set; }

        public string? Pronouns { get; set; }

        // ____________ phone _____________

        public string? AreaCode { get; set; }

        public string? Prefix { get; set; }

        public string? Line { get; set; }

        public string? Extension { get; set; }

        public string? PhoneLabel { get; set; }

        [Display(Name = "Gate Keeper")]
        public string? Gatekeeper { get; set; }

        [Display(Name = "Note")]
        public string? GatekeeperNote { get; set; }

        [Display(Name = "Note")]
        public string? PhoneNote { get; set; }

        public string? PhoneSort { get; set; }

        [Display(Name = "Phone")]
        public string? FullPhone
        {
            get
            {
                return PhoneLabel + " " + " " + " " + "(" + AreaCode + ")" + " " + Prefix + "-" + Line + " " + " " + Extension;
            }
        }

        // ____________ phone2 ________________

        public string? AreaCode2 { get; set; }

        public string? Prefix2 { get; set; }

        public string? Line2 { get; set; }

        public string? Extension2 { get; set; }

        public string? Phone2Label { get; set; }

        public string? Gatekeeper2 { get; set; }

        public string? Gatekeeper2Note { get; set; }

        [Display(Name = "Note")]
        [DisplayFormat(NullDisplayText = "Note")]
        public string? Phone2Note { get; set; }

        public string? Phone2Sort { get; set; }

        public string? FullPhone2
        {
            get
            {
                return Phone2Label + " " + " " + " " + "(" + AreaCode2 + ")" + " " + Prefix2 + " " + Line2 + " " + Extension2;
            }
        }

        // ____________ phone3 ________________

        public string? AreaCode3 { get; set; }

        public string? Prefix3 { get; set; }

        public string? Line3 { get; set; }

        public string? Extension3 { get; set; }

        public string? Phone3Label { get; set; }

        public string? Gatekeeper3 { get; set; }

        public string? Gatekeeper3Note { get; set; }

        [Display(Name = "Note")]
        [DisplayFormat(NullDisplayText = "Note")]
        public string? Phone3Note { get; set; }

        public string? Phone3Sort { get; set; }

        public string? FullPhone3
        {
            get
            {
                return Phone3Label + " " + Prefix3 + " " + Line3 + " " + Extension3;
            }
        }

        //_________ phone (end) __________

        //__________ email __________

        [Display(Name = "Email")]
        //[DisplayFormat(NullDisplayText = "Email")]
        public string? Email { get; set; }

        public string? EmailLabel { get; set; }

        public string? EmailSort { get; set; }

        // ----------------

        public string? Email2 { get; set; }

        public string? Email21Label { get; set; }

        public string? Email2Sort { get; set; }

        // ----------------

        public string? Email3 { get; set; }

        public string? Email2Label { get; set; }

        public string? Email3Sort { get; set; }

        //__________ email (end) __________

        // __________ website _____________

        [Display(Name = "Domain")]
        public string? Domain { get; set; }

        [Display(Name = "DNS")]
        public string? Domain1 { get; set; }

        // __________ website _____________
        [Display(Name = "Website")]
        [DisplayFormat(NullDisplayText = "Website")]
        public string? Website { get; set; }

        public string? WebsiteLabel { get; set; }

        public string? Website2 { get; set; }

        public string? Website2Label { get; set; }

        public string? Website3 { get; set; }

        public string? Website3Label { get; set; }

        // _______ website (end) __________

        // _________ address __________

        public string? StreetNumber { get; set; }

        public string? StreetName { get; set; }

        public string? StreetDesignator { get; set; }

        public string? Street2 { get; set; }

        public string? TownCity { get; set; }

        public string? State { get; set; }

        public string? ZipCode { get; set; }

        public string? County { get; set; }

        public string? Country { get; set; }

        public string? Map { get; set; }

        [Display(Name = "Address")]
        [DisplayFormat(NullDisplayText = "Address")]
        public string? FullAddress
        {
            get
            {
                return StreetNumber + " " + StreetName + " " + StreetDesignator + " " + Street2 + ", " + TownCity + ", " + ZipCode;
            }
        }

        // _________ address (end) __________

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime? Doh { get; set; }

        [Display(Name = "Hold")]
        public bool? Hold { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hold Date")]
        public DateTime? DateHold { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Separation Date")]
        public DateTime? Dos { get; set; }

        // _______________________________ contact specific fields (end) ________________________________

        public string? Tier1 { get; set; }

        public string? Rank1 { get; set; }

        // ______________________________________________ internal fields _______________________________________________

        // _______________ record __________________

        public bool? RecordFlag { get; set; }

        public string? RecordFlagString { get; set; }

        public bool? RecordFlag1 { get; set; }

        public string? RecordFlag1String { get; set; }

        public string? RecordNote { get; set; }

        public string? RecordNote1 { get; set; }

        public bool? RecordSelect { get; set; }

        public bool? RecordSelect1 { get; set; }


        // ___________ recordCreated _______________

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Record Creation Date")]
        public DateTime? RecordCreated { get; set; }

        //// ___________ recordInactive _______________

        [Display(Name = "Record Inactive")]
        public bool? RecordInactive { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Record Inactive Date")]
        public DateTime? RecordDateInactive { get; set; }

        [Display(Name = "Client")]
        public bool IsClient { get; set; }

        // ___________________________________ internal fields (end) ___________________________________

        // _____________________________________________________________________________________________
        
        public List<ContactClient>? ContactClients { get; set; }
        public List<Domain>? Domains { get; set; }

        // _____________________________________________________________________________________________


        //[NotMapped] public Client? Client { get; set; }

    }
}
