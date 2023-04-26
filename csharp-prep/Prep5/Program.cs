using System;


class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string username = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = ReturnSquaredNumber(userNumber);
        DisplayResult(username, squared);


        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Hello and Welcome!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter User name: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter favorite number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
        }

        static int ReturnSquaredNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"User's Name: {name}");
            Console.WriteLine($"Squared Number: {square}");
        } 
    }
}

// PromptUserNumber
    // Asks for and returns the user's favorite number (as an int)
// SquareNumber
    // Accepts an integer as a parameter and returns that number squared (as an integer)
// DisplayResult
    // Accept's the user's name and the squared number and displays them