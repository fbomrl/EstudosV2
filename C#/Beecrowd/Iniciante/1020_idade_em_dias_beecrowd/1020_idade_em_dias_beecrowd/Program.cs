using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int ano = n / 365;
        int ano2 = n % 365;
        int mes = ano2 / 30;
        int mes2 = ano2 % 30;
        int dia = mes2;

        Console.WriteLine($"{ano} ano(s)");
        Console.WriteLine($"{mes} mes(es)");
        Console.WriteLine($"{dia} dia(s)");

        Console.ReadLine();
    }
}