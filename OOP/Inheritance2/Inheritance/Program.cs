using Inheritance.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIST OF VEHICLES
            List<Vehicle> vehicles;
            vehicles = new List<Vehicle>();
            vehicles.Add(new Car("ABC1234"));
            vehicles.Add(new Car("ANJ9874") { Brand = "Jaguar", Model = "FType", Color = "White", NumOfDoors = 2 });
            vehicles.Add(new Motorcycle("DEF5678"));
            vehicles.Add(new Eletric() { Brand = "Tesla", Model = "ModelS", Color = "Red", NumOfDoors = 4 });

            //LIST OF DRIVERS
            List<Driver> drivers;
            drivers = new List<Driver>();
            drivers.Add(new Driver() { });
            drivers.Add(new Driver() {Name = "Bowser", CredentialIdentifier = "MKT20182019"});
            drivers.Add(new Driver() { Name = "Captain Falcon", CredentialIdentifier = "FLC99999999" });
            drivers.Add(new Driver() { Name = "Toreto", CredentialIdentifier = "V&F98765432" });

            //LIST OF MUSIC
            List<Music> usb;
            usb = new List<Music>();
            usb.Add(new Eletronic() { Song = "She's On My Mind", Artist = "JP Cooper", Volume = "80", SpeedIncreaser = 7 });
            usb.Add(new Rock() {});
            usb.Add(new Reagge() { Song = "Sorry", Artist = "SOJA", Volume = "60", SpeedIncreaser = 2 });

            //Shows which music is playing and how increase the Speed while playing music
            //Start
            Car car1 = (Car)vehicles[1];
            for(int i = 0; i < 3; i++)
            {
                car1.RecordMusicUSB(usb[i]);
                Console.WriteLine(car1.About());
                Console.WriteLine(car1.PlayMusic(i));
                Console.WriteLine(car1.About());
                Console.WriteLine("");
            }
            //End
            Console.WriteLine("");
            //Insert a Different Owner to a Vehicle
            //Start
            for (int i = 0; i < 3; i++)
            {
                drivers[i].GetAVehicle(vehicles[i]);
                Console.WriteLine(vehicles[i].About());
            }
            //End
            Console.WriteLine("");
            foreach (Vehicle v in vehicles)
            {
                for(int i = 0; i < 5; i++)
                {
                   if(v is Car)
                    {
                        ((Car)v).TurnOn();
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    if (v is Motorcycle)
                    {
                        ((Motorcycle)v).TurnOn();
                    }
                }

                for (int i = 0; i < 1; i++)
                {
                    if (v is Eletric)
                    {
                        ((Eletric)v).TurnOn();
                    }
                }


                Console.WriteLine(v.About());

                if(v is Eletric)
                {
                    Console.WriteLine(((Eletric)v).TurnOn());
                }else if(v is Car)
                {
                    Console.WriteLine(((Car)v).TurnOn());
                }
                else if(v is Motorcycle)
                {
                    Console.WriteLine(((Motorcycle)v).TurnOn());
                }
            }

            Console.ReadKey();
        }
    }
}
