using Microsoft.AspNetCore.Mvc;
using Proje_oop.Ornekler;
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

        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();
           
            //nesne sınıfı türettim 

            //propertyşlere değer atadım
            sehirler.Ad = "Ankara";
            sehirler.ID = 06;
            sehirler.Nufus = 5000000;
            sehirler.Ulke = "Türkiye";
            sehirler.Renk1 = "kırmızı";
            sehirler.Renk2 = "Beyaz";

            //değer ataması yaptığım değerleri bastırdım
            ViewBag.v3 = sehirler.Ad;
            ViewBag.v1 = sehirler.ID;
            ViewBag.v4 = sehirler.Nufus;
            ViewBag.v2 = sehirler.Ulke;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;
            ViewBag.v7 = sehirler.Renk3;


            sehirler.Ad = "Kiew";
            sehirler.Ulke = "Ukrayna";
            sehirler.Nufus = 200000;
            sehirler.ID = 2;
            sehirler.Renk1 = "Mavi";
            sehirler.Renk2 = "kırmızı";
            sehirler.Renk3 = "beyaz";

            ViewBag.z1 = sehirler.ID;
            ViewBag.z3 = sehirler.Ad;
            ViewBag.z4 = sehirler.Nufus;
            ViewBag.z2 = sehirler.Ulke;
            ViewBag.z5 = sehirler.Renk1;
            ViewBag.z6 = sehirler.Renk2;
            ViewBag.z7 = sehirler.Renk3;


            return View();

        }
    }
}
