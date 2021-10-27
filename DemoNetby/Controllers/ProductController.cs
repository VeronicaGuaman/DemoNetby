using Domain.Entities;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoNetby.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            if(ModelState.IsValid)
            { 
               await _productRepository.CreateAsync(product);
            }

            return View(product);
        }

        [HttpPost]
        public async Task<bool> UpdateProduct(Product product)
        {
            return await _productRepository.UpdateAsync(product);
        }

        [HttpPost]
        public async Task<bool>deleteProduct(int id)
        {
            return await _productRepository.DeleteAsync(id);
        }

      
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _productRepository.GetAllAsync();
        }






    }
}
