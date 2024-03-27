using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int start = 1, end = 100;

        while (numbers.Count < 10)
        {
            try
            {
                Console.Write("Enter a number: ");
                if (!int.TryParse(Console.ReadLine(), out int number) || number <= start || number >= end)
                {
                    Console.WriteLine("Invalid Number or not in range!");
                    continue;
                }
                numbers.Add(number);
                start = number;
            }
            catch { Console.WriteLine("Error!"); }
        }

        Console.WriteLine(string.Join(", ", numbers));
    }
}
