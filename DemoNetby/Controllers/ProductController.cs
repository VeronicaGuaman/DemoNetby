using Domain.Entities;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Domain.Enums.TypeNotification;

namespace DemoNetby.Controllers
{
    public class ProductController : BaseController
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetProducts();
            return View(products);
        }


        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                await _productRepository.CreateAsync(product);
                Alert("El Producto se ha agregado con éxito", NotificationType.success);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        public IActionResult UpdateProduct(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var productToEdit = _productRepository.GetProductById(id);

            return View(productToEdit);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                await _productRepository.UpdateAsync(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }


        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var productToDelete = _productRepository.GetProductById(id);

            _productRepository.DeleteAsync(productToDelete);

            return RedirectToAction("Index");
        }

    }
}
