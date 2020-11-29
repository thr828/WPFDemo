using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrazyElephant.Client.Prism.Models;

namespace CrazyElephant.Client.Prism.Services
{
    public interface IDataService
    {
        List<Dish> GetAllDishes();
    }
}
