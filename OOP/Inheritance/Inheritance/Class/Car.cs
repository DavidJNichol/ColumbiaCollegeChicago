using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Class
{
    public class Car : Vehicle
    {
        public string CarPlate;
        public int NumVehicle;
        public int NumOfDoors;
        public int TurnOnCount;
        

        public Car() : this("ABC1233")
        {

        }

        public Car(string newCarPlate)
        {
            this.CarPlate = newCarPlate;
            this.Brand = "Dodge";
            this.Model = "Challenger";
            this.Color = "Black";
            this.NumOfDoors = 4;
            this.VehicleCount++;
            this.NumVehicle = this.VehicleCount;

        }


        public virtual string TurnOn()
        {
            this.TurnOnCount++;
            return "Vroommmmm";
        }

        public int ShowHowManyTimesTurnedOn()
        {
            return this.TurnOnCount;
        }

        public override string About()
        {
            string CarAbout = base.About();
            CarAbout += $" . The Car Plate is :{this.CarPlate}, it has {this.NumOfDoors} doors and it has been turned on {this.TurnOnCount} times.";

            return CarAbout;

        }
    }
}
