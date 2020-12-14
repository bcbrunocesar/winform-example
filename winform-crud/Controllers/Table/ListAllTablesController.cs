using System.Collections.Generic;
using winform_crud.DTO.Table;
using winform_crud.Repositories.Table;

namespace winform_crud.Controllers.Table
{
    public class ListAllTablesController : BaseController
    {
        private readonly ListAllTablesRepository _listAllTablesRepository;

        public ListAllTablesController()
        {
            _listAllTablesRepository = new ListAllTablesRepository();
        }

        public List<TableDTO> Execute()
        {
            return _listAllTablesRepository.Execute();
        }
    }
}
