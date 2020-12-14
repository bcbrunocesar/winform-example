using winform_crud.Models;
using winform_crud.Repositories.OrderItems;

namespace winform_crud.Controllers.OrderItem
{
    public class AddOrderItemController : BaseController
    {
        private readonly AddOrderItemRepository _addOrderItemRepository;

        public AddOrderItemController()
        {
            _addOrderItemRepository = new AddOrderItemRepository();
        }

        public void Execute(OrderItemModel orderItemModel)
        {
            _addOrderItemRepository.Execute(orderItemModel);
        }
    }
}
