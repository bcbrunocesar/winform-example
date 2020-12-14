using System;

namespace winform_crud.Models
{
    public class OrderItemModel : BaseModel
    {
        public OrderItemModel(Guid productId, Guid orderId)
        {
            ProductId = productId;
            OrderId = orderId;
            OrderDate = DateTime.Now;
        }

        public Guid ProductId { get; private set; }
        public Guid OrderId { get; private set; }        
        public DateTime OrderDate { get; private set; }
        public ProductModel Produto { get; set; }
        public OrderModel Order { get; set; }
    }
}
