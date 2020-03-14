using System;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 7;
            var y = new A { a = 2 };
#if false
            while(true)
            { 
            }
#endif
        }
    }

    class A
    {
        public int a;
    }
}
