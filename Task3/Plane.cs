using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Plane : Vehicle
    {
        public int PassengersCount { get; set; }
        public int Hight { get; set; }


        public Plane(int x, int y, decimal price, int speed, int year)
            : base(x, y, price, speed, year)
        {

        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"PassengersCount:{PassengersCount}\nHight:{Hight}");
        }
    }
}
