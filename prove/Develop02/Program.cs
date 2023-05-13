using System;

class Program
{
    
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int menuChoice = 0;
        
        Console.WriteLine("Welcome to your Journal Program");
            Console.WriteLine("We recommend loading a file first.");  // Creativity #1: Load/Save Warning
            Console.WriteLine("Do you have a file you would like to load? Y/N: ");
            string userMenuOption = Console.ReadLine();
            if (userMenuOption == "Y"){
                journal.LoadfromFile();}
            if (userMenuOption == "N"){
               Console.WriteLine("Be aware: saving to an existing file before loading");
               Console.WriteLine("will overwrite all contents of the file.");
            }
                
//Displaying the menu and getting user response
        while (menuChoice != 5){
            Console.WriteLine("Please choose from the following menu:");
            Console.WriteLine("1.  Load");
            Console.WriteLine("2.  New Entry");
            Console.WriteLine("3.  Save");
            Console.WriteLine("4.  Display All");
            Console.WriteLine("5.  Quit Program");
            string _userMenuOption = Console.ReadLine();

            menuChoice = int.Parse(_userMenuOption);
            
            // 1. Load 
            if (menuChoice == 1){ 
                journal.LoadfromFile();
            }

            // 2. New Entry
            if (menuChoice == 2){
                EntryClass entry = new EntryClass();
                entry.WriteEntry();
                journal.AddNewEntry(entry);
            }

            // 3. Save
            if (menuChoice == 3){
                journal.SavetoFile();
            }

            // 4. Display All
            if (menuChoice == 4){
                journal.DisplayAll();
            }
        }
        
        // 5. Quit
        if (menuChoice == 5){
            Console.WriteLine("Did you remember to save? Y/N:  ");  // Creativity Point #2 (Save Double-Check)
            string quittingAnswer = Console.ReadLine();
            if (quittingAnswer == "Y"){
                Console.WriteLine("See you again soon!");
            }
            if (quittingAnswer == "N"){  
                Console.WriteLine("Do you want to save now? Y/N:  ");
                string secondQuit = Console.ReadLine();
                if (secondQuit == "Y"){
                    journal.SavetoFile();
                }
                if (secondQuit == "N"){
                    Console.WriteLine("See you again soon!");
                }
            }
        }
        else {
            Console.WriteLine("Not a Valid Option.  Please try again.");
        }
    }
}