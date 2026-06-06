using System;

class Indexer
{
    private string[] words;
    public Indexer(string sentence)
    {
        words = sentence.Split(' ');
    }
    public string this[int index]
    {
        get
        {
            return words[index];
        }
    }
}
