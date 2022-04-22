// See https://aka.ms/new-console-template for more information
using LOGICALPROGRAMS;

Console.WriteLine("---------Logical Programs in C #-----------");
while(true)
{
    Console.WriteLine("Enter the option to choose the program : \n1)Fibonacci Series\n2)Perfect Number\n3)Prime Numbers");
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
        default:
            break;
    }
}
