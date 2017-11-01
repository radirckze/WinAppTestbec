using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleThreading
{
    public class SimpleTask
    {

        public enum CommandType { Initial, Run, Complete, Terminate };

        public CommandType Command { get; set; }

        public Thread  TaskRunner = null;

        public SimpleTask()
        {
            this.Command = CommandType.Initial;

            TaskRunner = new Thread(DoTask);
            TaskRunner.Start();
        }

        public void DoTask()
        {
            while (this.Command != CommandType.Complete && this.Command != CommandType.Terminate)
            {
                Console.WriteLine("DoTask is doing something ...");
                TaskRunner.Join(10);
            }

            Console.WriteLine("DoTask command is: {0}", Command.ToString());
        }

    }
}
