using System;

namespace winform_crud.DTO.OrderItems
{
    public class OrderItemDTO
    {
        public OrderItemDTO(Guid id, Guid orderId, Guid productId, string productName, double productPrice, DateTime orderDate)
        {
            Id = id;
            OrderId = orderId;
            ProductId = productId;            
            ProductName = productName;
            ProductPrice = productPrice;
            OrderDate = orderDate;
        }

        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }        
        public DateTime OrderDate { get; set; }
    }
}
