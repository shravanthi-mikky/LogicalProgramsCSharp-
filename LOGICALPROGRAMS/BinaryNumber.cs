using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICALPROGRAMS
{
    public class BinaryNumber
    {
        public void BinaryNumberMethod()
        {
            Console.WriteLine("Enter the Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] arr =new int[number];
            for ( i = 0; number>0; i++)
            {
                arr[i] = (number % 2);
                number /= 2;
            }
            Console.Write("The Binary Number is : ");
            for( i = (i-1); i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
