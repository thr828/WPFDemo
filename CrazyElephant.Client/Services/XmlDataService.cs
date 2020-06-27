using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using CrazyElephant.Client.Models;

namespace CrazyElephant.Client.Services
{
    public class XmlDataService:IDataService
    {
        public List<Dish> GetAllDishes()
        {
          List<Dish> dishLIst=new List<Dish>();
          string xmlFileName = System.IO.Path.Combine(Environment.CurrentDirectory, @"Data\Data.xml");
          XDocument xDoc = XDocument.Load(xmlFileName);
          var dishes = xDoc.Descendants("Dish");
          foreach (var d in dishes)
          {
              Dish dish=new Dish();
              dish.Name = d.Element("Name").Value;
              dish.Category = d.Element("Category").Value;
              dish.Comment = d.Element("Comment").Value;
              dish.Score = double.Parse(d.Element("Score").Value);
              dishLIst.Add(dish);
          }

          return dishLIst;
        }

     
 
    }
}
