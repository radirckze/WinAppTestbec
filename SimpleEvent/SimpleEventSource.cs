using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleEvent
{

    public class SimpleEventSource
    {

        public event EventHandler<SimpleEventArgs> SimpleEvent;

        private int count = 0;

        public void CallSimpleEventSource()
        {
            count++;
            OnSimpleEvent(new SimpleEventArgs() { EventCount = count });
        }

        public void OnSimpleEvent(SimpleEventArgs eventArgs)
        {
            SimpleEvent(this, eventArgs);
        }

    }
}
