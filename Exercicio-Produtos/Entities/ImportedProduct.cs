using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_Produtos.Entities
{
    class ImportedProduct : Product
    {
        public double _customsFree { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFree)
            : base(name, price)
        {
            _customsFree = customsFree;
        }

        public override string priceTag()
        {
            return base.priceTag() + "(Customs fee: "+ _customsFree.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
