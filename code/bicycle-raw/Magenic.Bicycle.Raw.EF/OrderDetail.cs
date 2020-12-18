using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Magenic.Bicycle.Raw.EF
{
    [Table("OrderDetail", Schema = "store")]
    public partial class OrderDetail
    {
        [Key]
        public long OrderDetailId { get; set; }
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        [Column(TypeName = "money")]
        public decimal CostEach { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(OrderId))]
        [InverseProperty("OrderDetails")]
        public virtual Order Order { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("OrderDetails")]
        public virtual Product Product { get; set; }
    }
}
