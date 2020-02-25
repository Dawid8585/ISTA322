using quiz7;
using System;

namespace Quiz_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quiz 7");
            IFirearm s = new Shotgun();
            s.stuff("shotgun", "Boom");
            IFirearm r = new Rifle();
            r.stuff("rifle", "Bang");
            IFirearm p = new Pistol();
            p.stuff("Pistol", "Pop");

        }
    }
 }




