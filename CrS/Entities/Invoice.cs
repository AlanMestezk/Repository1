
using System.Globalization;


namespace CrS.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        

        public Invoice() { }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }


        public override string ToString()
        {
            Console.WriteLine();
            Console.WriteLine($"                   Pagamento básico: {BasicPayment.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"                   Taxa: {Tax.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine($"                   Valor total: {TotalPayment.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            return "developer by AlanMestezk";
        }

    }
}
