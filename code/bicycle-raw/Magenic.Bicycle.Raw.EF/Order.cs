using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Magenic.Bicycle.Raw.EF
{
    [Table("Order", Schema = "store")]
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public long OrderId { get; set; }
        public long CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool? IsActive { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("Orders")]
        public virtual Customer Customer { get; set; }
        [InverseProperty(nameof(OrderDetail.Order))]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
