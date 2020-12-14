using System.Collections.Generic;
using winform_crud.Repositories.Client;
using winform_crud.Responses.Order;

namespace winform_crud.Controllers.Order
{
    public class ListOrderController : BaseController
    {
        private readonly ListAllOrdersRepository _listAllOrdersRepository;

        public ListOrderController()
        {
            _listAllOrdersRepository = new ListAllOrdersRepository();
        }

        public List<OrderDTO> Execute()
        {
            return _listAllOrdersRepository.Execute();
        }
    }
}
