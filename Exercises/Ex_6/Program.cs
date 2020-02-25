using System;

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These are the Aircraft the Marine Corps has:");
            MV22 avi = new MV22();
            avi.Description();
            avi.PRINT();
            avi.Funny();
            avi.FLY();
            int topspeed = avi.topspeed();
            Console.WriteLine($"Im going {avi.currentspeed} MPH");
            Console.WriteLine($"My top speed is {topspeed} MPH");
            avi.bye();

            CH53E heli = new CH53E();
            heli.Description();
            heli.Funny();
            heli.FLY();
            heli.bye();

            FA18 plane = new FA18();
            plane.Description();
            plane.Funny();
            plane.FLY();
            plane.bye();


            Console.WriteLine("These are our units");
            Mals26 ui = new Mals26();
            ui.Atype();
            ui.PRINT();

            VMM363 vmm = new VMM363();
            vmm.unit();
            vmm.under();
            vmm.ammount();
            vmm.PRINT();

        }
    }
}
