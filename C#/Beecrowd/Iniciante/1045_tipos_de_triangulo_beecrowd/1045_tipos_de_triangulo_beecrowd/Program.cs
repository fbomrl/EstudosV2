using System;

class Program
{
    static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(' ');

        double a = double.Parse(vet[0]);
        double b = double.Parse(vet[1]);
        double c = double.Parse(vet[2]);

        if (!((a + b) > c && (b + c) > a && (c + a) > b))
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else if ((a * a) == (b * b) + (c * c) || (b * b) == (a * a) + (c * c) || (c * c) == (b * b) + (a * a))
        {
            Console.WriteLine("TRIANGULO RETANGULO");
            trianguloLadosIguais(a, b, c);
        }
        else if ((a * a) > (b * b) + (c * c) || (b * b) > (a * a) + (c * c) || (c * c) > (b * b) + (a * a))
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
            trianguloLadosIguais(a, b, c);
        }
        else if ((a * a) < (b * b) + (c * c) || (b * b) < (a * a) + (c * c) || (c * c) < (b * b) + (a * a))
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");
            trianguloLadosIguais(a, b, c);
        }

        Console.ReadLine();
    }

    static void trianguloLadosIguais(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        else if (a == b || a == c || b == c)
        {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }


}
