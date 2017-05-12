using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//A good piece of software by Timothy Stewart

namespace VehicleRent
{
    public partial class Main : Form
    {
        Vehicle[] vehicles = new Vehicle[100];


        int count = 0; //Determines maximum position in array

        
        public Main()
        {

            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        { 
            for (int i = 0; i < count; i++) //searches all positions in array
            {
                if (Convert.ToInt32(txtId.Text) == vehicles[i].VehicleId) //looks for vehicle id that matches input
                {
                    Journey distance = new Journey();
                    FuelPurchase fuel = new FuelPurchase();
                    PerDayRental days = new PerDayRental();
                    PerKmRental km = new PerKmRental();

                    distance.DistanceTravelled = Convert.ToDouble(txtTravelled.Text);
                    fuel.FuelPurchased = Convert.ToDouble(txtFuel.Text);
                    days.DaysHired = Convert.ToInt32(txtDays.Text);
                    km.TravelDistance = distance.DistanceTravelled;

                    vehicles[i].addJourney(distance.DistanceTravelled);
                    vehicles[i].addFuelPurchased(fuel.FuelPurchased);
                    km.getCost();
                    days.getCost();
                    vehicles[i].addRevenueDays(days.Cost);
                    vehicles[i].addRevenueKm(km.Cost);

                    listAllInfo.Items.Add(vehicles[i].printToScreen()); //displays full information to listbox
                }
            }
            


        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            //adds a new vehicle and displays relevant information in the vehicle listbox
            vehicles[count] = new Vehicle();
            vehicles[count].Manufacturer = txtManufacturer.Text;
            vehicles[count].Model = txtModel.Text;
            vehicles[count].MakeYear = Convert.ToInt32(txtMakeYear.Text);
            vehicles[count].Registration = txtRegistration.Text;
            vehicles[count].VehicleId = count;
            listOutput.Items.Add(vehicles[count]);
            count++;

        }



    }
}
