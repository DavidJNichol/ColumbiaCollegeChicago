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
        public int Speed;
        public int VehicleCount;

        //Containment
        public Driver Owner;

        public Vehicle()
        {
            this.Owner = new Driver();
        }

        public virtual string About()
        {
            string s = $"{this.Owner.Name} is the owner of this {this.Model} made by {this.Brand} in {this.Color}";
            return s;
        }

        public virtual void Drive(Driver d)
        {
            d.IsAuthorized = true;
        }

    }
}
