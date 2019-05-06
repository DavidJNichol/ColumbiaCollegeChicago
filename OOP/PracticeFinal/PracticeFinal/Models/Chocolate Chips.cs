using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFinal.Models
{
    public class Chocolate_Chips : Topping
    {
        public Chocolate_Chips()
        {
            this.Name = "Chocolate_Chips";
            this.Price += .2;
        }
    }
}
