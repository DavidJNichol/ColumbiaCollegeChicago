using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyingVehicleMidterm
{
    public class Airplane : AerialVehicle
    {
        public Airplane()
        {
            this.MaxAltitude = 41000;
            this.CurrentAltitude = 0;
            this.picure = "Airplane.bmp";
            LoadPicture();
        }

        public override string About()
        {
            if (this.Engine.IsStarted)
            {
                string s = base.About();
                s += $"{this} engine is started";
                return s;
            }
            else
            {
                string s = base.About();
                s += $"{this} engine is not started";
                return s;
            }
        }
    }
}