using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public abstract class Music
    {
        public string Song;
        public string Artist;
        public string Volume;
        public int SpeedIncreaser;

        public Music()
        {
            this.Artist = "Anyone";
            this.Song = "Any song";
            this.Volume = "0";
            this.SpeedIncreaser = 10;
        }

    }
}