using Microsoft.AspNetCore.Mvc;
using Proje_oop.Entitiy;
using Proje_oop.ProjeContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje_oop.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            if(p.CustomerName.Length >= 10 && p.CustomerCity!="" && p.CustomerCity.Length >= 10)
            {
                context.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Hatalı Kullanıcı Girişi Yaptınız";
                return View();
            }
        }
        public IActionResult DeleteCustomer(int id)
        {
            var value = context.Customers.Where(x => x.Id == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id )
        {
            var value = context.Customers.Where(x => x.Id == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            if (p.CustomerName.Length >= 10 && p.CustomerCity != "" && p.CustomerCity.Length >= 10)
            {
                var value = context.Customers.Where(x => x.Id == p.Id).FirstOrDefault();
                value.CustomerCity = p.CustomerCity;
                value.CustomerName = p.CustomerName;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Hatalı Kullanıcı Güncelleme Yaptınız";
                return View();
            }
        }
    }
}
