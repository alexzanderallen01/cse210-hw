using System;

public class MathAssignment : Assignment
{
    //Console.WriteLine("Hello Learning04 World!");
    String _textBookSection;
    string _problems;

    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeWork()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}