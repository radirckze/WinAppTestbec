using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SimpleThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program is starting ...");
            SimpleTask simpleTask = new SimpleTask();
            Thread.Sleep(100);
            simpleTask.Command = SimpleTask.CommandType.Terminate;
            Console.WriteLine("Program is done ... Press any key to terminate.");
            Console.ReadLine();
        }
    }
}
