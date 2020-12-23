using System;
using System.ComponentModel.DataAnnotations;

namespace Magenic.DDD.EShop.SharedKernel.Customer
{
    /// <summary>
    /// Interface: Inter-Domain Customer
    /// </summary>
    public interface ICustomer
    {
        /// <summary>
        /// PK
        /// </summary>
        [Required]
        Guid CustomerId { get; set; }

        /// <summary>
        /// Person to contact
        /// </summary>
        IPerson Contact { get; set;  }

        /// <summary>
        /// Address: Shipping
        /// </summary>
        AddressBase ShippingAddress { get; set; }

        /// <summary>
        /// Customer Status
        /// </summary>
        CustomerStatusKind CustomerStatus { get; set; }

        /// <summary>
        /// Profile
        /// </summary>
        ICustomerProfile Profile { get; set; }

        /// <summary>
        /// Order List
        /// </summary>
        ICustomerOrder Orders { get; set; }

    }
}
