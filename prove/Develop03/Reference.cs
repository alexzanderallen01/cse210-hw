using System;

public class Reference
{

    private string _book;
    private string _chapter;
    private string _verse;
    private string _secondVerse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _secondVerse = verse;
    }
    public Reference(string secondBook, string secondChapter, string verse, string secondVerse)
    {
        this._book = secondBook;
        this._chapter = secondChapter;
        this._verse = verse;
        this._secondVerse = secondVerse;
    }
    public string GetScripture()
    {
        if (_verse == _secondVerse)
        {
            string text = $"{_book} {_chapter}:{_verse}";
            return text;
        }
        else 
        {
            string text = $"{_book} {_chapter}:{_verse}-{_secondVerse}";
            return text;
        }
    }
}