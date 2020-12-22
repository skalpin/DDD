namespace Magenic.DDD.EShop.SharedKernel.Customer
{
    /// <summary>
    /// Kind: Customer Status
    /// </summary>
    public enum CustomerStatusKind
    {
        /// <summary>
        /// Visitor (not associated with a customer)
        /// </summary>
        NotLinked = 0,
        /// <summary>
        /// Linked to a Customer
        /// </summary>
        Linked = 1,
        /// <summary>
        /// Removed by the Company / System
        /// </summary>
        Removed = 2,
        /// <summary>
        /// Customer has opted out
        /// </summary>
        OptedOut = 3
    }
}
