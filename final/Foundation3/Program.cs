using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressL = new Address("101 E Viking St", "Rexburg,", "ID", "83460");
        Lecture lecture = new Lecture("Micro Robotic Engineering", "A simple break down of micro robotic engineering for youth", "October 1, 2030", "6pm", addressL, "stephen hawking", 100);
        
        Console.Clear();
        Console.WriteLine("Event 1:");
        Console.WriteLine("Would you like to view the standard details (1), full details (2), or the short description (3): ");
        string choice = Console.ReadLine();
        Console.WriteLine();
        if (choice == "1")
        {
            Console.WriteLine(lecture.GenerateStandard());
        }
        else if (choice == "2")
        {
            Console.WriteLine(lecture.GenerateDetailedLecture());
        }
        else if (choice == "3")
        {
            Console.WriteLine(lecture.GenerateShortLecture());
        }

        Address addressR = new Address("101 E Viking St", "Rexburg,", "ID", "83460");
        Reception reception = new Reception("Devotional on the use of social media.", "Come talk with missionaries from New York on how social media can help you get closer to the Lord.", "October 11, 2025", "6pm", addressR, "devotional@gmail.com");
        Console.WriteLine();
        Console.WriteLine("Event 2:");
        Console.WriteLine("Would you like to view the standard details (1), full details (2), or the short description (3): ");
        choice = Console.ReadLine();
        Console.WriteLine();
        if (choice == "1")
        {
            Console.WriteLine(reception.GenerateStandard());
        }
        else if (choice == "2")
        {
            Console.WriteLine(reception.GenerateDetailedReception());
        }
        else if (choice == "3")
        {
            Console.WriteLine(reception.GenerateShortReception());
        }

        Address addressOG = new Address("7135 N Linder Rd", "Meridian,", "ID", "83646");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Church BBQ", "4th of July church BBQ gathering", "July 4, 2025", "6-8pm", addressOG, "Sunny");
        Console.WriteLine();
        Console.WriteLine("Event 3:");
        Console.WriteLine("Would you like to view the standard details (1), full details (2), or the short description (3): ");
        choice = Console.ReadLine();
        Console.WriteLine();
        if (choice == "1")
        {
            Console.WriteLine(outdoorGathering.GenerateStandard());
        }
        else if (choice == "2")
        {
            Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());
        }
        else if (choice == "3")
        {
            Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
        }
    }
}