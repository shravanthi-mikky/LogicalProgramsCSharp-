// See https://aka.ms/new-console-template for more information
using LOGICALPROGRAMS;

Console.WriteLine("---------Logical Programs in C #-----------");
while(true)
{
    Console.WriteLine("Enter the option to choose the program : \n1)Fibonacci Series\n2)Perfect Number\n3)Prime Numbers\n4)Reverse a Number\n5)stop watch\n6)Coupon Codes");
    int option = Convert.ToInt16(Console.ReadLine());
    switch(option)
    {
        case 1:
            Console.WriteLine("Fibonacci Series");
            Fibonacci fibonacci = new();
            fibonacci.FibonacciSeries();
            break;
        case 2:
            PerfectNumber perfect = new();
            perfect.Perfect_Number();
            break;
        case 3:
            Prime prime = new();
            prime.Prime_Number();
            break;
        case 4:
            ReverseANumber reverse = new();
            reverse.Reverse();
            break;
        case 5:
            Stop_Watch watch = new();
            watch.Test();
            break;
        case 6:
            CouponCode coupon = new();
            coupon.Coupon();
            break;

        default:
            break;
    }
}




