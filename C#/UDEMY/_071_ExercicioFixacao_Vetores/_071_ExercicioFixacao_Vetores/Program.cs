using System;

namespace _071_ExercicioFixacao_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int qntdQuartosAlugados = int.Parse(Console.ReadLine());
            Cliente[] cliente = new Cliente[qntdQuartosAlugados];

            for(int i = 0; i < qntdQuartosAlugados; i ++)
            {
                    Console.WriteLine();
                    Console.WriteLine("Rent # " + (i + 1));
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Room: ");
                    int room = int.Parse(Console.ReadLine());
                    cliente[i] = new Cliente { Name = name, Email = email, NumeroQuarto = room};
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Busy rooms: ");
                if (cliente[i] != null)
                {
                    Console.WriteLine(cliente[i]);
                }
            }
        }
        }
    }

