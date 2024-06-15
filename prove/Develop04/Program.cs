using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        int breathingLog = 0;
        int reflectingLog = 0;
        int ListingLog = 0;
        void DisplayLog()
        {
            Console.WriteLine("Activity Log - Current Session");
            Console.WriteLine($"Breathing Activity: {breathingLog}");
            Console.WriteLine($"Reflecting Activity: {reflectingLog}");
            Console.WriteLine($"Listing Activity: {ListingLog}");
            Console.WriteLine();
        }
        while (input != "4")
        {
            Console.Clear();
            DisplayLog();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.RunActivity();
                breathingActivity.PromptBreathing();
                breathingActivity.EndActivity();
                breathingLog++;
            }
            else if (input == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.RunActivity();
                reflectingActivity.PromptReflecting();
                reflectingActivity.EndActivity();
                reflectingLog++;
            }
            else if (input == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.RunActivity();
                listingActivity.PromptListing();
                listingActivity.EndActivity();
                ListingLog++;
            }
        }
    }
}