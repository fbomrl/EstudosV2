using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecrowdTorneioExD_2248
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalAlunosTurma;
            int Codigo;
            int Media = 0;
            int Turma2 = int.Parse(Console.ReadLine());
            int Turma1 = 1;
            int CodMaiorMedia = 0;


            while(Turma2 == Turma1)
            {
                Console.WriteLine($"Turma {Turma1}");
                if (CodMaiorMedia > Media)
                {
                    Console.WriteLine($"{CodMaiorMedia}");
                }
                Console.WriteLine();
            }


        }
    }
}
