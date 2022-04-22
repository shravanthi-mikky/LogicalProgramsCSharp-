// See https://aka.ms/new-console-template for more information
using LOGICALPROGRAMS;

Console.WriteLine("---------Logical Programs in C #-----------");
while(true)
{
    Console.WriteLine("Enter the option to choose the program : \n1)Fibonacci Series");
    int option = Convert.ToInt16(Console.ReadLine());
    switch(option)
    {
        case 1:
            Console.WriteLine("Fibonacci Series");
            Fibonacci fibonacci = new();
            fibonacci.FibonacciSeries();
            break;
        default:
            break;
    }
}
