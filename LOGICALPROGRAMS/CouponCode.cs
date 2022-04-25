using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICALPROGRAMS
{
    public class CouponCode
    {
        public void Coupon()
        {
            Console.WriteLine("Enter number of coupons");
            int number = int.Parse(Console.ReadLine());
            string coupons = string.Empty;
            while (number > 0)
            {
                int random = new Random().Next(1, 123);
                coupons += (char)random;
                 number--;
            }
            Console.WriteLine("Your coupon number is " + coupons);
        }
    }
}
