using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICALPROGRAMS
{
    public class PerfectNumber
    {
        public void Perfect_Number()
        {
            Console.WriteLine("Enter the Number : ");
            int num = Convert.ToInt16(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }

            }
            if (sum == num)
                Console.WriteLine(num + " is Perfect Number!");
            else
                Console.WriteLine(num+" is not perfect Number!");

        }
          
         
    }
}
