using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("BreathingActivity");
        SetDecription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
    public void PromptBreathing()
    {
        while (currentTime <= futureTime) //Make these functions. Thank you team!
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            GenerateCountdownTimer(5);
            Console.WriteLine();
            Console.WriteLine("Breathe out...");
            GenerateCountdownTimer(5);
        }
    }
}