using System;

public class Activity
{
    private string _name;
    private string _decription;
    private int _duration;

    public Activity()   //string name, string decription, int duration
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
        GenerateSpinner(20);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} second of the {_name}.");
        GenerateSpinner(20);
    }
    public void GenerateSpinner(int totalWait)
    {
        int spinWait = 500;
        int loopSpinner = 5;
        while (loopSpinner != 0)
        {
            List<string> spinnerChars = spinnerList();
            foreach (string spinnerChar in spinnerChars)
            {
                Console.Write(spinnerChar);
                Thread.Sleep(spinWait);
                Console.Write("\b \b");
            }
            loopSpinner -= 1;
        }

    }
    public List<string> spinnerList()
    {
        List<string> spinnerChars = new List<string>();
        spinnerChars.Add("|");
        spinnerChars.Add("/");
        spinnerChars.Add("-");
        spinnerChars.Add("\\");
        return spinnerChars;
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

        for (int i = 0; i <= totalWait; i++)
        {
            Console.Write($"{totalWait - i} ");
            Thread.Sleep(timerwait);
        }
    }
}