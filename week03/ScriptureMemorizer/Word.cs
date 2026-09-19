using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        // Logic to hide the word
        _isHidden = true;
    }

    public void Show()
    {
        // Logic to show the word
        _isHidden = false;  
    }

    public bool IsHidden()
    {
        // Logic to check if the word is hidden
        return _isHidden;
    }
    
    public string GetDisplayText()
    {
        // Logic to return the word text or underscores if hidden
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}