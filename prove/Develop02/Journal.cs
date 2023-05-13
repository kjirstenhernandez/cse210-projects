public class Journal {
    public string _filename;
    public string _createFile;

    public List<string> _entries = new List<string>();

    public void AddNewEntry(EntryClass entry)
    // Adds a new entry to the _entries List
    {   
        _entries.Add($"{entry._todayDate}:" + entry._promptEntry + Environment.NewLine + entry._userEntry);
    }
    
    public void DisplayAll()
    // Displays All Current Entries
    {
        foreach (string entry in _entries){
            Console.WriteLine(entry);
        }
    }
    public void SavetoFile()
    // Saves all current entries to a specified file; if file doesn't exist, creates a new one.
    {
        Console.WriteLine("Please insert filename: ");
        _filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (string line in _entries){
                outputFile.WriteLine(line);
                outputFile.WriteLine();
            }
        }
    }

    public void LoadfromFile()
    // Loads all entries from user's specified file
    {
        Console.WriteLine("Please insert filename: ");
        _filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            _entries.Add(line);
            Console.WriteLine(line);
        }
    }

}