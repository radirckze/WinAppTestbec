using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleEvent
{
    public class SimpleEventSink
    {

        public static void SimpleEventHandler(object sender, SimpleEventArgs eventArgs)
        {
            Console.WriteLine("SimpleEvent has been raised {0} times.", eventArgs.EventCount);
        }
    }
}
