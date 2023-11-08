

using System.Security.Cryptography.X509Certificates;

class program {
    static void Main(string[] args)
    {
        List<double> saldoTotal = new  List<double>();

        MostrarMenu();



        void MostrarMenu()
        {
            Console.WriteLine("\nMenu de Operação");
            Console.WriteLine("[1] Mostrar Saldo: ");
            Console.WriteLine("[2] Efetuar Depósito: ");
            Console.WriteLine("[3] Efetuar Saque: ");
            Console.WriteLine("[0] Finalizar: ");

            Console.WriteLine("Digite uma das opções.");
            string opcao_selecionada = Console.ReadLine();
            int opcao_escolhida = int.Parse(opcao_selecionada);

            switch(opcao_escolhida)
            {
                case 1:
                    SaldoDisponivel();
                    Retorno();
                    break;
                case 2:
                    EfetuaDeposito();
                    Retorno();
                    break;
                case 3:
                    EfetuarSaque();
                    Retorno();
                    break;
                case 0: Console.WriteLine("\nFinalizando...");
                    break;
                default: Console.WriteLine("Opção inválida!");
                    Retorno();
                    break;
            }
        }
        void SaldoDisponivel()
        {
            List<double> saldoTotalDisponivel = saldoTotal;
            Console.WriteLine($"\nSaldo de R$ {saldoTotalDisponivel.Sum()}");
        }

        void EfetuaDeposito()
        {
            try
            {
                Console.WriteLine("\nValor a ser depositado R$ ");
                string valor = Console.ReadLine();
                double valorDeposito = Convert.ToDouble(valor);
                saldoTotal.Add(valorDeposito);
                Thread.Sleep(1000);
                if (valorDeposito > 0)
                {
                    Console.WriteLine($"\nEfetuando depósito de R${valorDeposito}");
                }
                else
                {
                    Console.WriteLine("Valor de depósito inválido");
                    Thread.Sleep(1000);
                }
            } catch (FormatException)
            {
                Console.WriteLine("\nFavor digitar caracteres numéricos.");
            }        
        }

        void EfetuarSaque()
        {
            Console.WriteLine("\nQual valor deseja sacar? R$ ");
            string valor = Console.ReadLine();
            double valorSaque = Convert.ToDouble(valor);

            if(valorSaque > 0 && valorSaque <= saldoTotal.Sum()) { 
                saldoTotal.Add(-valorSaque);
                Thread.Sleep(1000);
                Console.WriteLine($"Realizando saque no valor de R${valorSaque}");
            } else
            {
                Thread.Sleep(1000);
                Console.WriteLine($"\nValor de saque inválido ou saldo insuficiente");
                Console.WriteLine("Deseja verificar o saldo?\n ");
                string resposta = Console.ReadLine();
                if (resposta == "S" ||  resposta == "s") 
                {
                    SaldoDisponivel();
                } else
                {
                    MostrarMenu();
                }

            }
        }

        void Retorno()
        {
            Console.WriteLine("\nDigite qualquer tecla para voltar ao MENU de Operação.");
            Console.ReadKey();
            Console.Clear();
            MostrarMenu();
        }
    }
}

