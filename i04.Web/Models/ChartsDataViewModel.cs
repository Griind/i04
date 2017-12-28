using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace i04.Web.Models.Home
{
    public class ChartsDataViewModel
    {
        public ChartsDataViewModel()
        {
            Numbers = new int[0][];
            CheckBoxAlgoType = new List<CheckBoxAlgorithms>
                {

                     new CheckBoxAlgorithms { Id = 0, Name = "Bubble Sort", IsSelected = false },
                     new CheckBoxAlgorithms { Id = 1, Name = "Merge Sort", IsSelected = false },
                     new CheckBoxAlgorithms { Id = 2, Name = "Quick Sort", IsSelected = false }
                 };
            }
        public int[][] Numbers { get; set; }

        public int Amount { get; set; }
        public string ConId { get; set; }

        public List<CheckBoxAlgorithms> CheckBoxAlgoType { get; set; }

    }


}