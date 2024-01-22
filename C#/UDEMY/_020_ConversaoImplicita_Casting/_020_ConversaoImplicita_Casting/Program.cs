using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_ConversaoImplicita_Casting
{
    class Program
    {
        static void Main(string[] args)
        {

            //casting =  conversão explicita de tipos
            double a;
            float b;
            Console.WriteLine("==========");
            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);
            Console.WriteLine("==========");
            double c;

            c = (int)a;

            Console.WriteLine(c);
            Console.WriteLine("==========");

            int d = 5;
            int e = 2;
            double resultado = (double)d / e;
            Console.WriteLine(resultado);
            Console.WriteLine("==========");
        }
    }
}