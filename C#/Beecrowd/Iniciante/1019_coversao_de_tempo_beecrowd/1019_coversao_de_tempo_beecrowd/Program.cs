using System;
class Program
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());

        int h = n / 3600;
        int h2 = n % 3600;
        int m = h2 / 60;
        int m2 = h2 % 60;
        int s = m2;

        Console.WriteLine($"{h}:{m}:{s}");

        Console.ReadLine();
    }
}
