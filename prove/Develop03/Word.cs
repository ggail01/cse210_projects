using System;

public class Word
{
    private string _text;
    private bool _hidden;

    //Constructor
    public Word(string text, bool hidden = false)
    {
        _text = text;
        _hidden = hidden;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetRenderedText()
    {
        return _text;
    }
}