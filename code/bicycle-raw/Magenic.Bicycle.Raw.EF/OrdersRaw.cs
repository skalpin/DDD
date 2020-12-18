using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Magenic.Bicycle.Raw.EF
{
    [Keyless]
    [Table("Orders-Raw", Schema = "etl")]
    public partial class OrdersRaw
    {
        [Column("EMail")]
        public string Email { get; set; }
        public long? ProductId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
