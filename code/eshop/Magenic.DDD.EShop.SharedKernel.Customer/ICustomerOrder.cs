using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magenic.DDD.EShop.SharedKernel.Customer
{
    /// <summary>
    /// Interface: Customer Order
    /// </summary>
    public interface ICustomerOrder
    {
        /// <summary>
        /// FK: Customer
        /// </summary>
        [Required]
        Guid CustomerId { get; set; }

        /// <summary>
        /// PK: Order
        /// </summary>
        [Required]
        Guid OrderId { get; set; }

        /// <summary>
        /// Order Date
        /// </summary>
        DateTime OrderDate { get; set; } 

        /// <summary>
        /// Order Status
        /// </summary>
        CustomerOrderStatusKind OrderStatus { get; set; }

        /// <summary>
        /// Order Items
        /// </summary>
        IEnumerable<ISku> OrderItems { get; set; }

    }
}
