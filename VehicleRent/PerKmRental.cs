using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    class PerKmRental
    {
        //variables here
        double travelDistance;
        double cost;

        //default constructor
        public PerKmRental()
        {

        }

        //parameter constructor
        public PerKmRental(double pTravelDistance, double pCost)
        {
            travelDistance = pTravelDistance;
            cost = pCost;
        }

        //get/sets
        
        public double TravelDistance
        {
            get { return (travelDistance); }
            set { travelDistance = value; }
        }
        public double Cost
        {
            get { return (cost); }
            set { cost = value; }
        }

        public void addJourney(double distance)
        {
            travelDistance = distance;
        }

        public double getCost()
        {
            cost = travelDistance * 1;
            return cost;
        }
    }
}
