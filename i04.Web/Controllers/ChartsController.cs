using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using i04.Web.Models.Home;

namespace i04.Web.Controllers
{
    public class ChartsController : Controller
    {
        private readonly Random _random = new Random();

        public ActionResult Charts() => View(new ChartsDataViewModel() { Numbers = new int[0][] });

        [HttpPost]
        public ActionResult Charts(ChartsDataViewModel model)
        {
            var size = model.Amount < 0 || model.Amount > 4000 ? _random.Next(5, 150) : model.Amount;
            var numbers = new List<int>();
            for (int i = 0; i < size; i++)
            {
                numbers.Add(_random.Next(1, 380));
            }
            model.Numbers[0] = numbers.ToArray();
            bool flag = true;
            int numLength = numbers.Count();
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (numbers.ElementAt(j + 1) < numbers.ElementAt(j))
                    {
                        var temp = numbers.ElementAt(j);
                        numbers[j] = numbers.ElementAt(j + 1);
                        numbers[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            model.Numbers[1] = numbers.ToArray();
            return View(model);
        }
    }
}