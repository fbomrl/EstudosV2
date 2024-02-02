using System.Globalization;
namespace _060_ExercicioFixacaoPOO
{
    class DadosConta
    {
        private string _nome;
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        public DadosConta(string nome, int conta)
        {
            _nome = nome;
            Conta = conta;
        }
        public DadosConta(string nome, int conta, double depositoInicial) : this(nome, conta)
        {
            Deposito(depositoInicial);
        }


        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.00;
        }

        public override string ToString()
        {
            return "Conta "
                + Conta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}