using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Magenic.Bicycle.Raw.EF
{
    [Table("ErrorLog", Schema = "common")]
    public partial class ErrorLog
    {
        [Key]
        public long ErrorLogId { get; set; }
        [Required]
        [StringLength(255)]
        public string Step { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}
