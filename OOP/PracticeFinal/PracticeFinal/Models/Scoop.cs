using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeFinal
{
    public class Scoop
    {
        public Flavor flavor;
        public double Price;

        public Scoop() : this(Flavor.Vanilla)
        {

        }

        public Scoop(Flavor f)
        {
            this.Price = .5;
            this.flavor = f;
        }
    }
}