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

        public override string ToString()
        {
            return this.Category + "\t" + this.Name + "\t" + this.Price;
        }

    }
}
