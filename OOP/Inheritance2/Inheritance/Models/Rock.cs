using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class Rock : Music
    {
        public Rock()
        {
            this.Artist = "Bring me to the Horizon";
            this.Song = "Doomed";
            this.Volume = "25";
            this.SpeedIncreaser = 100;
        }
    }
}