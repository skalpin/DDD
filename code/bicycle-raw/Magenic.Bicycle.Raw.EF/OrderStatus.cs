using System;
using System.Collections.Generic;
using System.Text;

namespace Magenic.Bicycle.Raw.EF
{
    public enum OrderStatus
    {
        New = 0,
        Confirmed = 1,
        InProcess = 2,
        Done = 3,
        Aborted = 4
    }
}
