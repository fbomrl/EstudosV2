using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _072_ModificadorParametroParams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explicação sobre PARAMS...
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 3, 4);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine();

            //Explicação sobre modificador de parametro REF, faz o parâmetro ser uma referência para a variável original
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            //Explicação sobre modificador OUT faz o parâmetro ser uma referência para a variável original, mas não exige que ela seja inicializada;
            int b = 10;
            int triple;
            Calculator.Triple2(b, out triple);
            Console.WriteLine(triple);
        }
    }

}
