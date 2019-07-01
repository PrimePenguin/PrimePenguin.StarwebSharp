using System;
using System.Collections.Generic;
using System.Text;

namespace StarwebSharp.Entities
{
    public enum OrderItemModelDiscountType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"amount")]
        Amount = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"percent")]
        Percent = 1,

    }
}
