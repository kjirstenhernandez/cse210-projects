public class PromptGenerator 
{
    public string _promptEntry;
    public string _menuChoice;

    public string _userPromptResponse;

    public string GetPrompt()
    // Displays prompts for Journal Entries
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
}