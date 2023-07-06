public class Lecture : Event {
    private string _lecturer;
    private int _capacity;
    public Lecture(string title, string description, string date, string time, Address address, string lecturer, int capacity) : base(title, description, date, time, address){
        _eventType = "Lecture";
        _capacity = capacity;
        _lecturer = lecturer;
    }

    public override void DisplayDetailedMessage(){
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {base.GetTitle()}");
        Console.WriteLine($"Description: {base.GetDescription()}");
        Console.WriteLine($"Date and Time: {base.GetDate()}, {base.GetTime()}");
        Console.WriteLine($"Guest Lecturer: {_lecturer}");
        Console.WriteLine($"Room Capacity: {_capacity}");
    }
}