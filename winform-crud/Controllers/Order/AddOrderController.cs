using winform_crud.Models;
using winform_crud.Repositories.Client;

namespace winform_crud.Controllers.Order
{
    public class AddOrderController : BaseController
    {
        private readonly AddOrderRepository _addClientRepository;

        public AddOrderController()
        {
            _addClientRepository = new AddOrderRepository();
        }

        public void Execute(OrderModel orderModel)
        {
            _addClientRepository.Execute(orderModel);
        }
    }
}
