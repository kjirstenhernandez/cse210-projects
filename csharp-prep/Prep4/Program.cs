using System;

class Program
{
    static void Main(string[] args)
    {
        // Set up the variables and lists
        int i = 1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        
        while (i !=0)
        {
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            i = int.Parse(userNumber);
            
            if (i != 0)
            {
                numbers.Add(i);
            }
            
        }

        // Set up for sum of list then print for user 
        int total = 0;
        foreach (int number in numbers)
        {
            total = number + total;
        }
        Console.WriteLine($"The sum is: {total}");

        // Calculate average
        int count = numbers.Count;
        double average = (double)total/(double)count;
        Console.WriteLine($"The average is: {average}");

        // Determine and print the Largest number
        int largest = 0;
        foreach(int j in numbers)
        {
            if (j>largest)
            {
                largest = j;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
        
        //Determine and print the Smallest (positive) Number
        int smallest = 0;
        foreach (int j in numbers)
        {
            if (j>0)
            {
                if(j<smallest)
                {
                    smallest = j;
                }
            }
        }
        Console.WriteLine($"The smallest (positive) number is: {smallest}");

        // Sort the numbered list and print each item in order
        numbers.Sort();
        foreach(int j in numbers)
        {
            Console.WriteLine(j);
        }
    }
    
}