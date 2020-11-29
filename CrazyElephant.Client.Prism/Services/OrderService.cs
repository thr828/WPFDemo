using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyElephant.Client.Prism.Services
{
    public class OrderService:IOrderService
    {
        public void PlaceOrder(List<string> dishes)
        {
          File.WriteAllLines(@"D:\order.txt",dishes.ToArray());
        }
    }
}
