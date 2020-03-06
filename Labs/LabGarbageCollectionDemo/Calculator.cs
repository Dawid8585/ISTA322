using System;
using System.Collections.Generic;
using System.Text;

namespace LabGarbageCollectionDemo
{
    class Calculator : IDisposable
    {
        private bool disposed = false;
        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }


        public int Divide(int first, int second)
        {
            return first / second;
        }
        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            this.Dispose();
        }
        public void Dispose()
        {
            Console.WriteLine("Calculator being disposed");

            if (!this.disposed)
                Console.WriteLine("Calculator being disposed, disposed is false ");

           this.disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
