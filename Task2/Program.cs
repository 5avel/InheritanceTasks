using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(
                new GoodPupil(),
                new Pupil()
                );

            classRoom.Study();
            classRoom.Write();
            classRoom.Read();
            classRoom.Relax();
        }
    }
}
