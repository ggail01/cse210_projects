using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    //Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideWords(int count)
    {
        Random random = new Random();
        List<Word> _wordsToHide = new List<Word>();
        foreach (Word word in _words)
        {
            if(!word.IsHidden())
            {
                _wordsToHide.Add(word);
            }
        }

        for (int i = 0; i < count && _wordsToHide.Count > 0; i++)
        {
            int index = random.Next(0, _wordsToHide.Count);
            _wordsToHide[index].Hide();
        }

    }

    public string GetRenderedText()
    {
        List<string> _displayText = new List<string>();
        string renderedText = _reference.GetRenderedText();
        foreach (Word word in _words)
        {
            renderedText += word.GetRenderedText() + " ";
            _displayText.Add(word.IsHidden() ? new string('_', word.GetRenderedText().Length) : word.GetRenderedText());
        }
        return $"{_reference.GetRenderedText()}\n{string.Join(" ", _displayText)}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

}