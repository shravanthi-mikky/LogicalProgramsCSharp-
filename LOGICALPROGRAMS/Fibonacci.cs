using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICALPROGRAMS
{
    public class Fibonacci
    {
        public void FibonacciSeries()
        {
            Console.WriteLine("Enter the Number : ");
            int num = Convert.ToInt16(Console.ReadLine());
            int n1 = 0, n2 = 1, n3=0;
            Console.WriteLine(n2);
            Console.Write("Fibonacci Series of "+num+" is "+ n1 +" "+ n2 + " ");
            for (int i = 0; n3 < num; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3+" ");
                n1 = n2;
                n2 = n3;
             
            }
            Console.WriteLine("\n ");
        }
    
    }
}
