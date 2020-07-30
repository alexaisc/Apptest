using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppTest
{
    [TestClass]
    public class TripTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Trip trip = new Trip("USA", 3000, 500, 25);
            Console.WriteLine(trip);
        }
        [TestMethod]
        public void MilesPerGalon()
        {
            Trip trip = new Trip("USA", 2000, 500, 99);
            double milesPerGalon = trip.milesPerGallon();
            Assert.AreEqual(milesPerGalon, 20.2020, 0.0001);
        }
        [TestMethod]
        public void CostPerMile()
        {
            Trip trip = new Trip("USA", 3000, 500, 25);
            double milesPerGalon = trip.costPerMile();
            Assert.AreEqual(milesPerGalon, 0.161616, 0.01);
        }
    }
}
