using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magenic.DDD.EShop.SharedKernel.Customer
{
    /// <summary>
    /// Interface: Customer Profile
    /// </summary>
    public interface ICustomerProfile
    {
        /// <summary>
        /// PK: Customer
        /// </summary>
        [Required]
        Guid CustomerId { get; set; }

        /// <summary>
        /// Key Value Pairs as a Dictionary
        /// </summary>
        IDictionary<string,string> ProfileKeyValues { set; get; }

    }
}
