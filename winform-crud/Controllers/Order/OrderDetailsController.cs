using System;
using winform_crud.DTO.Order;
using winform_crud.Repositories.Order;

namespace winform_crud.Controllers.Order
{
    public class OrderDetailsController : BaseController
    {
        private readonly OrderDetailsRepository _orderDetailsRepository;

        public OrderDetailsController()
        {
            _orderDetailsRepository = new OrderDetailsRepository();
        }

        public OrderDetailsDTO Execute(Guid id)
        {
            return _orderDetailsRepository.Execute(id);
        }
    }
}
