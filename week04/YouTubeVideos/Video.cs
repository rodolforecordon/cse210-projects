using System.Net;

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
    _comments = [];
  }

  public void SetComments(params Comment[] comments)
  {
    foreach (Comment comment in comments)
    {
      _comments.Add(comment);
    }
  }

  public int GetCommentNumber()
  {
    return _comments.Count;
  }

  public void DisplayVideoDetails()
  {
    Console.WriteLine();
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine($"Video: {_title} ({_length}s)");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine();
    Console.WriteLine($"Comments ({_comments.Count})");
    Console.WriteLine();
    foreach (Comment comment in _comments)
    {
      comment.Display();
    }
  }
}