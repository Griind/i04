﻿
using i04.Web.Models.Home;
using System.Web.Mvc;

namespace i04.Web.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult GetCount1()
        {
            var model = new ChartsDataViewModel() { Numbers = new int[][] { new int[] { 1, 2, 6, 8 }, new[] { 1, 20, 4, 6, 7 } } };

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //TODO: zamutyty user input na list size;
        //public ActionResult Contact()
        //{

        //    return View(new List<int>[1]);
        //}
        //[HttpPost]
        //public ActionResult Contact()
        //{
          
        //    return View();
        //}
        public void QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int bordPos = Partition(arr, start, end);
                QuickSort(arr, start, bordPos - 1);
                QuickSort(arr, bordPos + 1, end);
            }
        }
        private int Partition(int[] arr, int start, int end)
        {
            int i = start + 1;
            int border = arr[start];
            for (int j = start + 1; j <= end; j++)
            {
                if (arr[j] < border)
                {
                    Swap(ref arr[i], ref arr[j]);
                }
            }
            Swap(ref arr[start], ref arr[i - 1]);
            return i - 1;

        }

        private void Swap(ref int v1, ref int v2)
        {
            int tmp = v1;
            v1 = v2;
            v2 = tmp;
        }
    }
}