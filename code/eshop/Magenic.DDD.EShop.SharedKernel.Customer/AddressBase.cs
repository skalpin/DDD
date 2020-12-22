namespace Magenic.DDD.EShop.SharedKernel.Customer
{
    /// <summary>
    /// Abstact Base: Address
    /// </summary>
    public abstract class AddressBase
    {
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
        public string CO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address1 { get; set; }

        public string Address2 { get; set; }
        
        public string Address3 { get; set; }
        
        public string Address4 { get; set; }
        
        public string City { get; set; }
        
        public string StateOrProvence { get; set; }
        
        public string PostalCode { get; set; }
        
        public string CountryOrDistrict { get; set; }

    }
}
