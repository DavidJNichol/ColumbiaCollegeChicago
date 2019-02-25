using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Class
{
    public sealed class Eletric : Car
    {

        public override string TurnOn()
        {
            return "Eltric Car does not make sound when turn it on";
        }
    }
}
