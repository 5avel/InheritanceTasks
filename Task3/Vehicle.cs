using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public abstract class Vehicle
    {
        public int X { get; set; }
        public int Y { get; set; }

        public decimal Price { get; set; }
        public int Speed { get; set; }
        public int Year { get; set; }

        public Vehicle(int x, int y, decimal price, int speed, int year)
        {
            this.X = x;
            this.Y = y;
            this.Price = price;
            this.Speed = speed;
            this.Year = year;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"X:{X}\nY:{Y}\nPrice:{Price}\nSpeed:{Speed}\nYear:{Year}");
        }
                
    }
}
