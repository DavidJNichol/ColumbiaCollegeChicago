using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyingVehicleMidterm
{
    public class Helicopter : AerialVehicle
    {
        public bool HasTailRotor;
        public int NumRotors;

        public Helicopter()
        {
            this.MaxAltitude = 8000;
            this.CurrentAltitude = 0;
            this.HasTailRotor = true;
            this.NumRotors = 2;
        }

        public Helicopter(int NumOfRotors, bool HasTailRotor)
        {
            this.NumRotors = NumOfRotors;
            this.HasTailRotor = HasTailRotor;
        }

        public override string About()
        {
            return $"{base.About()} {HasTailRotorString()}";
        }

        public string HasTailRotorString()
        {
            string s = $"{this.Engine} ";
            s += $"rotors: {this.NumRotors} and has tail rotor: {this.HasTailRotor}\n";

            return s;
        }
    }
}