using System.IO;

public class Journal
{
  public List<Entry> _entries = [];
  public JournalDatabase db = new JournalDatabase("journal.db");

  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }

  public void DisplayAll()
  {
    foreach (Entry entry in _entries)
    {
      Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
      Console.WriteLine(entry._entryText);
      Console.WriteLine();
    }
  }

  public void SaveToDB()
  {
    db.InsertEntry(_entries);
  }

  public void LoadFromDB()
  {
    _entries = db.GetEntries();
  }
}