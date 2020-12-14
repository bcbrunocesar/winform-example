using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace winform_crud.Models
{
    public class OrderModel : BaseModel
    {
        public OrderModel(Guid tableId)
        {
            TableId = tableId;
            Number = OrderNumberGenerator();
            Status = EOrderStatus.Open;
            OpenDate = DateTime.Now;
        }

        private OrderModel() { }

        public Guid TableId { get; private set; }
        public string Number { get; private set; }
        public EOrderStatus Status { get; private set; }
        public DateTime OpenDate { get; private set; }
        public DateTime? ClosingDate { get; private set; }
        public TableModel Table { get; private set; }
        public List<OrderItemModel> Orders { get; private set; }

        public void AddOrderItem(OrderItemModel orderItemModel)
        {
            Orders.Add(orderItemModel);
        }

        public void RemoveOrderItem(Guid orderItemId)
        {
            var itemToBeRemoved = Orders.FirstOrDefault(x => x.Id == orderItemId);
            Orders.Remove(itemToBeRemoved);
        }

        public void CloseOrder()
        {
            ClosingDate = DateTime.Now;
            Status = EOrderStatus.Closed;
        }

        public void ReOpenOrder()
        {
            ClosingDate = default;
            Status = EOrderStatus.Open;
        }

        public override string ToString()
        {
            return $"Comanda {Number}, {Status}";
        }

        private string OrderNumberGenerator()
        {
            return Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
        }

        public class Factory : BaseModel
        {
            public static OrderModel Load(Guid id, Guid tableId, string number, EOrderStatus status, DateTime openDate, DateTime? closingDate)
            {
                return new OrderModel()
                {
                    Id = id,
                    TableId = tableId,
                    Number = number,
                    Status = status,
                    OpenDate = openDate,
                    ClosingDate = closingDate
                };
            }
        }
    }

    public enum EOrderStatus
    {
        [Display(Name = "Fechado")]
        Closed,

        [Display(Name = "Aberto")]
        Open,

        [Display(Name = "Cancelado")]
        Canceled
    }
}
