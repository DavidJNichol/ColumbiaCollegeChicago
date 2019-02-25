using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class Eletronic : Music
    {
        public Eletronic()
        {
            this.Artist = "ALOK";
            this.Song = "Underground";
            this.Volume = "150";
            this.SpeedIncreaser = 50;
        }
    }
}