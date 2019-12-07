using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentPupil Stydy");
        }
        public override void Read()
        {
            Console.WriteLine("ExcelentPupil Read");
        }
        public override void Write()
        {
            Console.WriteLine("ExcelentPupil Write");
        }
        public override void Relax()
        {
            Console.WriteLine("ExcelentPupil Relax");
        }
    }
}
