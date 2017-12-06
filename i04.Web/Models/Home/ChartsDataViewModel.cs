using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace i04.Web.Models.Home
{
    public class ChartsDataViewModel
    {
        public int[][] Numbers  { get; set; }
        public int Amount  { get; set; }
    }
    public class MyModel
    {
        public string DateColumn { get; set; }
        public int Count { get; set; }

        public static List<MyModel> GetList()
        {
            return new List<MyModel>
            {
                new MyModel {DateColumn = "09-05-2017",Count = 10},
                new MyModel {DateColumn = "10-05-2017",Count = 30},
                new MyModel {DateColumn = "11-05-2017",Count = 50},
                new MyModel {DateColumn = "12-05-2017",Count = 10},
                new MyModel {DateColumn = "13-05-2017",Count = 100},
                new MyModel {DateColumn = "14-05-2017",Count = 20},
                new MyModel {DateColumn = "15-05-2017",Count = 10},
                new MyModel {DateColumn = "16-05-2017",Count = 150},
                new MyModel {DateColumn = "17-05-2017",Count = 15},
                new MyModel {DateColumn = "18-05-2017",Count = 11},
                new MyModel {DateColumn = "19-05-2017",Count = 5},
            };
        }
    }
}