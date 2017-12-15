using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using i04.Web.Models.Home;
using i04.Web.Hubs;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System.Threading;
using i04.Web.Helpers;

namespace i04.Web.Controllers
{
    public class ChartsController : Controller
    {
        private readonly Random _random = new Random();
        public ActionResult Charts()
        {
            return View(new ChartsDataViewModel() { Numbers = new int[][] { new int[] { 0 }, new[] { 0 } } });
        }

        [HttpPost]
        public ActionResult Charts(ChartsDataViewModel model)
        {
            var str = "BubbleSort";
            switch (str)//Todo: request from the view;
            {
                case "BubbleSort":
                    {
                        model = Sortingalgorithms.BubbleSort(model, _random);
                    }
                    break;
                case "MergeSort":
                    {
                        model = Sortingalgorithms.BubbleSort(model, _random);
                    }
                    break;
                case "QuickSort":
                    {
                        model = Sortingalgorithms.BubbleSort(model, _random);
                    }
                    break;
            }
            return View(model);
        }
    }
}