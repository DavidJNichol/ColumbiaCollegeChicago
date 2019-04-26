using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyingVehicleMidterm
{
    public class Airport
    {
        private int MaxVehicle;
        private List<AerialVehicle> Vehicles;

        public string AirportCode
        {
            get => default(string);
            set
            {
            }
        }

        public Airport()
        {
            this.MaxVehicle = 10;
            this.AirportCode = "1";

        }

        public Airport(string Code)
        {
            this.MaxVehicle = 10;
            this.AirportCode = Code;            
        }

        public Airport(string Code, int MaxVehicles)
        {
            this.MaxVehicle = MaxVehicles;
            this.AirportCode = Code;
            this.Vehicles = new List<AerialVehicle>();
        }

        public string Land(AerialVehicle a)
        {
            return $"{a.GetType().ToString().Replace("FlyingVehicleMidterm.", "")} has landed";
        }

        public string Land(List<AerialVehicle> landing)
        {
            if(this.Vehicles.Count() > this.MaxVehicle)
            {
                return "Sorry, too much Vehicles !";
            }
            else
            {
                string s = $"Landing: ";
                foreach (AerialVehicle ae in landing)
                {
                    s += $"{ae.GetType().ToString().Replace("FlyingVehicleMidterm.", "")},";
                }

                s += $" they are landing !";
                return s;
            }
        }

        public string AllTakeOff()
        {
            string s = $"";
            foreach(AerialVehicle ae in this.Vehicles)
            {
                if (ae.Engine.IsStarted)
                {
                    ae.IsFlying = true;
                    s += $"{ae.GetType().ToString().Replace("FlyingVehicleMidterm.", "")} is flying.\n";
                    
                }
                else
                {
                    s += $"{ae.GetType().ToString().Replace("FlyingVehicleMidterm.", "")} cannot fly.\n";
                    s += $"It's engine is not started.\n";
                }
            }
            return s;
        }

        public string TakeOff(AerialVehicle a)
        {
            if (a.Engine.IsStarted)
            {
                a.IsFlying = true;
                string s = $"{this} can fly , it is wound up.\n";
                s += $"{this} can fly it's engine is started.";

                return s;
            }
            else
            {
                string s = $"{this} can't fly , it is not wound up.\n";
                s += $"{this} can't fly it's engine is not started.";

                return s;
            }
        }
    }
}