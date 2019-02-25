using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Class
{
    public class Motorcycle : Vehicle
    {
        public string MotorcyclePlate;
        public int NumMotorcycle;
        public int TurnOnCount;


        public Motorcycle() : this("ZXC8521")
        {

        }

        public Motorcycle(string newMotorcyclePlate)
        {
            this.MotorcyclePlate = newMotorcyclePlate;
            this.Brand = "Ducati";
            this.Model = "Monster";
            this.Color = "Pink";
            this.VehicleCount++;
            this.NumMotorcycle = this.VehicleCount;

        }


        public virtual string TurnOn()
        {
            this.TurnOnCount++;
            return "TOTOTOTOTOTO";
        }

        public int ShowHowManyTimesTurnedOn()
        {
            return this.TurnOnCount;
        }

        public override string About()
        {
            string MotorcycleAbout = base.About();
            MotorcycleAbout += $" . The Motorcycle Plate is :{this.MotorcyclePlate}, it hasn't doors and it has been turned on {this.TurnOnCount} times.";

            return MotorcycleAbout;

        }
    }
}
