using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil Stydy");
        }
        public override void Read()
        {
            Console.WriteLine("BadPupil Read");
        }
        public override void Write()
        {
            Console.WriteLine("BadPupil Write");
        }
        public override void Relax()
        {
            Console.WriteLine("BadPupil Relax");
        }
    }
}
