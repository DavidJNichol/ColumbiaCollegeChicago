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
            this.isWoundUp = false; ;
        }

        public string TakeOff()
        {
            string s = $"";
            return s;
        }

        public string getWindUpString()
        {
            string s = $"";
            return s;
        }

        public string About()
        {
            string s = $"Is wound up: {this.isWoundUp}";

            return s;
        }
    }
}