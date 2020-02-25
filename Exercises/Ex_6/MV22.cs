using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_6
{
    class MV22 : Aircraft
    {

        
        public virtual void Description()
        {
            Console.WriteLine($"I am a MV-22.");

        }
      
        public virtual void FLY()
        {
       
            Console.WriteLine("WAAAAP WAAAAP");
            base.currentspeed += 162;
        }
        public virtual int topspeed()
        {
            int topspeed = 351;
            return topspeed;
        }
    }
}
