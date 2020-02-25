using System;
using System.Collections.Generic;
using System.Text;

namespace quiz7
{
    class Rifle : IFirearm
    {
        public void stuff(string v1, string v2)
        {
            Console.WriteLine($"I am a {v1} and I go {v2}");
        }
    }
}
