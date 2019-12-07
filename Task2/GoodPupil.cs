using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil Stydy");
        }
        public override void Read()
        {
            Console.WriteLine("GoodPupil Read");
        }
        public override void Write()
        {
            Console.WriteLine("GoodPupil Write");
        }
        public override void Relax()
        {
            Console.WriteLine("GoodPupil Relax");
        }
    }
}
