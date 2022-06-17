using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        private readonly int COST_PER_MINUTE = 1;
        private readonly double MINIMUM_FARE = 5;
        private readonly double MINIMUM_COST_PER_KM = 10;
        public int time;
        public double distance;

        public double CalculateFare(Ride ride)
        {
            double totalFare = 0;
            if (ride.distance >= 0 && ride.time >= 0)
            {
                totalFare = ride.distance * MINIMUM_COST_PER_KM + ride.time * COST_PER_MINUTE;
            }
            else
            {
                if (ride.distance <= 0)
                {
                    throw new InvoiceGeneratorExceptions(InvoiceGeneratorExceptions.ExceptionType.INVALID_DISTANCE, "Invalid Distance");
                }
                if (ride.time < 0)
                {
                    throw new InvoiceGeneratorExceptions(InvoiceGeneratorExceptions.ExceptionType.INVALID_MINUTE, "Invalid Time");
                }
            }
            return Math.Max(totalFare, MINIMUM_FARE);
        }
        public double MultipleRides(Ride[] rides)
        {
            double totalFare = 0;
            try
            {
                foreach (var ride in rides)
                {
                    totalFare += CalculateFare(ride);
                }
            }
            catch (InvoiceGeneratorExceptions)
            {
                throw new InvoiceGeneratorExceptions(InvoiceGeneratorExceptions.ExceptionType.NULL_RIDES, "Rides Are Null");
            }
            Console.WriteLine("Total Fare: " + totalFare);
            return totalFare;
        }
    }
}
