using System;
using System.Threading;

namespace ThreadsAndTasks_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            NumNum numNum1 = new NumNum("thread1");
            NumNum numNum2 = new NumNum("thread2");
            NumNum numNum3 = new NumNum("thread3");
            NumNum numNum4 = new NumNum("thread4");

            Console.WriteLine("Starting All Threads!");

            numNum1.Sleep();
            numNum2.Sleep();
            numNum3.Sleep();
            numNum4.Sleep();

            Console.WriteLine("All Threads Started!");
        }
    }

    public class NumNum
    {
        public int SleepTime { get; set; }
        public string NameOfThread { get; set; }
        public Thread thread;

        public NumNum(string threadName)
        {
            Random rnd = new Random();
            SleepTime = rnd.Next(0, 5000);
            NameOfThread = threadName;
            Console.WriteLine($"Thread {NameOfThread}; Sleep Time: {SleepTime}");
        }
        
        public void Sleep()
        {
            Console.WriteLine($"{this.NameOfThread} going to sleep!");
            this.thread = new Thread(() =>
            {
                Thread.Sleep(SleepTime);
            });
            Console.WriteLine($"{this.NameOfThread} done sleeping!");
            thread.Start();
            thread.Join();
        }
    }
}
