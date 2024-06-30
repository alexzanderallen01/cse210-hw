using System;
using System.IO;
public class GoalTracker
{
    private List<Goal> _goal = new List<Goal>();
    private int _accumulatedPoints = 0;
    public void addGoal(Goal goal)
    {
        _goal.Add(goal);
    }
    public int GetAccumulatedPoints() 
    {
        return _accumulatedPoints;
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter((fileName + ".txt")))
        {
            int totalAGP = GetAccumulatedPoints();
            outputFile.WriteLine(totalAGP.ToString());
            
            foreach(Goal goal in _goal)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }
    public void LoadGoals()
    {
        _goal.Clear(); 

        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines((fileName + ".txt"));

        _accumulatedPoints = Convert.ToInt32(lines[0]);
        
        for (int i = 1; i < lines.Count(); i++ )
        {
            string[] parts = lines[i].Split(":");

            if (parts[0] == "SimpleGoal") {

                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                Console.WriteLine($"{parts[1]}, {parts[2]}, {parts[3]}, {parts[4]}");
                _goal.Add(simpleGoal);             

            } else if (parts[0] == "EternalGoal") {

                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                _goal.Add(eternalGoal);

            } else if (parts[0] == "CheckListGoal") {
                
                CheckListGoal checklistGoal = new CheckListGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));
                _goal.Add(checklistGoal);

            }
        }
    }
    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goal.Count(); i++)
        {
            Console.Write($"{i + 1}. ");
            _goal[i].ListGoal();
            Console.Write("\n");
        }
        Console.WriteLine();
    }
    public int CalculateTotalAGP()
    {
        int totalAGP = _accumulatedPoints;
        foreach(Goal goal in _goal) {
            totalAGP += goal.CalculateAGP();
        }

        _accumulatedPoints = totalAGP;

        return totalAGP;
    }
    public void RecordEventInTracker()
    {
        Console.Write("Which goal did you accomplish? ");
        string goalIndex = Console.ReadLine();
        int goalIndexInt = Convert.ToInt32(goalIndex) - 1;

        if (_goal[goalIndexInt].IsComplete() == false) {

            _goal[goalIndexInt].RecordEvent();

            int pointsEarned = _goal[goalIndexInt].CalculateAGP();

            _accumulatedPoints += pointsEarned;

            Console.WriteLine($"Congratulations! You have earned {pointsEarned.ToString()} points!");
            Console.WriteLine($"You now have {_accumulatedPoints} points");

        } else {

            Console.WriteLine("You have already completed this goal.");

        }
    }
}