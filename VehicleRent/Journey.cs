using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    class Journey
    {
      //Declared attributes
        private double distanceTravelled;


        //default constructor
        public Journey()
        {

        }

        //parameter constructor
        public Journey(double jDistanceTravelled)
        {
            distanceTravelled = jDistanceTravelled;
        }

        public double DistanceTravelled
        {
            get { return (distanceTravelled); }
            set { distanceTravelled = value; }
        }
    }
}
