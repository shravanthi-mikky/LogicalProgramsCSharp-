using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICALPROGRAMS
{
    public class Stop_Watch
    {
        public void Test()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Choose the option 1 to start : ");
            int start = Convert.ToInt32(Console.ReadLine());
            if(start == 1)
            {
                // Begin timing.
                stopwatch.Start();
            }

            // Do something.
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1);
            }
            Console.WriteLine("Choose the option 2 to start : ");
            int stop = Convert.ToInt32(Console.ReadLine());
            if (stop == 2)
            {
                // Stop timing.
                stopwatch.Stop();
            }

            // Write result.
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
