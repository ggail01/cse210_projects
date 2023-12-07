using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"\nTitle: {_title}\nAuthor: {_author}\nLength (seconds): {_length}\nNumber of Comments: {GetNumberOfComments()}\n");

        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            comment.GetCommentInfo();
        }
        Console.WriteLine();
    }
}