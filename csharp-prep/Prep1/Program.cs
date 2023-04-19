using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user for their name
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        // Blank Line to match example
        Console.WriteLine("");

        // "Bond, James Bond" Statement with user input
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}