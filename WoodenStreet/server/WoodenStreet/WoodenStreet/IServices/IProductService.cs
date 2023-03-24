﻿using Microsoft.AspNetCore.Mvc;
using WoodenStreet.Models;

namespace WoodenStreet.IServices
{
    public interface IProductService : IRepository<Product>
    {
        public Task<IActionResult> GetAllProducts();

        public Task<IActionResult> GetProductDetailById(int id);
    }
}
