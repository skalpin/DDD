using System;
using System.ComponentModel.DataAnnotations;

namespace Magenic.DDD.EShop.SharedKernel.Customer
{
    /// <summary>
    /// Interface: SKU / PRoduct
    /// </summary>
    public interface ISku
    {
        /// <summary>
        /// PK
        /// </summary>
        [Required]
        Guid ProductId { get; set; }

        /// <summary>
        /// SKU as scanned
        /// <para>Length: 4-32</para>
        /// </summary>
        [Required]
        [StringLength(maximumLength: 32, MinimumLength = 4)]
        string SKU { get; set; }

        /// <summary>
        /// Product Title (Label)
        /// <para>Length: 2-128</para>
        /// </summary>
        [Required]
        [StringLength(maximumLength: 128, MinimumLength = 2)]
        string Title { get; set; }

        /// <summary>
        /// In Kilograms (Metric)
        /// <para>Range: 0 - 200 Kg</para>
        /// </summary>
        [Required]
        [Range(0.0, 200.0)]
        decimal Weight { get; set; }
    }
}
