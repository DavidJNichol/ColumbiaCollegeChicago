using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidtermPractice
{
    public class Pencil
    {
        public bool isSharp;

        public Pencil()
        {
            this.isSharp = true;
        }

        public void Shapen()
        {
            this.isSharp = true;
        }

        public string Write(string whatToWrite)
        {
            this.isSharp = false;
            return $"{this} writes {whatToWrite}";
        }

        public string About()
        {
            if (this.isSharp)
            {
                string s = $"The pencil is sharp";
                return s;
            }
            else
            {
                string s = $"The pencil is not sharp ";
                return s;
            }            
        }

        
    }
}