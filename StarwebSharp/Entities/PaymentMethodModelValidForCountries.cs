using System.Runtime.Serialization;

namespace StarwebSharp.Entities
{
    public enum PaymentMethodModelValidForCountries
    {
        [EnumMember(Value = @"all")] All = 0,

        [EnumMember(Value = @"EU")] EU = 1,

        [EnumMember(Value = @"non-EU")] NonEU = 2,

        [EnumMember(Value = @"selected")] Selected = 3,

        [EnumMember(Value = @"none")] None = 4
    }
}