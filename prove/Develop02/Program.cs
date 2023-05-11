using System;

class Program
{
    PromptGenerator prompts = new PromptGenerator();
    Journal journal = new Journal();
    EntryClass entryClass = new EntryClass();
    
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal");
        Console.WriteLine("Please select from the following Menu:");
        prompts.DisplayMenuOption()

    }
}