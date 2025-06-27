namespace _045_ExerciciosFixacao
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;


        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            double resultado = porcentagem * Salario / 100;
            Salario = Salario + resultado;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + SalarioLiquido().ToString("F2");
        }
    }
}