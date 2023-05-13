public class EntryClass{

    public string _todayDate;
    public string _userEntry;

    public string _promptEntry;


    public void WriteEntry()
    // Builds Entry from Prompt Generator and Stores User Response
    {
        DateTime theCurrentTime = DateTime.Now;
        string _dateText = theCurrentTime.ToShortDateString();
        _todayDate = _dateText;
        // I don't understand why I have to do that to get it to work
        //  If I put "public" in front of the string on _dateText it creates an error.

        PromptGenerator prompts = new PromptGenerator();
        _promptEntry = prompts.GetPrompt();
        Console.WriteLine(_promptEntry);
        _userEntry = Console.ReadLine();
    }
}


