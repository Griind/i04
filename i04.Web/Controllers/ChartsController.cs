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


            return View(
                new ChartsDataViewModel()
                {
                    Numbers = new int[][] { new int[] { 0 }, new[] { 0 } },
                    CheckBoxAlgoType = new List<CheckBoxAlgorithms>
                {
                     new CheckBoxAlgorithms {Id=0,Name="Bubble Sort",IsSelected=false},
                     new CheckBoxAlgorithms {Id=1,Name="Merge Sort",IsSelected=false},
                     new CheckBoxAlgorithms {Id=2,Name="Quick Sort",IsSelected=false}
                }
                }
                );
        }

        [HttpPost]
        public ActionResult Charts(ChartsDataViewModel model)
        {
            if (model.CheckBoxAlgoType.Where(x => x.IsSelected).FirstOrDefault() == null || model.Amount == 0|| model.CheckBoxAlgoType.Where(x => x.IsSelected).Count()>1)
            {
                ViewBag.CheckBoxError = "Please enter amount of random numbers and select just one sorting method";
                return View(new ChartsDataViewModel()
                {
                    Numbers = new int[][] { new int[] { 0 }, new[] { 0 } },
                    CheckBoxAlgoType = new List<CheckBoxAlgorithms>
                {
                     new CheckBoxAlgorithms {Id=0,Name="Bubble Sort",IsSelected=false},
                     new CheckBoxAlgorithms {Id=1,Name="Merge Sort",IsSelected=false},
                     new CheckBoxAlgorithms {Id=2,Name="Quick Sort",IsSelected=false}
                }
                }
                );
            }
            else
            {
                List<CheckBoxAlgorithms> lHob = new List<CheckBoxAlgorithms>();
                lHob = model.CheckBoxAlgoType;

                var str = lHob.Where(x => x.IsSelected).Select(x => x.Name).FirstOrDefault().ToString();


                switch (str)//Todo: request from the view;
                {
                    case "Bubble Sort":
                        {
                            model = Sortingalgorithms.BubbleSort(model, _random);
                        }
                        break;
                    case "Merge Sort":
                        {
                            model = Sortingalgorithms.BubbleSort(model, _random);
                        }
                        break;
                    case "Quick Sort":
                        {
                            model = Sortingalgorithms.QuickSort(model, _random);
                        }
                        break;
                }
                return View(model);
            }
        }
    }
}