using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC_Practice2.Models;

namespace WebMVC_Practice2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Productinfo pro1 = new Productinfo
            {
                ProID = 1,
                Proname = "Sed ut perspiciati ",
                ProImage = "17.Png",
                ProPrice = 56.00,
                CatId = 1,
                ProCategory = "Women"
            };

            Productinfo pro2 = new Productinfo
            {
                ProID = 2,
                Proname = "At vero eos",
                ProImage = "18.png",
                ProPrice = 56.00,
                CatId = 1,
                ProCategory = "Women"
            };
            Productinfo pro3 = new Productinfo
            {
                ProID = 3,
                Proname = "On the other",
                ProImage = "19.png",
                ProPrice = 56.00,
                CatId = 1,
                ProCategory = "Women"
            };
            Productinfo pro4 = new Productinfo
            {
                ProID = 4,
                Proname = "Sed ut perspiciati",
                ProImage = "20.png",
                ProPrice = 56.00,
                CatId = 1,
                ProCategory = "Women"
            };
            Productinfo pro5 = new Productinfo
            {
                ProID = 5,
                Proname = "At vero eos",
                ProImage = "21.png",
                ProPrice = 56.00,
                CatId = 1,
                ProCategory = "Women"
            };
            Productinfo pro6 = new Productinfo
            {
                ProID = 6,
                Proname = "On the other",
                ProImage = "22.png",
                ProPrice = 56.00,
                CatId = 1,
                ProCategory = "Women"
            };
            Productinfo pro7 = new Productinfo
            {
                ProID = 7,
                Proname = "Sed ut perspiciati",
                ProImage = "23.png",
                ProPrice = 56.00,
                CatId = 1,
                ProCategory = "Women"
            };
            Productinfo pro8 = new Productinfo
            {
                ProID = 8,
                Proname = "At vero eos",
                ProImage = "24.png",
                ProPrice = 56.00,
                CatId = 1,
                ProCategory = "Women"
            };
            Productinfo pro9 = new Productinfo
            {
                ProID = 9,
                Proname = "At vero eos",
                ProImage = "25.png",
                ProPrice = 56.00,
                CatId = 1,
                ProCategory = "Women"
            };
            Productinfo pro11 = new Productinfo
            {
                ProID = 11,
                Proname = "At vero eos",
                ProImage = "27.png",
                ProPrice = 56.00,
                CatId = 1,
                ProCategory = "Women"
            };
            Productinfo pro12 = new Productinfo
            {
                ProID = 12,
                Proname = "At vero eos",
                ProImage = "28.png",
                ProPrice = 56.00,
                CatId = 1,
                ProCategory = "Women"
            };
            List<Productinfo> Productinfo = new List<Productinfo>();
            Productinfo.Add(pro1);
            Productinfo.Add(pro2);
            Productinfo.Add(pro3);
            Productinfo.Add(pro4);
            Productinfo.Add(pro5);
            Productinfo.Add(pro6);
            Productinfo.Add(pro7);
            Productinfo.Add(pro8);
            Productinfo.Add(pro9);
            Productinfo pro10 = new Productinfo
            {
                ProID = 10,
                Proname = "At vero eos",
                ProImage = "26.png",
                ProPrice = 56.00,
                CatId = 1,
                ProCategory = "Women"
            };
            Productinfo.Add(pro10);
            Productinfo.Add(pro11);
            Productinfo.Add(pro12);

            return View(Productinfo);

        }

            return View();
        }


        public ActionResult Detail()
        {
            return View();
        }
    }
}