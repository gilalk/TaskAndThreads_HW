using System;
using System.Threading;

namespace ThreadsAndTasks_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            SumALotOfNumbers summy1 = new SumALotOfNumbers(1, 200000);

            SumALotOfNumbers summy2 = new SumALotOfNumbers(200001, 400000);

            SumALotOfNumbers summy3 = new SumALotOfNumbers(400001, 600000);

            SumALotOfNumbers summy4 = new SumALotOfNumbers(600001, 800000);

            SumALotOfNumbers summy5 = new SumALotOfNumbers(800001, 1000000);

            Console.WriteLine(SumALotOfNumbers.sum);

            long summ = 0;
            for (long i = 1; i <= 1000000; i++)
            {
                summ = summ + i;
            }

            Console.WriteLine(summ);
        }
    }

    public class SumALotOfNumbers
    {
        public Thread thread;
        public static long sum;

        public SumALotOfNumbers(long start, long end)
        {
            if(start > end)
            {
                start = start + end;
                end = start - end;
                start = start - end;
            }

            thread = new Thread(() =>
            {
                for (long i = start; i <= end; i++)
                {
                    sum = sum + i;
                }
            });
            thread.Start();
            thread.Join();
        }
    }
}
