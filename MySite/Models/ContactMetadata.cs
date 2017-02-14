using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MySite.Models {
    [MetadataType(typeof(Contact.Metadata))]
    public partial class Contact {
        sealed class Metadata {
            [Key]
            public System.Guid ContactID { get; set; }

            [Required]
            public string Name { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string Address { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string City { get; set; }

            public int? State { get; set; }

            [Required]
            public string Phone { get; set; }

            [Required]
            public string Email { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string Notes { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$", ErrorMessage = "Please enter a valid 5 digit zip code.")]
            public string Zipcode { get; set; }
        }
    }
}