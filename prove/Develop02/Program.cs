using System;

class Program
{
    static void Main(string[] args)
    {
        
        int programLoop = 1;
        PromptJournal promptJournal1 = new PromptJournal();
        JournalFile journalFile1 = new JournalFile();
        promptJournal1.PromptFile();
        while (programLoop == 1)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            int userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                journalFile1._journal.Add(promptJournal1.WriteJournal());
            }
            else if (userChoice == 2)
            {
                promptJournal1.DisplayJournal(journalFile1._journal);
            }
            else if (userChoice == 3)
            {
                journalFile1._journal.Clear();
                journalFile1._journal = journalFile1.Load();
            }
            else if (userChoice == 4)
            {
                journalFile1.Save();
            }
            else if (userChoice == 5)
            {
                programLoop = 2;
            }
        }
    }
}