using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFinal.Models
{
    public class Nuts: Topping
    {
        public Nuts()
        {
            this.Name = "Nuts";
            this.Price += .25;
        }
    }
}
