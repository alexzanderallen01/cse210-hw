using System;

public class WritingAssignment : Assignment
{
    //Console.WriteLine("Hello Learning04 World!");
    string _title;

    public WritingAssignment(string studentName, string topic, string title) :base (studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformantion()
    {
        string _studentName = GetStudentName();
        return $"{_title} by {_studentName}";
    }
}