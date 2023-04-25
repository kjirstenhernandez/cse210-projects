using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the Magic Number? ");
        string userNumber = Console.ReadLine();
        int magicNumber = int.Parse(userNumber);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int userGuess = int.Parse(guess);

        do
        {
            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            if (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                userGuess = int.Parse(guess);
            }

        } while (userGuess != magicNumber);

        if (userGuess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
    }
}