using System;
using Exercicio_Produtos.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            Console.WriteLine("Enter the number of products:");
            int n = Console.ReadLine();


            Product product = new Product("Note", 100.00);

            Console.WriteLine(product.priceTag());
            
            ImportedProduct importedProduct = new ImportedProduct("Note", 100.00, 20.00);

            Console.WriteLine(importedProduct.priceTag());

            UsedProduct usedProduct = new UsedProduct("Note", 100.00, DateTime.Now);

            Console.WriteLine(usedProduct.priceTag());

        }
    }
}
