using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject2
{
    internal class Product
    {
        private string _category;
        private string _name;
        private int _price;

        public string Category
        {
            get => _category;
            set => _category = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

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

        public Product(string category, string name, int price) {
            _category = (category == null) ? _category = "" : _category = category;
            _name = (name == null) ? _name = "" : _name = name;
            _price = (price >= 0) ? _price = price : _price = 0;
        }
    }
}
