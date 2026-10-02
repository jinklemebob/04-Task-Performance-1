using System;
using System.Threading;

namespace _04_Task_Performance_1
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            Thread thread = Thread.CurrentThread;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(
                    "Name of Thread: " + thread.Name + " Process = " + i
                );

                Thread.Sleep(500);
            }
        }

        public static void Thread2()
        {
            Thread thread = Thread.CurrentThread;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(
                    "Name of Thread: " + thread.Name + " Process = " + i
                );

                Thread.Sleep(1500);
            }
        }
    }
}