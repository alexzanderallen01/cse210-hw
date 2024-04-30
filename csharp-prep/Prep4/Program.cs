using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number;
        int total = 0;
        do
        {
            Console.WriteLine("Enter number");
            string userguess = Console.ReadLine();
            number = int.Parse(userguess);
            if (number != 0)
            {
                numbers.Add(number);
            }
            
        } while (number != 0);
        Console.WriteLine("loop complete");
        Console.WriteLine(numbers.Count);
        int count = numbers.Count;
        int max = 0;

        foreach (int i in numbers)
        {
            total = total + i;
            if (max < i)
            {
                max = i;
            }
        }
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {total/count}");
        Console.WriteLine($"The largest number is: {max}");
    }
}