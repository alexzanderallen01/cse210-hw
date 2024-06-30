using System;
public class Goal
{
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected bool _status;

    public Goal()
    {
        _name = "";
        _description = "";
        _goalPoints = 0;
        _status = false;
    }
    public Goal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
    }
    protected void CreateBaseGoal()
    {
        Console.WriteLine("What is the name of your goal");
        _name = Console.ReadLine();

        Console.WriteLine("What is a shot description of it");
        _description = Console.ReadLine();

        Console.WriteLine("What is the amount of points assciated with this goal? ");
        _goalPoints = Convert.ToInt32(Console.ReadLine());

        _status = false;
    }
    public virtual string SaveGoal()
    {
        return "";
    }
    public virtual void CreateChildGoal()
    {
        //
    }
    public virtual void RecordEvent()
    {
        //
    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual void ListGoal()
    {
        //
    }
    public virtual int CalculateAGP()
    {
        return 0;
    }
}