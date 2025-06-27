using System;

namespace _079_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); // Quantos elementos a matriz tem no total;
            Console.WriteLine(mat.Rank); // Quanto é a primeira dimensão da matriz (qntd linhas);
            Console.WriteLine(mat.GetLength(0)); //A quantidade de linhas;
            Console.WriteLine(mat.GetLength(1)); //A quantidade de colunas;

        }
    }
}