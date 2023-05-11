public class EntryClass{

    public string _date;
    public string _userEntry;
    public List<PromptGenerator> _entry = new List<PromptGenerator>();

    public void WriteEntry()
    {
        Console.WriteLine($"Date:  {_date}");

        foreach (PromptGenerator entry in _entry)
            entry
    }
    public void DisplayEntry(){
        
    }

}