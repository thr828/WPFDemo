using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrazyElephant.Client.Prism.Models;
using Prism.Mvvm;


namespace CrazyElephant.Client.Prism.ViewModels
{
   public class DishMenuItemViewModel: BindableBase
   {
        public Dish dish { get; set; }

        private bool isSelected;

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                this.RaisePropertyChanged("IsSelected");

            }
        }
    }
}
