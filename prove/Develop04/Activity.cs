using System;

public class Activity
{
    private string _name;
    private string _decription;
    private int _duration;

    public Activity()   //Pre set name, decription, & duration
    {
        _name = "";
        _decription = "";
        _duration = 10;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetDecription(string decription)
    {
        _decription = decription;
    }
    public void Setduration(int duration)
    {
        _duration = duration;
    }
    public void AskDuration()
    {
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string readDuration = Console.ReadLine();
        Setduration(Convert.ToInt32(readDuration));
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void ShowDetails()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_decription);
    }
    public void RunActivity()
    {
        Console.Clear();
        ShowDetails();
        AskDuration();
    }
    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Well done!");
        GenerateSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} second of the {_name}.");
        GenerateSpinner(10);
    }
    public void GenerateSpinner(int totalWait)
    {
        int spinWait = 150;
        DateTime futureTime = GetFutureTime(5);
        while (DateTime.Now <= futureTime)
        {
            List<string> spinnerChars = new List<string>() {"|", "/", "-", "\\"};
            foreach (string spinnerChar in spinnerChars)
            {
                Console.Write(spinnerChar);
                Thread.Sleep(spinWait);
                Console.Write("\b \b");
            }
        }

    }
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        GenerateSpinner(5);
    }
    public void GenerateCountdownTimer(int totalWait)
    {
        int timerwait = 1000;

        for (int i = 0; i <= (totalWait - 1); i++)
        {
            Console.Write($"{totalWait - i}");
            Thread.Sleep(timerwait);
            Console.Write("\b \b");
        }
    }
    public DateTime GetCurrentTime()
    {
        DateTime currentTime = new DateTime();
        currentTime = DateTime.Now;
        return currentTime;
    }
    public DateTime GetFutureTime(int duration)
    {
        DateTime futureTime = new DateTime();
        futureTime = DateTime.Now.AddSeconds(duration);
        return futureTime;
    }
}