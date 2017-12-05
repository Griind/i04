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

        public ActionResult Contact()
        {
            var number = new List<int> { 23, 5, 19, 12, 14 };
                            

            bool flag = true;
            int temp;
            int numLength = number.Count();

            var z = number.ElementAt(0);

            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number.ElementAt(j + 1) < number.ElementAt(j))
                    {
                        temp = number.ElementAt(j);
                       
                            number[j] = number.ElementAt(j + 1);
                        
                        number[j + 1] = temp;
                        flag = true;
                       
                    }
                  
                }
            }

            return View(number);
        }
        public void  QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int bordPos = Partition(arr, start, end);
                QuickSort(arr,start, bordPos - 1);
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