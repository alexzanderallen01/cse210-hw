public class CheckListGoal : Goal
{
    private int _bonusPoints;
    private int _steps;
    private int _stepCounter;
    public CheckListGoal()
    {
        _name = "";
        _description = "";
        _goalPoints = 50;
        _bonusPoints = 0;
        _steps = 0;
        _stepCounter = 0;
    }
    public CheckListGoal(string name, string description, int goalPoints, int bonusPoints, int steps, int stepCounter)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _bonusPoints = bonusPoints;
        _steps = steps;
        _stepCounter = stepCounter;
    }
    public override void CreateChildGoal()
    {
        CreateBaseGoal();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _steps = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = Convert.ToInt32(Console.ReadLine());

        _stepCounter = 0;
    }
    public override bool IsComplete() 
    {
        if (_stepCounter >= _steps) {
            return true;
        } else {
            return false;
        }
    }
    public override void RecordEvent()
    {
        _stepCounter ++;
    }
    public override int CalculateAGP()
    {
        int points = _stepCounter * _goalPoints;

        bool status = IsComplete();

        if (status == true) {
            points += _bonusPoints;
        }
        return points;
    }
    public override void ListGoal()
    {
        string statusSymbol = "";
        bool status = IsComplete();
        if (status == true) {
            statusSymbol = "X";
        } else {
            statusSymbol = " ";
        }

        Console.Write($"[{statusSymbol}] {_name} ({_description}) -- Currently Completed {_stepCounter}/{_steps}");
    }
    public override string SaveGoal()
    {
        string line = "";
        line = $"CheckListGoal:" + _name + ":" + _description + ":" + _goalPoints.ToString() + ":" + _bonusPoints.ToString() + ":" + _steps.ToString() + ":" + _stepCounter.ToString();
        return line;
    }
}