using System;

public class JournalFile
{
    public List<string> _journal = new List<string>();
    static List<string> _savedJournalNames = new List<string>();

    

    public void Save()
    {
        Console.WriteLine("File name: ");
        string _fileName = Console.ReadLine();
        string _filePath = _fileName + ".txt";
        
                        
        if (!File.Exists($@"../../../savedJournals/{_filePath}"))
        {
            File.Create(_filePath);
            TextWriter tw = new StreamWriter($@"../../../savedJournals/{_filePath}");

            foreach (string line in _journal)
            {
                Console.WriteLine(line);
                tw.WriteLine(line);
            }
            
            tw.Close();
            _savedJournalNames.Add($@"../../../savedJournals/{_filePath}");
        }
        else if (File.Exists(_filePath))
        {
            TextWriter tw = new StreamWriter($@"../../../savedJournals/{_filePath}");
            foreach (string line in _journal)
            {
                tw.WriteLine(line);
            }
            tw.Close(); 
        }
    }
    public List<string> Load()
    {
        Console.WriteLine("Saved files: (Please only include the name. Not the .txt)");
        string[] _filedata = Directory.GetFiles($@"../../../savedJournals/");
        foreach (string name in _filedata) 
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("File name to be loaded: ");
        string _fileName = Console.ReadLine();
        string _filePath = _fileName + ".txt"; 

        var lines = File.ReadAllLines($@"../../../savedJournals/{_filePath}");
        for (var i = 0; i < lines.Length; i += 1)
        {
            var line = lines[i];
            _journal.Add(line);
            
        }
        return _journal;
        
    }

}