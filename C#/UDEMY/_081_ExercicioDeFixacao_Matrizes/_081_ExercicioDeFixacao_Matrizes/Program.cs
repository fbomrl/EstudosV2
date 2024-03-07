using System;

namespace _081_ExercicioDeFixacao_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position: " + i + "," + j + " .");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1] + ".");
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1] + ".");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j] + ".");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j] + ".");
                        }
                    }
                }
            }
        }
    }
}