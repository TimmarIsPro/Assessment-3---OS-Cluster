using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRent
{
    public class Vehicle
    {
        //Declared attributes
        private string manufacturer;
        private string model;
        private int makeYear;
        private string registration;
        private int vehicleId;

        private double travelDistance;
        private double fuelUsed;

        private double revenueKm;
        private double revenueDay;
        private double totalRevenue;

        private bool requiresService;


        //default constructor
        public Vehicle()
        {

        }

        //paramater constructor
        public Vehicle(string pManufacturer, string pModel, int pMakeYear, string pRegistration, double pTravelDistance, double pFuelUsed)
        {
            manufacturer = pManufacturer;
            model = pModel;
            makeYear = pMakeYear;
            registration = pRegistration;
            travelDistance = pTravelDistance;
            fuelUsed = pFuelUsed;
        }

        //get set methods

        public string Manufacturer
        {
            get { return (manufacturer); }
            set { manufacturer = value; }
        }
        public string Model
        {
            get { return (model); }
            set { model = value; }
        }
        public int MakeYear
        {
            get { return (makeYear); }
            set { makeYear = value; }
        }
        public string Registration
        {
            get { return (registration); }
            set { registration = value; }
        }
        public int VehicleId
        {
            get { return (vehicleId); }
            set { vehicleId = value; }
        }
        public double TravelDistance
        {
            get { return (travelDistance); }
            set { travelDistance = value; }
        }
        public double FuelUsed
        {
            get { return (fuelUsed); }
            set { fuelUsed = value; }
        }

        public override string ToString()
        { 
            return "Vehicle Id: " + vehicleId + ", Manufacturer: " + manufacturer + ", Model: " + model + ", Make Year:" + makeYear + ", Registration:" + registration;
        }
        
        public void addJourney(double distance)
        {
            travelDistance = travelDistance + distance;
        }

        public void addFuelPurchased(double fuel)
        {
            fuelUsed = fuelUsed + fuel;
        }
        public void addRevenueKm(double revKm)
        {
            revenueKm = revenueKm + revKm;
        }
        public void addRevenueDays(double revDay)
        {
            revenueDay = revenueDay + revDay;
        }

        public double addCombinedRevenue()
        {
            totalRevenue = totalRevenue + (revenueKm + revenueDay);
            return totalRevenue;
        }
        
        public void addServiceRequired(bool service)
        {
            requiresService = service;
        }


        public string printToScreen()
        {
            if (requiresService == false)
            {
                return "Id:" + vehicleId + "\n Manufacturer: " + manufacturer + "\n Model: " + model + "\n Make Year: " + makeYear + " \n Registration: " + registration + "\n Total km Travelled: " + travelDistance + " \n Total Services: " + Convert.ToInt32(travelDistance / 100) + "\n Fuel Economy: " + fuelUsed / (travelDistance / 100) + @" / L100km Total Revenue: $" + addCombinedRevenue() + " Requires Service: No";
            }
            else
            {
                return "Id:" + vehicleId + "\n Manufacturer: " + manufacturer + "\n Model: " + model + "\n Make Year: " + makeYear + " \n Registration: " + registration + "\n Total km Travelled: " + travelDistance + " \n Total Services: " + Convert.ToInt32(travelDistance / 100) + "\n Fuel Economy: " + fuelUsed / (travelDistance / 100) + @" / L100km Total Revenue: $" + addCombinedRevenue() + " Requires Service: Yes";
            }
            
        }
    }
}
