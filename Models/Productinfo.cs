using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC_Practice2.Models
{
    public class Productinfo
    {
        public int ProID { get; set; }
        public string Proname { get; set; }
        public string ProImage { get; set; }
        public double ProPrice { get; set; }
        public int CatId { get; set; }
        public string ProCategory { get; set; }

    }
}