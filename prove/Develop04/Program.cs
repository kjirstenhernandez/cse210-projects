using System;

class Program
{
    static void Main(string[] args)
    {
        //Intro Statement
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program");

        //Display Menu
        int userMenuChoice = 0;
        while (userMenuChoice != 4){
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select an option from the menu: ");
            string response = Console.ReadLine();
            userMenuChoice = Convert.ToInt32(response);

            if (userMenuChoice == 1){
                Console.Clear();
                Breathing newBreathing = new Breathing();
                newBreathing.GetOpeningMessage();
                Console.WriteLine();
                newBreathing.EstablishDuration();
                Console.WriteLine();
                newBreathing.StartBreathingActivity();
                Console.WriteLine();
                newBreathing.GetEndingMessage();
            }

            else if (userMenuChoice == 2){
                Console.Clear();
                Reflecting newReflecting = new Reflecting();
                newReflecting.GetOpeningMessage();
                Console.WriteLine();
                newReflecting.EstablishDuration();
                Console.WriteLine();
                newReflecting.StartReflectingActivity();
                Console.WriteLine();
                newReflecting.GetEndingMessage();
            }

            else if (userMenuChoice == 3){
                Console.Clear();
                Listing newListing = new Listing();
                newListing.GetOpeningMessage();
                Console.WriteLine();
                newListing.EstablishDuration();
                Console.WriteLine();
                newListing.StartListingActivity();
                Console.WriteLine();
                newListing.GetEndingMessage();
            }
        }
    }
}