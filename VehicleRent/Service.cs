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

        //default constructor
        public Service()
        {

        }

        //parameter constructor
        public Service(bool sServiceRequired)
        {
            serviceRequired = sServiceRequired;
        }

        //get/sets
        public bool ServiceRequired
        {
            get { return (serviceRequired); }
            set { serviceRequired = value; }
        }


    }
}
