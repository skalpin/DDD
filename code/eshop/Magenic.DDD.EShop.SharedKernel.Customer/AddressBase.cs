using System;
using System.ComponentModel.DataAnnotations;

namespace Magenic.DDD.EShop.SharedKernel.Customer
{
    /// <summary>
    /// Base: Address
    /// <para>
    /// Address Standard: <a href="https://www.upu.int">UN Universal Postal Union</a>
    /// </para>
    /// <para>
    /// By Convention all string (text) fields (address lines) have a maximum of 40 Unicode (UTF-8) characters
    /// </para>
    /// </summary>
    public class AddressBase
    {
        /// <summary>
        /// Unique Id for an Address
        /// </summary>
        public Guid AddressId { get; set; }

        /// <summary>
        /// <c>TO</c> line
        /// <example>
        /// <list type="bullet">
        /// <item>
        /// <term>Persons name</term>
        /// <description>John Smith</description>
        /// </item>
        /// <item>
        /// <term>Company name</term>
        /// <description>Flimco, Inc.</description>
        /// </item>
        /// </list>
        /// </example>
        /// </summary>
        [Required]
        [StringLength(maximumLength: 40, MinimumLength = 1)]
        public string To { get; set; }

        /// <summary>
        /// (optional) <c>CO</c> Care-Of line
        /// <example>
        /// <list type="bullet">
        /// <item>
        /// <term>Persons name</term>
        /// <description>John Smith</description>
        /// </item>
        /// </list>
        /// </example>
        /// </summary>
        [StringLength(maximumLength: 40, MinimumLength = 0)]
        public string CO { get; set; }

        /// <summary>
        /// Delivery Address
        /// </summary>
        [Required]
        [MaxLength(40)]
        public string Address1 { get; set; }

        /// <summary>
        /// (optional) Appt #, etc.
        /// </summary>
        [MaxLength(40)]
        public string Address2 { get; set; }

        /// <summary>
        /// (optional) Department, etc.
        /// </summary>
        [MaxLength(40)]
        public string Address3 { get; set; }

        /// <summary>
        /// (optional) Internal delivery code
        /// </summary>
        [MaxLength(40)]
        public string Address4 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [Required]
        [StringLength(maximumLength: 40, MinimumLength = 2)]
        public string City { get; set; }

        /// <summary>
        /// State or Province
        /// <example>
        /// <list type="bullet">
        /// <item>
        /// <term>State</term>
        /// <description>CA (USA: California)</description>
        /// </item>
        /// <item>
        /// <term>Province</term>
        /// <description>BC (Canada: British Columbia)</description>
        /// </item>
        /// </list>
        /// </example>
        /// </summary>
        [Required]
        [StringLength(maximumLength: 40, MinimumLength = 2)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// Postal Code In International Format
        /// <para>
        /// <a href="https://en.wikipedia.org/wiki/List_of_postal_codes" target="_blank">Wikipedia</a>
        /// </para>
        /// </summary>
        [Required]
        [StringLength(maximumLength: 40, MinimumLength = 1)]
        public string PostalCode { get; set; }

        /// <summary>
        /// (optional) Country or District
        /// <example>
        /// <list type="bullet">
        /// <item>
        /// <term>Country</term>
        /// <description>USA</description>
        /// </item>
        /// <item>
        /// <term>District</term>
        /// <description>Guam</description>
        /// </item>
        /// </list>
        /// </example>
        /// </summary>
        [MaxLength(40)]
        public string CountryOrDistrict { get; set; }

        /// <summary>
        /// Kind: Address
        /// </summary>
        [Required]
        public AddressKind AddressKind { get; set; } = AddressKind.Mailing;

        /// <summary>
        /// Geo-Location
        /// </summary>
        public GeoLocation Location { get; set; } = default;
    }
}
