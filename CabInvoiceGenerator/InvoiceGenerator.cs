using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    internal class InvoiceGenerator
    {
        private readonly int COST_PER_MINUTE = 1;
        private readonly double MINIMUM_FARE = 5;
        private readonly double MINIMUM_COST_PER_KM = 10;
        public int time;
        public double distance;
       
        public InvoiceGenerator(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
        public double CalculateFare()
        {
            double totalFare = 0;
            if (distance >= 0 && time >= 0)
            {
                totalFare = distance * MINIMUM_COST_PER_KM + time * COST_PER_MINUTE;
            }
            else
            {
                if (distance <= 0)
                {
                    throw new InvoiceGeneratorExceptions(InvoiceGeneratorExceptions.ExceptionType.INVALID_DISTANCE, "Invalid Distance");
                }
                if (time < 0)
                {
                    throw new InvoiceGeneratorExceptions(InvoiceGeneratorExceptions.ExceptionType.INVALID_MINUTE, "Invalid Time");
                }
            }
            return totalFare;
        }
    }
}
