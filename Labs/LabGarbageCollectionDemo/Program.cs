using System;

namespace LabGarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Garbage collector lab");

                using (Calculator calculator = new Calculator())
                {
                int dividend = calculator.Divide(120, 0);
                Console.WriteLine($"Divedend is {dividend}");
                   // Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");
                }

                //Calculator calculator = new Calculator();
                // Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");
                Console.WriteLine("Program finishing");
            }
        }
    }
}
