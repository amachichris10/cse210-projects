using System;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _commentList = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds, List<Comment> commentList)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _commentList = commentList;
    }

    public int GetNumberOfComments()
    {
        return _commentList.Count;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }

    public void GetComments()
    {
        foreach (var comment in _commentList)
        {
            Console.WriteLine($"- {comment.GetAuthor()}: {comment.GetText()}");
        }
    }
}