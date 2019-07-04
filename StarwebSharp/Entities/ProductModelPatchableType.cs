using System.Runtime.Serialization;

namespace StarwebSharp.Entities
{
    public enum ProductModelPatchableType
    {
        [EnumMember(Value = @"basic")] Basic = 0,

        [EnumMember(Value = @"bundle")] Bundle = 1
    }
}