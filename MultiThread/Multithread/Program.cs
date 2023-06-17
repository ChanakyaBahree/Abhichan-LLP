using System;
using System.Threading;

namespace Multithread
{
    class MainClass
    {
        static void Test1()
        {
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Test1:" + i);
        }
        static void Test2()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i == 10)

                {
                    Console.WriteLine("Main Thread going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Main Thread woke up");
                }

                Console.WriteLine("Test2:" + i);
            }
           
        }
        static void Test3()
        {
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Test3:" + i);
        }



        public static void Main(string[] args)
        {
            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);
            T1.Start(); T2.Start(); T3.Start();
            Console.WriteLine("Thread Main is Exiting");

        }
    }
}
