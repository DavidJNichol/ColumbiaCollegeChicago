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
            List<Vehicle> vehicles;
            vehicles = new List<Vehicle>();
            vehicles.Add(new Car("ABC1234"));
            vehicles.Add(new Car("ANJ9874") { Brand = "Jaguar", Model = "FType", Color = "White", NumOfDoors = 2 });
            vehicles.Add(new Motorcycle("DEF5678"));
            vehicles.Add(new Eletric() { Brand = "Tesla", Model = "ModelS", Color = "Red", NumOfDoors = 4 });

            


            foreach(Vehicle v in vehicles)
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
