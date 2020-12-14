using System.Collections.Generic;
using winform_crud.DTO.Product;
using winform_crud.Repositories.Product;

namespace winform_crud.Controllers.Product
{
    public class ListProductController : BaseController
    {
        private readonly ListAllProductsRepository _listAllProductsRepository;

        public ListProductController()
        {
            _listAllProductsRepository = new ListAllProductsRepository();
        }

        public List<ProductDTO> Execute()
        {
            return _listAllProductsRepository.Execute();
        }
    }
}
