using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle> {
                new Car(1, 2, 35000, 220, 2015),
                new Ship(12, 22, 3500000, 40, 2015) { PassengersCount = 1500, Port = "Portu" },
                new Plane(132, 232, 15000000, 1300, 2015) { PassengersCount = 350, Hight = 10000 }
            };

            foreach (var v in vehicles)
                v.GetInfo();
        }
    }
}
