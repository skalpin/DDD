using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Magenic.Bicycle.Raw.EF
{
    [Table("Customer", Schema = "store")]
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        public long CustomerId { get; set; }
        [Required]
        [StringLength(255)]
        public string NameLast { get; set; }
        [Required]
        [StringLength(255)]
        public string NameFirst { get; set; }
        [StringLength(255)]
        public string Company { get; set; }
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
        [StringLength(40)]
        public string StateOrProvence { get; set; }
        [Required]
        [StringLength(40)]
        public string PostalCode { get; set; }
        [StringLength(15)]
        public string PhonePrimary { get; set; }
        [Required]
        [Column("EMail")]
        public string Email { get; set; }
        public bool? IsActive { get; set; }

        [InverseProperty(nameof(Order.Customer))]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
