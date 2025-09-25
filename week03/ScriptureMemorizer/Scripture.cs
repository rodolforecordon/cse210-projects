public class Scripture
{
  private Reference _reference;
  private List<Word> _words = [];

  public Scripture(Reference reference, string text)
  {
    _reference = reference;

    string[] words = text.Split(" ");

    foreach (string word in words)
    {
      _words.Add(new Word(word));
    }
  }

  public void HideRandomWords(int numberToHide)
  {
    Random random = new Random();
    int wordsListLength = _words.Count();

    for (int i = 0; i < numberToHide; i++)
    {
      bool isHidden = false;
      int randomNumber = 0;
      while (!isHidden && !IsCompletelyHidden())
      {
        randomNumber = random.Next(0, wordsListLength);
        if (!_words[randomNumber].IsHidden())
        {
          _words[randomNumber].Hide();
          isHidden = true;
        }
      }
    }
  }

  public string GetDisplayText()
  {
    string fullText = $"{_reference.GetDisplayText()} -";

    foreach (Word word in _words)
    {
      fullText = fullText + " " + word.GetDisplayText();
    }

    return fullText;
  }

  public bool IsCompletelyHidden()
  {
    bool isCompletelyHidden = true;

    foreach (Word word in _words)
    {
      if (!word.IsHidden()) isCompletelyHidden = false;
    }

    return isCompletelyHidden;
  }
}