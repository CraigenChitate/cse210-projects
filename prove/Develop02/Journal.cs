class Journal
{
    public List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        JournalEntry entry = new JournalEntry(prompt, response, date);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToCsv(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename, true))//true allows csv file to keep the information that was entered before
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving journal: {e.Message}");
        }
    }

    public void LoadFromCsv(string filename)
    {
        entries.Clear();
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        entries.Add(new JournalEntry(parts[1], parts[2], parts[0]));
                    }
                }
            }
            Console.WriteLine("Journal is loaded from CSV file.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading journal: {e.Message}");
        }
    }
}
