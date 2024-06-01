public class Word
{
    private string _word;
    private bool _ishidden;

    public Word(string word)
    {
        _word = word;
        _ishidden = false;
    }
    public void Hide()
    {
        _ishidden = true;
    }
    public string GetText()
    {
        return _word;
    }
    public bool IsHidden()
    {
        return _ishidden;
    }
}