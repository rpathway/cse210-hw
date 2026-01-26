public class Video
{
  private string _title;
  private string _author;
  private int _length;

  private List<Comment> _comments = new List<Comment>();

  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;
  }

  public void AddComment(Comment comment)
  {
    _comments.Add(comment);
  }

  public int GetCommentCount()
  {
    return _comments.Count;
  }

  public void DisplayVideoData()
  {
    Console.WriteLine($"\nTitle: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Length: {_length}");
    Console.WriteLine($"Comment: {GetCommentCount()}\n");

    foreach (Comment comment in _comments)
    {
      comment.DisplayCommentData();
    }
  }
}