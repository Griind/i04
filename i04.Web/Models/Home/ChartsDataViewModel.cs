using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace i04.Web.Models.Home
{
    public class ChartsDataViewModel
    {
        public int[][] Numbers { get; set; }
        public int Amount { get; set; }





        public static ChartsDataViewModel GetList()
        {
            return new ChartsDataViewModel
            {
                Numbers = new int[][] { new int[] { 1, 3, 2, 8, 9 }, new int[] { 1, 2, 3, 4, 5 } },
                Amount = 5
            };
        }

    }
}