using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject2
{
    internal class Product
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string category, string name, int price) {
            Category = category;
            Name = name;
            Price = price;
        }
    }
}
