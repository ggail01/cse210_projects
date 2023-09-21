using System;
using System.Collections.Generic;
using System.Data;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 to finish");

        Console.Write("Enter a number: ");
        string userResponse = Console.ReadLine();
        number = int.Parse(userResponse);
            

        while (number != 0)
        {
            if (number != 0)
            {
                numbers.Add(number);

                Console.Write("Enter a number: ");
                userResponse = Console.ReadLine();
                number = int.Parse(userResponse);
            }
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

    }
}