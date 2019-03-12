using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicio_proposto.Entities;
using System.Globalization;

namespace exercicio_proposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    ImportedProduct imp = new ImportedProduct(name, price, customsFee);
                    list.Add(imp);
                }
                else if (ch == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product comum = new Product(name, price);
                    list.Add(comum);
                }
                else if (ch == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime dateProd = DateTime.Parse(Console.ReadLine());
                    UsedProduct used = new UsedProduct(name, price, dateProd);
                    list.Add(used);
                }
                else if (ch != 'i' || ch != 'u' || ch != 'c')
                {
                    Console.WriteLine("Opção Inválida. Por favor, tente novamente!");
                    i--;
                }
            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.priceTag(), CultureInfo.InvariantCulture);
                Console.ReadKey();
            }
        }
    }
}
