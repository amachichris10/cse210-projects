using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private List<Entry> Entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in Entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true
        };

        string json = JsonSerializer.Serialize(Entries, options);
        File.WriteAllText(filename, json);

        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string filename)
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true
        };

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string json = File.ReadAllText(filename);
        Entries = JsonSerializer.Deserialize<List<Entry>>(json, options)
                  ?? new List<Entry>();

        Console.WriteLine("Journal loaded successfully.");
    }
}