using System;
using System.Collections.Generic;
using System.Text;

namespace Magenic.Bicycle.Raw.EF
{
    class OrderWithStatus : Order
    {
        public OrderStatus Status { get; set; }

        public Address DeliveryAddress { get; set; }
    }
}
