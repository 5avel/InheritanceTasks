using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class RedPrinter: Printer
    {
        ConsoleColor textColor = ConsoleColor.Red;

        public new void Print(string text)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(text);
        }
    }
}
