using System;
using System.Collections.Generic;
using winform_crud.DTO.OrderItems;
using winform_crud.Repositories.OrderItems;

namespace winform_crud.Controllers.OrderItem
{
    public class ListOrderItemsController : BaseController
    {
        private readonly ListAllOrderItemsRepository _listAllOrderItemRepository;

        public ListOrderItemsController()
        {
            _listAllOrderItemRepository = new ListAllOrderItemsRepository();
        }

        public List<OrderItemDTO> Execute(Guid orderId)
        {
            return _listAllOrderItemRepository.Execute(orderId);
        } 
    }
}
