using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIAssignment.Models;

namespace FlyingVehicleMidterm
{
    public abstract class AerialVehicle : Sprite
    {
        public int CurrentAltitude;
        public Engine Engine;
        public bool IsFlying;
        public int MaxAltitude;

        public AerialVehicle()
        {
            this.CurrentAltitude = 0;
            this.IsFlying = false;
            this.MaxAltitude = 1000;
            this.Engine = new Engine();

        }

        public void FlyDown()
        {
            this.CurrentAltitude -= 1000;

            if (this.CurrentAltitude < 1001)
            {
                Console.WriteLine("It can't Fly down 1000ft !");
                this.CurrentAltitude += 1000;
            }
            else
            {
                Console.WriteLine("Flying down !");
            }
            
        }

        public void FlyDown(int HowManyFeet)
        {
            this.CurrentAltitude -= HowManyFeet;

            if (this.CurrentAltitude < 0)
            {
                Console.WriteLine("It can't Fly down 0ft !");
                this.CurrentAltitude += HowManyFeet;
            }
            else
            {
                Console.WriteLine("Flying down !");
            }
            
        }

        public void FlyUp()
        {
            this.CurrentAltitude += 1000;

            if (this.CurrentAltitude > this.MaxAltitude)
            {
                Console.WriteLine($"It can't Fly up to {this.MaxAltitude} !");
                this.CurrentAltitude -= 1000;
            }
            else
            {
                Console.WriteLine("Flying up !");
            }
            
        }

        public void FlyUp(int HowManyFeet)
        {
            this.CurrentAltitude += HowManyFeet;

            if (this.CurrentAltitude > this.MaxAltitude)
            {
                Console.WriteLine($"It can't Fly up to {this.MaxAltitude} !");
                this.CurrentAltitude -= HowManyFeet;
            }
            else
            {
                Console.WriteLine("Flying up !");
            }
        }

        public virtual void StartEngine()
        {
            this.Engine.Start();
        }

        public void StopEngine()
        {
            this.Engine.Stop();
        }

        public string getEngineStartedString()
        {
            string EngineStartedString = $"empty";
            return EngineStartedString;
        }

        public virtual string TakeOff()
        {
            if (this.Engine.IsStarted)
            {
                this.IsFlying = true;
                string s = $"{this} can fly , it is wound up.\n";
                s += $"{this} can fly it's engine is started.";

                return s;
            }
            else
            {
                string s = $"{this} can't fly , it is not wound up.\n";
                s += $"{this} can't fly it's engine is not started.";

                return s;
            }
        }

        public virtual string About()
        {
            string s = $"This {this} has a max altitude of {this.MaxAltitude}\n";
            s += $"It's current altitude is {this.CurrentAltitude}\n";
            
            return s;
        }
    }
}