using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        GoalTracker goals = new GoalTracker();

        while (input != "6")
        {
            int points = goals.GetAccumulatedPoints();

            //Console.Clear();
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                Console.WriteLine("The Types of Goals are: ");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalType = Console.ReadLine();
                Console.Clear();
                
                if (goalType == "1")
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.CreateChildGoal();
                    goals.addGoal(simpleGoal);
                }
                else if (goalType == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.CreateChildGoal();
                    goals.addGoal(eternalGoal);
                }
                else if (goalType == "3")
                {
                    CheckListGoal checkListGoal = new CheckListGoal();
                    checkListGoal.CreateChildGoal();
                    goals.addGoal(checkListGoal);
                }
            }
            else if (input == "2")
            {
                Console.Clear();
                goals.ListGoals();
                Console.ReadLine();
            }
            else if (input == "3")
            {
                Console.Clear();
                goals.SaveGoals();
            }
            else if (input == "4")
            {
                Console.Clear();
                goals.LoadGoals();
            }
            else if (input == "5")
            {
                Console.Clear();
                goals.ListGoals();
                goals.RecordEventInTracker();
            }
            else if (input == "6")
            {
                Console.Clear();
                Console.WriteLine("Good bye.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please select a valid number from the menu options.");
            }
        }
    }
}