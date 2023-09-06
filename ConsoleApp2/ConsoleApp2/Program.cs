using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        public int count;
        public string s;
        string thrdName;
        public Program(string Name)
        {
            count = 0;
            thrdName = Name;
        }
        public void run()
        {
            s = thrdName + "strting \n";
            do
            {
                Thread.Sleep(50);
                s = s + "In " + thrdName + ", count is " + count + "\n";
                count++;
            } while (count < 10);
            s += thrdName + " terminating.\n";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starting. \n");
            Program mt = new Program("Thread #1");
            Thread newThrd = new Thread(mt.run);
            newThrd.Start();
            do
            {
                Thread.Sleep(10);

            } while (mt.count != 10);
            Console.WriteLine($"{mt.s}");
            Console.WriteLine($"\n main thread ending.");
            Console.ReadKey();


        }
    }
}
