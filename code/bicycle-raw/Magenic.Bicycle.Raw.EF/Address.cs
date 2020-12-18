using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Magenic.Bicycle.Raw.EF
{
    public class Address
    {
        [Required]
        [StringLength(40)]
        public string Address1 { get; set; }
        [StringLength(40)]
        public string Address2 { get; set; }
        [StringLength(40)]
        public string Address3 { get; set; }
        [StringLength(40)]
        public string Address4 { get; set; }
        [Required]
        [StringLength(40)]
        public string City { get; set; }
        [Required]
        [StringLength(40)]
        public string StateOrProvence { get; set; }
        [Required]
        [StringLength(40)]
        public string PostalCode { get; set; }
    }
}
