using System;
using winform_crud.Models;

namespace winform_crud.Responses.Order
{
    public class OrderDTO
    {
        public OrderDTO() { }

        public OrderDTO(Guid id, string orderNumber, string tableNumber, EOrderStatus status, DateTime openDate, DateTime? closingDate)
        {
            Id = id;
            OrderNumber = orderNumber;
            TableNumber = tableNumber;
            Status = status;
            OpenDate = openDate;
            ClosingDate = closingDate;
        }

        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public string TableNumber { get; set; }
        public EOrderStatus Status { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? ClosingDate { get; set; }
    }
}
