namespace winform_crud.Models
{
    public class TableModel : BaseModel
    {
        public TableModel(int number)
        {
            Number = number;
        }

        public int Number { get; private set; }

        public override string ToString()
        {
            return $"Mesa {Number}";
        }
    }
}
