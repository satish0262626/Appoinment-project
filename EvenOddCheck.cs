
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is an Even number.");
        }
        else
        {
            Console.WriteLine($"{number} is an Odd number.");
        }
    }
}
