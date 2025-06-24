using System;
using System.Globalization;
using _138_Interface.Entities;
using _138_Interface.Services;

namespace _138_139_140_Solucao_Sem_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            #region INTERFACE Aula - 138

            //    Interface é um tipo que define um conjunto de operações que uma classe (ou struct) deve implementar.

            //    A inteface estabelece um contrato que a classe (ou struct) deve cumprir.

            //    Pra quê interfaces?
            //-Para criar sistemas com baixo acoplamento e flexíveis. 
            #endregion

            #region SOLUÇÃO SEM INTERFACE - Aula 139/140

            //PROBLEMA EXEMPLO

            //   Uma locadora brasileira de carros cobra um valor por hora para locações de até 12 horas. Porém, se a duração da locação
            // ultrapassar 12 horas, a locação será cobrada com base em um valor diário. Além do valor da locação, é acrescido no preço
            // do valor do imposto conforme regras do país que, no caso do Brasil, é de 20% para valores até 100.00, ou  15% para valores
            // acima de 100.00. Fazer um programa que lê os dados da locação (modelo do carro, instante inicial e final da locação), bem
            // como o valor por hora e o valor diário da locação. O programa deve então gerar a nota de pagamento (contendo valor da locação,
            // valor do imposto e valor total do pagamento) e informar os dados na tela.

            #endregion

            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:ss): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:ss): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carrental = new CarRental(start, finish, new Vehicle(model));
            RentalServices rentalServices = new RentalServices(hour, day);

            rentalServices.ProcessInvoice(carrental);

            Console.WriteLine();
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carrental.Invoice);

            Console.ReadLine();
        }
    }
}
