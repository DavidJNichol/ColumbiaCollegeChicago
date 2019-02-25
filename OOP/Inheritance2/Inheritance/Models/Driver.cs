using Inheritance.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class Driver
    {
        public string Name;
        public string CredentialIdentifier;
        public bool IsAuthorized;

        public Driver()
        {
            this.Name = "Angelo";
            this.CredentialIdentifier = "ANJ12345678";
            this.IsAuthorized = false;
        }

        public string AboutDriver()
        {
            string s = $"{this.Name} has the license {this.CredentialIdentifier} and he {this.GetAuthorization()} authorized to drive";
            return s;
        }

        public string GetAuthorization()
        {
            if (this.IsAuthorized)
            {
                return "is";
            }
            return "is not";
        }

        public void GetAVehicle(Vehicle v)
        {
            v.Owner = this;
        }

    }
}