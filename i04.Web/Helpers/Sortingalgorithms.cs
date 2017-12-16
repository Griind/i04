using i04.Web.Hubs;
using i04.Web.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace i04.Web.Helpers
{
    public class Sortingalgorithms
    {
        
        public static ChartsDataViewModel BubbleSort(ChartsDataViewModel model, Random random)
        {

            model.Numbers = new int[2][];
            var size = model.Amount < 0 || model.Amount > 40 ? random.Next(2, 40) : model.Amount;
            var numbers = new List<int>();
            for (int i = 0; i < size; i++)
            {
                numbers.Add(random.Next(1, 380));
            }
            model.Numbers[0] = numbers.ToArray();

            bool flag = true;
            int numLength = numbers.Count();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (numbers.ElementAt(j) > numbers.ElementAt(j + 1))
                    {
                        var temp = numbers.ElementAt(j + 1);
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;

                        flag = true;

                        AlgoHub.Send(numbers.ToArray(), null, Encode.Base64Decode(model.ConId));
                        Thread.Sleep(50);
                    }
                }
            }
            watch.Stop();
            //if (watch.ElapsedMilliseconds < 2)
            //{
            //    ViewBag.ExecutionTime = "Execution time: less than 1 millisecond";
            //}
            //else
            //{
            //    ViewBag.ExecutionTime = "Execution time: " + watch.ElapsedMilliseconds + " milliseconds";
            //}
            model.Numbers[1] = numbers.ToArray();
            return model;
        }
    }
}