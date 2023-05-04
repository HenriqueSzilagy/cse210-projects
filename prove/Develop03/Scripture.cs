class Scripture {
        private Reference _reference;
        private List<Word> _wordsInScripture;

        public Scripture(Reference reference, string scripture){
            _reference = reference;
            _wordsInScripture = new List<Word>();
            
            string[] wordsScripture = scripture.Split(' ');
            foreach (string wordScripture in wordsScripture) 
            {
                _wordsInScripture.Add(new Word(wordScripture));
            }

        }

        public void HideRandomWords()
{
    Random random = new Random();
    List<int> indices = new List<int>();
    while (indices.Count < 3)
    {
        int index = random.Next(_wordsInScripture.Count);
        if (!_wordsInScripture[index].isHidden())
        {
            indices.Add(index);
            _wordsInScripture[index].Hide();
        }
    }
}


        public bool isCompletelyHidden()
{
        foreach (Word word in _wordsInScripture)
            {
                if (!word.isHidden())
                {
                    return false;
                }
            }

        return true;
    }
    public string GetRenderedText()
{
    string[] words = new string[_wordsInScripture.Count];
    for (int i = 0; i < _wordsInScripture.Count; i++)
    {
        words[i] = _wordsInScripture[i].GetWord();
    }
    string renderedText = string.Join(" ", words);
    return renderedText;
}

}
        

        



