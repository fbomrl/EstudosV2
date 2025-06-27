using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdTorneioEx_2247
{
    class Program
    {
        static void Main(string[] args)
        {
            int teste = 1;
            while (true)
            {
                Console.WriteLine("Teste " + teste);
                int nDepositos = Convert.ToInt32(Console.ReadLine());
                if (nDepositos == 0) break;
                for (int i = 0; i < nDepositos; i++)
                {
                    string[] vetor = Console.ReadLine().Split(' ');
                    int j = Convert.ToInt32(vetor[0]);
                    int z = Convert.ToInt32(vetor[1]);
                    Console.WriteLine(Math.Abs(j - z));
                }
                Console.WriteLine();
                teste++;
            }
        }
    }
    }

