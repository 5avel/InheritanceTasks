using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];

       
        public ClassRoom(Pupil p0, Pupil p1)
        {
            pupils[0] = p0;
            pupils[1] = p1;
            pupils[2] = new BadPupil();
            pupils[3] = new ExcelentPupil();
        }

        
        public ClassRoom(Pupil p0, Pupil p1, Pupil p2)
        {
            pupils[0] = p0; //Заполение массива значениями
            pupils[1] = p1;
            pupils[2] = p2;
            pupils[3] = new BadPupil();
        }
       
        public ClassRoom(Pupil p0, Pupil p1, Pupil p2, Pupil p3)
        {
            pupils[0] = p0;
            pupils[1] = p1;
            pupils[2] = p2;
            pupils[3] = p3;
        }


        public void Study()
        {
            foreach (Pupil p in pupils)
            {
                p.Study();
            }
        }
        public void Write()
        {
            foreach (Pupil p in pupils)
            {
                p.Write();
            }
        }
        public void Read()
        {
            foreach (Pupil p in pupils)
            {
                p.Read();
            }
        }
        public void Relax()
        {
            foreach (Pupil p in pupils)
            {
                p.Relax();
            }
        }
    }
}
