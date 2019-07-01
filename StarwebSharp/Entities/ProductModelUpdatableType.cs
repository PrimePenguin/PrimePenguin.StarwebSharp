using System.Runtime.Serialization;

namespace StarwebSharp.Entities
{
    public enum ProductModelUpdatableType
    {
        [EnumMember(Value = @"basic")] Basic = 0,

        [EnumMember(Value = @"bundle")] Bundle = 1
    }
}