
class Video {
    public string _title;
    public string _author;
    public float _lenght;

    public List<Comment> Comments;

    public Video(string title, string author, float lenght ) {
        _title = title;
        _author = author;
        _lenght = lenght;
        Comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        Comments.Add(comment);
    }
    public int NumComments()
    {
        return Comments.Count;
    }
}
