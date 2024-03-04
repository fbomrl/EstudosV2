using System;
using System.Collections.Generic;

namespace ExercicioFixacaoPessoal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Animon serão apresentados ? ");
            int qntd = int.Parse(Console.ReadLine());

            List<Animon> animon = new List<Animon>();

            for (int i = 0; i < qntd; i++)
            {
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Raça: ");
                string tipo = Console.ReadLine();
                Console.Write("Força: ");
                double forca = double.Parse(Console.ReadLine());

                animon.Add(new Animon(id, nome, tipo, forca));
                Console.WriteLine();
            }

            Console.WriteLine("Escolha o ID do Animon que será acrescentado força: ");
            int idAnimon = int.Parse(Console.ReadLine());

            Animon a = animon.Find(x => x.Id == idAnimon);
            if (a != null)
            {
                Console.WriteLine("Força do Animon aumentada em: ");
                double aumentoForca = double.Parse(Console.ReadLine());
                a.StrengthBoost(aumentoForca);
            }
            else
            {
                Console.WriteLine("Animon não localizado e/ou não existe! ");
            }
            Console.WriteLine();
            Console.WriteLine("Lista atualizada de Animons: ");
            foreach (Animon obj in animon)
            {
                Console.WriteLine(obj);
            }

        }
    }
}