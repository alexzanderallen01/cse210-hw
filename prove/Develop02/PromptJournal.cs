using System;

public class PromptJournal
{
    public List<string> _prompts = new List<string>();
    public string _userResponse;
    
    
    public void PromptFile()
    {
        foreach (string line in File.ReadLines(@"..\..\..\Prompts.txt"))
        {
            _prompts.Add(line);
            
        }
    }
    
    public string WriteJournal()
    {
        Random rnd = new Random();
        string _prompt = _prompts[rnd.Next(0,4)];                       //prompt picked
        Console.WriteLine(_prompt);
        _userResponse = Console.ReadLine();                             //user writes journal

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();           //date of journal

        string writtenJournal = $"Date: {dateText} - Prompt: {_prompt} {_userResponse}";

        return writtenJournal;
    }

    public void DisplayJournal(List<string> _journal)
    {
        foreach (string lines in _journal)
        {
            Console.WriteLine(lines);
        }     
    }
}

