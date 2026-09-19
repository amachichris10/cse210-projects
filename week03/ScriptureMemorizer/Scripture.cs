using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int NumbersToHide)
    {
        // Logic to hide random words from the scripture text
        Random random = new Random();
        for (int i = 0; i < NumbersToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        // Logic to return the scripture text with hidden words replaced by underscores
        return _reference.GetDisplayText() + " " + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        // Logic to check if all words in the scripture are hidden
        return _words.All(w => w.IsHidden());
    }
}