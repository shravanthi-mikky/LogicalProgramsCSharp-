using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICALPROGRAMS
{
    public class ReverseANumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter the Number : ");
            long number = Convert.ToInt32(Console.ReadLine());
            long rev = 0;
            for (int i = 0; number>0; i++)
            {
                rev = (rev * 10) + (number % 10);
                number /= 10;
            }
            Console.WriteLine("Reverse of number is :",rev);
        }
    }
}
