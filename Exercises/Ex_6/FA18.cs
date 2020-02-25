using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_6
{
    class FA18 : Aircraft
    {
        internal void Description()
        {
            Console.WriteLine($"I am a F/A-18.");
        }

        internal void FLY()
        {
            Console.WriteLine("BRAAAAAA BRAAAAAAAA ");
        }
    }
}
