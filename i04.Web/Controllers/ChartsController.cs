﻿using System;
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

        public ActionResult Charts()
        {
            return View(new ChartsDataViewModel() { Numbers = new int[][] { new int[] { 0 }, new[] { 0 } } });
        }


        //Test
     
        //Test HTTP
        [HttpPost]
        public ActionResult GetCount(ChartsDataViewModel model)
        {
            model.Numbers = new int[2][];
            var size = model.Amount < 0 || model.Amount > 4000 ? _random.Next(5, 150) : model.Amount;
            var numbers = new List<int>();
            for (int i = 0; i < size; i++)
            {
                numbers.Add(_random.Next(1, 380));
            }
            model.Numbers[0] = numbers.ToArray();
            bool flag = true;
            int numLength = numbers.Count();

            //Execution Timer Start
            var watch = System.Diagnostics.Stopwatch.StartNew();
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
            watch.Stop();
            if (watch.ElapsedMilliseconds < 2)
            {
                ViewBag.ExecutionTime = "Execution time: less than 1 millisecond";
            }
            else
            {
                ViewBag.ExecutionTime = "Execution time: " + watch.ElapsedMilliseconds + " milliseconds";
            }


            //Execution Timer Stop

            model.Numbers[1] = numbers.ToArray();
            return View(model);
        }
        public JsonResult GetCount()
        {
            var model = GetList();

            return Json(model, JsonRequestBehavior.AllowGet);
        }
        public static ChartsDataViewModel GetList()
        {

            return new ChartsDataViewModel
            {
                Numbers = new Int32[2][] { new Int32[] { 2, 3, 1, 4 }, new Int32[] { 1, 2, 3, 4 } },
                Amount = 4
            };
        }
        //End Test

        [HttpPost]
        public ActionResult Charts(ChartsDataViewModel model)
        {
            model.Numbers = new int[2][];
            var size = model.Amount < 0 || model.Amount > 4000 ? _random.Next(5, 150) : model.Amount;
            var numbers = new List<int>();
            for (int i = 0; i < size; i++)
            {
                numbers.Add(_random.Next(1, 380));
            }
            model.Numbers[0] = numbers.ToArray();
            bool flag = true;
            int numLength = numbers.Count();

            //Execution Timer Start
            var watch = System.Diagnostics.Stopwatch.StartNew();
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
            watch.Stop();
            if (watch.ElapsedMilliseconds < 2)
            {
                ViewBag.ExecutionTime = "Execution time: less than 1 millisecond";
            }
            else
            {
                ViewBag.ExecutionTime = "Execution time: " + watch.ElapsedMilliseconds + " milliseconds";
            }


            //Execution Timer Stop

            model.Numbers[1] = numbers.ToArray();
            return View(model);
        }
    }
}