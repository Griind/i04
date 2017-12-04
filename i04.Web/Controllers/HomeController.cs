using i04.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace i04.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("http://www.google.com");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            var number = new List<Algoritms>{
                            new Algoritms() { Numbers=23 } ,
                            new Algoritms() { Numbers=5 } ,
                            new Algoritms() { Numbers=19 } ,
                            new Algoritms() { Numbers=12 } ,
                            new Algoritms() { Numbers=14 } ,

                        };

            bool flag = true;
            int temp;
            int numLength = number.Count();

            var z = number.ElementAt(0).Numbers;

            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number.ElementAt(j + 1).Numbers < number.ElementAt(j).Numbers)
                    {
                        temp = number.ElementAt(j).Numbers;
                        number.ElementAt(j).Numbers = number.ElementAt(j + 1).Numbers;

                        number.ElementAt(j + 1).Numbers = temp;
                        flag = true;
                    }
                }
            }



            return View(number);
        }
    }
}