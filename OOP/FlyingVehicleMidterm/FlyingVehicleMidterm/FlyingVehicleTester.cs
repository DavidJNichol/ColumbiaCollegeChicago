using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyingVehicleMidterm
{
    public class FlyingVehicleTester
    {
        public void Test()
        {
            Console.WriteLine("Flying Vehicle Tester......................................................");
            AirpaneTest();      //Test Aiplane Class
            ToyPlaneTest();     //Test ToyPlane Class
            HelicopterTest();   //Test Helicopter Class
            Console.WriteLine("All Done................");
            Console.ReadKey();
        }

        public void HelicopterTest()
        {
            Helicopter chopper = new Helicopter();
            Console.WriteLine(chopper.About());
            ///*
            // * Output:
            // * This OOPFlyingVehicle.Helicopter has a max altitude of 8000 ft.
            // * It's current altitude is 0 ft.
            // * OOPFlyingVehicle.Engine is not started. 2 : rotors and has tail rotor.
            // */
        }

        public void ToyPlaneTest()
        {
            //ToyPlane class tests
            Console.WriteLine("\nToyPlane.cs Tests.........................................................");

            ToyPlane tp = new ToyPlane();
            Console.WriteLine(tp.About());
            ///*
            // * Output:
            // * This OOPFlyingVehicleMidterm.ToyPlane has a max altitude of 50 ft.
            // */
            Console.WriteLine("\ncall tp.TakeOff() shoudn't take off");
            Console.WriteLine(tp.TakeOff());
            Console.WriteLine("\nCall tp.StartEngine():");
            tp.StartEngine();
            Console.WriteLine("Call tp.TakeOff():");
            Console.WriteLine(tp.TakeOff());
            Console.WriteLine("\nCall tp.windUp():");
            tp.WindUp();
            Console.WriteLine("Call tp.StartEngine():");
            tp.StartEngine();
            Console.WriteLine("Call tp.TakeOff():");
            Console.WriteLine(tp.TakeOff());

        }

        public void AirpaneTest()
        {
            Console.WriteLine("\nAirlplane.cs...............................................................");

            /*
             * Airplane class tests
             * many of the airplane class methods return a string we will write these to the console for testing
             */
            Airplane ap = new Airplane();
            //Air plane should inherit from AerialVehicle
            Console.WriteLine(ap.About());
            /* Output AirplaneAbout:
             * This OOPFlyingVehicle.Airplane has a max altitude of 41000 ft.
             * It's current altitude is 0 ft.
             * OOPFlyingVehicleMidterm.Airplane engine is not started
             */

            Console.WriteLine("\nAireplaneTakeOffTests...............................................................");
            Console.WriteLine("\nCall ap.TakeOff():");
            //Test take off should fail engine isn't started
            Console.WriteLine(ap.TakeOff());  //Don't take off engine isn't started
                                              /* Output:
                                               * OOPFlyingVehicleMidterm.Airplane can't fly it's engine is                  *                   not started.
                                               */
            Console.WriteLine("\nCall ap.StartEngine():");
            ap.StartEngine();
            Console.WriteLine(ap.TakeOff());  //take off engine is started
                                              /* Output:
                                               * OOPFlyingVehicleMidterm.Airplane is flying
                                               */

            //Fly up
            Console.WriteLine("\nFly up Tests...................................................................");
            Console.WriteLine("Call ap.FlyUp() fly to 1,000ft default");
            ap.FlyUp();    //Fly up tp 1,000 ft
            Console.WriteLine(ap.About());
            Console.WriteLine("\nCall ap.FlyUp(44000) Fly up to 45,000ft:");
            ap.FlyUp(44000);    //Fly up tp 45,000 ft shouldn't work
            Console.WriteLine(ap.About());
            Console.WriteLine("\nCall ap.FlyUp(44000) Fly up another 40,000ft shouldn't work");
            ap.FlyUp(40000);    //Fly up tp 41,000 ft shouldn't work
            Console.WriteLine(ap.About());

            //Land
            Console.WriteLine("\nFly Down.................................................................");
            Console.WriteLine("Call ap.FlyDown(50000) Fly Down 50,000 ft");
            ap.FlyDown(50000);   //Land by flying down 50,000 ft = Crash and shouldn't work
            Console.WriteLine(ap.About());
            Console.WriteLine("Call ap.FlyDown(ap.CurrentAltitude) this should land");
            ap.FlyDown(ap.CurrentAltitude); //Land by flying down current altitiute
            Console.WriteLine(ap.About());

        }

    }
}