using System;

namespace _109_110_111_112_Aulas_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aula 109 - Upcasting e Downcasting

            //Account acc = new Account(1001, "Alex", 0.0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            ////UPCASTING
            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            ////DOWNCASTING
            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(100.0);

            ////Embora o compilador não acuse nenhum erro, quando roda o programa ele gera uma exceção.
            ////"Não foi possível converter o objeto saving para business account"
            ////Só ocorre o erro em tempo de execução

            ////BusinessAccount acc5 = (BusinessAccount)acc3;

            ////Testar se é uma instancia para depois fazer a conversão
            //if(acc3 is BusinessAccount)
            //{
            //    //BusinessAccount acc5 = (BusinessAccount)acc3;

            //    //Outra forma de fazer o casting:
            //    BusinessAccount acc5 = acc3 as BusinessAccount;
            //    acc5.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}

            //if(acc3 is SavingsAccount)
            //{
            //    //SavingsAccount acc5 = (SavingsAccount)acc3;

            //    //Outra forma de fazer o casting:
            //    SavingsAccount acc5 = acc3 as SavingsAccount;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("Update!");
            //}
            #endregion

            #region Aula 110 - Sobreposição, palavras virtual, override e base

            //Account acc1 = new Account(1001, "Alex", 500.0);
            //Account acc2 = new SavingsAccount(1002, "Ana", 500.00, 0.01);

            //acc1.Withdraw(10.00);
            //acc2.Withdraw(10.00);

            //Console.WriteLine(acc1.Balance);
            //Console.WriteLine(acc2.Balance);

            #endregion

            #region Aula 111 - Classes e métodos selados

            //Ao incluir a palavra sealed na classe SavingsAccount e posteriormente criar a classe SavingAccountPlus e tentar herdar de SavingAccount
            //acaba não permitindo erro CS0509 "não é possível derivar do tipo sealed

            //Método Selado evita que um método sobreposto possa ser sobreposto novamente (só pode ser aplicado a métodos sobrepostos;

            //Pra quê ?

            //    Segurança: dependendo das regras de negócio, às vezes é desejável garantir que uma classe não seja herdada, ou que um um;
            //não seja sobreposto;
            //        Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas podem gerar uma porta de entrada para inconsistências

            //    Performance: atributos de tipo de uma classe selada são analisados de forma mais rápida em tempo de execução.
            //        Exemplo clássico: string

            #endregion

            #region Aula 112 - Introdução ao polimorfismo

            //Polimorfismo: Variáveis do mesmo tipo instânciados com objetos diferentes vão ter comportamentos diferentes;
            //    foi utilizado em inúmeras partes das aulas anteriores, como o exemplo do withdraw, que tem comportamentos distintos.

            //Importante entender:
            //        A associação do tipo específico com o tipo genérico é feita em tempo de execução (upcasting).
            //        O compilador não sabe para qual tipo específico a chamada do método Withdraw está sendo feita(ele só sabe que são duas variáveis
            //            tipo Account);

            #endregion

            Console.ReadLine();
        }
    }
}
