using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_TrianguloComMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());


            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX);
            Console.WriteLine("Área de Y = " + areaY);
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área = X");
            }
            else
            {
                Console.WriteLine("Maior área = Y");
            }
        }
    }
}