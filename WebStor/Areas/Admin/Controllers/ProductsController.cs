using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStor.Domain.Entities.Base.Identity;
using WebStor.Services.Interfaces;

namespace WebStor.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Role.Administrators)]
    public class ProductsController : Controller
    {
        private readonly IProductData _ProductData;

        public ProductsController(IProductData ProductData) => _ProductData = ProductData;

        public IActionResult Index()
        {
            var products = _ProductData.GetProducts();
            return View(products);
        }

        public IActionResult Edit(int id) => RedirectToAction(nameof(Index));

        public IActionResult Delete(int id) => RedirectToAction(nameof(Index));
    }
}
