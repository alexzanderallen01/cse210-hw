using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade percentage: ");
        string answer = Console.ReadLine();
        int gradePercent = int.Parse(answer);
        string grade = "";

        if (gradePercent >= 90)
        {
            grade = "A";
        }
        else if (gradePercent >= 80)
        {
            grade = "B";
        }
        else if (gradePercent >= 70)
        {
            grade = "C";
        }
        else if (gradePercent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Grade: {grade}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("You passed your class! Good job");
        }
        else
        {
            Console.WriteLine("You failed, but with everything you learned, you can pass next time");
        }
    }
}