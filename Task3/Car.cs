using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class Car : Vehicle
    {
        public Car(int x, int y, decimal price, int speed, int year)
            :base(x, y, price, speed, year)
        {
        }
    }
}
