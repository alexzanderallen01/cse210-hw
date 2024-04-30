using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int sqnumber = SquareNumber(number);
        DisplayResult(name, sqnumber);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        return number*number;
    }
    static void DisplayResult(string name, int sqnumber)
    {
        Console.WriteLine($"{name}, the square of your number is {sqnumber}");
    }
}