// See https://aka.ms/new-console-template for more information

using demo;

Console.Write("Enter a number: ");

string numInput = Console.ReadLine();

int num = int.Parse(numInput);

for (int i = 0; i < num; i++)
{
    Console.Write($"{Fibonacci.fib(i)} ");
}



