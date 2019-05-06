using PracticeFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            IceCreamSugarCone icsc = new IceCreamSugarCone();
            icsc.AddScoop(new Scoop());
            icsc.AddTopping(new Sprinkles());

            IceCreamWaffleCone icwc = new IceCreamWaffleCone();
            icwc.AddScoop(new Scoop(Flavor.MintChocolateChip));
            icwc.AddScoop(new Scoop(Flavor.MintChocolateChip));
            icwc.AddTopping(new Whipped_Cream());

            IceCreamSundae ics = new IceCreamSundae();
            ics.AddScoop(new Scoop(Flavor.PeanuButter));
            ics.AddTopping(new Sprinkles());
            ics.AddTopping(new Whipped_Cream());
            ics.AddTopping(new Cherry());


            Console.WriteLine(icsc.About());
            Console.WriteLine(icwc.About());
            Console.WriteLine(ics.About());

            Console.ReadKey();
        }
    }
}
