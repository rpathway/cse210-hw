public class Word
{
  private string _text = "";
  private bool _isHidden;

  public Word(string text)
  {
    _text = text;
  }

  public void Hide()
  {
    _isHidden = true;
  }

  public void Show()
  {
    _isHidden = false;
  }

  public bool IsHidden()
  {
    return _isHidden;
  }

  public string GetDisplayText()
  {
    if (IsHidden())
    {
      string hiddenString = "";
      for (int i = 0; i < _text.Length; i++)
      {
        hiddenString += '_';
      }

      return hiddenString;
    }

    return _text;
  }
}