using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Printer
    {
        protected ConsoleColor textColor = ConsoleColor.White;

        public Printer()
        {
        }

        public virtual void Print(string text)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(text);
        }
    }
}
