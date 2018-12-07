using System.Runtime.Serialization;

namespace StarwebSharp.Entities
{
    public enum WebHookModelEvent
    {
        [EnumMember(Value = "product-created")]
        ProductCreated = 0,

        [EnumMember(Value = "product-updated")]
        ProductUpdated = 1,

        [EnumMember(Value = "product-removed")]
        ProductRemoved = 2,

        [EnumMember(Value = "order-created")] OrderCreated = 3,

        [EnumMember(Value = "order-updated")] OrderUpdated = 4,

        [EnumMember(Value = "order-status-changes")]
        OrderStatusChanges = 5,

        [EnumMember(Value = "shop-opened")] ShopOpened = 6,

        [EnumMember(Value = "shop-closed")] ShopClosed = 7,

        [EnumMember(Value = "shop-removed")] ShopRemoved = 8
    }
}