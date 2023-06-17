using System;
using System.Threading;

namespace ThreadSample
{
    class Program
    {
        static void Test()
        {
            for (int i = 1; i <= 100; i++)
                Console.WriteLine("Test:" + i);
        }
         static void Main(string[] args)
        {
            Thread T1 = new Thread(Test);  
            Test();
            Console.ReadLine();
        }
    }
}
     