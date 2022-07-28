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
        void messages()
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
        int cevre()
        {
            int kisakenar = 20;
            int uzunkenar = 50;
            int sonuc = (2 * kisakenar) + (2 * uzunkenar);
            return sonuc;
        }

        int faktorıyel()
        {
            int sayi = 5;
            int fakt = 1;
            for (int i = 1; i <= sayi; i++)
            {
                fakt = fakt * i;
            }
            return fakt;
        }
        string cumle()
        {
            string c = "Aleyna ÇELİK BİLGİSAYAR MÜHENDİSLİĞİ";
            return c;
        }
        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }
        void Kullanıcı(string username)
        {
            ViewBag.k = username;
        }
        int Topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }
        public IActionResult Index()
        {
            messages();
            MesajListesi("parametre ismi");
            Kullanıcı("Aleyna");
            ViewBag.y = Topla(20,35);
            return View();
        }
        public IActionResult Urunler()
        {
            messages();
            ViewBag.t = topla();
            ViewBag.C = cevre();
            ViewBag.f = faktorıyel();
            return View();
        }
        public IActionResult Musteriler()
        {
            ViewBag.h = cumle();
            Kullanıcı("Aleyna12");
            return View();
        }
    }
}
