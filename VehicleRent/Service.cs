using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    class Service
    {

        //variables here
        bool serviceRequired;
        double distance;

        //default constructor
        public Service()
        {

        }

        //parameter constructor
        public Service(bool sServiceRequired, double sDistance)
        {
            serviceRequired = sServiceRequired;
            distance = sDistance;
        }

        //get/sets
        public bool ServiceRequired
        {
            get { return (serviceRequired); }
            set { serviceRequired = value; }
        }
        public double Distance
        {
            get { return (distance); }
            set { distance = value; }
        }


        
        public bool serviceCheck()
        {
            double calculation = distance;

            do
            {
                    //the bit in here needs to find the mod value to determine if a service is required or not
                calculation = calculation - 100;
            } while (calculation > 100);

            calculation = calculation % 100;
            if (calculation == 0)
            {
                serviceRequired = true;
            }
            else
            {
                serviceRequired = false;
            }
            return serviceRequired;
        }


    }
}
