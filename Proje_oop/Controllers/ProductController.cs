using Microsoft.AspNetCore.Mvc;
using Proje_oop.Entitiy;
using Proje_oop.ProjeContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje_oop.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            //layout=sayfa değişsse bile sabit kalan alan 
            var values = context.Products.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            context.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int id)
        {
            var value = context.Products.Where(x => x.Id == id).FirstOrDefault(); // tek değeri hafızaya almakiçin kullanılır
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = context.Products.Where(x => x.Id == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
            var value = context.Products.Where(x => x.Id == p.Id).FirstOrDefault();
            value.Name = p.Name;
            value.Price = p.Price;
            value.Stock = p.Stock;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

