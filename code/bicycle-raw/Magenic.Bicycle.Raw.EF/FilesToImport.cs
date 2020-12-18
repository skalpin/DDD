using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Magenic.Bicycle.Raw.EF
{
    [Keyless]
    [Table("FilesToImport", Schema = "etl")]
    public partial class FilesToImport
    {
        public string FileNamePath { get; set; }
    }
}
