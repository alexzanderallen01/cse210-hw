using System;
public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void ListComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int CountComment()
    {
        int count = _comments.Count;
        return count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"title: {_title}, Author: {_author}, Length: {_length}");
        Console.WriteLine();
        Console.WriteLine($"Number of comments: {CountComment()}");
        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo();
        }
    }
}