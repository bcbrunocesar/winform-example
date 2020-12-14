using System;

namespace winform_crud.DTO.Table
{
    public class TableDTO
    {
        public TableDTO(Guid id, int number, bool isBusy)
        {
            Id = id;
            Number = number;
            IsBusy = isBusy;
        }

        public Guid Id { get; set; }
        public int Number { get; set; }
        public bool IsBusy { get; set; }
    }
}
