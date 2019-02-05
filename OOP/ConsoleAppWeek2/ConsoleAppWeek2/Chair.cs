using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppWeek2
{
    public class Chair
    {
        //fields : Nouns. operators
        public int Height;
        public int NumLegs;
        public bool HasBack;
        public bool HeightAdjustable;

        //constructor
        public Chair()
        {
            //default propreties
            this.Height = 7;
            this.NumLegs = 4;
            this.HeightAdjustable = false;
            this.HasBack = true;
        }

        //methods : Verbs operations
        /// <summary>
        ///  
        /// </summary>
        public void RaiseHeight()
        {
            //Only adjust height if it is ajustable
            if (this.HeightAdjustable)
            {
                this.Height++;
            }            
        }

        public void LowerHeight()
        {
            if (this.HeightAdjustable)
            {
                this.Height--;
            }
        }

        public string About()
        {
            return $"I have {this.NumLegs} legs, is {this.Height} and {this.GetHeightAdjustableString()} and {this.GetHasBackString()}";
        }

        private string GetHasBackString()
        {
            string heightString = "has back";
            if (this.HasBack)
            {
                return heightString;
            }

            return "has not back";
        }

        private string GetHeightAdjustableString()
        {
            string adjustString = "the height is adjustable";
            if (this.HeightAdjustable)
            {
                return adjustString;
            }

            return "not adjustable";
        }
    }
}