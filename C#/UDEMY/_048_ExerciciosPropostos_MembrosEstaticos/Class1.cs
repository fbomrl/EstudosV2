namespace _048_ExerciciosPropostos_MembrosEstaticos
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.0;
        public static double ConversorDolarParaReal(double cotacao, double quantidade)
        {
            double total = cotacao * quantidade;
            return total + total * IOF / 100.00;

        }

    }
}