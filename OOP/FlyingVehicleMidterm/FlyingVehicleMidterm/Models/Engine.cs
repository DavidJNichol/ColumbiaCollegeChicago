using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyingVehicleMidterm
{
    public class Engine
    {
        public bool IsStarted;

        public Engine()
        {
            this.IsStarted = false;
        }

        public void Start()
        {
            this.IsStarted = true;
        }

        public void Stop()
        {
            this.IsStarted = false;
        }

        public string About()
        {
            string s = $"Is Started: {this.IsStarted}";
            return s;
        }
    }
}