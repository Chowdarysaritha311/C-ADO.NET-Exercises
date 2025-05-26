using System;
using System.Threading;

class Program
{
    static object lock1 = new object();
    static object lock2 = new object();

    static void Thread1()
    {
        lock (lock1)
        {
            Thread.Sleep(100);
            if (Monitor.TryEnter(lock2, 1000))
            {
                Console.WriteLine("Thread1 acquired both locks");
                Monitor.Exit(lock2);
            }
            else
            {
                Console.WriteLine("Thread1 could not acquire lock2");
            }
        }
    }

    static void Thread2()
    {
        lock (lock2)
        {
            Thread.Sleep(100);
            if (Monitor.TryEnter(lock1, 1000))
            {
                Console.WriteLine("Thread2 acquired both locks");
                Monitor.Exit(lock1);
            }
            else
            {
                Console.WriteLine("Thread2 could not acquire lock1");
            }
        }
    }

    static void Main()
    {
        new Thread(Thread1).Start();
        new Thread(Thread2).Start();

        Thread.Sleep(2000);
        Console.WriteLine("Deadlock simulation complete");
    }
}
