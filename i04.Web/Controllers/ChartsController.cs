﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using i04.Web.Models.Home;
using i04.Web.Hubs;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System.Threading;

namespace i04.Web.Controllers
{  
    public class ChartsController : Controller
    {
        private readonly Random _random = new Random();

        //public JsonResult GetCount()
        //{

        //    //var model = ChartsDataViewModel.GetList();

        //    return Json(model, JsonRequestBehavior.AllowGet);
        //}
        public ActionResult Charts()
        {
            return View(new ChartsDataViewModel() { Numbers = new int[][] { new int[] { 0 }, new[] { 0 } } });
        }


        //Test
       
        public PartialViewResult Charts2(ChartsDataViewModel model)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<AlgoHub>();
            for (int i = 0; i < 30; i++)
            {
               
                context.Clients.All.updateChart(new int[] { 3, 7, 4, 2, 1, 3 });
                Thread.Sleep(100);
            }
                return PartialView("_Charts", model);
     
        }


        [HttpPost]
        public ActionResult Charts(ChartsDataViewModel model)
        {   
            var context = GlobalHost.ConnectionManager.GetHubContext<AlgoHub>();
            model.Numbers = new int[2][];
            var size = model.Amount < 0 || model.Amount > 4000 ? _random.Next(5, 150) : model.Amount;
            var numbers = new List<int>();
            for (int i = 0; i < size; i++)
            {
                numbers.Add(_random.Next(1, 380));
            }
            model.Numbers[0] = numbers.ToArray();
            AlgoHub.UpdateChart1(model.Numbers[0],null,model.ConId);
            bool flag = true;
            int numLength = numbers.Count();

            //Execution Timer Start
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (numbers.ElementAt(j) > numbers.ElementAt(j+1))
                    {
                        var temp = numbers.ElementAt(j+1);
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                        
                        flag = true;


                        AlgoHub.UpdateChart1(numbers.ToArray(), null, model.ConId);
                        Thread.Sleep(25);

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
           
            //DefaultHubManager hubManager = new DefaultHubManager(GlobalHost.DependencyResolver);
            //var hub = hubManager.ResolveHub("AlgoHub") as AlgoHub;

            //hub.BubleSort(numbers);





            return View(model);
        }
    }
}