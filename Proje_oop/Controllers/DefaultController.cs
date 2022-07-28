using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje_oop.Controllers
{
    public class DefaultController : Controller
    {
        //void İslemler()
       // {
        //}
        void messages ()
        {
            ViewBag.m1 = "Merhaba bu bir Core projesi";
            ViewBag.m2 = "Aleyna ÇELİK";
            ViewBag.m3 = "Bilgisayar Mühendisliği";
        }
        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;
        }
        public IActionResult Index()
        {
            messages();
            return View();
        }
        public IActionResult Urunler()
        {
            messages();
            ViewBag.t = topla();
            return View();
        }
    }
}
