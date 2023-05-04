class Reference {
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book ,int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }
       public Reference(string book ,int chapter, int startVerse, int endVerse)
    {
        this._book = book;
       this. _chapter = chapter;
        this._startVerse = startVerse;
        this._endVerse = endVerse;
    }
     public string GetReference()
    {
        
        string text = $"{_book} {_chapter}:{_startVerse}";
        if (_endVerse != 0)
        {
            text += $"-{_endVerse}";
        }
        return text;
    }
      public void SetReference(string book ,int chapter, int startVerse, int endVerse)
    {
         _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
}