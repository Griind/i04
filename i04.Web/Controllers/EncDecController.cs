using i04.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace i04.Web.Controllers
{
    public class EncDecController : Controller
    {
        // GET: EncDec
        public ActionResult EncDec()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Encode(EncodeData d)
        {
            if (d.DataLeft != null)
            {
                d.DataRight = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(d.DataLeft));
            }

            return View("EncDec",d);
        }
    }
}