using System;

public class Scripture
{
    private Reference _reference;
    private string _scriptureText;
    private List<Word> _scriptureWords;
    private string _completeReference;

    public Scripture(string book, string chapter, string verse, string secondVerse, string scriptureText)
    {
        _reference = new Reference(book, chapter, verse, secondVerse);
        _completeReference = _reference.GetScripture();
        _scriptureText = scriptureText;
        _scriptureWords = new List<Word>();

        string[] words = _scriptureText.Split(' ');
        foreach (var word in words)
        {
            _scriptureWords.Add(new Word(word));        //using Word class as a list. Thank you google.
        }
    }

    public void Display()
    {
        Console.WriteLine($"{_completeReference}:");
        foreach (Word word in _scriptureWords)
        {
            if (word.IsHidden())
            {
                Console.Write(new string('_', word.GetText().Length) + " ");        //Getting length of word to put the same amount of _. Credit to my friend Garrett for openning my mind to this
            }
            else
            {
                Console.Write(word.GetText() + " ");
            }
        }
    }

    private List<Word> AllSeeableWords()
    {
        List<Word> seeableWords = new List<Word>();
        foreach (Word word in _scriptureWords)
        {
            if (!word.IsHidden())
            {
                seeableWords.Add(word);
            }
        }
        return seeableWords;
    }
    public bool HideRandomWord()
    {
        List<Word> seeableWords = AllSeeableWords();
        if (seeableWords.Count == 0)             //should close program if all words hidden
        {
            return false;
        }
        Random random = new Random();
        int randomIndex = random.Next(seeableWords.Count);
        seeableWords[randomIndex].Hide();
        int randomIndex1 = random.Next(seeableWords.Count);
        seeableWords[randomIndex1].Hide();

        return true;
    }
}