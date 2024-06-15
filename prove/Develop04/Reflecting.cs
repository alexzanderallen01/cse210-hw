using System;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a scenario where you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a moment when you extended help to someone in need.",
        "Think of an experience where you demonstrated genuine selflessness."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDecription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }
    public string GeneratePrompt()
    {
        Random random = new Random();
        int i = random.Next(0, _prompts.Count);
        return _prompts[i];
    }
    public string GenerateQuestion()
    {
        Random random = new Random();
        int i = random.Next(0, _questions.Count);
        return _questions[i];
    }
    public void PromptReflecting()
    {
        string prompt = GeneratePrompt();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();

        DateTime futureTime = GetFutureTime(GetDuration());
        while (DateTime.Now <= futureTime)
        {
            string question = GenerateQuestion();
            Console.Write(question + " ");
            GenerateSpinner(15);
            Console.WriteLine();
        }
    }
}