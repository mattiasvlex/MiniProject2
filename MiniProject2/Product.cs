using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject2
{
    internal class Product
    {
        //No need to set fields for category and name
        private int _price;

        public string Category { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
        
        public int Price
        {
            get => _price;
            set
            {
                if (value >= 0)
                {
                    _price = value;
                } else
                {
                    _price = 0;
                }
            }
        }
        public Product(string category, string name, int price)
        {
            Category = category;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return this.Category.PadRight(25) + this.Name.PadRight(25) + this.Price;
        }

    }
}
