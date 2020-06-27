using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrazyElephant.Client.Models;


namespace CrazyElephant.Client.ViewModels
{
   public class DishMenuItemViewModel: NotificationObject
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
