using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            RedPrinter redPrinter = new RedPrinter();

            redPrinter.Print("TEXT");

            (redPrinter as Printer).Print("TEXT");

            (redPrinter as RedPrinter).Print("TEXT");


        }
    }
}
