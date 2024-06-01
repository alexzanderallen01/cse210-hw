using System;
using System.IO; 
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways ackowledge him; and he shall drict thy paths.";
    
        Scripture scripture = new Scripture("Proverbs", "3", "5", "6", scriptureText);
        Console.Clear();
        scripture.Display();
        Console.WriteLine("\n\nPress Enter to contine or type 'quite' to exit.");
        while (true)
        {
            string userResponse = Console.ReadLine();
            if (userResponse == "quite")
            {
                break;
            }


            Console.Clear();
            scripture.Display();
            Console.WriteLine("\n\nPress Enter to contine or type 'quite' to exit.");
        }
        
    }
}