using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Magenic.Bicycle.Raw.EF
{
    [Table("Configuration", Schema = "common")]
    public partial class Configuration
    {
        [Key]
        [StringLength(255)]
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
