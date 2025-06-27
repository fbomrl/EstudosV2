using _105_ExercicioProposto_Enumeracoes_Composição.Entities;
using _105_ExercicioProposto_Enumeracoes_Composição.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105_ExercicioProposto_Enumeracoes_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter order data: ");
            Console.Write($"Status: ");
            OrderStatus orderStatus = OrderStatus.Parse(Console.ReadLine));

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string product = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int qntd = int.Parse(Console.ReadLine());

                Product product_1 = new Product();
            }


        }
    }
}
