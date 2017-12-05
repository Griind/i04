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
        public ActionResult Contact()
        {
            var random = new Random();
            var size = random.Next(5, 150);
            var result = new List<int>[2];
            var numbers = new List<int>();
            for (int i = 0; i < size; i++)
            {
                numbers.Add(random.Next(1, 380));
            }
            result[0] = new List<int>(numbers);


            bool flag = true;
            int temp;
            int numLength = numbers.Count();

            var z = numbers.ElementAt(0);

            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (numbers.ElementAt(j + 1) < numbers.ElementAt(j))
                    {
                        temp = numbers.ElementAt(j);

                        numbers[j] = numbers.ElementAt(j + 1);

                        numbers[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            result[1] = numbers;
            return View(result);
        }
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