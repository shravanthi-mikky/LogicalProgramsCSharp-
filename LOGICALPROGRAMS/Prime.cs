using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICALPROGRAMS
{
    public class Prime
    {
        public void Prime_Number()
        {
            Console.WriteLine("Enter the Number : ");
            int number = Convert.ToInt16(Console.ReadLine());
            int count = 0;
            for(int i = 2; i < number; i++)
            {
                if((number % i) == 0)
                {
                    count++;
                }
            }
            if (count == 0)
                Console.WriteLine(number + " is prime Number");
            else
                Console.WriteLine(number + " is not a Prime Number!");
        }
    }
}

