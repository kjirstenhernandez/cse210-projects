using System;

class Program
{
    static void Main(string[] args)
    {
        string user_Response = "";

        // Creating the Scripture Reference
        Reference reference = new Reference("Galatians", 5, 22, 23);
        string newReference = reference.DisplayReference();

        // Setting up the Scripture Verse(s)
        Scripture newScripture = new Scripture(newReference, "But the fruit of the Spirit is love, joy, peace, longsuffering, gentleness, goodness, faith; Meekness, temperance: against such there is no law.");
        Console.Clear();
        newScripture.GetRenderedText();
        Console.WriteLine("Hit 'Enter' to hide letters, or 'Quit' to exit");
        user_Response = Console.ReadLine();
        while (user_Response != "quit") {

            // Clears console and generates scripture with words hidden
            Console.Clear();
            newScripture.HideWords();
            newScripture.GetRenderedText();
            Console.WriteLine("Hit 'Enter' to hide letters, or 'Quit' to exit");
            user_Response = Console.ReadLine();
            
            // Check to see if scripture has been completed
            bool test = newScripture.IsCompletelyHidden();
            if (test == true){
                break;
            }
        };

    }
}