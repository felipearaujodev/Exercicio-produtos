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
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char option = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (option == 'c') {
                    Product product = new Product(name, price);
                    list.Add(product);
                }
                else if (option == 'u') {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    UsedProduct usedProduct = new UsedProduct(name, price, date);
                    list.Add(usedProduct);
                }
                else if(option == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    ImportedProduct importedProduct = new ImportedProduct(name, price, customfee);

                    list.Add(importedProduct);
                }

            }

            Console.WriteLine();
            Console.WriteLine("Price Tags:");
            foreach (Product prod in list)
            {
               Console.WriteLine(prod.priceTag());
            }
        }
    }
}
