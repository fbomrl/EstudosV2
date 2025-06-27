using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdTorneioEx_2234
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int hotDog = int.Parse(vet[0]);
            int participantes = int.Parse(vet[1]);
            double media = (double) hotDog / participantes;

            Console.WriteLine(media.ToString("F"));

            Console.ReadLine();
        }
    }
}
