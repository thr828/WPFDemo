using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CrazyElephant.Client.Prism.Models;
using CrazyElephant.Client.Prism.Services;
using Prism.Commands;
using Prism.Mvvm;


namespace CrazyElephant.Client.Prism.ViewModels
{
    public class MainWindowViewModel: BindableBase
    {
        public DelegateCommand PlaceOrderCommand { get; set; }
        public DelegateCommand SelectMenuItemCommand { get; set; }

        private int count;

        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                this.RaisePropertyChanged("Count");
            }
        }

        private Restaurant restaurant;

        public Restaurant Restaurant
        {
            get { return restaurant; }
            set
            {
                restaurant = value;
                this.RaisePropertyChanged("Restaurant");
            }
        }

        private List<DishMenuItemViewModel> dishMenu;

        public List<DishMenuItemViewModel> DishMenu
        {
            get { return dishMenu; }
            set
            {
                dishMenu = value;
                this.RaisePropertyChanged("DishMenu");
            }
        }


        public MainWindowViewModel()
        {
            this.LoadRestaurant();
            this.LoadDishMenu();
            this.PlaceOrderCommand=new DelegateCommand(new Action(this.PlaceOrderCommandExecute));
         //   this.PlaceOrderCommand. = new Action<object>(this.PlaceOrderCommandExecute);
            this.SelectMenuItemCommand=new DelegateCommand(new Action(this.SelectMenuItemExecute));
          //  this.SelectMenuItemCommand.ExecuteAction=new Action<object>(this.SelectMenuItemExecute);
        }

        private void LoadRestaurant()
        {
           this.Restaurant=new Restaurant();
           this.Restaurant.Name = "Crazy大象";
           this.Restaurant.Address = "北京市海淀区万泉河路紫金庄园1号楼11室";
           this.Restaurant.PhoneNumber = "15210365423 or 82650336";
        }

        private void LoadDishMenu()
        {
            XmlDataService xmlData = new XmlDataService();
            var dishes = xmlData.GetAllDishes();
            this.DishMenu = new List<DishMenuItemViewModel>();
            foreach (var dish in dishes)
            {
                DishMenuItemViewModel dishMenuModel = new DishMenuItemViewModel()
                {
                    dish = dish
                };
                DishMenu.Add(dishMenuModel);

            }
        }

        private void PlaceOrderCommandExecute()
        {
            var selectDishes = this.DishMenu.Where(p => p.IsSelected == true).Select(p => p.dish.Name).ToList();
            IOrderService orderService=new OrderService();
            orderService.PlaceOrder(selectDishes);
            MessageBox.Show("订餐成功!");
        }

        private void SelectMenuItemExecute()
        {
            this.Count = this.DishMenu.Count(p=>p.IsSelected==true);
        }

        

       

      
    }
}
