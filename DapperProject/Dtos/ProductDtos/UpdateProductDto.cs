﻿namespace DapperProject.Dtos.ProductDtos
{
    public class UpdateProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }

    }
}
