using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrazyElephant.Client.ViewModels;

namespace CrazyElephant.Client.Models
{
    public class Dish
    {
       
        public string Name { get; set; }
      
        public string Category { get; set; }
        public string Comment { get;set; }
        public double Score { get; set; }
    }
}
