using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Produtos.Entities
{
    class UsedProduct : Product
    {
        public DateTime _manufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            _manufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return _name + " (used) " + _price.ToString("F2") + " (Manufacture date: " + _manufactureDate + ")";
        }
    }
}
