using System.Runtime.Serialization;

namespace StarwebSharp.Enums
{
    public enum PaymentMethodModelValidForShippingMethods
    {
        [EnumMember(Value = "all")] All = 0,

        [EnumMember(Value = "selected")] Selected = 1
    }
}