namespace Magenic.DDD.EShop.SharedKernel.Customer
{
    /// <summary>
    /// Kind: Customer Order Status
    /// </summary>
    public enum CustomerOrderStatusKind
    {
        /// <summary>
        /// Not an order yet
        /// </summary>
        Cart = 0,
        /// <summary>
        /// Associated to an order
        /// </summary>
        Order = 1,
        /// <summary>
        /// Abandoned
        /// </summary>
        Abandoned = 2,
        /// <summary>
        /// Purposely deleted
        /// </summary>
        Deleted = 3
    }
}
