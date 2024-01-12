using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Characteristic { get; set; }
        public string listStr;
        public Product()
        {
            Price = 0;
        }
         
        public override string ToString()
        {
            return $"Компьютер: {Name} Описание: {Description}";
        }
        


    }

}
