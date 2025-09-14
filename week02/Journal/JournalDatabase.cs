using Microsoft.Data.Sqlite;

public class JournalDatabase
{
  private string _connectionString;

  public JournalDatabase(string dbPath)
  {
    _connectionString = $"Data Source={dbPath}";
    Initialize();
  }

  private void Initialize()
  {
    using (SqliteConnection connection = new SqliteConnection(_connectionString))
    {
      connection.Open();

      var command = connection.CreateCommand();
      command.CommandText =
      @"
        CREATE TABLE IF NOT EXISTS Entries (
          Id INTEGER PRIMARY KEY AUTOINCREMENT,
          Date TEXT NOT NULL,
          Prompt TEXT NOT NULL,
          Text TEXT NOT NULL
        );
      ";
      command.ExecuteNonQuery();
    }
  }

  public void InsertEntry(List<Entry> _entries)
  {
    using (SqliteConnection connection = new SqliteConnection(_connectionString))
    {
      connection.Open();

      foreach (Entry entry in _entries)
      {
        // the conditional below prevents duplicated inserts
        if (entry._dbUniqueId == 0)
        {
          SqliteCommand command = connection.CreateCommand();
          command.CommandText =
          @"
            INSERT INTO Entries (Date, Prompt, Text)
            VALUES ($date, $prompt, $text);
          ";

          command.Parameters.AddWithValue("$date", entry._date);
          command.Parameters.AddWithValue("$prompt", entry._promptText);
          command.Parameters.AddWithValue("$text", entry._entryText);

          command.ExecuteNonQuery();
        }

      }
    }
  }

  public List<Entry> GetEntries()
  {
    List<Entry> entries = [];

    using (SqliteConnection connection = new SqliteConnection(_connectionString))
    {
      connection.Open();

      SqliteCommand command = connection.CreateCommand();
      command.CommandText = "SELECT * FROM Entries;";

      using (SqliteDataReader reader = command.ExecuteReader())
      {
        while (reader.Read())
        {
          Entry entry = new Entry();
          entry._dbUniqueId = reader.GetInt32(0);
          entry._date = reader.GetString(1);
          entry._promptText = reader.GetString(2);
          entry._entryText = reader.GetString(3);
          entries.Add(entry);
        }
      }
    }

    return entries;
  }
}