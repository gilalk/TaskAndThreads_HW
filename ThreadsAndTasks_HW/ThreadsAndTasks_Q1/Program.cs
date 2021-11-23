using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsAndTasks_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(() =>
            {
                for (int i = 1; i <= 5000; i++)
                {
                    Console.WriteLine(i);
                }
            });
            thread.Start();

            Task task = new Task(() =>
            {
                for (int i = 1; i <= 5000; i++)
                {
                    Console.WriteLine(i);
                }
            });

            task.Start();
        }
    }
}
