using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class Reagge : Music
    {
        public Reagge()
        {
            this.Artist = "SOJA";
            this.Song = "Slow Down";
            this.Volume = "50";
            this.SpeedIncreaser = -10;
        }
    }
}