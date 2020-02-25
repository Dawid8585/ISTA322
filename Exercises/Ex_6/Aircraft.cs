using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_6
{
    class Aircraft
    {
        public int currentspeed;

        public void PRINT()
        {
            Console.WriteLine("Current Air Speed in MPH " + currentspeed);
        }

        public virtual void Description()
        {
           
            Console.WriteLine($"I am a Aircaft.");
        }
        public virtual void FLY()
        {
            Console.WriteLine("I FLY!");
        }
        public virtual void Funny()
        {
            Console.WriteLine("I guees im going to take off now!");
        }
        public virtual void bye()
        {
            Console.WriteLine("CYA LATER ALLIGATOR\n");
        }

    }
}
