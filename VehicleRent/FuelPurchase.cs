using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    class FuelPurchase
    {
        //Declared attributes
        private double fuelPurchased;


        //default constructor
        public FuelPurchase()
        {

        }

        //parameter constructor
        public FuelPurchase(double jFuelPurchased)
        {
            fuelPurchased = jFuelPurchased;
        }

        public double FuelPurchased
        {
            get { return (fuelPurchased); }
            set { fuelPurchased = value; }
        }

    }
}
