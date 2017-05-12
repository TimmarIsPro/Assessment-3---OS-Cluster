using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    class PerDayRental
    {
        //variables here
        double cost;
        int daysHired;

        //default constructor
        public PerDayRental()
        {

        }

        //parameter constructor
        public PerDayRental(double pCost, int pDaysHired)
        {
            cost = pCost;
            daysHired = pDaysHired;
        }

        //get/sets
        public double Cost
        {
            get { return (cost); }
            set { cost = value; }
        }
        public int DaysHired
        {
            get { return (daysHired); }
            set { daysHired = value; }
        }

        public void addDays(int days)
        {
            daysHired = days;
        }

        public double getCost()
        {
            cost = daysHired * 100;
            return cost;
        }

    }
}
