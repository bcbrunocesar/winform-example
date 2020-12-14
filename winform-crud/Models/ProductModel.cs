using System;
using System.ComponentModel.DataAnnotations;

namespace winform_crud.Models
{
    public class ProductModel : BaseModel
    {
        public ProductModel(string name, double value, EProductStatus status)
        {
            Name = name;
            Value = value;
            Status = status;
            RegisterDate = DateTime.Now;
        }

        public string Name { get; private set; }
        public double Value { get; private set; }
        public EProductStatus Status { get; private set; }
        public DateTime RegisterDate { get; private set; }
        public DateTime? LastUpdate { get; private set; }

        public void MakeProductAvailable()
        {
            Status = EProductStatus.Available;
            LastUpdate = DateTime.Now;
        }

        public void MakeProductUnavailable()
        {
            Status = EProductStatus.Unavailable;
            LastUpdate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Produto {Name}, {Status}";
        }
    }

    public enum EProductStatus
    {
        [Display(Name = "Disponível")]
        Available,

        [Display(Name = "Indisponível")]
        Unavailable
    }
}
