using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFinal.Models
{
    public class Whipped_Cream : Topping
    {
        public Whipped_Cream()
        {
            this.Name = "Whipped_Cream";
            this.Price += .1;
        }
    }
}
