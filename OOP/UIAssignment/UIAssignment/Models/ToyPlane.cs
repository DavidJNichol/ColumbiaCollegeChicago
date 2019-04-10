using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyingVehicleMidterm
{
    public class ToyPlane : Airplane
    {
        public bool isWoundUp;

        public ToyPlane()
        {
            this.MaxAltitude = 50;
            this.CurrentAltitude = 0;
            this.isWoundUp = false;
        }

        public override void StartEngine()
        {
            if (this.isWoundUp)
            {
                base.StartEngine();
            }
            else
            {
                Console.WriteLine("It's not wound up !");
            }
        }

        public void WindUp()
        {
            this.isWoundUp = true;
        }

        public void UnWind()
        {
            this.isWoundUp = false;
        }

        public override string TakeOff()
        {
            return base.TakeOff();
        }

        public string getWindUpString()
        {
            string s = $"";
            return s;
        }

        public override string About()
        {
            if (this.isWoundUp)
            {
                string s = $"{base.About()}\n";
                s += "it's no wound up.";

                return s;
            }
            else
            {
                string s = $"{base.About()}\n";
                s += "it's wound up.";

                return s;
            }
        }
    }
}