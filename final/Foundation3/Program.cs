using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        
        Address outdoorGatheringAddress = new Address("261 W 200 S", "Springville", "Utah", "United States");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("The Alleman Reunion", "A family reunion for all the children, grandchildren, and great-granchildren of Glenn and Afton Alleman. Join us for dinner, snacks, and games while we gather together as family!", "Thursday, July 6th", "12:00pm", outdoorGatheringAddress, "Cloudy");
        Address lectureAddress = new Address("149 N Walnut St", "Westfield", "Indiana", "United States");
        Lecture lecture1 = new Lecture("The Borgia Pope", "As a central figure to the Borgia Dynasty, Rodrigo Borgia, or Pope Alexander VI, was known for corruption, and his name became a symbol of the low standards of the papacy throughout the Renaissance.", "Saturday, July 29th, 2023", "7:00PM", lectureAddress, "Christopher Hibbert", 40);
        Address receptionAddress = new Address("100 W 560 S", "Provo", "Utah", "United States");
        Reception reception1 = new Reception("The Baker Wedding Reception","Join us in celebrating the marriage of Jolynn Marquez and Quinn Baker", "Tuesday, July 18th, 2023", "7 o' clock in the evening", receptionAddress, "sharihunter89@gmail.com");

        events.Add(outdoorGathering1);
        events.Add(lecture1);
        events.Add(reception1);

        foreach (Event eventOccurence in events){
            Console.WriteLine($"=============={eventOccurence.GetTitle()}=================");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("                  STANDARD DETAILS                 ");
            Console.WriteLine();
            eventOccurence.DisplayStandardMessage();
            Console.WriteLine();
            Console.WriteLine();
             Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("                    FULL DETAILS                    ");
            Console.WriteLine();
            eventOccurence.DisplayDetailedMessage();
            Console.WriteLine();
            Console.WriteLine();
             Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("                    SHORT DETAILS                   ");
            Console.WriteLine();
            eventOccurence.DisplayShortMessage();
            Console.WriteLine();
            Console.WriteLine();
        }

        
    }
}