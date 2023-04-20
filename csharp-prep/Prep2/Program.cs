using System;

class Program
{
    static void Main(string[] args)
    {
        //Initial User Input
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int userPercentage = int.Parse(percentage);
        
        //Determining + or -
        if (userPercentage >60)
        {
            
        }

        // Determining Letter Grade
        if (userPercentage >= 90)
        {
            if ((userPercentage % 10) >=7)
            {
                Console.WriteLine("Grade: A+");
            }

            else if ((userPercentage % 10) <=3)
            {
                Console.WriteLine("Grade: A-");
            }

            else
            {
                Console.WriteLine("Grade: A");
            }
        }
        
        else if (userPercentage >= 80 && userPercentage <= 89)
        {
            if ((userPercentage % 10) >=7)
            {
                Console.WriteLine("Grade: B+");
            }

            else if ((userPercentage % 10) <=3)
            {
                Console.WriteLine("Grade: B-");
            }

            else
            {
                Console.WriteLine("Grade: B");
            }
        }
        
        else if (userPercentage >= 70 && userPercentage <= 79)
        
        {
           if ((userPercentage % 10) >=7)
            {
                Console.WriteLine("Grade: C+");
            }

            else if ((userPercentage % 10) <=3)
            {
                Console.WriteLine("Grade: C-");
            }

            else
            {
                Console.WriteLine("Grade: C");
            }
        }

        else if (userPercentage >= 60 && userPercentage <= 69)
        {
            if ((userPercentage % 10) >=7)
            {
                Console.WriteLine("Grade: D+");
            }

            else if ((userPercentage % 10) <=3)
            {
                Console.WriteLine("Grade: D-");
            }

            else
            {
                Console.WriteLine("Grade: D");
            }
        }
        
        else if (userPercentage < 60)
        {
            Console.WriteLine("Grade: F");
            
        }


        // Determine if they've passed or not

        if (userPercentage > 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, but you didn't pass the class.");
        }
    }
}