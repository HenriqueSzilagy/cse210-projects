class Word{
    private string _word;

    public Word(string word){
        _word = word;
    }

    public string GetWord()
    {
        return _word;
    }

    public void Hide()
    {
        _word = new string('_', _word.Length);
    }

    public bool isHidden()
    {
        for (int i = 0; i < _word.Length; i++)
        {
            if (_word[i] != '_')
            {
                return false;
            }
        }
        return true;
    }
}