using System;

namespace _068_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {

            //A primeira é a forma menos resumida de escrita, a segunda é a mesma coisa, porém de forma simplificada;

            Nullable<double> xd = null;
            double? x = null;
            double? y = 10.0;

            //Pega o valor que tem ou caso seja nulo, pega o padrão do valor, que nesse caso é 0;
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //Mostra se tem ou não um valor, no caso do X , da o resultado False, já que não possui.
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Nesse caso, o valor que está nulo, irá chamar uma exceção, indicando que tem um valor nulo.
            //Console.WriteLine(x.Value);
            //Console.WriteLine(y.Value);

            //Porém, pode ser feito dessa maneira abaixo:
            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");


            //OPERADOR DE COALESCÊNCIA NULA
            //Nesse caso do ??, 'c' recebe o valor de 'a', porém, caso ele seja nulo, irá receber o valor de 5;
            //Enquando no 'd' recebe o valor de 'b', porém, caso ele seja nulo, irá receber o valor de 5;
            Console.WriteLine();
            double? a = null;
            double? b = 10;

            double c = a ?? 5;
            double d = b ?? 5;

            Console.WriteLine($"{c} -- {d}");


        }
    }
}