using System;

namespace CabInvoiceGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter distance you want to Ride");
            int fare1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter time of your journey in minutes");
            int fare2 = Convert.ToInt32(Console.ReadLine());
            InvoiceGenerator example = new InvoiceGenerator(fare1, fare2);
            double fare = example.CalculateFare();
            Console.WriteLine("Fare: " + fare);

        }
    }
}
