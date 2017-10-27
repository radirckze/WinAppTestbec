using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleEvent
{
    public class Program
    {

        static void Main(string[] args)
        {

            SimpleEventSource seSource = new SimpleEventSource();
            SimpleEventSink seSink = new SimpleEventSink();

            seSource.SimpleEvent += SimpleEventSink.SimpleEventHandler;

            for(int i=0; i<3; i++)
            {
                seSource.CallSimpleEventSource();
            }

            Console.WriteLine("Enter any key to end");
            Console.ReadLine();


        }

    }
}
