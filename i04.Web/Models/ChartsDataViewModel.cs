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
       
        public int[][] Numbers { get; set; }
       
        public int Amount { get; set; }
        public string ConId { get; set; }
     
        public List<CheckBoxAlgorithms> CheckBoxAlgoType { get; set; }

    }
  

}