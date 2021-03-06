﻿using System;

namespace winform_crud.DTO.Product
{
    public class ProductDTO
    {
        public ProductDTO(Guid id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Guid Id{ get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
