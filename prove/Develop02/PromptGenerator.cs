public class PromptGenerator 
{
    public string _promptEntry;
    public string _menuChoice;

    public string _userPromptResponse;

    public string DisplayMenuOption()
    {
        Console.WriteLine("1.  Load from File");
        Console.WriteLine("2.  New Entry");
        Console.WriteLine("3.  Save to File");
        Console.WriteLine("4.  Diplay All Entries");
        Console.WriteLine("5.  Quit Program");
        Console.WriteLine("Please enter your choice number:  ");
        _menuChoice = Console.ReadLine();
        return _menuChoice;
    }

    public string GetPrompt()
    {
       string[] prompts = {
        "What was something interesting that happened today?",
        "What blessings have you noticed more today?",
        "What was the hardest thing about today?",
        "What was the best part about today?",
        "WHat was the weather like today?",
        "Is there something you're going to try to do differenty tomorrow?"
       };

        Random rand = new Random();
        int index = rand.Next(prompts.Length);       
       string _promptEntry = prompts[index];
       return _promptEntry;
    }

    public string TakeEntry()
    {
        Console.WriteLine(_promptEntry);
       _userPromptResponse = Console.ReadLine();
        return _userPromptResponse;
    }
}