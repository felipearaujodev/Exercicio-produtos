using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_Produtos.Entities
{
    class Product
    {
        public string _name { get; set; }
        public double _price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public virtual string priceTag()
        {
            
            return _name + " " + _price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
