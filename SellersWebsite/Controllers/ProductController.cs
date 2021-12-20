using Microsoft.AspNetCore.Mvc;
using SellersWebsite.Context;
using SellersWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellersWebsite.Controllers
{
    public class ProductController : Controller
    {
        private readonly SellersDBContext _db;

        public ProductController(SellersDBContext db)
        {
            _db = db;
        }
        

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductModel obj)
        {
            _db.Products.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index", "List");
        }
    }
}
