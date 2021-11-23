using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsAndTasks_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(() =>
            {
                string path = @"C:\Program Files\JetBrains\PyCharm Community Edition 2021.1.1\bin";
                string[] files = Directory.GetFiles(path);
                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine(files[i]);
                }
            });

            Thread thread1 = new Thread(() =>
            {
                string path = @"C:\Program Files\JetBrains\PyCharm Community Edition 2021.1.1\license";
                string[] files1 = Directory.GetFiles(path);
                for (int i = 0; i < files1.Length; i++)
                {
                    Console.WriteLine(files1[i]);
                }
            });

            thread.Start();
            thread1.Start();

            var t1 = Task.Run(() =>
            {
                string path = @"C:\Program Files\JetBrains\PyCharm Community Edition 2021.1.1\bin";
                string[] files = Directory.GetFiles(path);
                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine(files[i]);
                }
            });

            var t2 = Task.Run(()=>
            {
                string path = @"C:\Program Files\JetBrains\PyCharm Community Edition 2021.1.1\license";
                string[] files1 = Directory.GetFiles(path);
                for (int i = 0; i < files1.Length; i++)
                {
                    Console.WriteLine(files1[i]);
                }
            });

            t1.Wait();
            t2.Wait();


        }
    }
}
