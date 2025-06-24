using System; 
class Program
{
    static void Main(string[] args)
    {

        double valor = double.Parse(Console.ReadLine());

        int[] notas = { 100, 50, 20, 10, 5, 2 };
        double[] moedas = { 1.00, 0.50, 0.25, 0.10, 0.05, 0.01 };

        Console.WriteLine("NOTAS:");
        foreach (var nota in notas)
        {
            int qntdNota = (int)(valor / nota);
            Console.WriteLine($"{qntdNota} nota(s) de R$ {nota:0.00}");
            valor %= nota;
        }
        Console.WriteLine("MOEDAS:");
        foreach (var moeda in moedas)
        {
            double qntdMoeda = (valor / moeda);
            Console.WriteLine($"{Math.Truncate(qntdMoeda)} moeda(s) de R$ {moeda:0.00}");
            valor = Math.Round(valor % moeda, 2);
        }

        Console.ReadLine();
    }
}