

using System.Globalization;
using CrS.Entities;
using CrS.Services;

namespace CrS
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                   ALUGUEL DE CARROS");
            Console.WriteLine();

            Console.WriteLine("             entre com os dados do aluguel");
            Console.WriteLine();
            Console.Write("                   Modelo do carro: ");
            string model = Console.ReadLine();
            Console.Write("                   Data e hora da retirada: ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InstalledUICulture);
            Console.Write("                   Data e hora de devolução: ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InstalledUICulture);


            Console.WriteLine();
            Console.WriteLine("                   esta quase no fim");
            Console.WriteLine();
            Console.Write("                   Preço por hora: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("                   Preço por dia: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            CarRental carRental = new(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine();
            Console.WriteLine("                   NOTA DO ALGUEL");
            Console.WriteLine(carRental.Invoice);
        }
     
    }
}
