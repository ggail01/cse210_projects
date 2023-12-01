using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

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

    public string DisplayVideoInfo()
    {
        string videoInfo = $"\nTitle: {_title}\nAuthor: {_author}\nLength (seconds): {_length}\nNumber of Comments: {GetNumberOfComments()}\n\n";

        if (GetNumberOfComments() > 0)
        {
            videoInfo += "Comments:\n";
            foreach (var comment in _comments)
            {
                videoInfo += $"{comment.GetCommentInfo()}\n";
            }
        }

        return videoInfo;
    }
}