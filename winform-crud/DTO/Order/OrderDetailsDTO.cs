using System;
using winform_crud.Models;

namespace winform_crud.DTO.Order
{
    public class OrderDetailsDTO
    {
        public OrderDetailsDTO() { }

        public OrderDetailsDTO(Guid id, Guid tableId, string tableNumber, string orderNumber, EOrderStatus status, DateTime openDate, DateTime? closingDate)
        {
            Id = id;
            TableId = tableId;
            TableNumber = tableNumber;
            OrderNumber = orderNumber;
            Status = status;
            OpenDate = openDate;
            ClosingDate = closingDate;
        }

        public Guid Id { get; set; }
        public Guid TableId { get; set; }
        public string TableNumber { get; set; }
        public string OrderNumber { get; set; }
        public EOrderStatus Status { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? ClosingDate { get; set; }
    }
}
