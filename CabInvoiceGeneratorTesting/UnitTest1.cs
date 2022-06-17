using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTesting
{
    public class Tests
    {
        // [Test]
        /*  public void GivenDistanceAndTime_ShouldReturnExpectedTotalFare()
          {
              double distance = 10;
              int time = 5, expected = 105;
              CabInvoiceGenerator.InvoiceGenerator example = new CabInvoiceGenerator.InvoiceGenerator(distance, time);
              Assert.AreEqual(expected, example.CalculateFare());
          }*/



        // [Test]
        /* public void GivenDistanceAndTime_ShouldReturnExpectedTotalFare()
         {
             double distance = 20;
             int time = 5, expected = 205;
             CabInvoiceGenerator.InvoiceGenerator example = new CabInvoiceGenerator.InvoiceGenerator();
             Ride ride = new Ride(distance, time);
             Assert.AreEqual(expected, example.CalculateFare(ride));
         }
         [Test]
         public void GivenMultipleRideData_ShouldReturnExpectedTotalFare()
         {
             int expected = 425;
             CabInvoiceGenerator.InvoiceGenerator example = new CabInvoiceGenerator.InvoiceGenerator();
             Ride[] ride = { new Ride(20, 20), new Ride(20, 5) };
             Assert.AreEqual(expected, example.MultipleRides(ride));
         }*/
        
        [Test]
        public void GivenMultipleRideData_ShouldReturnExpectedTotalFare_numberOfRides_AverageFare()
        {
            InvoiceGenerator fare = new InvoiceGenerator();
            Ride[] ride = { new Ride(20, 20), new Ride(10, 5), new Ride(30, 30) };
            double totalFare = 655, numberOfRides = ride.Length, averageFare = totalFare / numberOfRides;
            EnhanceInvoice result = fare.MultipleRides(ride);
            Assert.AreEqual(totalFare, result.totalFare);
            Assert.AreEqual(averageFare, result.averageFare);
            Assert.AreEqual(numberOfRides, result.numberOfRides);

        }
    }
}
