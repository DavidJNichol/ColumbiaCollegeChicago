using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Class
{
    public abstract class Vehicle
    {
        public string Brand;
        public string Model;
        public string Color;
        public int VehicleCount;

        public Vehicle()
        {
            
        }

        public virtual string About()
        {
            string s = $"{this.Model} is a car made by {this.Brand} and is {this.Color}";
            return s;
        }

    }
}
