using System;
using winform_crud.DTO.Order;
using winform_crud.Models;
using winform_crud.Repositories.Order;

namespace winform_crud.Controllers.Order
{
    public class CloseOrderController : BaseController
    {
        private readonly CloseOrderRepository _closeOrderRepository;
        private readonly OrderDetailsRepository _orderDetailsRepository;

        public CloseOrderController()
        {
            _closeOrderRepository = new CloseOrderRepository();
            _orderDetailsRepository = new OrderDetailsRepository();
        }

        public void Execute(Guid id)
        {
            OrderDetailsDTO orderDetailsDTO = _orderDetailsRepository.Execute(id);
            if (orderDetailsDTO is null) return;

            OrderModel orderModel = OrderModel.Factory.Load(
                orderDetailsDTO.Id,
                orderDetailsDTO.TableId,
                orderDetailsDTO.OrderNumber,
                orderDetailsDTO.Status,
                orderDetailsDTO.OpenDate,
                orderDetailsDTO.ClosingDate
            );
            
            if (orderModel.Status != EOrderStatus.Open) return;
            orderModel.CloseOrder();

            _closeOrderRepository.Execute(orderModel);
        }
    }
}
