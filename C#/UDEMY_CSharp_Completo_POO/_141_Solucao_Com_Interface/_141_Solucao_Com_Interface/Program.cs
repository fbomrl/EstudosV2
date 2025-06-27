using _141_Solucao_Com_Interface.Entities;
using _141_Solucao_Com_Interface.Services;
using System;
using System.Globalization;

namespace _141_Solucao_Com_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
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
            RentalServices rentalServices = new RentalServices(hour, day, new BrazilTaxServices());

            rentalServices.ProcessInvoice(carrental);

            Console.WriteLine();
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carrental.Invoice);

            Console.ReadLine();
        }
    }
}
