﻿using System;

namespace CabInvoiceGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Console.WriteLine("Enter distance you want to Ride");
             double fare1 = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Enter time of your journey in minutes");
             int fare2 = Convert.ToInt32(Console.ReadLine());
             InvoiceGenerator example = new InvoiceGenerator(fare1, fare2);
             double fare = example.CalculateFare();
             Console.WriteLine("Fare: " + fare);*/

            /* Ride[] ride = { new Ride(20, 20), new Ride(20, 5) };
             InvoiceGenerator name = new InvoiceGenerator();
             double fare = name.MultipleRides(ride);*/

            InvoiceGenerator name = new InvoiceGenerator();
            Ride[] ride = { new Ride(20, 20), new Ride(10, 5), new Ride(30, 30) };
            EnhanceInvoice invoice = name.MultipleRides(ride);
            Console.WriteLine("TotalFare: " + invoice.totalFare + "\nNumberOfRides: " + invoice.numberOfRides + "\nAverage Fare: " + invoice.averageFare);
        }
    }
}
