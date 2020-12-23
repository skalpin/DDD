using System;
using System.ComponentModel.DataAnnotations;

namespace Magenic.DDD.EShop.SharedKernel.Customer
{
    /// <summary>
    /// Base: Customer 
    /// </summary>
    public class CustomerBase : ICustomer
    {
        /// <summary>
        /// PK
        /// </summary>
        [Required]
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Person (Contact)
        /// </summary>
        public IPerson Contact { get; set; }

        /// <summary>
        /// Shipping Address
        /// </summary>
        public AddressBase ShippingAddress { get; set; }

        /// <summary>
        /// Customer Status
        /// </summary>
        public CustomerStatusKind CustomerStatus { get; set; }
        
        /// <summary>
        /// Customer Profile
        /// </summary>
        public ICustomerProfile Profile { get; set; }

        /// <summary>
        /// Customer Orders (partial, lazy)
        /// </summary>
        public ICustomerOrder Orders { get; set; }
    }
}
