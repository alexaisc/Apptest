using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest
{
    class Trip
    {
        //Variables
        private string destination;
        private double distanceTraveled;
        private double totalCostOfGasoline;
        private double numberOfGallonsConsumed;

        //Constructor
        public Trip(string destin, double disTrav, double cosGas, double numGal)
        {
            Destination = destin;
            DistanceTraveled = disTrav;
            TotalCostOfGasoline = cosGas;
            NumberOfGallonsConsumed = numGal;
        }
        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }
        public double DistanceTraveled
        {
            get
            {
                return distanceTraveled;
            }
            set
            {
                distanceTraveled = value;
            }
        }
        public double TotalCostOfGasoline
        {
            get
            {
                return totalCostOfGasoline;
            }
            set
            {
                totalCostOfGasoline = value;
            }
        }
        public double NumberOfGallonsConsumed
        {
            get
            {
                return numberOfGallonsConsumed;
            }
            set
            {
                numberOfGallonsConsumed = value;
            }
        }
        //Methods
        public double milesPerGallon()
        {
            double result = DistanceTraveled / NumberOfGallonsConsumed;
            return result;
        }
        public double costPerMile()
        {
            double result = TotalCostOfGasoline / DistanceTraveled;
            return result;
        }
        public override string ToString()
        {
            return "Destination:" + Destination +
                "\nDistance traveled:" + DistanceTraveled +
                "\nTotal cost of gasoline:" + TotalCostOfGasoline.ToString("c") +
                "\nNumber of Gallons Consumed:" + NumberOfGallonsConsumed.ToString("f1") + " Gallons";
        }
    }
}
