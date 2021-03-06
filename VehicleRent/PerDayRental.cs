﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public class PerDayRental
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
            if (daysHired < 0)
            {
                cost = 0; //days cannot be negative, therefore should default to zero.
                return cost;
            }
            else

            {
                cost = daysHired * 100;
                return cost;
            }
        }

    }
}
