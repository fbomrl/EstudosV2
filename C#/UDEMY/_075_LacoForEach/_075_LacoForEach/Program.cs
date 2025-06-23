using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _075_LacoForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "José", "Felipe" };

            foreach(string nomes in vect)
            {
                Console.WriteLine(nomes);
            }

        }
    }
}
