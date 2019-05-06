using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFinal.Models
{
    public class Sprinkles : Topping
    {
        public Sprinkles()
        {
            this.Name = "Sprinkles";
            this.Price += .1; 
        }
    }
}
